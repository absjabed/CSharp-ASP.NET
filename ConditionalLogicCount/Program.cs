using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalLogicCount
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(i);
                }
                if (i % 2 == 0)
                {
                    if (i % 10 == 0)
                    {
                        Console.Write(" dotnet");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write(" dot ");
                    }
                }
            }
            Console.Read();

        }
    }
}
