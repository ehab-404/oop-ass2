using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_ass2
{
    internal class Parent
    {


        public int X { get; set; }
        public int Y { get; set; }

        //public Parent()
        //{
        //}

        public Parent(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Fun01()
        {
            Console.WriteLine("I am Parent [Base]");
        }

        public void Fun02()
        {
            Console.WriteLine($"X = {X}, Y = {Y}");
        }

        public override string ToString()
        {
            return $"X = {X}, Y = {Y}";
        }

    }
}
