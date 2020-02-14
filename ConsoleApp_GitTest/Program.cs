using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Add(1, 2);
            Console.Read();
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Mul(int a, int b)
        {
            return a * b;
        }
    }
}
