using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.BinaryShort
{
    class Program
    {
        static void Main(string[] args)
        {
            short number = short.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine(Convert.ToString(number, 2));
            }
            else
            {
                Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
            }
            
        }
    }
}
