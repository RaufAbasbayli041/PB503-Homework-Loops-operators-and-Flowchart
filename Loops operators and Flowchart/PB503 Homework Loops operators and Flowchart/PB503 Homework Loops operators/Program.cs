using System.Numerics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1 

            //// Verilmiş n tam ədədinin sadə və ya mürəkkəb ədəd olduğunu tapan alqoritm

            //Console.Write("Tam eded daxil edin: ");

            //int number = Convert.ToInt32(Console.ReadLine());

            //int count = 0;

            //for (int i = 1; i <= number; i++)
            //{
            //    if (number % i == 0)
            //    {
            //        count++;
            //    }
            //}

            //switch ((number, count))
            //{
            //    case (0, _):
            //        Console.WriteLine(" 0 daxil etmek olmaz!");
            //        break;

            //    case (1, _):
            //        Console.WriteLine(" 1 daxil etmek olmaz!");
            //        break;

            //    case ( < 0, _):
            //        Console.WriteLine($" {number} - natural eded sayilmir!");
            //        break;

            //    case (_, > 2):
            //        Console.WriteLine($"{number} - murekkeb ededdir");
            //        break;

            //    default:
            //        Console.WriteLine($"{number} - sade ededdir");
            //        break;
            //}            

            #endregion

            #region Task 2

            // Verilmiş n tam ədədinin neçə mərtəbəli olduğunu tapın. Məs: 23452, output: 5 , Məs: 456, output: 3

            Console.Write("Tam eded daxil edin:");
            int number = Convert.ToInt32(Console.ReadLine());
            int countOfNumbers = 0;

            do
            {
                int temp = number % 10;
                number -= temp;
                number /= 10;
                countOfNumbers++;

            } while (number != 0);

            Console.WriteLine($"Mertebe sayi - {countOfNumbers}");

            #endregion


        }
    }
}

