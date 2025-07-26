using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_ass2
{
    internal class Child:Parent
    {

        public int Z { get; set; }

        public Child(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }


        // Override Or Hide
        public void Fun01()
        {
            Console.WriteLine("I am Child [Derived]");
        }

        public void Fun02()
        {
            Console.WriteLine($"X = {X}, Y = {Y}, Z = {Z}");
        }

        public override string ToString()
        {
            return $"X = {X}, Y = {Y}, Z = {Z}";
        }



    }
}
