using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace ArrayListArayaEklemeSilme
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add(1);
            liste.Add(2);
            liste.Add(3);
            liste.Add("Tuğçe");
            liste.Add("Yılmaz");
            foreach (object eleman in liste)
            {
                Console.WriteLine(eleman);
            }
            Console.WriteLine();
            liste.Insert(2, "Türkiye");
            Console.WriteLine("Then Insert--------");
            foreach (object eleman in liste)
            {
                Console.WriteLine(eleman);
            }
            Console.WriteLine();
            Console.WriteLine("Then Clear--------");
            liste.Clear();
            foreach (object eleman in liste)
            {
                Console.WriteLine(eleman);
            }
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
