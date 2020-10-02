using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
                {
                Console.Write("Введите значение x:");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Введите значение y:");
                double y = double.Parse(Console.ReadLine());
                bool i = (x * x + y * y <= 4) && !(x * x + y * y + 2 * x <= 0);     
                Console.WriteLine(i);





                }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
            
    }
}

