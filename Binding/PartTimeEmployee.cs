using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_ass2.Binding
{
    internal class PartTimeEmployee : Employee
    {

        #region Video 9

        public double HourRate { get; set; }
        public double NumberOfHour { get; set; }

        public new void FUN01()
        {
            Console.WriteLine("I'm Part Time Employee");
        }
        public override void FUN02()
        {
            Console.WriteLine($"Salary : {HourRate * NumberOfHour}");
        }





        #endregion
    }
}
