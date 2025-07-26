using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_ass2.Override
{
    internal class TypeE : TypeD
    {
        public int E { get; set; }
        public new void Fun01()
        {
            Console.WriteLine("Fun01 From TypeE");
        }

        public override void Fun02()
        {
            Console.WriteLine($"A: {A} ,B:{B} ,C: {C} ,D:{D} , E:{E} ");
        }


    }

}



