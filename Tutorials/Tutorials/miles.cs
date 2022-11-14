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
                if (value < 10000)
                {
                    //flyerpoints = flyerpoints + 0;
                    //Console.WriteLine("No Flyerpoint");
                    _flyerpoints = 0;
                }

                if (value > 10000)
                {
                    _flyerpoints = _flyerpoints + 10;
                }
                if (value > 20000)
                {
                    _flyerpoints = _flyerpoints + 20;
                }
                if (value > 50000)
                {
                    _flyerpoints = _flyerpoints + 30;
                }
                if (value > 100000)
                {
                    _flyerpoints = _flyerpoints + 50;
                }
            }
        }
        public void ShowData()
        {
            Console.WriteLine();
            Console.WriteLine($"Flyerpoints   :{_flyerpoints}");

        }
    }
}
