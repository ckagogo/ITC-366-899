using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*.	Given the string “Missouri State University College of Business”,
            extract the second Word and display it (Console.Writeline) like this:
            “Second Word: State:*/

            string sentence = "Missouri State University";

            int firstPosition = sentence.IndexOf(" ") + 1;
            string secondWord = sentence.Substring(firstPosition, sentence.IndexOf(" ", firstPosition) - firstPosition);
            Console.WriteLine("Exercise 1");
            Console.WriteLine("Second word: " + secondWord);
            Console.WriteLine();


            /* Print the string “ Hello, <your name> Today is <day of the week>, it’s <date time> now.
               Print this string once using Composite formatting and then a second time using String
               Interpolation Use the DateTime.Now method for determining the date.
               Match the date/time formatting in the example output  below.*/


            string Name = "Charles! ";
            var date = DateTime.Now;

            Console.WriteLine("Exercise 2");
            Console.WriteLine("Composite Formating");
            Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", Name, date.DayOfWeek, date);
            Console.WriteLine();
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello, {Name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");
            Console.WriteLine();


            // Demonstrate two (2) ways to print this string: “C:\Windows\System32”

            string string1 = "The path is C:\\Windows\\System32";
            string string2 = @"The path is C:\Windows\System32";
            Console.WriteLine("Exercise 3");
            Console.WriteLine(string1);
            Console.WriteLine(string2);
            Console.WriteLine();


            /* Debug the following code:
               Look for syntax, logic, math, spelling errors.
               Copy/Paste this code into Visual Studio and then debug. */

            const double WITHHOLDING_RATE = 0.15;
            string hoursAsString, rateAsString;
            double hours, rate;
            double gross, withholding, net;
            Console.WriteLine("Exercise 4");
            Console.WriteLine("Enter the number of hours you worked this week >> ");
            hoursAsString = Console.ReadLine();
            Console.WriteLine("Enter your hourly rate >> ");
            rateAsString = Console.ReadLine();
            hours = Convert.ToDouble(hoursAsString);
            rate = Convert.ToDouble(rateAsString);
            gross = hours * rate;
            withholding = gross * WITHHOLDING_RATE;
            net = gross - withholding;
            Console.WriteLine("You worked {0} hours at {1} per hour",
           hours, rate.ToString("C"));
            Console.WriteLine("Gross pay is {0}", gross.ToString("C"));
            Console.WriteLine("Withholding is {0}", withholding.ToString("C"));
            Console.WriteLine("Net pay is {0}", net.ToString("C"));
            Console.WriteLine();


            /* Debug the following code:
               Look for syntax, logic, math, spelling errors.
               Copy/Paste this code into Visual Studio and then debug. */


            string name, bossName;
            bool areNamesTheSame;
            Console.WriteLine("Enter your name >> ");
      
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}! Enter the name of your boss >> ", name);
            bossName = Console.ReadLine();
            areNamesTheSame = String.Equals(name, bossName);
            Console.WriteLine("It is {0} that you are your own boss", areNamesTheSame);







        }
    }
}
