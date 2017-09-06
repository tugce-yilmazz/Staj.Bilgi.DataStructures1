using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace ArrayListEklemeSilme
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
            Console.WriteLine("Then Add--------");
            foreach (object eleman in liste)
            {
                Console.WriteLine(eleman);
            }
            Console.WriteLine();
            liste.Remove("Yılmaz");
            liste.Remove("Tuğçe");
            Console.WriteLine("Then Remove--------");
            foreach (object eleman in liste)
            {
                Console.WriteLine(eleman);
            }
            Console.ReadLine();
        }
    }
}
