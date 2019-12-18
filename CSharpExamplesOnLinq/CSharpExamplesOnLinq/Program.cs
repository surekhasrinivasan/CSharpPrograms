using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamplesOnLinq
{
    // Program to count File Extensions and group it using Linq
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = {"aaa.txt", "bbb.TXT", "xyz.abc.pdf", "aaaa.PDF",
                             "abc.xml", "ccc.txt", "zzz.txt"};

            var egrp = arr.Select(file => Path.GetExtension(file).TrimStart('.').ToLower())
                            .GroupBy(x => x, (ext, extCnt) => new
                            {
                                Extension = ext,
                                Count = extCnt.Count()
                            });

        }
    }
}
