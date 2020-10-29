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
            Console.WriteLine("Draw a right-aligned triangle. Insert a name.");

            string name =  Console.ReadLine();
            char [] characters = name.ToCharArray();
            int height = name.Length;
            int max = height +1;      // we add +1 because we want to capture the full name. Column starts at 1 below so that's why this needs to be higher  


                for (int column = 1; column < max; column++)  //here we have to start with column = 1 because the name.length function cannot be full, 
                                                              //it has to be less than the full length
                {
                    Console.Write(name.Substring(name.Length - column));
                    Console.WriteLine();
                }

            Console.ReadLine();
        }
    }
}
