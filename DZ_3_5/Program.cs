using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*5.	Дано целое число N (> 0), найти число, полученное при прочтении числа N справа налево.
             * Например, если было введено число 345, то программа должна вывести число 543*/

            Console.WriteLine("Необходимо ввести число N, причем N>0 ");
            try
            {
                Console.WriteLine("Введите N");
                string N = Console.ReadLine();
                
                if(Convert.ToInt32(N) < 0)
                {
                    Console.WriteLine("Не соблюдено условие N>0");
                    return;
                }
                Console.Clear();
                Console.WriteLine("Полученное число");
                for(int i= N.Length - 1; i >= 0; i--)
                {
                    Console.Write(N[i]);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Заверщение программы");
                Environment.Exit(0);
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
