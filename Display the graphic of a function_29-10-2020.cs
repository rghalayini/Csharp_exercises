using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace test
{
    class Program
    {

        //https://www.exercisescsharp.com/


        //RG 28-10-2020 Lexicon utbildning
        static void Main(string[] args)
        {
            // write to a text file
            Console.WriteLine("Display the graphic of a function fiven the formula y=(x-4)2.");
            Console.WriteLine("Enter lower x:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter upper x:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int length = x2 - x1;
            Console.WriteLine("your function is below:");
            int y;

                for (int i = x1; i <= x2; i++)
                {
                    y = (i - 4) * (i - 4);
                    for (int a = 0; a < y; a++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            Console.ReadLine();
        }
    }
}
