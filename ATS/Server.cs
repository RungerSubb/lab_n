using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATS
{
    public delegate void CellularAnswer(Condition SleepOrTone, string Access, string ConnectWay);
    public delegate void DataExpress(string Num, string Destination);
    public delegate Condition Searcher(string Num);




    public delegate void ConnectAnotherServer(string Num, string Number, int NumberOfNetwork);
    public delegate void GlobalNetworkSignal(Condition Signal, string Number, int NetWay, string CallAddress, int NumberOfNetwork);
    public delegate void StatusReturn(Condition Returner, string Number, string CallAddress, int NumberOfNetwork);
    public delegate void GlobalTransfer(string Data, string Destination, int NetworkKey);
    public delegate void CallOut(string Signal, string Number, int NumberOFNetwork);


    class Server
    {
        public List<string> Numbers { set; get; }
        public List<string> OutCalls;
        public string[] CurrentCalls { set; get; }
        public int NetworkIndicator { set; get; }
        public string[][] CurrentOutCalls { set; get; }


        public Server(int ind, params string[] SetNumbers)
        {
            Numbers = new List<string>();

            foreach (string i in SetNumbers)
                Numbers.Add(i);

            OutCalls = new List<string>();
            CurrentCalls = new string[Numbers.Count];

            

            for (int j = 0; j < Numbers.Count; j++)
                Numbers[j] = "";

            NetworkIndicator = ind;


            if (ind == 0)
            {
                CurrentOutCalls = new string[2][];
                for (int i = 0; i < CurrentOutCalls.Length; i++)
                    CurrentOutCalls[i] = new string[1000];

                for (int k = 0; k < 2; k++)
                 OutCalls.Add((k + 1).ToString() + "#");
            }
            else OutCalls.Add("0#");
        }



        public event CellularAnswer ConditionSignal;
        public event DataExpress TransferDate;
        public event Searcher SearchCurrentCondition;



        private void WaitTime(string Number, string ConnectWay)
        {
            Timer CallWaiter = new Timer();
            CallWaiter.Interval = 10000;
            CallWaiter.Tick += delegate (object sender, EventArgs e)
            {
                if (SearchCurrentCondition(Number) != Condition.Network)
                {
                    ConditionSignal(Condition.Busy, Number, ConnectWay);
                    ConditionSignal(Condition.Sleep, ConnectWay, Number);
                }
                CallWaiter.Stop();
            };

            CallWaiter.Start();

        }

        private void WaitOutTime(string Number, string ConnectWay, int NumberOfNetwork)
        {
            Timer Tmr = new Timer();
            Tmr.Interval = 10000;
            Tmr.Tick += delegate (object sender, EventArgs e)
            {
                if (SearchCurrentCondition(ConnectWay) != Condition.Network)
                {
                    ConditionSignal(Condition.Sleep, ConnectWay, Number);
                    if (NumberOfNetwork == 0) ReturnToAnotherNet(Condition.Busy, Number, "", NumberOfNetwork);
                    else ReturnToAnotherNet(Condition.Busy, Number, "0#" + CurrentOutCalls[NumberOfNetwork - 1][Convert.ToInt32(Number)], NumberOfNetwork);
                }
                Tmr.Stop();
            };
            Tmr.Start();
        }

        public void ReturnCondition(Condition CurrentCondition, string Number, string ConnectWay)
        {

            CurrentCalls[Convert.ToInt32(Number)] = "";

            if (CurrentCondition == Condition.Sleep)
                Sleeper(Number, ConnectWay);

            if (CurrentCondition == Condition.Tone)
                TonerBusierWaiter(Number, ConnectWay);

            if (CurrentCondition == Condition.Busy)
                TonerBusierWaiter(Number, ConnectWay);
          
            if (CurrentCondition == Condition.Wait)
                TonerBusierWaiter(Number, ConnectWay);

            if (CurrentCondition == Condition.Bell)
            {
                Beller(Number, ConnectWay);

                if (ConnectWay.Contains("#"))
                    GlobalSignal(Condition.Network, Number, ConnectWay);

                else Beller(Number, ConnectWay);
            }


            if (CurrentCondition == Condition.Network)
            {
                Networker(Number, ConnectWay);

                if (ConnectWay.Contains("#"))
                    GlobalSignal(Condition.Busy, Number, ConnectWay);

                else Networker(Number, ConnectWay);
            }

            if (CurrentCondition == Condition.Calling)
            {
                Networker(Number, ConnectWay);

                if (ConnectWay.Contains("#"))
                    GlobalSignal(Condition.Sleep, Number, ConnectWay);

                else Callinger(Number, ConnectWay);
            }
        }

        private void Sleeper(string Number, string ConnectWay)
        { ConditionSignal(Condition.Tone, Number, ConnectWay); }
        private void TonerBusierWaiter(string Number, string ConnectWay)
        { ConditionSignal(Condition.Sleep, Number, ConnectWay); }
        private void Beller(string Number, string ConnectWay)
        {
            ConditionSignal(Condition.Network, ConnectWay, Number);
            ConditionSignal(Condition.Network, Number, ConnectWay);
        }
        private void Networker(string Number, string ConnectWay)
        {
            ConditionSignal(Condition.Sleep, Number, ConnectWay);
            ConditionSignal(Condition.Busy, ConnectWay, Number);
        }
        private void Callinger(string Number, string ConnectWay)
        {
            ConditionSignal(Condition.Sleep, Number, ConnectWay);
            ConditionSignal(Condition.Sleep, ConnectWay, Number);
        }



        public event GlobalNetworkSignal NetSignal;

        private void GlobalSignal(Condition Signal, string Number, string ConnectWay)
        {
            string NetWay = "";
            string CallAddress = ""; 

            bool flag = false;

            foreach (char i in ConnectWay)
            {
                if (i != '#')
                {
                    if (!flag) { NetWay += i; flag = true; }
                    else CallAddress += i;
                }
            }

            NetSignal(Signal, Number, Convert.ToInt32(NetWay), CallAddress, NetworkIndicator);
        }


        

        public void GetGlobalSignal(Condition Signal, string Number, int NetWay, string CallAddress, int NumberOfNetwork)
        {
            if (this.NetworkIndicator == NetWay)
                ConditionSignal(Signal, CallAddress, NumberOfNetwork.ToString() + "#" + Number);
        }



        public event GlobalTransfer GlobalTransferDate;


        private void PreparationToAdventure(string Data, string Number, string EncryptedDestination)
        {
            string NetKey = "";
            string Destination = "";

            bool flag = false;

            foreach (char i in EncryptedDestination)
            {
                if (i != '#')
                {
                    if (!flag) { NetKey += i; flag = true; }
                    else Destination += i;
                }
            }

            GlobalTransferDate(Data, Destination, Convert.ToInt32(NetKey));
        }


        public void DataReciver(string Data, string Destination, int NetKey)
        {
            if (NetKey == this.NetworkIndicator)
                TransferDate(Data, Destination);
        }

        public event CallOut OutCaller;
        public void NumeralSignalReciver(Condition CurrentCondition, string Signal, string Number, string Destination)
        {
            if (CurrentCondition != Condition.Network)
            {
                if (Destination.Contains("#")) OutCaller(Signal, Number, NetworkIndicator);

                else Connector(Signal, Number, NetworkIndicator);

            }
            else
            {
                if (Destination.Contains("#")) PreparationToAdventure(Signal, Number, Destination);
                else TransferDate(Signal, Destination);
            }
        }

     
        private void Connector(string Signal, string Number, int Indicate)
        {
            if (Signal == "*") ConditionSignal(Condition.Busy, Number, "");
            else
            {
                CurrentCalls[Convert.ToInt32(Number)] += Signal;

                if (CurrentCalls[Convert.ToInt32(Number)] == "#")
                    ConditionSignal(Condition.Busy, Number, "");

                else
                {

                    if (CurrentCalls[Convert.ToInt32(Number)].Length < Number.Length)
                        ConditionSignal(Condition.Wait, Number, "");



                    if (CurrentCalls[Convert.ToInt32(Number)].Length == 2
                           && CurrentCalls[Convert.ToInt32(Number)][CurrentCalls[Convert.ToInt32(Number)].Length - 1] == '#')
                        ServersConnection(CurrentCalls[Convert.ToInt32(Number)], Number);


                    else if (CurrentCalls[Convert.ToInt32(Number)].Length == Number.Length)
                    {
                        if (CurrentCalls[Convert.ToInt32(Number)] == Number) ConditionSignal(Condition.Busy, Number, "");

                        else
                        {
                            if (SearchCurrentCondition(CurrentCalls[Convert.ToInt32(Number)]) == Condition.Bell)
                                ConditionSignal(Condition.Busy, Number, "");
                            else
                            {
                                ConditionSignal(Condition.Bell, CurrentCalls[Convert.ToInt32(Number)], Number);


                                if (SearchCurrentCondition(CurrentCalls[Convert.ToInt32(Number)]) == Condition.Bell)
                                {
                                    ConditionSignal(Condition.Calling, Number, CurrentCalls[Convert.ToInt32(Number)]);
                                    CurrentCalls[Convert.ToInt32(CurrentCalls[Convert.ToInt32(Number)])] = Number;

                                    WaitTime(Number, CurrentCalls[Convert.ToInt32(Number)]);
                                }
                                else ConditionSignal(Condition.Busy, Number, "");
                            }
                        }
                    }
                }
            }
        }






       public void OutConnector(string Signal, string Number, int NumberOfNetwork)
       {
            if (Signal == "*" || Signal == "#") ReturnToAnotherNet(Condition.Busy, Number, Signal, NumberOfNetwork);
            else
            {
                if (Signal == "0#")
                {
                    CurrentOutCalls[NumberOfNetwork - 1][Convert.ToInt32(Number)] = "";
                    ReturnToAnotherNet(Condition.Wait, Number, Signal, NumberOfNetwork);
                }
                else
                {
                    CurrentOutCalls[NumberOfNetwork - 1][Convert.ToInt32(Number)] += Signal;

                    if (CurrentOutCalls[NumberOfNetwork - 1][Convert.ToInt32(Number)].Length < 3)
                        ReturnToAnotherNet(Condition.Wait, Number, "0#", NumberOfNetwork);

                    else if (CurrentOutCalls[NumberOfNetwork - 1][Convert.ToInt32(Number)].Length == 3)
                    {
                        if (SearchCurrentCondition(CurrentOutCalls[NumberOfNetwork - 1][Convert.ToInt32(Number)]) == Condition.Bell)
                            ReturnToAnotherNet(Condition.Busy, Number, "0#", NumberOfNetwork);
                        else
                        {
                            ConditionSignal(Condition.Bell, CurrentOutCalls[NumberOfNetwork - 1][Convert.ToInt32(Number)], NumberOfNetwork.ToString() +  "#" + Number);


                            if (SearchCurrentCondition(CurrentOutCalls[NumberOfNetwork - 1][Convert.ToInt32(Number)]) == Condition.Bell)
                            {
                                ReturnToAnotherNet(Condition.Calling, Number, "0#" + CurrentOutCalls[NumberOfNetwork - 1][Convert.ToInt32(Number)], NumberOfNetwork);
                                CurrentCalls[Convert.ToInt32(Convert.ToInt32(CurrentOutCalls[NumberOfNetwork - 1][Convert.ToInt32(Number)]))] = Number;

                                WaitOutTime(Number, CurrentOutCalls[NumberOfNetwork - 1][Convert.ToInt32(Number)], NumberOfNetwork);
                            }
                            else ReturnToAnotherNet(Condition.Busy, Number, "0#", NumberOfNetwork);
                        }

                    }
                }
            }
        }





        public event ConnectAnotherServer CallToAnotherNet;
        public event StatusReturn ReturnToAnotherNet;


        private void ServersConnection(string Signal, string Number)
        {
            if (this.OutCalls.Contains(Signal))
                CallToAnotherNet(Signal, Number, NetworkIndicator);

            else ConditionSignal(Condition.Busy, Number, "");
        }

        public void ConnectNetvorks(string Signal, string Number, int NumberOfNetwork)
        {
            if (Signal == "0#") OutConnector(Signal, Number, NumberOfNetwork);
            else if (Signal == this.NetworkIndicator.ToString() + "#")
            {
                if (SearchCurrentCondition(CurrentCalls[Convert.ToInt32(Number)]) == Condition.Bell)
                    ReturnToAnotherNet(Condition.Busy, Number, Signal, NumberOfNetwork);
                else
                {
                    this.ConditionSignal(Condition.Bell, "000", NumberOfNetwork.ToString() + "#" + Number);

                    if (this.SearchCurrentCondition("000") == Condition.Bell)
                    {
                        ReturnToAnotherNet(Condition.Calling, Number, Signal + "000", NumberOfNetwork);
                        WaitOutTime(Number, "000", NumberOfNetwork);
                    }

                    else ReturnToAnotherNet(Condition.Busy, Number, Signal, NumberOfNetwork);
                }
            }
        }


        public void GetStatusOfNet(Condition Returner, string Number, string Signal, int NumberOfNetwork)
        {
            if (NumberOfNetwork == this.NetworkIndicator)
                ConditionSignal(Returner, Number, Signal);

        }



        public void SetNewNetForPhone(Condition AddCall, string Number, int NumberOfNetwork, bool ChangeServer)
        {
            if (NumberOfNetwork == this.NetworkIndicator)          
                ConditionSignal(AddCall, Number, "");
        }

      
    }    
}


