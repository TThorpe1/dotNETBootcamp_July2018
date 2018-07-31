using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOPJuly2018
{
    class Manager: Employee
    {
        private int timeOff;

        public int TimeOff
        {
            set { timeOff = value; }
            get { return timeOff; }
        }

        public Manager():base()
        {
            timeOff = 30;

        }

        public Manager(string fn, string ln, float sal, string s, int tOff) :
            base(fn, ln, sal, s)
        {
            TimeOff = tOff;

        }

        public override void PrintInfo()
        {
            // base.PrintInfo();
            Console.WriteLine($"Hey, I am a manager: My name is {FirstName} , {LastName}");

        }

    }
}
