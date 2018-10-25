using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WAN.InitializationFactory();
            WAN.InitializationCity();
            WAN.CreateGlobalNetworks();
        }


        private void TimerReloader()
        {
            Timer Tmr = new Timer();
            Tmr.Interval = 10000;
            Tmr.Tick += delegate (object sender, EventArgs e)
            {
                Fact1Reload_Click(sender, e);
                CityReload_Click(sender, e);
                Fact2Reload_Click(sender, e);

                Tmr.Stop();
            };

            Tmr.Start();
           
            }
        // Factory-1 Left
        private void CallLeft_Click(object sender, EventArgs e)
        {
            LeftPhoneView(WAN.CellUp(PhoneLeftView.Text, 0), 0);
            RightPhoneView(WAN.ForView(PhoneRightView.Text, 0), 0);
        }

        private void OneLeft_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("1", PhoneLeftView.Text, 0), 0);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text) RightPhoneView(WAN.ForView(PhoneRightView.Text, 0), 0);
            else RightPhoneView(Viewer, 0);

            LeftPhoneView(WAN.ForView(PhoneLeftView.Text, 0), 0);
        }

        private void TwoLeft_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("2", PhoneLeftView.Text, 0), 0);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text) RightPhoneView(WAN.ForView(PhoneRightView.Text, 0), 0);
            else RightPhoneView(Viewer, 0);

            LeftPhoneView(WAN.ForView(PhoneLeftView.Text, 0), 0);
        }

        private void ThreeLeft_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("3", PhoneLeftView.Text, 0), 0);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text) RightPhoneView(WAN.ForView(PhoneRightView.Text, 0), 0);
            else RightPhoneView(Viewer, 0);

            LeftPhoneView(WAN.ForView(PhoneLeftView.Text, 0), 0);
        }

        private void FourLeft_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("4", PhoneLeftView.Text, 0), 0);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text) RightPhoneView(WAN.ForView(PhoneRightView.Text, 0), 0);
            else RightPhoneView(Viewer, 0);

            LeftPhoneView(WAN.ForView(PhoneLeftView.Text, 0), 0);
        }

        private void FiveLeft_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("5", PhoneLeftView.Text, 0), 0);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text) RightPhoneView(WAN.ForView(PhoneRightView.Text, 0), 0);
            else RightPhoneView(Viewer, 0);

            LeftPhoneView(WAN.ForView(PhoneLeftView.Text, 0), 0);
        }

        private void SixLeft_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("6", PhoneLeftView.Text, 0), 0);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text) RightPhoneView(WAN.ForView(PhoneRightView.Text, 0), 0);
            else RightPhoneView(Viewer, 0);

            LeftPhoneView(WAN.ForView(PhoneLeftView.Text, 0), 0);
        }

        private void SevenLeft_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("7", PhoneLeftView.Text, 0), 0);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text) RightPhoneView(WAN.ForView(PhoneRightView.Text, 0), 0);
            else RightPhoneView(Viewer, 0);

            LeftPhoneView(WAN.ForView(PhoneLeftView.Text, 0), 0);
        }

        private void EightLeft_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("8", PhoneLeftView.Text, 0), 0);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text) RightPhoneView(WAN.ForView(PhoneRightView.Text, 0), 0);
            else RightPhoneView(Viewer, 0);

            LeftPhoneView(WAN.ForView(PhoneLeftView.Text, 0), 0);
        }

        private void NineLeft_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("9", PhoneLeftView.Text, 0), 0);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text) RightPhoneView(WAN.ForView(PhoneRightView.Text, 0), 0);
            else RightPhoneView(Viewer, 0);

            LeftPhoneView(WAN.ForView(PhoneLeftView.Text, 0), 0);
        }

        private void ZeroLeft_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("0", PhoneLeftView.Text, 0), 0);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text) RightPhoneView(WAN.ForView(PhoneRightView.Text, 0), 0);
            else RightPhoneView(Viewer, 0);

            LeftPhoneView(WAN.ForView(PhoneLeftView.Text, 0), 0);
        }

        private void StarLeft_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("*", PhoneLeftView.Text, 0), 0);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text) RightPhoneView(WAN.ForView(PhoneRightView.Text, 0), 0);
            else RightPhoneView(Viewer, 0);

            LeftPhoneView(WAN.ForView(PhoneLeftView.Text, 0), 0);
        }

        private void PrisonLeft_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("#", PhoneLeftView.Text, 0), 0);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text) RightPhoneView(WAN.ForView(PhoneRightView.Text, 0), 0);
            else RightPhoneView(Viewer, 0);

            LeftPhoneView(WAN.ForView(PhoneLeftView.Text, 0), 0);
        }
      
        private void LeftPhoneView(Phone i, int Ender)
        {
            if (i.CurrentCondition == Condition.Sleep || i.CurrentCondition == Condition.Bell)
                CallLeft.BackgroundImage = Properties.Resources.off;
            else CallLeft.BackgroundImage = Properties.Resources.on;

            switch (i.CurrentCondition)
            {
                case Condition.Sleep:
                    ScreenLeft.Text = "";
                    break;

                case Condition.Network:
                    ScreenLeft.Text = i.CurrentCondition.ToString() + " with " + i.ConnectWay;
                    break;

                case Condition.Calling:
                    ScreenLeft.Text = i.CurrentCondition.ToString() + " to " + i.ConnectWay;
                    break;

                case Condition.Bell:
                    ScreenLeft.Text = i.CurrentCondition.ToString() + " from " + i.ConnectWay;
                    break;

                default:
                    if (i.CurrentCondition == Condition.Wait && i.ConnectWay.Contains("#"))
                        ScreenLeft.Text = "#" + i.CurrentCondition.ToString() + "#";

                    else ScreenLeft.Text = i.CurrentCondition.ToString() + "...";

                    break;
            }

            NumbersLeft.Text = i.DataScreen;

            if (i.CurrentCondition != Condition.Sleep && i.CurrentCondition != Condition.Bell && i.CurrentCondition != Condition.Calling) ActivateAllLeftButtons();
            else DeactivateAllLeftButtons();

            PhoneLeftView.Text = i.Number;

            Ender++;



            if (Ender == 1)
            {
                if (i.ConnectWay.Contains("#") && i.ConnectWay.Length == 5)
                    if (i.CurrentCondition == Condition.Calling || i.CurrentCondition == Condition.Network)
                    {
                        string Need = WAN.ReturnNumber(i.ConnectWay);

                        if (Need == PhoneRightCity.Text) CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), Ender);
                        else CityLeftPhoneView(WAN.ForViewCity(Need), Ender);
                    }

                    if (i.CurrentCondition == Condition.Sleep)
                    {
                            CityLeftPhoneView(WAN.ForViewCity(PhoneLeftCity.Text), Ender);
                            CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), Ender);
                    }

                TimerReloader();
            }




        }



        // Factory-1 Right
        private void CallRight_Click(object sender, EventArgs e)
        {
           RightPhoneView(WAN.CellUp(PhoneRightView.Text, 0), 0);
           LeftPhoneView(WAN.ForView(PhoneLeftView.Text, 0), 0);
        }

        private void OneRight_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("1", PhoneRightView.Text, 0), 0);

            if (Viewer.Number == "###" || Viewer.Number == PhoneRightView.Text) LeftPhoneView(WAN.ForView(PhoneLeftView.Text, 0), 0);
            else LeftPhoneView(Viewer, 0);

            RightPhoneView(WAN.ForView(PhoneRightView.Text, 0), 0);
        }

        private void TwoRight_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("2", PhoneRightView.Text, 0), 0);

            if (Viewer.Number == "###" || Viewer.Number == PhoneRightView.Text) LeftPhoneView(WAN.ForView(PhoneLeftView.Text, 0), 0);
            else LeftPhoneView(Viewer, 0);

            RightPhoneView(WAN.ForView(PhoneRightView.Text, 0), 0);
        }

        private void ThreeRight_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("3", PhoneRightView.Text, 0), 0);

            if (Viewer.Number == "###" || Viewer.Number == PhoneRightView.Text) LeftPhoneView(WAN.ForView(PhoneLeftView.Text, 0), 0);
            else LeftPhoneView(Viewer, 0);

            RightPhoneView(WAN.ForView(PhoneRightView.Text, 0), 0);
        }

        private void FourRight_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("4", PhoneRightView.Text, 0), 0);

            if (Viewer.Number == "###" || Viewer.Number == PhoneRightView.Text) LeftPhoneView(WAN.ForView(PhoneLeftView.Text, 0), 0);
            else LeftPhoneView(Viewer, 0);

            RightPhoneView(WAN.ForView(PhoneRightView.Text, 0), 0);
        }

        private void FiveRight_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("5", PhoneRightView.Text, 0), 0);

            if (Viewer.Number == "###" || Viewer.Number == PhoneRightView.Text) LeftPhoneView(WAN.ForView(PhoneLeftView.Text, 0), 0);
            else LeftPhoneView(Viewer, 0);

            RightPhoneView(WAN.ForView(PhoneRightView.Text, 0), 0);
        }

        private void SixRight_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("6", PhoneRightView.Text, 0), 0);

            if (Viewer.Number == "###" || Viewer.Number == PhoneRightView.Text) LeftPhoneView(WAN.ForView(PhoneLeftView.Text, 0), 0);
            else LeftPhoneView(Viewer, 0);

            RightPhoneView(WAN.ForView(PhoneRightView.Text, 0), 0);
        }

        private void SevenRight_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("7", PhoneRightView.Text, 0), 0);

            if (Viewer.Number == "###" || Viewer.Number == PhoneRightView.Text) LeftPhoneView(WAN.ForView(PhoneLeftView.Text, 0), 0);
            else LeftPhoneView(Viewer, 0);

            RightPhoneView(WAN.ForView(PhoneRightView.Text, 0), 0);
        }

        private void EightRight_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("8", PhoneRightView.Text, 0), 0);

            if (Viewer.Number == "###" || Viewer.Number == PhoneRightView.Text) LeftPhoneView(WAN.ForView(PhoneLeftView.Text, 0), 0);
            else LeftPhoneView(Viewer, 0);

            RightPhoneView(WAN.ForView(PhoneRightView.Text, 0), 0);
        }

        private void NineRight_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("9", PhoneRightView.Text, 0), 0);

            if (Viewer.Number == "###" || Viewer.Number == PhoneRightView.Text) LeftPhoneView(WAN.ForView(PhoneLeftView.Text, 0), 0);
            else LeftPhoneView(Viewer, 0);

            RightPhoneView(WAN.ForView(PhoneRightView.Text, 0), 0);
        }

        private void ZeroRight_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("0", PhoneRightView.Text, 0), 0);

            if (Viewer.Number == "###" || Viewer.Number == PhoneRightView.Text) LeftPhoneView(WAN.ForView(PhoneLeftView.Text, 0), 0);
            else LeftPhoneView(Viewer, 0);

            RightPhoneView(WAN.ForView(PhoneRightView.Text, 0), 0);
        }

        private void StarRight_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("*", PhoneRightView.Text, 0), 0);

            if (Viewer.Number == "###" || Viewer.Number == PhoneRightView.Text) LeftPhoneView(WAN.ForView(PhoneLeftView.Text, 0), 0);
            else LeftPhoneView(Viewer, 0);

            RightPhoneView(WAN.ForView(PhoneRightView.Text, 0), 0);
        }

        private void PrisonRight_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("#", PhoneRightView.Text, 0), 0);

            if (Viewer.Number == "###" || Viewer.Number == PhoneRightView.Text) LeftPhoneView(WAN.ForView(PhoneLeftView.Text, 0), 0);
            else LeftPhoneView(Viewer, 0);

            RightPhoneView(WAN.ForView(PhoneRightView.Text, 0), 0);
        }


        private void RightPhoneView(Phone i, int Ender)
        {
            if (i.CurrentCondition == Condition.Sleep || i.CurrentCondition == Condition.Bell)
                CallRight.BackgroundImage = Properties.Resources.off;
            else CallRight.BackgroundImage = Properties.Resources.on;

            switch (i.CurrentCondition)
            {
                case Condition.Sleep:
                    ScreenRight.Text = "";
                    break;

                case Condition.Network:
                    ScreenRight.Text = i.CurrentCondition.ToString() + " with " + i.ConnectWay;
                    break;

                case Condition.Calling:
                    ScreenRight.Text = i.CurrentCondition.ToString() + " to " + i.ConnectWay;
                    break;

                case Condition.Bell:
                    ScreenRight.Text = i.CurrentCondition.ToString() + " from " + i.ConnectWay;
                    break;

                default:
                    if (i.CurrentCondition == Condition.Wait && i.ConnectWay.Contains("#"))
                        ScreenRight.Text = "#" + i.CurrentCondition.ToString() + "#";

                    else ScreenRight.Text = i.CurrentCondition.ToString() + "...";
                    break;
            }

            NumbersRight.Text = i.DataScreen;

            if (i.CurrentCondition != Condition.Sleep && i.CurrentCondition != Condition.Bell && i.CurrentCondition != Condition.Calling) ActivateAllRightButtons();
            else DeactivateAllRightButtons();

            PhoneRightView.Text = i.Number;

            Ender++;

            if (Ender == 1)
            {
                if (i.ConnectWay.Contains("#") && i.ConnectWay.Length == 5)
                    if (i.CurrentCondition == Condition.Calling || i.CurrentCondition == Condition.Network)
                    {
                        string Need = WAN.ReturnNumber(i.ConnectWay);

                        if (Need == PhoneRightCity.Text) CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), Ender);
                        else CityLeftPhoneView(WAN.ForViewCity(Need), Ender);
                    }

                if (i.CurrentCondition == Condition.Sleep)
                {
                    CityLeftPhoneView(WAN.ForViewCity(PhoneLeftCity.Text), Ender);
                    CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), Ender);
                }

                TimerReloader();
            }
        }




        private void CallLeftCity_Click(object sender, EventArgs e)
        {
            CityLeftPhoneView(WAN.CellUpCity(PhoneLeftCity.Text), 0);
            CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), 0);
        }

        private void OneLeftCity_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForViewCity(WAN.CallingCity("1", PhoneLeftCity.Text));

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftCity.Text)
                CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), 0);

            else CityRightPhoneView(Viewer, 0);

            CityLeftPhoneView(WAN.ForViewCity(PhoneLeftCity.Text), 0);
        }

        private void TwoLeftCity_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForViewCity(WAN.CallingCity("2", PhoneLeftCity.Text));

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftCity.Text)
                CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), 0);

            else CityRightPhoneView(Viewer, 0);

            CityLeftPhoneView(WAN.ForViewCity(PhoneLeftCity.Text), 0);
        }

        private void ThreeLeftCity_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForViewCity(WAN.CallingCity("3", PhoneLeftCity.Text));

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftCity.Text)
                CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), 0);

            else CityRightPhoneView(Viewer, 0);

            CityLeftPhoneView(WAN.ForViewCity(PhoneLeftCity.Text), 0);
        }

        private void FourLeftCity_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForViewCity(WAN.CallingCity("4", PhoneLeftCity.Text));

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftCity.Text)
                CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), 0);

            else CityRightPhoneView(Viewer, 0);

            CityLeftPhoneView(WAN.ForViewCity(PhoneLeftCity.Text), 0);
        }

        private void FiveLeftCity_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForViewCity(WAN.CallingCity("5", PhoneLeftCity.Text));

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftCity.Text)
                CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), 0);

            else CityRightPhoneView(Viewer, 0);

            CityLeftPhoneView(WAN.ForViewCity(PhoneLeftCity.Text), 0);
        }

        private void SixLeftCity_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForViewCity(WAN.CallingCity("6", PhoneLeftCity.Text));

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftCity.Text)
                CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), 0);

            else CityRightPhoneView(Viewer, 0);

            CityLeftPhoneView(WAN.ForViewCity(PhoneLeftCity.Text), 0);
        }

        private void SevenLeftCity_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForViewCity(WAN.CallingCity("7", PhoneLeftCity.Text));

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftCity.Text)
                CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), 0);

            else CityRightPhoneView(Viewer, 0);

            CityLeftPhoneView(WAN.ForViewCity(PhoneLeftCity.Text), 0);
        }

        private void EightLeftCity_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForViewCity(WAN.CallingCity("8", PhoneLeftCity.Text));

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftCity.Text)
                CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), 0);

            else CityRightPhoneView(Viewer, 0);

            CityLeftPhoneView(WAN.ForViewCity(PhoneLeftCity.Text), 0);
        }

        private void NineLeftCity_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForViewCity(WAN.CallingCity("9", PhoneLeftCity.Text));

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftCity.Text)
                CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), 0);

            else CityRightPhoneView(Viewer, 0);

            CityLeftPhoneView(WAN.ForViewCity(PhoneLeftCity.Text), 0);
        }

        private void ZeroLeftCity_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForViewCity(WAN.CallingCity("0", PhoneLeftCity.Text));

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftCity.Text)
                CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), 0);

            else CityRightPhoneView(Viewer, 0);

            CityLeftPhoneView(WAN.ForViewCity(PhoneLeftCity.Text), 0);
        }

        private void StarLeftCity_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForViewCity(WAN.CallingCity("*", PhoneLeftCity.Text));

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftCity.Text)
                CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), 0);

            else CityRightPhoneView(Viewer, 0);

            CityLeftPhoneView(WAN.ForViewCity(PhoneLeftCity.Text), 0);
        }
        private void PrisonLeftCity_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForViewCity(WAN.CallingCity("#", PhoneLeftCity.Text));

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftCity.Text)
                CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), 0);
            else CityRightPhoneView(Viewer, 0);

            CityLeftPhoneView(WAN.ForViewCity(PhoneLeftCity.Text), 0);
        }



        private void CityLeftPhoneView(Phone i, int Ender)
        {
            if (i.CurrentCondition == Condition.Sleep || i.CurrentCondition == Condition.Bell)
                CallLeftCity.BackgroundImage = Properties.Resources.off;
            else CallLeftCity.BackgroundImage = Properties.Resources.on;

            switch (i.CurrentCondition)
            {
                case Condition.Sleep:
                    ScreenLeftCity.Text = "";
                    break;

                case Condition.Network:
                    ScreenLeftCity.Text = i.CurrentCondition.ToString() + " with " + i.ConnectWay;
                    break;

                case Condition.Calling:
                    ScreenLeftCity.Text = i.CurrentCondition.ToString() + " to " + i.ConnectWay;
                    break;

                case Condition.Bell:
                    ScreenLeftCity.Text = i.CurrentCondition.ToString() + " from " + i.ConnectWay;
                    break;

                default:
                    ScreenLeftCity.Text = i.CurrentCondition.ToString() + "...";
                    break;
            }


            NumbersLeftCity.Text = i.DataScreen;

            if (i.CurrentCondition != Condition.Sleep && i.CurrentCondition != Condition.Bell) ActivateAllLeftCityButtons();
            else DeactivateAllLeftCityButtons();

            PhoneLeftCity.Text = i.Number;

            Ender++;

            if (Ender == 1)
            {

                if (i.ConnectWay.Contains("#") && i.ConnectWay.Length == 5)
                    if (i.CurrentCondition == Condition.Calling || i.CurrentCondition == Condition.Network)
                    {
                        string Need = WAN.ReturnNumber(i.ConnectWay);
                        string Net = WAN.ReturnNetwork(i.ConnectWay);

                        if (Net == "1")
                        {
                            if (Need == PhoneRightView.Text) RightPhoneView(WAN.ForView(PhoneRightView.Text, 0), Ender);
                            else LeftPhoneView(WAN.ForView(Need, 0), Ender);
                        }

                        if (Net == "2")
                        {
                            if (Need == AnotherRightPhoneView.Text) AnotherPhoneRightView(WAN.ForView(AnotherRightPhoneView.Text, 1), Ender);
                            else AnotherPhoneLeftView(WAN.ForView(Need, 1), Ender);
                        }
                    }

                if (i.CurrentCondition == Condition.Sleep)
                {
                    LeftPhoneView(WAN.ForView(PhoneLeftView.Text, 0), Ender);
                    RightPhoneView(WAN.ForView(PhoneRightView.Text, 0), Ender);

                    AnotherPhoneLeftView(WAN.ForView(AnotherLeftPhoneView.Text, 1), Ender);
                    AnotherPhoneRightView(WAN.ForView(AnotherRightPhoneView.Text, 1), Ender);
                }

                TimerReloader();
            }
        }







        private void CallRightCity_Click(object sender, EventArgs e)
        {
            CityRightPhoneView(WAN.CellUpCity(PhoneRightCity.Text), 0); 
            CityLeftPhoneView(WAN.ForViewCity(PhoneLeftCity.Text), 0);
        }
        

        private void OneRightCity_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForViewCity(WAN.CallingCity("1", PhoneRightCity.Text));

            if (Viewer.Number == "###" || Viewer.Number == PhoneRightCity.Text)
                CityLeftPhoneView(WAN.ForViewCity(PhoneLeftCity.Text), 0);

            else CityLeftPhoneView(Viewer, 0);

            CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), 0);
        }

        private void TwoRightCity_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForViewCity(WAN.CallingCity("2", PhoneRightCity.Text));

            if (Viewer.Number == "###" || Viewer.Number == PhoneRightCity.Text)
                CityLeftPhoneView(WAN.ForViewCity(PhoneLeftCity.Text), 0);

            else CityLeftPhoneView(Viewer, 0);

            CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), 0);
        }

        private void ThreeRightCity_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForViewCity(WAN.CallingCity("3", PhoneRightCity.Text));

            if (Viewer.Number == "###" || Viewer.Number == PhoneRightCity.Text)
                CityLeftPhoneView(WAN.ForViewCity(PhoneLeftCity.Text), 0);

            else CityLeftPhoneView(Viewer, 0);

            CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), 0);
        }

        private void FourRightCity_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForViewCity(WAN.CallingCity("4", PhoneRightCity.Text));

            if (Viewer.Number == "###" || Viewer.Number == PhoneRightCity.Text)
                CityLeftPhoneView(WAN.ForViewCity(PhoneLeftCity.Text), 0);

            else CityLeftPhoneView(Viewer, 0);

            CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), 0);
        }

        private void FiveRightCity_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForViewCity(WAN.CallingCity("5", PhoneRightCity.Text));

            if (Viewer.Number == "###" || Viewer.Number == PhoneRightCity.Text)
                CityLeftPhoneView(WAN.ForViewCity(PhoneLeftCity.Text), 0);

            else CityLeftPhoneView(Viewer, 0);

            CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), 0);
        }

        private void SixRightCity_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForViewCity(WAN.CallingCity("6", PhoneRightCity.Text));

            if (Viewer.Number == "###" || Viewer.Number == PhoneRightCity.Text)
                CityLeftPhoneView(WAN.ForViewCity(PhoneLeftCity.Text), 0);

            else CityLeftPhoneView(Viewer, 0);

            CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), 0);
        }

        private void SevenRightCity_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForViewCity(WAN.CallingCity("7", PhoneRightCity.Text));

            if (Viewer.Number == "###" || Viewer.Number == PhoneRightCity.Text)
                CityLeftPhoneView(WAN.ForViewCity(PhoneLeftCity.Text), 0);

            else CityLeftPhoneView(Viewer, 0);

            CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), 0);
        }

        private void EightRightCity_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForViewCity(WAN.CallingCity("8", PhoneRightCity.Text));

            if (Viewer.Number == "###" || Viewer.Number == PhoneRightCity.Text)
                CityLeftPhoneView(WAN.ForViewCity(PhoneLeftCity.Text), 0);

            else CityLeftPhoneView(Viewer, 0);

            CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), 0);
        }

        private void NineRightCity_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForViewCity(WAN.CallingCity("9", PhoneRightCity.Text));

            if (Viewer.Number == "###" || Viewer.Number == PhoneRightCity.Text)
                CityLeftPhoneView(WAN.ForViewCity(PhoneLeftCity.Text), 0);

            else CityLeftPhoneView(Viewer, 0);

            CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), 0);
        }

        private void ZeroRightCity_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForViewCity(WAN.CallingCity("0", PhoneRightCity.Text));

            if (Viewer.Number == "###" || Viewer.Number == PhoneRightCity.Text)
                CityLeftPhoneView(WAN.ForViewCity(PhoneLeftCity.Text), 0);

            else CityLeftPhoneView(Viewer, 0);

            CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), 0);
        }

        private void StarRightCity_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForViewCity(WAN.CallingCity("*", PhoneRightCity.Text));

            if (Viewer.Number == "###" || Viewer.Number == PhoneRightCity.Text)
                CityLeftPhoneView(WAN.ForViewCity(PhoneLeftCity.Text), 0);

            else CityLeftPhoneView(Viewer, 0);

            CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), 0);
        }

        private void PrisonRightCity_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForViewCity(WAN.CallingCity("#", PhoneRightCity.Text));

            if (Viewer.Number == "###" || Viewer.Number == PhoneRightCity.Text)
                CityLeftPhoneView(WAN.ForViewCity(PhoneLeftCity.Text), 0);

            else CityLeftPhoneView(Viewer, 0);

            CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), 0);
            
        }


        private void CityRightPhoneView(Phone i, int Ender)
        {
            if (i.CurrentCondition == Condition.Sleep || i.CurrentCondition == Condition.Bell)
                CallRightCity.BackgroundImage = Properties.Resources.off;
            else CallRightCity.BackgroundImage = Properties.Resources.on;

            switch (i.CurrentCondition)
            {
                case Condition.Sleep:
                    ScreenRightCity.Text = "";
                    break;

                case Condition.Network:
                    ScreenRightCity.Text = i.CurrentCondition.ToString() + " with " + i.ConnectWay;
                    break;

                case Condition.Calling:
                    ScreenRightCity.Text = i.CurrentCondition.ToString() + " to " + i.ConnectWay;
                    break;

                case Condition.Bell:
                    ScreenRightCity.Text = i.CurrentCondition.ToString() + " from " + i.ConnectWay;
                    break;

                default:
                    ScreenRightCity.Text = i.CurrentCondition.ToString() + "...";
                    break;
            }

            NumbersRightCity.Text = i.DataScreen;

            if (i.CurrentCondition != Condition.Sleep && i.CurrentCondition != Condition.Bell) ActivateAllRightCityButtons();
            else DeactivateAllRightCityButtons();

            PhoneRightCity.Text = i.Number;

            Ender++;

            if (Ender == 1)
            {

                if (i.ConnectWay.Contains("#") && i.ConnectWay.Length == 5)
                    if (i.CurrentCondition == Condition.Calling || i.CurrentCondition == Condition.Network)
                    {
                        string Need = WAN.ReturnNumber(i.ConnectWay);
                        string Net = WAN.ReturnNetwork(i.ConnectWay);

                        if (Net == "1")
                        {
                            if (Need == PhoneRightView.Text) RightPhoneView(WAN.ForView(PhoneRightView.Text, 0), Ender);
                            else LeftPhoneView(WAN.ForView(Need, 0), Ender);
                        }

                        if (Net == "2")
                        {
                            if (Need == AnotherRightPhoneView.Text) AnotherPhoneRightView(WAN.ForView(AnotherRightPhoneView.Text, 1), Ender);
                            else AnotherPhoneLeftView(WAN.ForView(Need, 1), Ender);
                        }
                    }

                if (i.CurrentCondition == Condition.Sleep)
                {
                    LeftPhoneView(WAN.ForView(PhoneLeftView.Text, 0), Ender);
                    RightPhoneView(WAN.ForView(PhoneRightView.Text, 0), Ender);

                    AnotherPhoneLeftView(WAN.ForView(AnotherLeftPhoneView.Text, 1), Ender);
                    AnotherPhoneRightView(WAN.ForView(AnotherRightPhoneView.Text, 1), Ender);
                }

                TimerReloader();
            }
        }








        private void AnotherLeftCall_Click(object sender, EventArgs e)
        {
            AnotherPhoneLeftView(WAN.CellUp(AnotherLeftPhoneView.Text, 1), 0);
            AnotherPhoneRightView(WAN.ForView(AnotherRightPhoneView.Text, 1), 0);
        }

        private void AnotherLeftOne_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("1", AnotherLeftPhoneView.Text, 1), 1);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text)
                AnotherPhoneRightView(WAN.ForView(AnotherRightPhoneView.Text, 1), 0);
            else AnotherPhoneRightView(Viewer, 0);

            AnotherPhoneLeftView(WAN.ForView(AnotherLeftPhoneView.Text, 1), 0);
        }

        private void AnotherLeftTwo_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("2", AnotherLeftPhoneView.Text, 1), 1);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text)
                AnotherPhoneRightView(WAN.ForView(AnotherRightPhoneView.Text, 1), 0);
            else AnotherPhoneRightView(Viewer, 0);

            AnotherPhoneLeftView(WAN.ForView(AnotherLeftPhoneView.Text, 1), 0);
        }

        private void AnotherLeftThree_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("3", AnotherLeftPhoneView.Text, 1), 1);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text)
                AnotherPhoneRightView(WAN.ForView(AnotherRightPhoneView.Text, 1), 0);
            else AnotherPhoneRightView(Viewer, 0);

            AnotherPhoneLeftView(WAN.ForView(AnotherLeftPhoneView.Text, 1), 0);
        }

        private void AnotherLeftFour_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("4", AnotherLeftPhoneView.Text, 1), 1);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text)
                AnotherPhoneRightView(WAN.ForView(AnotherRightPhoneView.Text, 1), 0);
            else AnotherPhoneRightView(Viewer, 0);

            AnotherPhoneLeftView(WAN.ForView(AnotherLeftPhoneView.Text, 1), 0);
        }

        private void AnotherLeftFive_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("5", AnotherLeftPhoneView.Text, 1), 1);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text)
                AnotherPhoneRightView(WAN.ForView(AnotherRightPhoneView.Text, 1), 0);
            else AnotherPhoneRightView(Viewer, 0);

            AnotherPhoneLeftView(WAN.ForView(AnotherLeftPhoneView.Text, 1), 0);
        }

        private void AnotherLeftSix_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("6", AnotherLeftPhoneView.Text, 1), 1);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text)
                AnotherPhoneRightView(WAN.ForView(AnotherRightPhoneView.Text, 1), 0);
            else AnotherPhoneRightView(Viewer, 0);

            AnotherPhoneLeftView(WAN.ForView(AnotherLeftPhoneView.Text, 1), 0);
        }

        private void AnotherLeftSeven_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("7", AnotherLeftPhoneView.Text, 1), 1);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text)
                AnotherPhoneRightView(WAN.ForView(AnotherRightPhoneView.Text, 1), 0);
            else AnotherPhoneRightView(Viewer, 0);

            AnotherPhoneLeftView(WAN.ForView(AnotherLeftPhoneView.Text, 1), 0);
        }

        private void AnotherLeftEight_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("8", AnotherLeftPhoneView.Text, 1), 1);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text)
                AnotherPhoneRightView(WAN.ForView(AnotherRightPhoneView.Text, 1), 0);
            else AnotherPhoneRightView(Viewer, 0);

            AnotherPhoneLeftView(WAN.ForView(AnotherLeftPhoneView.Text, 1), 0);
        }

        private void AnotherLeftNine_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("9", AnotherLeftPhoneView.Text, 1), 1);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text)
                AnotherPhoneRightView(WAN.ForView(AnotherRightPhoneView.Text, 1), 0);
            else AnotherPhoneRightView(Viewer, 0);

            AnotherPhoneLeftView(WAN.ForView(AnotherLeftPhoneView.Text, 1), 0);
        }

        private void AnotherLeftZero_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("0", AnotherLeftPhoneView.Text, 1), 1);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text)
                AnotherPhoneRightView(WAN.ForView(AnotherRightPhoneView.Text, 1), 0);
            else AnotherPhoneRightView(Viewer, 0);

            AnotherPhoneLeftView(WAN.ForView(AnotherLeftPhoneView.Text, 1), 0);
        }

        private void AnotherLeftStar_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("*", AnotherLeftPhoneView.Text, 1), 1);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text)
                AnotherPhoneRightView(WAN.ForView(AnotherRightPhoneView.Text, 1), 0);
            else AnotherPhoneRightView(Viewer, 0);

            AnotherPhoneLeftView(WAN.ForView(AnotherLeftPhoneView.Text, 1), 0);
        }

        private void AnotherLeftPrison_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("#", AnotherLeftPhoneView.Text, 1), 1);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text)
                AnotherPhoneRightView(WAN.ForView(AnotherRightPhoneView.Text, 1), 0);
            else AnotherPhoneRightView(Viewer, 0);

            AnotherPhoneLeftView(WAN.ForView(AnotherLeftPhoneView.Text, 1), 0);
        }


        private void AnotherPhoneLeftView(Phone i, int Ender)
        {
            if (i.Number != AnotherRightPhoneView.Text)
            {
                if (i.CurrentCondition == Condition.Sleep || i.CurrentCondition == Condition.Bell)
                    AnotherLeftCall.BackgroundImage = Properties.Resources.off;
                else AnotherLeftCall.BackgroundImage = Properties.Resources.on;

                switch (i.CurrentCondition)
                {
                    case Condition.Sleep:
                        AnotherLeftScreen.Text = "";
                        break;

                    case Condition.Network:
                        AnotherLeftScreen.Text = i.CurrentCondition.ToString() + " with " + i.ConnectWay;
                        break;

                    case Condition.Calling:
                        AnotherLeftScreen.Text = i.CurrentCondition.ToString() + " to " + i.ConnectWay;
                        break;

                    case Condition.Bell:
                        AnotherLeftScreen.Text = i.CurrentCondition.ToString() + " from " + i.ConnectWay;
                        break;

                    default:
                        if (i.CurrentCondition == Condition.Wait && i.ConnectWay.Contains("#"))
                            AnotherLeftScreen.Text = "#" + i.CurrentCondition.ToString() + "#";

                        else AnotherLeftScreen.Text = i.CurrentCondition.ToString() + "...";
                        break;
                }

                AnotherLeftNumbers.Text = i.DataScreen;

                if (i.CurrentCondition != Condition.Sleep && i.CurrentCondition != Condition.Bell && i.CurrentCondition != Condition.Calling)
                    ActivateAllLeftAnotherButtons();
                else DeactivateAllLeftAnotherButtons();

                AnotherLeftPhoneView.Text = i.Number;

                Ender++;

                if (Ender == 1)
                {
                    if (i.ConnectWay.Contains("#") && i.ConnectWay.Length == 5)
                        if (i.CurrentCondition == Condition.Calling || i.CurrentCondition == Condition.Network)
                        {
                            string Need = WAN.ReturnNumber(i.ConnectWay);

                            if (Need == PhoneRightCity.Text) CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), Ender);
                            else CityLeftPhoneView(WAN.ForViewCity(Need), Ender);
                        }

                    if (i.CurrentCondition == Condition.Sleep)
                    {
                        CityLeftPhoneView(WAN.ForViewCity(PhoneLeftCity.Text), Ender);
                        CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), Ender);
                    }

                    TimerReloader();
                }
            }
        }



        private void AnotherRightCall_Click(object sender, EventArgs e)
        {
            AnotherPhoneRightView(WAN.CellUp(AnotherRightPhoneView.Text, 1), 0);
            AnotherPhoneLeftView(WAN.ForView(AnotherLeftPhoneView.Text, 1), 0);
        }

        private void AnotherRightOne_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("1", AnotherRightPhoneView.Text, 1), 1);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text)
                AnotherPhoneLeftView(WAN.ForView(AnotherLeftPhoneView.Text, 1), 0);
            else AnotherPhoneLeftView(Viewer, 0);

            AnotherPhoneRightView(WAN.ForView(AnotherRightPhoneView.Text, 1), 0);
        }

        private void AnotherRightTwo_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("2", AnotherRightPhoneView.Text, 1), 1);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text)
                AnotherPhoneLeftView(WAN.ForView(AnotherLeftPhoneView.Text, 1), 0);
            else AnotherPhoneLeftView(Viewer, 0);

            AnotherPhoneRightView(WAN.ForView(AnotherRightPhoneView.Text, 1), 0);
        }

        private void AnotherRightThree_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("3", AnotherRightPhoneView.Text, 1), 1);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text)
                AnotherPhoneLeftView(WAN.ForView(AnotherLeftPhoneView.Text, 1), 0);
            else AnotherPhoneLeftView(Viewer, 0);

            AnotherPhoneRightView(WAN.ForView(AnotherRightPhoneView.Text, 1), 0);
        }

        private void AnotherRightFour_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("4", AnotherRightPhoneView.Text, 1), 1);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text)
                AnotherPhoneLeftView(WAN.ForView(AnotherLeftPhoneView.Text, 1), 0);
            else AnotherPhoneLeftView(Viewer, 0);

            AnotherPhoneRightView(WAN.ForView(AnotherRightPhoneView.Text, 1), 0);
        }

        private void AnotherRightFive_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("5", AnotherRightPhoneView.Text, 1), 1);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text)
                AnotherPhoneLeftView(WAN.ForView(AnotherLeftPhoneView.Text, 1), 0);
            else AnotherPhoneLeftView(Viewer, 0);

            AnotherPhoneRightView(WAN.ForView(AnotherRightPhoneView.Text, 1), 0);
        }

        private void AnotherRightSix_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("6", AnotherRightPhoneView.Text, 1), 1);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text)
                AnotherPhoneLeftView(WAN.ForView(AnotherLeftPhoneView.Text, 1), 0);
            else AnotherPhoneLeftView(Viewer, 0);

            AnotherPhoneRightView(WAN.ForView(AnotherRightPhoneView.Text, 1), 0);
        }

        private void AnotherRightSeven_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("7", AnotherRightPhoneView.Text, 1), 1);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text)
                AnotherPhoneLeftView(WAN.ForView(AnotherLeftPhoneView.Text, 1), 0);
            else AnotherPhoneLeftView(Viewer, 0);

            AnotherPhoneRightView(WAN.ForView(AnotherRightPhoneView.Text, 1), 0);
        }

        private void AnotherRightEight_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("8", AnotherRightPhoneView.Text, 1), 1);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text)
                AnotherPhoneLeftView(WAN.ForView(AnotherLeftPhoneView.Text, 1), 0);
            else AnotherPhoneLeftView(Viewer, 0);

            AnotherPhoneRightView(WAN.ForView(AnotherRightPhoneView.Text, 1), 0);
        }

        private void AnotherRightNine_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("9", AnotherRightPhoneView.Text, 1), 1);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text)
                AnotherPhoneLeftView(WAN.ForView(AnotherLeftPhoneView.Text, 1), 0);
            else AnotherPhoneLeftView(Viewer, 0);

            AnotherPhoneRightView(WAN.ForView(AnotherRightPhoneView.Text, 1), 0);
        }

        private void AnotherRightZero_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("0", AnotherRightPhoneView.Text, 1), 1);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text)
                AnotherPhoneLeftView(WAN.ForView(AnotherLeftPhoneView.Text, 1), 0);
            else AnotherPhoneLeftView(Viewer, 0);

            AnotherPhoneRightView(WAN.ForView(AnotherRightPhoneView.Text, 1), 0);
        }

        private void AnotherRightStar_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("*", AnotherRightPhoneView.Text, 1), 1);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text)
                AnotherPhoneLeftView(WAN.ForView(AnotherLeftPhoneView.Text, 1), 0);
            else AnotherPhoneLeftView(Viewer, 0);

            AnotherPhoneRightView(WAN.ForView(AnotherRightPhoneView.Text, 1), 0);
        }

        private void AnotherRightPrison_Click(object sender, EventArgs e)
        {
            Phone Viewer = WAN.ForView(WAN.Calling("#", AnotherRightPhoneView.Text, 1), 1);

            if (Viewer.Number == "###" || Viewer.Number == PhoneLeftView.Text)
                AnotherPhoneLeftView(WAN.ForView(AnotherLeftPhoneView.Text, 1), 0);
            else AnotherPhoneLeftView(Viewer, 0);

            AnotherPhoneRightView(WAN.ForView(AnotherRightPhoneView.Text, 1), 0);
        }

        private void AnotherPhoneRightView(Phone i, int Ender)
        {
            if (i.CurrentCondition == Condition.Sleep || i.CurrentCondition == Condition.Bell)
                AnotherRightCall.BackgroundImage = Properties.Resources.off;
            else AnotherRightCall.BackgroundImage = Properties.Resources.on;

            switch (i.CurrentCondition)
            {
                case Condition.Sleep:
                    AnotherRightScreen.Text = "";
                    break;

                case Condition.Network:
                    AnotherRightScreen.Text = i.CurrentCondition.ToString() + " with " + i.ConnectWay;
                    break;

                case Condition.Calling:
                    AnotherRightScreen.Text = i.CurrentCondition.ToString() + " to " + i.ConnectWay;
                    break;

                case Condition.Bell:
                    AnotherRightScreen.Text = i.CurrentCondition.ToString() + " from " + i.ConnectWay;
                    break;

                default:
                    if (i.CurrentCondition == Condition.Wait && i.ConnectWay.Contains("#"))
                        AnotherRightScreen.Text = "#" + i.CurrentCondition.ToString() + "#";

                    else AnotherRightScreen.Text = i.CurrentCondition.ToString() + "...";
                    break;
            }

            AnotherRightNumbers.Text = i.DataScreen;

            if (i.CurrentCondition != Condition.Sleep && i.CurrentCondition != Condition.Bell && i.CurrentCondition != Condition.Calling)
                ActivateAllRightAnotherButtons();
            else DeactivateAllRightAnotherButtons();

            AnotherRightPhoneView.Text = i.Number;

            Ender++;

            if (Ender == 1)
            {
                if (i.ConnectWay.Contains("#") && i.ConnectWay.Length == 5)
                    if (i.CurrentCondition == Condition.Calling || i.CurrentCondition == Condition.Network)
                    {
                        string Need = WAN.ReturnNumber(i.ConnectWay);

                        if (Need == PhoneRightCity.Text) CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), Ender);
                        else CityLeftPhoneView(WAN.ForViewCity(Need), Ender);
                    }

                if (i.CurrentCondition == Condition.Sleep)
                {
                    CityLeftPhoneView(WAN.ForViewCity(PhoneLeftCity.Text), Ender);
                    CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), Ender);
                }

                TimerReloader();

            }
        }





        private bool CurrentMousePosition = false;

        private int MouseY;
        private int MouseX;

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        { CurrentMousePosition = false; }
   
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentMousePosition = true;
            MouseY = Cursor.Position.Y - this.Top;
            MouseX = Cursor.Position.X - this.Left;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (CurrentMousePosition)
            {
                this.Top = Cursor.Position.Y - MouseY;
                this.Left = Cursor.Position.X - MouseX;
            }
        }






        private void ProjectName_MouseUp(object sender, MouseEventArgs e)
        { CurrentMousePosition = false; }
        private void ProjectName_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentMousePosition = true;
            MouseY = Cursor.Position.Y - this.Top;
            MouseX = Cursor.Position.X - this.Left;
        }

        private void ProjectName_MouseMove(object sender, MouseEventArgs e)
        {
            if (CurrentMousePosition)
            {
                this.Top = Cursor.Position.Y - MouseY;
                this.Left = Cursor.Position.X - MouseX;
            }
        }




        private void Exit_Click(object sender, EventArgs e)
        { Application.Exit(); }
        private void Exit_MouseEnter(object sender, EventArgs e)
        { Exit.BackgroundImage = Properties.Resources.exitActive; }
        private void Exit_MouseLeave(object sender, EventArgs e)
        { Exit.BackgroundImage = Properties.Resources.exit; }

        private void Minimize_Click(object sender, EventArgs e)
        { this.WindowState = FormWindowState.Minimized; }
        private void Minimize_MouseEnter(object sender, EventArgs e)
        { Minimize.BackgroundImage = Properties.Resources.Minimum_on; }
        private void Minimize_MouseLeave(object sender, EventArgs e)
        { Minimize.BackgroundImage = Properties.Resources.Minimum_off; }

        private void ActivateAllLeftButtons()
        {
            OneLeft.Enabled = true;
            TwoLeft.Enabled = true;
            ThreeLeft.Enabled = true;
            FourLeft.Enabled = true;
            FiveLeft.Enabled = true;
            SixLeft.Enabled = true;
            SevenLeft.Enabled = true;
            EightLeft.Enabled = true;
            NineLeft.Enabled = true;
            ZeroLeft.Enabled = true;
            StarLeft.Enabled = true;
            PrisonLeft.Enabled = true;
        }
        private void ActivateAllRightButtons()
        {
            OneRight.Enabled = true;
            TwoRight.Enabled = true;
            ThreeRight.Enabled = true;
            FourRight.Enabled = true;
            FiveRight.Enabled = true;
            SixRight.Enabled = true;
            SevenRight.Enabled = true;
            EightRight.Enabled = true;
            NineRight.Enabled = true;
            ZeroRight.Enabled = true;
            StarRight.Enabled = true;
            PrisonRight.Enabled = true;
        }
        private void ActivateAllLeftCityButtons()
        {
            OneLeftCity.Enabled = true;
            TwoLeftCity.Enabled = true;
            ThreeLeftCity.Enabled = true;
            FourLeftCity.Enabled = true;
            FiveLeftCity.Enabled = true;
            SixLeftCity.Enabled = true;
            SevenLeftCity.Enabled = true;
            EightLeftCity.Enabled = true;
            NineLeftCity.Enabled = true;
            ZeroLeftCity.Enabled = true;
            StarLeftCity.Enabled = true;
            PrisonLeftCity.Enabled = true;
        }

        private void ActivateAllRightCityButtons()
        {
            OneRightCity.Enabled = true;
            TwoRightCity.Enabled = true;
            ThreeRightCity.Enabled = true;
            FourRightCity.Enabled = true;
            FiveRightCity.Enabled = true;
            SixRightCity.Enabled = true;
            SevenRightCity.Enabled = true;
            EightRightCity.Enabled = true;
            NineRightCity.Enabled = true;
            ZeroRightCity.Enabled = true;
            StarRightCity.Enabled = true;
            PrisonRightCity.Enabled = true;
        }

        private void ActivateAllLeftAnotherButtons()
        {
            AnotherLeftOne.Enabled = true;
            AnotherLeftTwo.Enabled = true;
            AnotherLeftThree.Enabled = true;
            AnotherLeftFour.Enabled = true;
            AnotherLeftFive.Enabled = true;
            AnotherLeftSix.Enabled = true;
            AnotherLeftSeven.Enabled = true;
            AnotherLeftEight.Enabled = true;
            AnotherLeftNine.Enabled = true;
            AnotherLeftZero.Enabled = true;
            AnotherLeftStar.Enabled = true;
            AnotherLeftPrison.Enabled = true;
        }
        private void ActivateAllRightAnotherButtons()
        {
            AnotherRightOne.Enabled = true;
            AnotherRightTwo.Enabled = true;
            AnotherRightThree.Enabled = true;
            AnotherRightFour.Enabled = true;
            AnotherRightFive.Enabled = true;
            AnotherRightSix.Enabled = true;
            AnotherRightSeven.Enabled = true;
            AnotherRightEight.Enabled = true;
            AnotherRightNine.Enabled = true;
            AnotherRightZero.Enabled = true;
            AnotherRightStar.Enabled = true;
            AnotherRightPrison.Enabled = true;
        }




        private void DeactivateAllLeftButtons()
        {
            OneLeft.Enabled = false;
            TwoLeft.Enabled = false;
            ThreeLeft.Enabled = false;
            FourLeft.Enabled = false;
            FiveLeft.Enabled = false;
            SixLeft.Enabled = false;
            SevenLeft.Enabled = false;
            EightLeft.Enabled = false;
            NineLeft.Enabled = false;
            ZeroLeft.Enabled = false;
            StarLeft.Enabled = false;
            PrisonLeft.Enabled = false;
        }
        private void DeactivateAllRightButtons()
        {
            OneRight.Enabled = false;
            TwoRight.Enabled = false;
            ThreeRight.Enabled = false;
            FourRight.Enabled = false;
            FiveRight.Enabled = false;
            SixRight.Enabled = false;
            SevenRight.Enabled = false;
            EightRight.Enabled = false;
            NineRight.Enabled = false;
            ZeroRight.Enabled = false;
            StarRight.Enabled = false;
            PrisonRight.Enabled = false;
        }



        private void DeactivateAllLeftCityButtons()
        {
            OneLeftCity.Enabled = false;
            TwoLeftCity.Enabled = false;
            ThreeLeftCity.Enabled = false;
            FourLeftCity.Enabled = false;
            FiveLeftCity.Enabled = false;
            SixLeftCity.Enabled = false;
            SevenLeftCity.Enabled = false;
            EightLeftCity.Enabled = false;
            NineLeftCity.Enabled = false;
            ZeroLeftCity.Enabled = false;
            StarLeftCity.Enabled = false;
            PrisonLeftCity.Enabled = false;
        }

        private void DeactivateAllRightCityButtons()
        {
            OneRightCity.Enabled = false;
            TwoRightCity.Enabled = false;
            ThreeRightCity.Enabled = false;
            FourRightCity.Enabled = false;
            FiveRightCity.Enabled = false;
            SixRightCity.Enabled = false;
            SevenRightCity.Enabled = false;
            EightRightCity.Enabled = false;
            NineRightCity.Enabled = false;
            ZeroRightCity.Enabled = false;
            StarRightCity.Enabled = false;
            PrisonRightCity.Enabled = false;
        }

        private void DeactivateAllLeftAnotherButtons()
        {
            AnotherLeftOne.Enabled = false;
            AnotherLeftTwo.Enabled = false;
            AnotherLeftThree.Enabled = false;
            AnotherLeftFour.Enabled = false;
            AnotherLeftFive.Enabled = false;
            AnotherLeftSix.Enabled = false;
            AnotherLeftSeven.Enabled = false;
            AnotherLeftEight.Enabled = false;
            AnotherLeftNine.Enabled = false;
            AnotherLeftZero.Enabled = false;
            AnotherLeftStar.Enabled = false;
            AnotherLeftPrison.Enabled = false;
        }
        private void DeactivateAllRightAnotherButtons()
        {
            AnotherRightOne.Enabled = false;
            AnotherRightTwo.Enabled = false;
            AnotherRightThree.Enabled = false;
            AnotherRightFour.Enabled = false;
            AnotherRightFive.Enabled = false;
            AnotherRightSix.Enabled = false;
            AnotherRightSeven.Enabled = false;
            AnotherRightEight.Enabled = false;
            AnotherRightNine.Enabled = false;
            AnotherRightZero.Enabled = false;
            AnotherRightStar.Enabled = false;
            AnotherRightPrison.Enabled = false;
        }



        private void CostumePhoneFact1_TextChanged(object sender, EventArgs e)
        {
            Fact1Viewer.Enabled = true;

            if (CostumePhoneFact1.Text.Length != 3) Fact1Viewer.Enabled = false;
            if (Fact1Left.Checked == false && Fact1Right.Checked == false)
                Fact1Viewer.Enabled = false;

            foreach (char i in CostumePhoneFact1.Text)
                if (!"1234567890".Contains(i))
                    Fact1Viewer.Enabled = false;

            if (PhoneLeftView.Text == CostumePhoneFact1.Text && Fact1Left.Checked)
                Fact1Viewer.Enabled = false;

            if (PhoneRightView.Text == CostumePhoneFact1.Text && Fact1Right.Checked)
                Fact1Viewer.Enabled = false;

            if (PhoneLeftView.Text == CostumePhoneFact1.Text && Fact1Right.Checked)
                Fact1Viewer.Enabled = false;

            if (PhoneRightView.Text == CostumePhoneFact1.Text && Fact1Left.Checked)
                Fact1Viewer.Enabled = false;
        }

        private void Fact1Left_CheckedChanged(object sender, EventArgs e)
        {
            Fact1Viewer.Enabled = true;

            if (CostumePhoneFact1.Text.Length != 3) Fact1Viewer.Enabled = false;
            if (Fact1Left.Checked == false && Fact1Right.Checked == false)
                Fact1Viewer.Enabled = false;

            foreach (char i in CostumePhoneFact1.Text)
                if (!"1234567890".Contains(i))
                    Fact1Viewer.Enabled = false;

            if (PhoneLeftView.Text == CostumePhoneFact1.Text && Fact1Left.Checked)
                Fact1Viewer.Enabled = false;

            if (PhoneRightView.Text == CostumePhoneFact1.Text && Fact1Right.Checked)
                Fact1Viewer.Enabled = false;

            if (PhoneLeftView.Text == CostumePhoneFact1.Text && Fact1Right.Checked)
                Fact1Viewer.Enabled = false;

            if (PhoneRightView.Text == CostumePhoneFact1.Text && Fact1Left.Checked)
                Fact1Viewer.Enabled = false;
        }

        private void Fact1Right_CheckedChanged(object sender, EventArgs e)
        {
            Fact1Viewer.Enabled = true;

            if (CostumePhoneFact1.Text.Length != 3) Fact1Viewer.Enabled = false;
            if (Fact1Left.Checked == false && Fact1Right.Checked == false)
                Fact1Viewer.Enabled = false;

            foreach (char i in CostumePhoneFact1.Text)
                if (!"1234567890".Contains(i))
                    Fact1Viewer.Enabled = false;


            if (PhoneLeftView.Text == CostumePhoneFact1.Text && Fact1Left.Checked)
                Fact1Viewer.Enabled = false;

            if (PhoneRightView.Text == CostumePhoneFact1.Text && Fact1Right.Checked)
                Fact1Viewer.Enabled = false;

            if (PhoneLeftView.Text == CostumePhoneFact1.Text && Fact1Right.Checked)
                Fact1Viewer.Enabled = false;

            if (PhoneRightView.Text == CostumePhoneFact1.Text && Fact1Left.Checked)
                Fact1Viewer.Enabled = false;
        }

        private void Fact1Viewer_Click(object sender, EventArgs e)
        {
            if (Fact1Left.Checked) LeftPhoneView(WAN.ForView(CostumePhoneFact1.Text, 0), 1);
            if (Fact1Right.Checked) RightPhoneView(WAN.ForView(CostumePhoneFact1.Text, 0), 1);

            CostumePhoneFact1.Text = "";
            Fact1Viewer.Enabled = false;
        }

        private void Fact1Reload_Click(object sender, EventArgs e)
        {
            LeftPhoneView(WAN.ForView(PhoneLeftView.Text, 0), 1);
            RightPhoneView(WAN.ForView(PhoneRightView.Text, 0), 1);
        }


        private void CostumePhoneCity_TextChanged(object sender, EventArgs e)
        {
            CityViewer.Enabled = true;

            if (CostumePhoneCity.Text.Length != 3) CityViewer.Enabled = false;
            if (CityLeft.Checked == false && CityRight.Checked == false)
                CityViewer.Enabled = false;

            foreach (char i in CostumePhoneCity.Text)
                if (!"1234567890".Contains(i))
                    CityViewer.Enabled = false;

            if (PhoneLeftCity.Text == CostumePhoneCity.Text && CityLeft.Checked)
                CityViewer.Enabled = false;

            if (PhoneRightCity.Text == CostumePhoneCity.Text && CityRight.Checked)
                CityViewer.Enabled = false;

            if (PhoneLeftCity.Text == CostumePhoneCity.Text && CityRight.Checked)
                CityViewer.Enabled = false;

            if (PhoneRightCity.Text == CostumePhoneCity.Text && CityLeft.Checked)
                CityViewer.Enabled = false;
        }

        private void CityLeft_CheckedChanged(object sender, EventArgs e)
        {
            CityViewer.Enabled = true;

            if (CostumePhoneCity.Text.Length != 3) CityViewer.Enabled = false;
            if (CityLeft.Checked == false && CityRight.Checked == false)
                CityViewer.Enabled = false;

            foreach (char i in CostumePhoneCity.Text)
                if (!"1234567890".Contains(i))
                    CityViewer.Enabled = false;

            if (PhoneLeftCity.Text == CostumePhoneCity.Text && CityLeft.Checked)
                CityViewer.Enabled = false;

            if (PhoneRightCity.Text == CostumePhoneCity.Text && CityRight.Checked)
                CityViewer.Enabled = false;

            if (PhoneLeftCity.Text == CostumePhoneCity.Text && CityRight.Checked)
                CityViewer.Enabled = false;

            if (PhoneRightCity.Text == CostumePhoneCity.Text && CityLeft.Checked)
                CityViewer.Enabled = false;
        }

        private void CityRight_CheckedChanged(object sender, EventArgs e)
        {
            CityViewer.Enabled = true;

            if (CostumePhoneCity.Text.Length != 3) CityViewer.Enabled = false;
            if (CityLeft.Checked == false && CityRight.Checked == false)
                CityViewer.Enabled = false;

            foreach (char i in CostumePhoneCity.Text)
                if (!"1234567890".Contains(i))
                    CityViewer.Enabled = false;

            if (PhoneLeftCity.Text == CostumePhoneCity.Text && CityLeft.Checked)
                CityViewer.Enabled = false;

            if (PhoneRightCity.Text == CostumePhoneCity.Text && CityRight.Checked)
                CityViewer.Enabled = false;

            if (PhoneLeftCity.Text == CostumePhoneCity.Text && CityRight.Checked)
                CityViewer.Enabled = false;

            if (PhoneRightCity.Text == CostumePhoneCity.Text && CityLeft.Checked)
                CityViewer.Enabled = false;
        }

        private void CityViewer_Click(object sender, EventArgs e)
        {
            if (CityLeft.Checked) CityLeftPhoneView(WAN.ForViewCity(CostumePhoneCity.Text), 1);
            if (CityRight.Checked) CityRightPhoneView(WAN.ForViewCity(CostumePhoneCity.Text), 1);

            CostumePhoneCity.Text = "";
            CityViewer.Enabled = false;
        }

        private void CityReload_Click(object sender, EventArgs e)
        {
            CityLeftPhoneView(WAN.ForViewCity(PhoneLeftCity.Text), 1);
            CityRightPhoneView(WAN.ForViewCity(PhoneRightCity.Text), 1);
        }


        private void CostumePhoneFact2_TextChanged(object sender, EventArgs e)
        {
            Fact2Viewer.Enabled = true;

            if (CostumePhoneFact2.Text.Length != 3) Fact2Viewer.Enabled = false;
            if (Fact2Left.Checked == false && Fact2Right.Checked == false)
                Fact2Viewer.Enabled = false;

            foreach (char i in CostumePhoneFact2.Text)
                if (!"1234567890".Contains(i))
                    Fact2Viewer.Enabled = false;

            if (AnotherLeftPhoneView.Text == CostumePhoneCity.Text && Fact2Left.Checked)
                Fact2Viewer.Enabled = false;

            if (AnotherLeftPhoneView.Text == CostumePhoneCity.Text && Fact2Right.Checked)
                Fact2Viewer.Enabled = false;

            if (AnotherRightPhoneView.Text == CostumePhoneCity.Text && Fact2Right.Checked)
                Fact2Viewer.Enabled = false;

            if (AnotherRightPhoneView.Text == CostumePhoneCity.Text && Fact2Left.Checked)
                Fact2Viewer.Enabled = false;
        }

        private void Fact2Left_CheckedChanged(object sender, EventArgs e)
        {
            Fact2Viewer.Enabled = true;

            if (CostumePhoneFact2.Text.Length != 3) Fact2Viewer.Enabled = false;
            if (Fact2Left.Checked == false && Fact2Right.Checked == false)
                Fact2Viewer.Enabled = false;

            foreach (char i in CostumePhoneFact2.Text)
                if (!"1234567890".Contains(i))
                    Fact2Viewer.Enabled = false;

            if (AnotherLeftPhoneView.Text == CostumePhoneCity.Text && Fact2Left.Checked)
                Fact2Viewer.Enabled = false;

            if (AnotherLeftPhoneView.Text == CostumePhoneCity.Text && Fact2Right.Checked)
                Fact2Viewer.Enabled = false;

            if (AnotherRightPhoneView.Text == CostumePhoneCity.Text && Fact2Right.Checked)
                Fact2Viewer.Enabled = false;

            if (AnotherRightPhoneView.Text == CostumePhoneCity.Text && Fact2Left.Checked)
                Fact2Viewer.Enabled = false;
        }

        private void Fact2Right_CheckedChanged(object sender, EventArgs e)
        {
            Fact2Viewer.Enabled = true;

            if (CostumePhoneFact2.Text.Length != 3) Fact2Viewer.Enabled = false;
            if (Fact2Left.Checked == false && Fact2Right.Checked == false)
                Fact2Viewer.Enabled = false;

            foreach (char i in CostumePhoneFact2.Text)
                if (!"1234567890".Contains(i))
                    Fact2Viewer.Enabled = false;

            if (AnotherLeftPhoneView.Text == CostumePhoneCity.Text && Fact2Left.Checked)
                Fact2Viewer.Enabled = false;

            if (AnotherLeftPhoneView.Text == CostumePhoneCity.Text && Fact2Right.Checked)
                Fact2Viewer.Enabled = false;

            if (AnotherRightPhoneView.Text == CostumePhoneCity.Text && Fact2Right.Checked)
                Fact2Viewer.Enabled = false;

            if (AnotherRightPhoneView.Text == CostumePhoneCity.Text && Fact2Left.Checked)
                Fact2Viewer.Enabled = false;
        }

        private void Fact2Viewer_Click(object sender, EventArgs e)
        {
            if (Fact2Left.Checked) AnotherPhoneLeftView(WAN.ForView(CostumePhoneFact2.Text, 1), 1);
            if (Fact2Right.Checked) AnotherPhoneRightView(WAN.ForView(CostumePhoneFact2.Text, 1), 1);

            CostumePhoneFact2.Text = "";
            Fact2Viewer.Enabled = false;
        }

        private void Fact2Reload_Click(object sender, EventArgs e)
        {
            AnotherPhoneLeftView(WAN.ForView(AnotherLeftPhoneView.Text, 1), 1);
            AnotherPhoneRightView(WAN.ForView(AnotherRightPhoneView.Text, 1), 1);
        }
    }
}
