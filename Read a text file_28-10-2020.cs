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
            Console.WriteLine("Insert the text file name you want to read:");

            string line;
            string fileName = Console.ReadLine();

            using (StreamReader sr = new StreamReader(fileName))
            {
                line = sr.ReadLine();

                while (line != null)
                {    
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
            }


            Console.ReadLine();
        }
    }
}
