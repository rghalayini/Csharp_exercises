using System;
using System.IO;
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

        //https://www.exercisescsharp.com/


        //RG 28-10-2020 Lexicon utbildning
        static void Main(string[] args)
        {
            // write to a text file
            Console.WriteLine("Draw a square. Insert the number (x) and the width of the square:");

            int x = Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());

            for (int row = 0; row < width; row++)
            {
                for (int column = 0; column < width; column++)
                    Console.Write(x);

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
