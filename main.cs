using System;
using System.Collections.Generic;
using System.Linq;

class Program 
{
    static void Main()
    {
       //create array or months of the year
       string[] months = new string[12]       
       {"Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"};
       //initialise prng with a time-dependant default seed value
       Random rnd = new Random();

       // will create a number between 1 and 12
       int month = rnd.Next(1,13);

       //output the random month name
       Console.WriteLine("Month is {0}", months[month-1]);
       RangeTest();
   
    }

      public static void RangeTest() {
        IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x * x);

      foreach (int num in squares) {
        Console.WriteLine(num); 
      
      }
      }
    }
   /*
   This code produces the following output:
      
   1
   4
   9
   16
   25
   36
   49
   64
   81
  100
*/
