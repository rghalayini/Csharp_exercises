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
            Console.WriteLine("Draw a rectangle. Insert the number (x). The rectangle will be 3 columns wide and 5 rows high.");

            int x = Convert.ToInt32(Console.ReadLine());
            int width = 3;
            int height = 5;

            for (int column = 0; column < height; column++)
            {
                for (int row = 0; row < width; row++)
                    Console.Write(x);

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
