using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            int[] nums = { 3, 4, 24, 15, 165, 65, 8 };

            //Task1();

            //Task2();

            //Task3(ints);

            //Task4();

            //List<int> list = Task5(ints, nums);

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}


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

            double doubleNum;
            double sum = 0;

            Console.WriteLine("Введите любое число, либо sum для подсчета всех введенных вами чисел, либо exit для выхода из программы");
            while (true)
            {
                string input = Console.ReadLine();
                bool isDouble = Double.TryParse(input, out doubleNum);
                if (input == "exit")
                {
                    break;
                }
                else if (input == "sum")
                {
                    Console.WriteLine(sum);
                }
                else if (isDouble)
                {
                    sum += doubleNum;
                }
                else
                {
                    Console.WriteLine("Неверное введенное значение, введите либо: sum, либо: exit, либо любое число");
                }
            }
        }

        static List<int> Task5(int[] nums, int[] ints) // Task 2 with *
        {
            List<int> list = new List<int>();
            for (int i = 0; i < nums.Length;i++)
            {
                list.Add (nums[i]);
            }

            for (int i = 0; i < ints.Length; i++)
            {
                list.Add(ints[i]);
            }

            return list;
        }

        static void Task6() // Task 3 with *
        {
            string[] books = new string[] {"lord of the rings", "karlson", "dead souls", "harry poter: philosphery stone" };
            string inputBook = Console.ReadLine();
            string ToLower = inputBook.ToLower();
            bool isBookIntheLibrary = false;



            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == ToLower)
                {
                    Console.WriteLine($"Yes, book {inputBook} is in the Library");
                    isBookIntheLibrary = true;
                    break;
                }
            }
            if (!isBookIntheLibrary)
            {
                Console.WriteLine($"Unfortunately, our library doesn't have book named {inputBook}");
            }
        }
    }
}
