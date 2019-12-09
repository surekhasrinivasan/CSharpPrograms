using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamplesOnInterfaceAndLoopingOperation
{
    //// Program to implement PhoneBook
    //class Program
    //{
    //   static void Main(string[] arg)
    //    {
    //        Hashtable tab = new Hashtable();
    //        string fileName;
    //        if(arg.Length > 0)
    //        {
    //            fileName = arg[0];
    //        }
    //        else
    //        {
    //            fileName = "phoneBook.txt";
    //        }
    //        StreamReader r = File.OpenText(fileName);
    //        string line = r.ReadLine();
    //        while(line != null)
    //        {
    //            int pos = line.IndexOf('=');
    //            string name = line.Substring(0, pos).Trim();
    //            long phone = Convert.ToInt64(line.Substring(pos + 1));
    //            tab[name] = phone;
    //            line = r.ReadLine();
    //        }
    //        r.Close();
    //        for (; ; )
    //        {
    //            Console.Write("Name : ");
    //            string name = Console.ReadLine().Trim();
    //            if (name == "")
    //                break;
    //            object phone = tab[name];
    //            if (phone == null)
    //                Console.WriteLine("-- Not Found in Phone Book");
    //            else
    //                Console.WriteLine(phone);
    //        }
    //    }
    //}

    // Program to Implement for-each in Interface
    class GrowableArray : IEnumerable
    {
        object[] a;

        public GrowableArray(int size)
        {
            a = new object[size];
        }
        public GrowableArray() : this(8) { }
        void Grow()
        {
            object[] b = new object[2 * a.Length];
            Array.Copy(a, b, a.Length);
            a = b;
        }

        public object this[int i]
        {
            set
            {
                if (i >= a.Length) Grow();
                a[i] = value;
            }
            get
            {
                if (i >= a.Length) Grow();
                return a[i];
            }
        }
        public IEnumerator GetEnumerator()
        {
            return new GAEnumerator(a);
        }
        class GAEnumerator : IEnumerator
        {
            object[] a;
            int i = -1;
            public GAEnumerator(object[] a) { this.a = a; }
            public object Current
            {
                get
                {
                    return a[i];
                }
            }
            public void Reset()
            {
                i = -1;
            }
            public bool MoveNext()
            {
                do i++;
                while (i < a.Length && a[i] == null);
                if (i == a.Length)
                    return false;
                else return true;
            }
        }
    }

    
}
