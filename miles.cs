using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challenge
{
    internal class miles
    {
        public string Name { get; set; }
        public int milestravelled { get; set; }
        private int _flyerpoints { get; set; }
        public int Flyerpoints
        {
            get { return _flyerpoints; }
            set
            {
                _flyerpoints = value;

                if (milestravelled < 10000)
                {
                    //flyerpoints = flyerpoints + 0;
                    //Console.WriteLine("No Flyerpoint");
                    _flyerpoints = 0;
                }

                if (milestravelled >= 10000 && milestravelled < 20000)
                {
                    _flyerpoints =  10;
                }
                else if (milestravelled >= 20000 && milestravelled < 40000)
                {
                    _flyerpoints =  20;
                }
                else if (milestravelled >= 50000 && milestravelled < 100000)
                {
                    _flyerpoints =  30;
                }
                //if (milestravelled > 100000)
                else
                {
                    _flyerpoints =  50;
                }
            }
        }
        
    }
}
