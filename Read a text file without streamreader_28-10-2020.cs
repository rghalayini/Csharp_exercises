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

            string fileName = Console.ReadLine();
            string textfile = File.ReadAllText(fileName);

            Console.WriteLine(textfile);
            Console.ReadLine();
        }
    }
}
