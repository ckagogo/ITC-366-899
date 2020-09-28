using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 1.	Write a method that accepts a user’s message and determines 
             * whether it is short enough for a social networking service that 
             * does not accept messages of more than 140 characters */
/*
            Console.WriteLine(1);
            Console.WriteLine("Enter your message");
            string message = Console.ReadLine();

            if (message.Length <= 140)
            Console.WriteLine("The message is okay");
            Console.WriteLine();

            /*2.	Write a program named Admission for a college’s admissions office. 
             * The user enters a numeric high school grade point average (for example, 3.2) 
             * and an admission test score. Display the message Accept if the student meets 
             * either of the following requirements:

                •	A grade point average of 3.0 or higher, and an admission test score of at least 60
                •	A grade point average of less than 3.0, and an admission test score of at least 80 
                •	If the student does not meet either of the qualification criteria, display Reject.
             */

/*
            double pointAverage = 3.0;
            double testScore1 = 60;
            double testScore2 = 80;
            double user1, user2;
            string stringUser1, stringUser2;



            Console.WriteLine("Exersice 2");
            Console.WriteLine("Enter grade point average");
            stringUser1 = Console.ReadLine();
            user1 = Convert.ToDouble(stringUser1);

            Console.WriteLine("Enter test score");
            stringUser2 = Console.ReadLine();
            user2 = Convert.ToDouble(stringUser2);



            if (user1 >= pointAverage && user2 >= testScore1)
            {
                Console.WriteLine("Accepted");
                return;
                
            }
            if (user1 < pointAverage && user2 >= testScore2)
            { 
                Console.WriteLine("Accepted");
                return;
                
            }
            else
            {
                Console.WriteLine("Rejected");
                
            }
            



            /*3. In the game Rock Paper Scissors, two players simultaneously choose one of three options:
             * rock, paper, or scissors. If both players choose the same option, then the result is a tie. 
             * However, if they choose differently, the winner is determined as follows: 

                • Rock beats scissors, because a rock can break a pair of scissors. 
                • Scissors beats paper, because scissors can cut paper. 
                • Paper beats rock, because a piece of paper can cover a rock.
             */

    /*        char ComputerChoice = 'N', UserChoice;

            Random random = new Random();

            //Computer choices

            switch (random.Next(0, 3))
            {
                case 0:
                    ComputerChoice = 'r';
                    break;

                case 1:
                    ComputerChoice = 'p';
                    break;

                case 2:
                    ComputerChoice = 's';
                    break;

            }

            //user input

            Console.WriteLine("Exercise 3");
            Console.WriteLine("Enter r, p, s for Rock, Paper, Scissor");
            UserChoice = Convert.ToChar(Console.Read());
            UserChoice = Char.ToLower(UserChoice);


            if (UserChoice == 'r')
            {
                if (ComputerChoice == 'r')
                    Console.WriteLine("\n Computer picked Rock, Tie");
                if (ComputerChoice == 'p')
                    Console.WriteLine("\n Computer picked paper, You Lose");
                if (ComputerChoice == 's')
                    Console.WriteLine("\n Computer picked Scissor, You Win");
            }

            if (UserChoice == 'p')
            {
                if (ComputerChoice == 'r')
                    Console.WriteLine("\n Computer picked Rock, You Win");
                if (ComputerChoice == 'p')
                    Console.WriteLine("\n Computer picked paper, Tie");
                if (ComputerChoice == 's')
                    Console.WriteLine("\n Computer picked Scissor, You Lose");

            }

            if (UserChoice == 's')
            {
                if (ComputerChoice == 'r')
                    Console.WriteLine("\n Computer picked Rock, You Lose");
                if (ComputerChoice == 'p')
                    Console.WriteLine("\n Computer picked paper, You Win ");
                if (ComputerChoice == 's')
                    Console.WriteLine("\n Computer picked Scissor, Tie");


            }

            /*
             4.	Debug the following code:
                Look for syntax, logic, math, spelling errors. Copy/Paste this
                code into Visual Studio and then debug. 

             */

           

            // Program decides tuition based on several criteria:
            // 1 - 12 credit hours @ $150 per credit hour
            // 13 - 18 credit hours, flat fee $1900
            // over 18 hours, $1900 plus $100 per credit hour over 18
            // If year in school is 4, there is a 15% discount
/*
            int credits, year;
            string inputString;
            double tuition;
            const int LOWCREDITS = 12;
            const int HIGHCREDITS = 18;
            const double HOURFEE = 15000;
            const double DISCOUNT = 0.15;
            const double FLAT = 1900.00;
            const double RATE = 100.00;
            const int SENIORYEAR = 4;

            Console.WriteLine("How many credits? ");
            inputString = Console.ReadLine();
            credits = Convert.ToInt32(inputString);

            Console.WriteLine("Year in school? ");
            inputString = Console.ReadLine();
            year = Convert.ToInt32(inputString);

            if (credits > LOWCREDITS)
                tuition = HOURFEE * credits;
            else if (credits == HIGHCREDITS)
                tuition = FLAT;
            else
                tuition = FLAT + (credits - HIGHCREDITS) * RATE;
            if (year < SENIORYEAR)
                tuition = tuition - (tuition * DISCOUNT);
            Console.WriteLine("For year {0}, with {1} credits",
          year, credits);
            Console.WriteLine("Tuition is {0}", tuition.ToString("C"));


            /*5.Debug the following code:
            Look for syntax, logic, math, spelling errors.
            Copy / Paste this code into Visual Studio and then debug.
            */

            // Program takes a hot dog order
            // And determines price

            const double BASIC_DOG_PRICE = 2.00;
            const double CHILI_PRICE = 0.69;
            const double CHEESE_PRICE = 0.49;
            String wantChili, wantCheese;
            double price;
            Console.WriteLine("Do you want chili on your dog? ");
            wantChili = Console.ReadLine();
            Console.WriteLine("Do you want cheese on your dog? ");
            wantCheese = Console.ReadLine();
            if (wantChili == "Y")
                if (wantCheese == "Y")
                    price = BASIC_DOG_PRICE + CHILI_PRICE + CHEESE_PRICE;
                else
                    price = BASIC_DOG_PRICE + CHILI_PRICE;
            else
               if (wantCheese == "Y")
                price = BASIC_DOG_PRICE;
            else
                price = BASIC_DOG_PRICE;
            Console.WriteLine("Your total is {0}", price.ToString("C"));





        }
    }
}
