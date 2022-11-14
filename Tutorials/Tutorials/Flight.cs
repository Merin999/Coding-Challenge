using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    //internal class Flight
    //{
    //private int _fare { get; set; }
    //public int time { get; set; }
    //public string am_pm { get; set; }

    //        public int Fare
    //        {
    //            get
    //            {
    //                return _fare;
    //            }
    //            set
    //            {
    //               if(time >= 6 && time <=  9)
    //                {
    //                    Fare = Fare +(Fare * 10) / 100;
    //                }
    //                if (time >= 9 && time <= 17)
    //                {
    //                    Fare = Fare + (Fare * 20) / 100;
    //                }
    //                if (time >= 17 && time <= 23)
    //                {
    //                    Fare = Fare +(Fare * 7) / 100;
    //                }
    //                else
    //                {
    //                    Fare = Fare + (Fare * 5) / 100;
    //                }


    //        }
    //    }

    //}


    internal class Flight
    {
        private int _pfare;
        public int Time;
        public string Am_Pm;



        public int Pfare
        {
            get { return _pfare; }
            set
            {
                _pfare = value;
                if (Am_Pm == "am" && (Time >= 6 && Time <= 9))
                    _pfare = _pfare + ((_pfare * 10) / 100);
                else if ((Time > 9 && Time <= 12 && Am_Pm == "am") || (Time >= 1 && Time <= 5 && Am_Pm == "pm"))
                    _pfare = _pfare + ((_pfare * 20) / 100);
                else if ((Time > 5 && Time <= 11) && Am_Pm == "pm")
                    _pfare = _pfare + ((_pfare * 7) / 100);
                else
                    _pfare = _pfare + ((_pfare * 5) / 100);
            }
        }




    }
}