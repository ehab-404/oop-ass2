using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_ass2.Binding
{
    internal class FullTimeEmployee : Employee
    {
        #region V09

        public double Salary { get; set; }

        public new void FUN01()
        {
            Console.WriteLine("I'm Full Time Employee");
        }
        public override void FUN02()
        {
            Console.WriteLine($"Salary : {Salary}");
        }



        #endregion
    }
}
