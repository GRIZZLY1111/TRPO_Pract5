using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = 0;
            Console.WriteLine("Введите n");
            n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (n>9)
            {
                int digit = n % 10;
                n -= digit;
                sum += n;
                n /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
