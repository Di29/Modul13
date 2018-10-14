using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul13HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(10);

            Random random = new Random();
            int sum = 0;

            Console.WriteLine("Список чисел: ");
            for (int i = 0; i < list.Capacity; i++)
            {
                list.Add(random.Next(-10, 10));
                Console.Write(list[i] + "\t");
                if (i % 2 == 0)
                    sum += list[i];
            }
            Console.WriteLine("\nСумма чисел на четных позициях: " + sum);

            int maxNum = 0;
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] > list[maxNum])
                {
                    maxNum = i;
                }
            }

            int secondMaxNum = 0;
            for (int i = 1; i < list.Count; i++)
            {
                if (i != maxNum && list[i] != list[maxNum] && list[i] > list[secondMaxNum])
                {
                    secondMaxNum = i;
                }
            }
            Console.WriteLine("\n\nВторое максимальное значение: [" + secondMaxNum + "] : " + list[secondMaxNum]);

            Console.ReadLine();
        }
    }
}
