using System;
using System.Runtime.CompilerServices;

namespace csharpoverninethousand
{
    class Program
    {
        /*example of target typing 👇*/
        //Program program = new();
        public void RelationalPatternMatch()
        {
            while (true)
            {
                int @var = -12;
                switch (@var)
                {
                    //case int value when value <= 0:
                    case <= 0:
                        Console.WriteLine("Less than or equal to 0");
                        break;
                    case > 0 and <= 10:
                        Console.WriteLine("More than 0 but less than or equal to 10");
                        break;
                    default:
                        Console.WriteLine("More than 10");
                        break;
                }

                /*We can discard? This doesn't seem necessary*/
                _ = 9000 switch
                {

                    <= 0 => "Less than or equal to 0",
                    /*int value when value, you must use AND not the operator*/
                    //this 🥘 -> is now                    
                    > 0 and <= 10 =>
                    "More than 0 but less than or equal to 10",
                    _ => "More than 10"
                };


            }
        }
    }


}