using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace myFirstApp.cs
{
    


    class HelloWorld
    {
        public static void Main(string[] args)
        {
            Console.WriteLine ("Hello Mono World");

            for(int i = 0; i < args.Length; i++){ // Length capital!
                Console.WriteLine("Arg {0} : {1}", i, args[i]);
            }
            Console.ReadLine();
        }
    }
}