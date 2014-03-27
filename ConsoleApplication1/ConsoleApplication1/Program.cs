using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            String input;

            int h = 100, l = 0, guess;
            while(true)
            {

            guess = (h + l) / 2;
            Console.WriteLine("Is your guess higher, lower, or equal to {0}?", guess);
            input= Console.ReadLine();
            if (input == "h")
            {
    
                l = guess + l;
            }
            else if (input == "l")
            {
               
                h = guess - l;


            }
            else if (input == "e")
            {
                break;
            }
        }
    }
  }      
}


