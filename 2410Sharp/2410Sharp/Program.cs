using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace _2410Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 5, 1, 35, 6, 65, 34, 3 };
            Task1();

            //Task2();

            //Task3(ints);





        }
            static void Task1()
            {
                int size = Convert.ToInt32(Console.ReadLine());

                int[] ints = new int[size];

            for (int i = 0; i < size; i++)
            {
                ints[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int value in ints)
            {
                Console.Write(value + " ");
            }    


        }
        static void Task2()
        {
            int length = Convert.ToInt32(Console.ReadLine());
            int[] ints = new int[length];

            for (int i = 0; i < length; i++)
            {
                int values = Convert.ToInt32(Console.ReadLine());
                ints[i] = values;
            }
            var str = string.Join(" ", ints);
            Console.WriteLine(str);
        }
        static void Task3(int[] numbers)
        {
            Array.Sort(numbers);
            var str = string.Join(" ", numbers);
            Console.WriteLine(str);
        }
        static void Task4() // Task 1 with *
        {

        }

    }
}
