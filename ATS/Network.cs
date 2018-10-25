using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATS
{
    class Network
    {
        public Server ATS { set; get; }
        public List<Phone> BasePhones {set; get;}

        public Network(Server NewATS, params Phone[] Base)
        {
            ATS = NewATS;
   
            BasePhones = new List<Phone>();

            foreach (Phone i in Base)
                BasePhones.Add(i);


            CreateNetwork();
        }
        private void CreateNetwork()
        {
            this.ATS.SearchCurrentCondition += this.SearchStatus;

            for (int i = 0; i < BasePhones.Count; i++)
            {
                this.BasePhones[i].CellularSignal += this.ATS.ReturnCondition;
                this.ATS.ConditionSignal += this.BasePhones[i].ReciveNewCondition;

                this.BasePhones[i].NumeralSignal += this.ATS.NumeralSignalReciver;
                this.ATS.TransferDate += this.BasePhones[i].Reciver;
            }

        }


        public Condition SearchStatus(string Num)
        {
            foreach (Phone u in this.BasePhones)
                if (u.Number == Num)
                    return u.CurrentCondition;

            return Condition.Busy;
        }
    }
}
