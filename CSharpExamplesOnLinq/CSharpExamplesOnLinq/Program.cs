using System;
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

    // Program to display the student details using Select Clause Linq
    class Program
    {
        public class Student
        {
            public string First { get; set; }
            public string Last { get; set; }
            public int ID { get; set; }
            public List<int> Marks;
            public ContactInfo GetContactInfo(Program pg, int id)
            {
                ContactInfo allinfo =
                (from ci in pg.contactList
                 where ci.ID == id
                 select ci)
                .FirstOrDefault();

                return allinfo;
            }

            public override string ToString()
            {
                return First + "" + Last + " :  " + ID;
            }
        }


        public class ContactInfo
        {
            public int ID { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public override string ToString() { return Email + "," + Phone; }
        }

        public class ScoreInfo
        {
            public double Average { get; set; }
            public int ID { get; set; }
        }

        List<Student> students = new List<Student>
        {
            new Student {First="Tom", Last=".S", ID=1,
                        Marks= new List<int>() {97, 92, 81, 60}},
            new Student {First="Jerry", Last=".M", ID=2,
                        Marks= new List<int>() {75, 84, 91, 39}},
            new Student {First="Bob", Last=".P", ID=3,
                        Marks= new List<int>() {88, 94, 65, 91}},
            new Student {First="Mark", Last=".G", ID=4,
                        Marks= new List<int>() {97, 89, 85, 82}},
        };

        List<ContactInfo> contactList = new List<ContactInfo>()
        {
            new ContactInfo {ID=111, Email="Tom@abc.com", Phone="9328298765"},
            new ContactInfo {ID=112, Email="Jerry123@aaa.com", Phone="9876543201"},
            new ContactInfo {ID=113, Email="Bobstar@aaa.com", Phone="9087467653"},
            new ContactInfo {ID=114, Email="Markantony@qqq.com", Phone="9870098761"}
        };

        static void Main(string[] args)
        {
            Program pg = new Program();

            IEnumerable<Student> studentQuery1 =
            from student in pg.students
            where student.ID > 1
            select student;

            Console.WriteLine("Query : Select range_variable");
            Console.WriteLine("Name    : ID");

        }
    }
}
