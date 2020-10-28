using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {

        //https://www.exercisescsharp.com/arithmetic/division-by-zero


        //RG 28-10-2020 Lexicon utbildning
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication table. Insert a number: ");

            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}x1={1}", x, x*1);
            Console.WriteLine("{0}x2={1}", x, x * 2);
            Console.WriteLine("{0}x3={1}", x, x * 3);
            Console.WriteLine("{0}x4={1}", x, x * 4);
            Console.WriteLine("{0}x5={1}", x, x * 5);
            Console.WriteLine("{0}x6={1}", x, x * 6);
            Console.WriteLine("{0}x7={1}", x, x * 7);
            Console.WriteLine("{0}x8={1}", x, x * 8);
            Console.WriteLine("{0}x9={1}", x, x * 9);
            Console.WriteLine("{0}x10={1}", x, x * 10);


            Console.ReadLine();

        }
    }
}
