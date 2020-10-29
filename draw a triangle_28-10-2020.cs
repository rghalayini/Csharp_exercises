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
            Console.WriteLine("Draw a northeast triangle. Insert a number (x) for the width.");

            string x = "*";
            int height = Convert.ToInt32(Console.ReadLine());
            int width = 0;
            int max = height;

            for (int row = 0; row < height; row++)
            {

                for (int symb = 0; symb < max; symb++)
                {
                    Console.Write(x);
                }
                for (int column = 0; column < width; column++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
                max--;
                width++;
            }
            Console.ReadLine();
        }
    }
}
