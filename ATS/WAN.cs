using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATS
{


    static class WAN
    {
        public static List<Network> Factory = new List<Network>();
        public static Network City;

        internal static Network Network
        {
            get => default(Network);
            set
            {
            }
        }

        public static void InitializationFactory()
        {
            for (int k = 0; k < 2; k++)
            {
                List<string> Nums = new List<string>();
                List<Phone> Phns = new List<Phone>();

                for (int i = 0; i < 1000; i++)
                {
                    string Current = i.ToString();
                    while (Current.Length < 3) Current = "0" + Current;

                    Nums.Add(Current);
                    Phns.Add(new Phone(Current));


                }

                Factory.Add(new Network(new Server(k + 1, Nums.ToArray<string>()), Phns.ToArray<Phone>()));
            }
        }

        public static Phone CellUp(string Number, int Identificate)
        {
            int indicate = -1;

            for (int i = 0; i < Factory[Identificate].BasePhones.Count; i++)
                if (Number == Factory[Identificate].BasePhones[i].Number)
                {
                    indicate = i;
                    break;
                }

            Factory[Identificate].BasePhones[indicate].SignalCellular();

            return Factory[Identificate].BasePhones[indicate];
        }



        public static string Calling(string Num, string Number, int Identificate)
        {
            int indicate = -1;

            for (int i = 0; i < Factory[Identificate].BasePhones.Count; i++)
                if (Number == Factory[Identificate].BasePhones[i].Number)
                {
                    indicate = i;
                    break;
                }

            switch (Factory[Identificate].BasePhones[indicate].CurrentCondition)
            {
                case Condition.Tone:
                case Condition.Wait:
                case Condition.Network:
                    Factory[Identificate].BasePhones[indicate].SignalNumeral(Num);
                    break;

                default:
                    break;

            }

            return Factory[Identificate].ATS.CurrentCalls[indicate];
        }


        public static Phone ForView(string Number, int Identificate)
        {
            foreach (Phone I in Factory[Identificate].BasePhones)
                if (I.Number == Number) return I;

            return new Phone("###");
        }





        public static void CreateGlobalNetworks()
        {
            for (int j = 0; j < Factory.Count; j++)
            {
                City.ATS.CallToAnotherNet += Factory[j].ATS.ConnectNetvorks;
                Factory[j].ATS.CallToAnotherNet += City.ATS.ConnectNetvorks;

                City.ATS.NetSignal += Factory[j].ATS.GetGlobalSignal;
                Factory[j].ATS.NetSignal += City.ATS.GetGlobalSignal;

                City.ATS.ReturnToAnotherNet += Factory[j].ATS.GetStatusOfNet;
                Factory[j].ATS.ReturnToAnotherNet += City.ATS.GetStatusOfNet;

                City.ATS.GlobalTransferDate += Factory[j].ATS.DataReciver;
                Factory[j].ATS.GlobalTransferDate += City.ATS.DataReciver;

                Factory[j].ATS.OutCaller += City.ATS.OutConnector;
            }
        }





        public static void InitializationCity()
        {
            List<string> Nums = new List<string>();
            List<Phone> Phns = new List<Phone>();

            for (int i = 0; i < 1000; i++)
            {
                string Current = i.ToString();
                while (Current.Length < 3) Current = "0" + Current;

                Nums.Add(Current);
                Phns.Add(new Phone(Current));
            }

            City = new Network(new Server(0, Nums.ToArray<string>()), Phns.ToArray<Phone>());

        }


        public static Phone CellUpCity(string Number)
        {
            int indicate = -1;

            for (int i = 0; i < City.BasePhones.Count; i++)
                if (Number == City.BasePhones[i].Number)
                {
                    indicate = i;
                    break;
                }

            City.BasePhones[indicate].SignalCellular();

            return City.BasePhones[indicate];
        }



        public static string CallingCity(string Num, string Number)
        {
            int indicate = -1;

            for (int i = 0; i < City.BasePhones.Count; i++)
                if (Number == City.BasePhones[i].Number)
                {
                    indicate = i;
                    break;
                }

            switch (City.BasePhones[indicate].CurrentCondition)
            {
                case Condition.Tone:
                case Condition.Wait:
                case Condition.Network:
                    City.BasePhones[indicate].SignalNumeral(Num);
                    break;

                default:
                    break;

            }

            return City.ATS.CurrentCalls[indicate];
        }


        public static Phone ForViewCity(string Number)
        {
            foreach (Phone I in City.BasePhones)
                if (I.Number == Number) return I;

            return new Phone("###");
        }


        public static string ReturnNumber(string Encrypted)
        {
            bool flag = false;
            string result = "";

            foreach (char k in Encrypted)
            {
                if (flag) result += k;
                if (k == '#') flag = true;
            }

            return result;
        }
        public static string ReturnNetwork(string Encrypted)
        {
            string net = "";
            foreach (char k in Encrypted)
            {
                if (k == '#') break;
                net += k;
            }

            return net;
        }
    }
}
