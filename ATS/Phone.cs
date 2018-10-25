using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATS
{
    public delegate void SignalCell(Condition Now, string Number, string ConnectWay);
    public delegate void SignalNum(Condition Current, string Data, string Number, string Destination);

    public enum Condition : int { Sleep, Tone, Wait, Calling, Bell, Network, Busy}


    public class Phone
    {
        public string Number { set; get; }
        public Condition CurrentCondition { set; get; }
        public string DataScreen { set; get; }
        public string ConnectWay { set; get; }


        public Phone(string SetNumber)
        {
            Number = SetNumber;
            CurrentCondition = Condition.Sleep;
            DataScreen = "";
            ConnectWay = "";
        }


        public event SignalCell CellularSignal;
        public event SignalNum NumeralSignal;


        public void SignalCellular()
        {
            DataScreen = "";
            CellularSignal(this.CurrentCondition, this.Number, this.ConnectWay);
        }
        public void SignalNumeral(string Numeral)
        {
            if (this.CurrentCondition == Condition.Tone || this.CurrentCondition == Condition.Wait || this.CurrentCondition == Condition.Network)
            {
                if (this.CurrentCondition == Condition.Tone || this.CurrentCondition == Condition.Wait)

                    this.DataScreen += Numeral;
                else this.DataScreen = "";

                NumeralSignal(this.CurrentCondition, Numeral, this.Number, this.ConnectWay);
            }
        }

        public void ReciveNewCondition(Condition NewCondition, string Access, string NewConnectWay)
        {
            if (Access == this.Number)
            {
                if (NewCondition == Condition.Tone) this.Toner(NewCondition);
                if (NewCondition == Condition.Bell) this.Beller(NewCondition, NewConnectWay);
                if (NewCondition == Condition.Wait) this.Waiter(NewCondition, NewConnectWay);
                if (NewCondition == Condition.Busy) this.Busier(NewCondition);
                if (NewCondition == Condition.Calling) this.Callinger(NewCondition, NewConnectWay);
                if (NewCondition == Condition.Network) this.Networker(NewCondition, NewConnectWay);
                if (NewCondition == Condition.Sleep) this.Sleeper(NewCondition);
            }
        }

        private void Toner(Condition NewCondition)
        {
            if (CurrentCondition == Condition.Sleep || CurrentCondition == Condition.Wait)
            {
                this.DataScreen = "";
                this.ConnectWay = "";

                this.CurrentCondition = NewCondition;
            }

        }
        private void Waiter(Condition NewCondition, string NewConnectWay)
        {
            if (CurrentCondition == Condition.Tone || CurrentCondition == Condition.Wait)
            {
                if (CurrentCondition == Condition.Wait)
                    this.ConnectWay = NewConnectWay;

                this.CurrentCondition = NewCondition;
            }
        }
        private void Busier(Condition NewCondition)
        {
            if (CurrentCondition == Condition.Wait || CurrentCondition == Condition.Network || CurrentCondition == Condition.Tone || CurrentCondition == Condition.Calling)
            {
                this.DataScreen = "";
                this.CurrentCondition = NewCondition;
            }
        }
        private void Beller(Condition NewCondition, string NewConnectWay)
        {
            if (CurrentCondition == Condition.Sleep)
            {
                this.DataScreen = "";
                this.ConnectWay = NewConnectWay;

                this.CurrentCondition = NewCondition;
            }
        }
        private void Callinger(Condition NewCondition, string NewConnectWay)
        {
            if (CurrentCondition == Condition.Wait)
            {
                this.DataScreen = "";
                this.ConnectWay = NewConnectWay;

                this.CurrentCondition = NewCondition;
            }
        }
        private void Networker(Condition NewCondition, string NewConnectWay)
        {
            if (CurrentCondition == Condition.Calling || CurrentCondition == Condition.Bell)
            {
                this.DataScreen = "";
                this.ConnectWay = NewConnectWay;

                this.CurrentCondition = NewCondition;
            }
        }
        private void Sleeper(Condition NewCondition)
        {
            this.DataScreen = "";
            this.ConnectWay = "";

            this.CurrentCondition = NewCondition;
        }


        public void Reciver(string Data, string Access)
        {
            if (this.Number == Access)
                this.DataScreen = Data;
        }

    }
}
