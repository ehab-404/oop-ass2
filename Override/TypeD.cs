using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_ass2.Override
{
    internal class TypeD : TypeC
    {
        public int D { get; set; }
        public new void Fun01()
        {
            Console.WriteLine("Fun01 From TypeD");
        }

        public virtual void Fun02()
        {
            Console.WriteLine($"A: {A} ,B:{B} ,C: {C} ,D:{D} ");
        }


    }
}
