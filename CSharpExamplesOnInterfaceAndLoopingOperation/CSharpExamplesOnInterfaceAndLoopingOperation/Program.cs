﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamplesOnInterfaceAndLoopingOperation
{
    // Program to implement PhoneBook
    class Program
    {
       static void Main(string[] arg)
        {
            Hashtable tab = new Hashtable();
            string fileName;
            if(arg.Length > 0)
            {
                fileName = arg[0];
            }
            else
            {
                fileName = "phoneBook.txt";
            }
            StreamReader r = File.OpenText(fileName);
            string line = r.ReadLine();
            while(line != null)
            {
                int pos = line.IndexOf('=');
                string name = line.Substring(0, pos).Trim();
                long phone = Convert.ToInt64(line.Substring(pos + 1));
                tab[name] = phone;
                line = r.ReadLine();
            }
            r.Close();
                
        }
    }
}
