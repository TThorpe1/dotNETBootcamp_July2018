using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOPJuly2018
{
    class TA:Employee
    {
        private int workLoad;
        public int WorkLoad
        {
            set { workLoad = value; }
            get { return workLoad; }

        }
        public TA(string fn, string ln, float sal, string s, int wl) : base(fn, ln, sal, s)
        {
            WorkLoad = wl; 

        }

        public TA() : base()
        {
            WorkLoad = 30; 
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"WorkLoad {WorkLoad}");
        }
    }
}
