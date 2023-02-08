using System;

namespace VariableCS
{
    class Program
    {
        static void EverybitofCode()
        {
            //Create a variable (use your best judgment for type) that stores the numberOfCupsOfCoffee that you drink every day.
            //Create a variable (use your best judgment for type) called fullName and set it equal to your full name.
            //Create a variable (use your best judgment for type) called today and set it equal to today's date.
            //Use Console.WriteLine and your variables, numberOfCupsOfCoffee, fullName, and today, to output all three on one line.
            var numberOfCupsOfCoffee = 3;
            var fullName = "Samuel Gonzalez";
            //ADVENTURE MODE: use Date.Time for the date and time. I already had in this case.
            var today = DateTime.Now;
            Console.WriteLine($"The date is {today.Month}/{today.Day}/{today.Year} and {fullName} has had {numberOfCupsOfCoffee} cups of coffee.");

            //Ask the user for their name and store it in a variable named userName.
            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();
            //Print out a greeting to the user, using their name.
            // ADVENTURE MODE: Add some logic to your program that prints a different, special, greeting to the user if their name happens to be Alice.
            if (userName == "Alice")
            {
                Console.WriteLine($"We've been waiting for you specifically, {userName}. We're so happy you've arrived.");
            }
            else { Console.WriteLine($"Greetings, {userName}!"); }

            //Ask the user to input two numbers.
            Console.WriteLine("Please give me two numbers.");
            //Get the numbers as strings using Console.ReadLine, store them in variables named firstNumberAsString and secondNumberAsString
            string firstNumberAsString = Console.ReadLine();
            string secondNumberAsString = Console.ReadLine();
            //Convert each string above to a double using double.Parse. Save the first value in a variable named firstOperand and the second value in a variable named secondOperand.
            var firstOperand = double.Parse(firstNumberAsString);
            var secondOperand = double.Parse(secondNumberAsString);

            //Add the operand variables from above and save the results in a variable named sum.
            var sum = firstOperand + secondOperand;
            //Subtract the secondOperand variable from the firstOperand variable and save the results in a variable named difference.
            var difference = firstOperand - secondOperand;
            //Multiply the operand variables and save the results in a variable named product.
            var product = firstOperand * secondOperand;
            //Divide the firstOperand by the secondOperand and save the results in a variable named quotient.
            var quotient = firstOperand / secondOperand;
            //Find the remainder when one operand is divided by the other and save the results in a variable named remainder. See this page if you need to learn more about the modulo operator.
            var remainder = firstOperand % secondOperand;
            //Use Console.WriteLine to present the user, in a meaningful way, each of the values for the sum, difference, quotient, product, and remainder variables. (e.g. perhaps one of your outputs is similar to If you add 4 and 5 you get 9 if 4 and 5 were the input)
            Console.WriteLine($"The sum of these numbers is {sum}. The difference of the first number minus the second is {difference}.");
            Console.WriteLine($"The product of the two numbers multiplied is {product}. The quotient of the first number divided by the second is {quotient}");
            Console.WriteLine($"The remainder from the first number divided by the second is {remainder}.");
        }

        static void Main(string[] args)
        {
            //EPIC: implemented a method that runs the majority of the code
            EverybitofCode();
        }
    }
}
