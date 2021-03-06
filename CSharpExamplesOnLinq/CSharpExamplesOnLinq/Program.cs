﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamplesOnLinq
{
    //// Program to count File Extensions and group it using Linq
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string[] arr = {"aaa.txt", "bbb.TXT", "xyz.abc.pdf", "aaaa.PDF",
    //                         "abc.xml", "ccc.txt", "zzz.txt"};

    //        var egrp = arr.Select(file => Path.GetExtension(file).TrimStart('.').ToLower())
    //                        .GroupBy(x => x, (ext, extCnt) => new
    //                        {
    //                            Extension = ext,
    //                            Count = extCnt.Count()
    //                        });

    //        foreach(var v in egrp)
    //        {
    //            Console.WriteLine("{0} File(s) with {1} Extension", v.Count, v.Extension);
    //        }
    //        Console.ReadLine();
    //    }
    //}

    //// Program to calculate size of File using Linq
    //class Program
    //{
    //    static void Main()
    //    {
    //        string[] dirfiles = Directory.GetFiles("C:\\SampleFolder");
    //        var avg = dirfiles.Select(file => new FileInfo(file).Length).Average();
    //        avg = Math.Round(avg / 10, 1);
    //        Console.WriteLine("The average file size is {0} MB", avg);
    //        Console.ReadLine();
    //    }
    //}

    //// Program to generate odd numbers in parallel using linq
    //class Program
    //{
    //    static void Main()
    //    {
    //        IEnumerable<int> oddNums = ((ParallelQuery<int>)ParallelEnumerable.Range(20, 2000))
    //            .Where(x => x % 2 != 0).Select(i => i);
    //        foreach(int n in oddNums)
    //        {
    //            Console.WriteLine(n);
    //        }
    //        Console.ReadLine();
    //    }
    //}

    //// Program to implement IEnumerable Interface using LINQ
    //class Program
    //{
    //    public static void Main()
    //    {
    //        var t = typeof(IEnumerable);
    //        var typesIEnum = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x =>
    //                            x.GetTypes()).Where(x => t.IsAssignableFrom(x));
    //        foreach(var types in typesIEnum)
    //        {
    //            Console.WriteLine(types.FullName);
    //        }
    //        Console.ReadLine();
    //    }
    //}

    //// Program to divide sequence into groups using Linq
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var seq = Enumerable.Range(100, 100).Select(x => x / 10f);
    //        var grps = from x in seq.Select((i, j) => new { i, Grp = j / 10 })
    //                   group x.i by x.Grp into y
    //                   select new { Min = y.Min(), Max = y.Max() };
    //        foreach (var grp in grps)
    //            Console.WriteLine("Min: " + grp.Min + " Max:" + grp.Max);
    //        Console.ReadLine();
    //    }
    //}

    //// Program to display the student details using Select Clause Linq
    //class Program
    //{
    //    public class Student
    //    {
    //        public string First { get; set; }
    //        public string Last { get; set; }
    //        public int ID { get; set; }
    //        public List<int> Marks;
    //        public ContactInfo GetContactInfo(Program pg, int id)
    //        {
    //            ContactInfo allinfo =
    //            (from ci in pg.contactList
    //             where ci.ID == id
    //             select ci)
    //            .FirstOrDefault();

    //            return allinfo;
    //        }

    //        public override string ToString()
    //        {
    //            return First + "" + Last + " :  " + ID;
    //        }
    //    }


    //    public class ContactInfo
    //    {
    //        public int ID { get; set; }
    //        public string Email { get; set; }
    //        public string Phone { get; set; }
    //        public override string ToString() { return Email + "," + Phone; }
    //    }

    //    public class ScoreInfo
    //    {
    //        public double Average { get; set; }
    //        public int ID { get; set; }
    //    }

    //    List<Student> students = new List<Student>
    //    {
    //        new Student {First="Tom", Last=".S", ID=1,
    //                    Marks= new List<int>() {97, 92, 81, 60}},
    //        new Student {First="Jerry", Last=".M", ID=2,
    //                    Marks= new List<int>() {75, 84, 91, 39}},
    //        new Student {First="Bob", Last=".P", ID=3,
    //                    Marks= new List<int>() {88, 94, 65, 91}},
    //        new Student {First="Mark", Last=".G", ID=4,
    //                    Marks= new List<int>() {97, 89, 85, 82}},
    //    };

    //    List<ContactInfo> contactList = new List<ContactInfo>()
    //    {
    //        new ContactInfo {ID=111, Email="Tom@abc.com", Phone="9328298765"},
    //        new ContactInfo {ID=112, Email="Jerry123@aaa.com", Phone="9876543201"},
    //        new ContactInfo {ID=113, Email="Bobstar@aaa.com", Phone="9087467653"},
    //        new ContactInfo {ID=114, Email="Markantony@qqq.com", Phone="9870098761"}
    //    };

    //    static void Main(string[] args)
    //    {
    //        Program pg = new Program();

    //        IEnumerable<Student> studentQuery1 =
    //        from student in pg.students
    //        where student.ID > 1
    //        select student;

    //        Console.WriteLine("Query : Select range_variable");
    //        Console.WriteLine("Name    : ID");
    //        foreach (Student s in studentQuery1)
    //        {
    //            Console.WriteLine(s.ToString());
    //        }
    //        Console.ReadLine();
    //    }
    //}

    //// Program to Display the Greatest numbers in an Array using WHERE Clause LINQ
    //class Program
    //{
    //    static void Main()
    //    {
    //        int[] numbers = { 500, 344, 221, 4443, 229, 1008, 6000, 767, 256, 0 };

    //        var greaterNums =
    //        from num in numbers
    //        where num > 500
    //        select num;
    //        Console.WriteLine("Numbers Greater than 500 :");
    //        foreach (var s in greaterNums)
    //        {
    //            Console.Write(s.ToString() + " ");
    //        }
    //        Console.Read();
    //    }
    //}

    //// Program to Display the Smallest numbers in an Array using FROM Clause Linq
    //class Program
    //{
    //    static void Main()
    //    {
    //        int[] numbers = { 50, 30, 45, 10, 60, 100, 500, 300, 40, 22, 44, 55, 66, 1000 };

    //        var program = from num in numbers
    //                      where num < 50
    //                      select num;

    //        Console.WriteLine("Numbers less than 50 are :");
    //        foreach (int i in program)
    //        {
    //            Console.Write(i + " ");
    //        }
    //        Console.ReadLine();
    //    }
    //}

    // Program to Implement Let Condition using Linq
    class Program
    {
        static void Main()
        {
            List<Student> objStudent = new List<Student>{
                new Student{ Name="Tom",Regnum="R001",Marks=80},
                new Student{ Name="Bob",Regnum="R002",Marks=40},
                new Student{ Name="jerry",Regnum="R003",Marks=25},
                new Student{ Name="Syed",Regnum="R004",Marks=30},
                new Student{ Name="Mob",Regnum="R005",Marks=70},
            };

            // The let clause allows storing the result of an expression inside the query expression. 
            // The where clause is used in a query expression to specify which elements from the 
            // data source will be returned in the query expression.The foreach () function 
            // is used to print only the average marks greater than student marks.

                        var objresult = from stu in objStudent
                            let totalMarks = objStudent.Sum(mark => mark.Marks)
                            let avgMarks = totalMarks / 5
                            where avgMarks > stu.Marks
                            select stu;
            foreach (var stu in objresult)
            {
                Console.WriteLine("Student: {0} {1}", stu.Name, stu.Regnum);

            }
            Console.ReadLine();
        }    
    }

    class Student
    {
        public string Name { get; set; }
        public string Regnum { get; set; }
        public int Marks { get; set; }
    }
}
