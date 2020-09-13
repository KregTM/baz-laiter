using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Название_проекта
{
    class Program
    {
        static void Main(string[] args) {
            int a = 4;
            int b = 6;

            Console.WriteLine("Initial a is " + a);
            Console.WriteLine("Initial b is " + b);

            b = a;
            a = 400;

            Console.WriteLine("After b=a b is " + b);
            Console.WriteLine("Final b is " + b);
            Console.WriteLine("Final a is " + a);

            Console.WriteLine("Final a is " + a);

            Console.WriteLine("-------------------------------------------------------------");

            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> list2;

            list2 = list1;

            Console.WriteLine(list1[2]);
            Console.WriteLine(list2[2]);

            list1.RemoveAt(0);

            Console.WriteLine(list1[2]);
            Console.WriteLine(list2[2]);

            Console.ReadLine();
        }

    }
}
