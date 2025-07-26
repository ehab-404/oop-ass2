using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_ass2.Override
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }

        // Override or Hide
        // Apply Override
        // 1. apply Override Using 'new' KeyWord -> Default
        // 2. apply Override Using 'override' KeyWord

        // Static Binding
        // Compiler will Bind Function cal based on Reference Type Not the object Type
        // At Compilation Time

        public new void Fun01() // Using 'new' KeyWord
        {
            Console.WriteLine("Fun01 From TypeB");
        }

        //Must Be Not Private and Virtual
        //public override void Fun02() //Using 'override' KeyWord
        //{
        //    Console.WriteLine($"A: {A}, B: {B}");
        //}

        // Dynamic Binding
        //CLR Will Bind The function call based on object not the reference type
        //RunTime
        public override void Fun02()
        {
            Console.WriteLine($"A: {A}, B: {B}");
        }

    }
}