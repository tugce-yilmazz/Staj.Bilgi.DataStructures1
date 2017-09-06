using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace ArrayListSayma
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList colors = new ArrayList();
            colors.Add("red");
            colors.Add("blue");
            colors.Add("green");
            colors.Add("yellow");
            colors.Add("beige");
            colors.Add("brown");
            colors.Add("magenta");
            colors.Add("purple");
            Console.WriteLine("Array list Enumeration--------");
            IEnumerator e = colors.GetEnumerator();
            while (e.MoveNext())
            {
                Object obj = e.Current;
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            Console.WriteLine("GetEnumerator(2, 4):--------");
            IEnumerator e2 = colors.GetEnumerator(2, 4);
            while (e2.MoveNext())
            {
                Object obj = e2.Current;
                Console.WriteLine(obj);
            }
            Console.ReadLine();
        }
    }
}
