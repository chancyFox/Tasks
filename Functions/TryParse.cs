using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string input = Console.ReadLine();

            int result = Convertation(input);
            Console.WriteLine("Получено число: " + result);
        }

        static int Convertation(string data)
        {
            bool done = false;
            int result = 0;

            while(done == false)
            {
                done = int.TryParse(data, out result);
                if(done == true)
                {
                    result = Convert.ToInt32(data);
                }
                else
                {
                    Console.Write("Скорее всего, вы ввели не число, попробуйте ещё раз: ");
                    data = Console.ReadLine();
                }
            }

            return result;
        }
    }
}
