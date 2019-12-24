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

    }
}
