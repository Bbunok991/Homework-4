using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindNumbers findThreeNumbers = new FindNumbers();
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int target = 10;

            List<int> result = findThreeNumbers.FindThreeNumbers(arr, target);

            if (result.Count > 0)
            {
                Console.WriteLine("Три числа сумма которых равна " + target + ":");
                foreach (int num in result)
                {
                    Console.Write(num + " ");
                }
            }
            else
            {
                Console.WriteLine("Не удалось найти три числа сумма которых равна " + target);
            }
            Console.ReadLine();
        }

    }
}
