using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_ass2.Binding
{
     //Just Container For Common Property
    internal class Employee
    {
        #region Video 9
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public void FUN01()
        {
            Console.WriteLine("I'm  Employee");
        }
        public virtual void FUN02()
        {
            Console.WriteLine($"Salary : ???");
        }
        #endregion


    }
}
