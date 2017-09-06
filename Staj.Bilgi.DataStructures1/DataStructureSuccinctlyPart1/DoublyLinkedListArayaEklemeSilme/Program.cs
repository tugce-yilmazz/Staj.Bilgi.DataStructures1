using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace DoublyLinkedListArayaEklemeSilme
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList list = new DoubleLinkedList();
            list.Insert("1");
            list.Insert("2");
            list.Insert("3");
            DoubleLink link4 = list.Insert("4");
            list.Insert("5");
            Console.WriteLine("List: " + list);
            Console.WriteLine();
            list.InsertAfter(link4, "[4a]");
            Console.WriteLine("[4a] add to list: \n " + list);
            Console.WriteLine();
            list.Delete();
            Console.WriteLine("Delete to list first item : \n " + list);
            Console.Read();
        }
    }
}
