using System.IO;
using System;

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
  }
}