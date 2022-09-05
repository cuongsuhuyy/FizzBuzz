using System;

//Write a program from 1 to 100 which multiply by 3 is print fizz and multiply by 5 print buzz
//And multiply by all print fizzbuzz
namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //My Way
            //for (int i = 0; i < 100; i++)
            //{
            //    var isMultiplyOf = CheckIsMultiplyOf(i);
            //    if (!isMultiplyOf)
            //        Console.WriteLine(i);
            //}

            //New Way
            for (int i = 1; i <= 100; i++)
            {
                string result = "";
                if (i % 3 == 0) result = "Fizz";
                if (i % 5 == 0) result += "Buzz";
                if (result.Length == 0) result = i.ToString();
                Console.WriteLine(result);
            }
        }

        public static bool CheckIsMultiplyOf(int number)
        {
            int count = 1;
            int result = 0;
            bool isMultiplyOf3 = false, isMultiplyOf5 = false;

            //Multiply of 3
            while (result < number)
            {
                result = count * 3;
                if (result == number)
                {
                    isMultiplyOf3 = true;
                    break;
                }
                count++;
            }

            //Multiply of 5
            count = 1;
            result = 0;
            while (result < number)
            {
                result = count * 5;
                if (result == number)
                {
                    isMultiplyOf5 = true;
                    break;
                }
                count++;
            }

            if (isMultiplyOf3 && isMultiplyOf5)
                Console.WriteLine("FizzBuzz");
            else if (isMultiplyOf3)
                Console.WriteLine("Fizz");
            else if (isMultiplyOf5)
                Console.WriteLine("Buzz");

            if (isMultiplyOf3 || isMultiplyOf5)
                return true;
            else
                return false;
        }
    }
}
