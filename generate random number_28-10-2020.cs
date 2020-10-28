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


        //RG 27-10-2020 Lexicon utbildning
        static void Main(string[] args)
        {
            // write to a text file
            Console.WriteLine("Insert any text. Press enter and the text will be written in a text document.");
            string fileName = "out.txt";
            using (StreamWriter file = File.CreateText(fileName))
            {
                string line;
                do
                {
                    line = Console.ReadLine();

                    if (line.Length != 0)
                    {
                        file.WriteLine(line);
                    }
                }
                while (line.Length != 0);
            }
        }
    }
}
