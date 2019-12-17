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

    //// Program to illustrate Hierarchical Inheritance
    //class Program
    //{
    //    public static void Main()
    //    {
    //        Principal p = new Principal();
    //        p.Monitor();
    //        Teacher t = new Teacher();
    //        t.Monitor();
    //        t.Teach();
    //        Student s = new Student();
    //        s.Monitor();
    //        s.Learn();
    //        Console.ReadKey();
    //    }
    //}

    //class Principal
    //{
    //    public void Monitor()
    //    {
    //        Console.WriteLine("Monitor");
    //    }
    //}

    //class Teacher : Principal
    //{
    //    public void Teach()
    //    {
    //        Console.WriteLine("Teach");
    //    }
    //}

    //class Student : Principal
    //{
    //    public void Learn()
    //    {
    //        Console.WriteLine("Learn");
    //    }
    //}

    //// Program to illustrate multilevel inheritance with virtual methods
    //class Program
    //{
    //    public static void Main()
    //    {
    //        Student S = new Student();
    //        S.GetInfo();
    //        Stud stud = new Stud();
    //        stud.GetInfo();
    //        Console.ReadLine();
    //    }
    //}

    //public class Person
    //{
    //    protected string RNO = "44";
    //    protected string name = "Ram";
    //    public virtual void GetInfo()
    //    {
    //        Console.WriteLine("Name: {0}", name);
    //        Console.WriteLine("RNO: {0}", RNO);
    //        Console.WriteLine( );
    //    }
    //}

    //class Student : Person
    //{
    //    public string id = "ABC";
    //    public override void GetInfo()
    //    {
    //        base.GetInfo();
    //        Console.WriteLine("Student ID: {0}", id);
    //    }
    //}

    //class Stud : Student
    //{
    //    private string StudentAddress = "USA";
    //    public void GetInfo()
    //    {
    //        base.GetInfo();
    //        Console.WriteLine("Student Address: {0}", StudentAddress);
    //    }
    //}

    // Program to display cost of a Rectangle Plot using Inheritance
    class Program
    {

    }

    class Rectangle
    {
        protected double length;
        protected double width;

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }

    class Tabletop : Rectangle
    {
        private double cost;
        public Tabletop(double l, double w) : base(l, w) { } 

        public double costcal()
        {
            double cost;
            cost = GetArea() * 70;
            return cost;
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine("Cost: {0}", costcal());
        }
        
    }
}
