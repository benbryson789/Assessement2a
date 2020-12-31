using System;
using System.Collections.Generic;

namespace Assessment2a
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing for Task#1
            //string[] result = AddValues("qwe", "asd", "frf");
            //foreach(var item in result)
            //    Console.WriteLine(item);

            // Testing for Tas#2
            //int sum = SumArray(new int[] { 2, 6, 9 });
            //Console.WriteLine(sum);


            // Testing for Task#3
            List<int> numbers = RemoveNum(new List<int>() { 1, 2, 3, 4, 5 }, 8);
            //foreach(int number in numbers)
            //    Console.WriteLine(number);

            // Testing for Task#4
            List<string> result = AddToList("bananas");
            //foreach (string item in result)
            //    Console.WriteLine(item);

            // Testing for Task#5
            //int result = TryMe(5, 0);
            //Console.WriteLine(result);
            Console.ReadKey();
        }

        // Task#1
        static string[] AddValues(string s1, string s2, string s3)
        {
            return new string[] { s1, s2, s3 };
        }

        // Task#2
        static int SumArray(int[] values)
        {
            int sum = 0;
            if (values != null)
            {
                for (int i = 0; i < values.Length; i++)
                    sum = sum + values[i];
            }
            return sum;
        }

        // Task#3
        static List<int> RemoveNum(List<int> numbers, int number)
        {
            bool isFound = false;
            foreach (var item in numbers)
            {
                if (item == number)
                {
                    isFound = true;
                    break;
                }
            }
            if (isFound)
                numbers.Remove(number);
            return numbers;
        }

        // Task#4
        static List<string> AddToList(string s)
        {
            return new List<string>() { "grapes", "oranges", s };
        }

        // Task#5
        static int TryMe(int number1, int number2)
        {
            try
            {
                return number1 / number2;
            }
            catch (Exception)
            {
                return 9;
            }
        }
    }



}