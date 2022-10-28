using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assi_1._2
{
    class Program
    {
        public class program
        {
            static void main(string[] args)
            {
                Console.WriteLine("Average marks of 5 students: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("please enter marks for 2nd student: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("please enter marks for 3rd student: ");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("please enter marks for 4th student: ");
                int d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("please enter marks for 5th student: ");
                int e = Convert.ToInt32(Console.ReadLine());
                int[] Average = { a, b, c, d, e };
                Console.WriteLine("maximum marks obtained are: " + Average.Max());
                Console.ReadKey();
            }
        }
    }
}
