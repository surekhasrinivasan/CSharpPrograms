using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamplesOnInheritance
{
    //// Program to demonstrate Multilevel Inheritance 
    //class Program : Vehicle
    //{
    //    public void Noise()
    //    {
    //        Console.WriteLine("All vehicles creates noise !!");
    //    }

    //    static void Main(string[] args)
    //    {
    //        Program obj = new Program();
    //        obj.mode();
    //        obj.feature();
    //        obj.Noise();
    //        Console.Read();
    //    }
    //}

    //class Mode
    //{
    //    public void mode()
    //    {
    //        Console.WriteLine("There are many modes of Transport!!");
    //    }
    //}

    //class Vehicle : Mode
    //{
    //    public void feature()
    //    {
    //        Console.WriteLine("They mainly help in travelling !!");
    //    }
    //}

    //// Program to illustrate Single inheritance
    //class Program
    //{
    //    static void Main()
    //    {
    //        Teacher d = new Teacher();
    //        d.Teach();
    //        Student s = new Student();
    //        s.Learn();
    //        s.Teach();
    //        Console.ReadKey();
    //    }
    //}

    //class Teacher
    //{
    //    public void Teach()
    //    {
    //        Console.WriteLine("Teach");
    //    }
    //}

    //class Student : Teacher
    //{
    //    public void Learn()
    //    {
    //        Console.WriteLine("Learn");
    //    }
    //}    

    // Program to illustrate Hierarchical Inheritance
    class Program
    {

    }

    class Principal
    {
        public void Monitor()
        {
            Console.WriteLine("Monitor");
        }
    }
}
