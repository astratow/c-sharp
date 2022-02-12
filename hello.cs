using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;u

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Hello Mono World");

        for(int i = 1; i < args.length; i++){
            Console.WriteLine("Arg {}:{1}", i, args[i]);
        }
        Console.ReadLine();
    }
}
