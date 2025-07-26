using oop_ass2.Binding;
using oop_ass2.Override;
using static oop_ass2.Program;

namespace oop_ass2
{



    public class Order
    {
        public Item[] Items { get; set; }
    }
    public class Item
    {
    }

    public class Room
    {
        public Wall Wall { get; set; }
        public Chair[]? Chairs { get; set; }
    }
    public class Wall
    {
    }
    public class Chair
    {
    }



    internal class Program
    {



        static int Sum(int x, int y)
        {
            return x + y;
        }

        static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }

        static double Sum(double x, double y)
        {
            return x + y;
        }

        static double Sum(int x, double y)
        {
            return x + y;
        }

        static double Sum(double x, int y)
        {
            return x + y;
        }



        
        //V09 When need Binding

        //static void EmployeeProcess(FullTimeEmployee employee)
        //{
        //    if(employee is not null)
        //    {
        //        employee.FUN01();
        //        employee.FUN02();
        //    }

        //}

        //static void EmployeeProcess(PartTimeEmployee employee)
        //{
        //    if (employee is not null)
        //    {
        //        employee.FUN01();
        //        employee.FUN02();
        //    }

        //}

        static void EmployeeProcess(Employee employee)
        {
            if (employee is not null)
            {
                employee.FUN01();
                employee.FUN02();
            }

        }



            static void Main(string[] args)
        {
            //demo

            #region video1 class,struct
            /*
                    Class:
                        Reference type
                              stored on the heap
                              supports all pillars of OOP
                              supoorts all access modifiers
                              pointer of it can reference  null
            */


            // Struct:
            //      Value type
            //      stored on the stack
            //      supports only encapsulation and part of polymorphism (overloading)
            //      supoorts only (public, private, internal) access modifiers
            //      cannot be null

            // When to use Class Vs Struct ?
            //      when you need to use all OOP Pillars
            #endregion

            #region video 2 Inheritance
            // X  --> Y
            // DRY


            //Parent parent = new Parent(1, 2);
            //Console.WriteLine(parent);

            //parent.Fun01();
            //parent.Fun02();


            //Child child = new Child(1, 2, 3);
            //Console.WriteLine(child);

            //child.Fun01();
            //child.Fun02();
            #endregion

            #region Video3 Relationship between classes
            // 1. Inheritance: is a relationship [FullTimeEmployee is a Employee - Dog is an Animal]
            // 2. Aggregation: has a relationship [Order has Item]
            //      2.1 Composition: Order has Item - Room has Wall
            //      2.2 Association: 
            #endregion





            #region Video 4 Polymorphism 
            // Polymorphism
            //      Polymorphism methods (functions) overloading
            //      Polymorphism methods (functions) overriding

            //Console.WriteLine();
            #endregion




            #region Video5 Polymorphism methods overloading
            // More than one functions (in the same scope [class, struct]) have the same name but different signature
            // (count, type, order) parameters 

            //Sum(1, 2);
            //Sum(1.3, 2.5);

            #endregion






            #region video 6 Polymorphism Methods Overriding
            // There are more than one functions [in different class] these have the same Name and 
            // the same signature but with behavior

            //TypeB typeB = new TypeB() { A = 12, B = 13 };

            //typeB.A = 12;
            //typeB.B = 13;

            //Console.WriteLine(typeB.A);
            //Console.WriteLine(typeB.B);

            //typeB.Fun01();
            //typeB.Fun02();

            #endregion

            #region video 7 What is Binding
            //Binding
            // ReferenceFromParent ----> ObjectChild

            //TypeA Ref;

            ////Ref = new TypeA();
            ////Ref = new TypeB();

            //// Child is a parent

            //// TypeB is a TypeA

            //Ref = new TypeB();

            //Ref.A = 12;
            ////Ref.B = 12;

            //Ref.Fun01();// Static Binded Methods
            //Ref.Fun02();


            #endregion


            #region video8 not binding

            //binding (valid) : parente ref child as all of parent is in childe
            //not binding(not valid) : child ref parent  as not all of child  in parent 

            TypeB ref1 ; 
         //   ref1 = new TypeA(); not valid 
            ref1 =new TypeB();

            ref1 = (TypeB)new TypeA(); //not binding but valid casting  you must sure that ref1 is object of typeB

            TypeA ref2;
              ref2 = new TypeA(); // valid 
            ref2 = new TypeB();



            //Child is Parent but parent not child

            //    animal -->dog   : dog is animal 
            //    dog -> (dog) animal : animal must be dog object 




            #endregion



            #region V09 When need Binding
            //When U need Binding ??
            //FullTimeEmployee : Id , Name , Adress , Email , Salary

            FullTimeEmployee FullTime = new FullTimeEmployee()
            {
                ID = 1,
                Name = "Ahmed",
                Email = "ahmed@gmail.com",
                Address = "Cairo",
                Salary = 12000


            };
            EmployeeProcess(FullTime);
            //EmployeeProcess(null);
            //NullReferenceException

            //PartTimeEmployee :  Id , Name , Adress , Email , NumberOfHour ,HourRate

            PartTimeEmployee PartTime = new PartTimeEmployee()
            {
                ID = 1,
                Name = "Ali",
                Email = "Ali@gmail.com",
                Address = "Alex",
                HourRate = 300,
                NumberOfHour = 200
            };
            EmployeeProcess(PartTime);

            //After Creating EmployeeClass
            EmployeeProcess(FullTime);
            EmployeeProcess(PartTime);

            #endregion


            #region V10 Binding Example

            TypeA typeA;

            typeA = new TypeA();
            typeA = new TypeB(); //TypeA is a Parent of TypeB
            typeA = new TypeC(); //TypeA is a Indirect Parent of TypeC
            typeA = new TypeD(); //TypeA is a Indirect Parent of TypeD
            typeA = new TypeE(); //TypeA is a Indirect Parent of TypeE

            typeA.A = 12;//valid

            //not valid 
          //  typeA.B = 12;  
            //typeA.C = 12;
            //typeA.D = 12;

            typeA.Fun01();
            typeA.Fun02();
            #endregion





            #region task2 

            //protected property : accesssed in same class or any derived class
            //private protected property : accessed in same class or    derived class in same project 
            // protected  internal property : accessed in same class or   any class in same project  or derived class in anoter project 

            #endregion




        }
    }
}
