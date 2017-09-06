using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace ArrayListİcerik
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add(4);
            liste.Add(2);
            liste.Add(5);
            liste.Add(1);
            liste.Add(3);
            foreach (object eleman in liste)
            {
                Console.WriteLine(eleman + " ");
            }
            Console.WriteLine();

            if (liste.Contains(4) == true)
                Console.WriteLine("4 elemanı bulundu");
            else
                Console.WriteLine("4 elemanı bulunamadı");

            Console.ReadLine();
        }
    }
}
