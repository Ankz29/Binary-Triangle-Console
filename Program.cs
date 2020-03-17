using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTriangleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.BinaryTriangleMethod();
            Console.ReadLine();

        }
            
            void BinaryTriangleMethod()
        {
            int input, lastInt = 0;
            Console.WriteLine("enter the no. of Rows: ");
            input = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (lastInt == 1)
                    {
                        Console.Write("0");
                        lastInt = 0;
                    }
                    else if (lastInt == 0)
                    {
                        Console.Write("1");
                        lastInt = 1;
                    }
                }

                Console.Write("\n");
            }
        }
    }
}
