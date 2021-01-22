using System;

namespace ComputationalThinkingExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepThinking = true;
            while (keepThinking)
            {
                Console.Clear();
                Console.WriteLine("COMPUTATIONAL THINKING EXERCISES\n");
                Console.WriteLine("Which exercise would you like to run?");
                Console.WriteLine("1. Are These Integers Equal?");
                Console.WriteLine("2. Even or Odd?");
                Console.WriteLine("3. Vowel or Consonant?");
                Console.WriteLine("4. Find the Largest Number");
                Console.WriteLine("5. Divisible by 3");
                Console.WriteLine("6. Restaurant Bill");
                Console.WriteLine("7. Age Category");
                Console.WriteLine("8. Words to Digits");
                Console.WriteLine("9. Which Name is Longer?");
                Console.WriteLine("10. Are these Names the Same?");
                Console.WriteLine("11. Name and Place of Birth");
                Console.WriteLine("Press Q to quit");

                string userChoice = Console.ReadLine().ToLower();

                switch(userChoice)
                {
                    case "1":
                        AreTheseIntegersEqual();
                        break;
                    case "2":
                        EvenOrOdd();
                        break;
                    case "3":
                        VowelOrConsonant();
                        break;
                    case "4":
                        FindLargestNumber();
                        break;
                    case "5":
                        DivisibleBy3();
                        break;
                    case "6":
                        RestaurantBill();
                        break;
                    case "7":
                        AgeCategory();
                        break;
                    case "8":
                        WordsToDigits();
                        break;
                    case "9":
                        WhichNameIsLonger();
                        break;
                    case "10":
                        AreNamesSame();
                        break;
                    case "11":
                        NameAndBirthplace();
                        break;
                    case "q":
                        keepThinking = false;
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        break;
                }
            }
        }

        static void AreTheseIntegersEqual()
        {
            // Ask the user for two integers. 
            // Check and see if the two integers are equal to each other.
            // If they are, inform the user that the numbers are equal,
            // else inform the user that the numbers are not equal

            Console.Clear();
            Console.WriteLine("ARE THESE INTEGERS EQUAL?\n");

            // Enter your solution here

            Console.WriteLine("Pick any 2 numbers.  Enter your 1st number now.");
            int userNumber1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your 2nd number now.");
            int userNumber2 = Convert.ToInt32(Console.ReadLine());

            if (userNumber1 == userNumber2)
            {
                Console.WriteLine("These numbers are equal.");
            }
            else
            {
                Console.WriteLine("These numbers are NOT equal.");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void EvenOrOdd()
        {
            // Ask the user for a number.
            // Tell the user if that number is even or odd.

            Console.Clear();
            Console.WriteLine("EVEN OR ODD?\n");

            // Enter your solution here

            Console.WriteLine("What is your least favorite number???");
            int favoriteNumber = Convert.ToInt32(Console.ReadLine());

            if (favoriteNumber % 2 == 0)
            {
                Console.WriteLine("This number is even.");
            }

            else 
            {
                Console.WriteLine("This number is odd.");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void VowelOrConsonant()
        {
            // Ask the user for a letter. Check whether a letter is a vowel or consonant.
            // Hint: You can do this problem using a switch or an if condition.

            Console.Clear();
            Console.WriteLine("VOWEL OR CONSONANT?\n");

            // Enter your solution here

            Console.WriteLine("Tell me your favorite letter of all time!");
            string favoriteLetter = Console.ReadLine();

            switch (favoriteLetter.ToLower())
            {
                case "a": case "e": case "i": case "o": case "u":
                    Console.WriteLine("This letter is a vowel.");
                    break;
                default:
                    Console.WriteLine("This letter is a consonant.");
                    break;
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void FindLargestNumber()
        {
            // Prompt the user to input two integer values.
            // Find and print the greatest value of the two integers.

            Console.Clear();
            Console.WriteLine("FIND THE LARGEST NUMBER\n");

            // Enter your solution here

            Console.WriteLine("Think of 2 numbers and I'll tell you a fun fact about them.  What is the first number that comes to mind?");
            int bigNumber1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now tell me your second number.");
            int bigNumber2 = Convert.ToInt32(Console.ReadLine());

            if (bigNumber1 < bigNumber2)
                Console.WriteLine($"{bigNumber2} is the larger number.  I know this because I'm a computer and I know everything.");

            else if (bigNumber1 > bigNumber2)
                Console.WriteLine($"{bigNumber1} is the larger number.  I know this because I'm a computer and I know everything.");

            else
                Console.WriteLine("You cheated! Both numbers are the same, you big cheater!");

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void DivisibleBy3()
        {
            // Ask the user for a number and then tell them if it is divisible by 3

            Console.Clear();
            Console.WriteLine("DIVISIBLE BY 3\n");

            // Enter your solution here

            Console.WriteLine("Now for my next magical trick... Pick another number!");
            int divisibleNumber = Convert.ToInt32(Console.ReadLine());

            if ( divisibleNumber % 3 ==0)
                Console.WriteLine($"{divisibleNumber} is divisible by 3.");

            else
                Console.WriteLine($"{divisibleNumber} is NOT divisible by 3.");

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void RestaurantBill()
        {
            // At a restaurant, Mike and his three friends decided to divide the bill evenly.
            // If each person paid $13 then what was the total bill?
            // Use arithmetic operators and print the amount of the total bill to the console.

            // Returning to the above problem, replace hard-coded values of 4(number of diners)
            // and 13(cost per diner) with values provided by the user.

            // How nice!The restaurant is having Customer Appreciation Week.
            // If a table’s total bill is $50 or more, then they’ll receive a 10 % discount!
            // Otherwise, they’ll receive a 5 % discount.

            Console.Clear();
            Console.WriteLine("RESTAURANT BILL\n");

            // Enter your solution here

            float restaurantBill = 13;
            float numberOfPeople = 4;
            float totalBill = restaurantBill * numberOfPeople;

            Console.WriteLine($"Mike and his three friends ate at a restaurant and divided the bill evenly.  Each person paid {restaurantBill:C}.  Their total bill was {totalBill:C}.");

            Console.WriteLine("\nLets see how much money you and your friends would pay.  Including yourself, how many friends are you dining with?");
            numberOfPeople = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How much money did you pay for your meal?");
            restaurantBill = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"You and your {numberOfPeople - 1} friends would pay a total of {numberOfPeople * restaurantBill:C}.");

            Console.WriteLine("\nActually, I just received some great news!  Apparently the restaurant is having Customer Appreciation Week.");
            totalBill = restaurantBill * numberOfPeople;

            if (totalBill >= 50)
                Console.WriteLine($"\nSince your table's total bill is over $50, you receive a 10% discount!  Your new total is {totalBill - (totalBill * .1):C}.");
            
            else
                Console.WriteLine($"\nYou will receive a 5% discount. Your new total is {totalBill - (totalBill * .05):C}.");

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void AgeCategory()
        {
            // You're responsible for providing a demographic report for your local school district based on age.
            // To do this, you're going to determine which 'category' each person fits into based on their age.
            // The person's age will determine which category they should be in:

            // If they're from 0 to 2 the child should be with parents print : 'Still in Mama's Arms'
            // If they're 3 or 4 and should be in preschool print : 'Preschool Maniac'
            // If they're from 5 to 11 and should be in elementary school print : 'Elementary School'
            // From 12 to 14: 'Middle School'
            // From 15 to 18: 'High School'
            // From 19 to 22: 'College'
            // From 23 to 65: 'Working for the Man'
            // From 66 to 100: 'The Golden Years'
            // If the age of the person is less than 0 or more than 100 - it might be an alien
                    // print: "This program is for humans".

            Console.Clear();
            Console.WriteLine("AGE CATEGORY\n");

            // Enter your solution here

            Console.WriteLine("How old are you?");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge >= 0 && userAge <= 2)
                Console.WriteLine("Still in Mama's Arms");

            else if (userAge == 3 || userAge == 4)
                Console.WriteLine("Preschool Maniac");

            else if (userAge >= 5 && userAge <= 11)
                Console.WriteLine("Elementary School");

            else if (userAge >= 12 && userAge <= 14)
                Console.WriteLine("Middle School");

            else if (userAge >= 15 && userAge <= 18)
                Console.WriteLine("High School");

            else if (userAge >= 19 && userAge <= 22)
                Console.WriteLine("College");

            else if (userAge >= 23 && userAge <= 65)
                Console.WriteLine("Working for the Man");

            else if (userAge >= 66 && userAge <= 100)
                Console.WriteLine("The Golden Years");

            else
                Console.WriteLine("This program is for humans only!");

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void WordsToDigits()
        {
            // Having a string representation of a number, you need to print the digit form of the number.
            // Ask the user to enter a string representation of a number from zero to ten.
            // Using switch case, print the digit (0-10) representation of the number.

            Console.Clear();
            Console.WriteLine("WORDS TO DIGITS\n");

            // Enter your solution here

            Console.WriteLine("Pick a number from zero to ten.  Spell out the word, DON'T write the number");
            string numberWord = Console.ReadLine();

            switch (numberWord.ToLower())
            {
                case "zero":
                    Console.WriteLine("Your number is 0.");
                    break;
                case "one":
                    Console.WriteLine("Your number is 1.");
                    break;
                case "two":
                    Console.WriteLine("Your number is 2.");
                    break;
                case "three":
                    Console.WriteLine("Your number is 3.");
                    break;
                case "four":
                    Console.WriteLine("Your number is 4.");
                    break;
                case "five":
                    Console.WriteLine("Your number is 5.");
                    break;
                case "six":
                    Console.WriteLine("Your number is 6.");
                    break;
                case "seven":
                    Console.WriteLine("Your number is 7.");
                    break;
                case "eight":
                    Console.WriteLine("Your number is 8.");
                    break;
                case "nine":
                    Console.WriteLine("Your number is 9.");
                    break;
                case "ten":
                    Console.WriteLine("Your number is 10.");
                    break;
                default:
                    Console.WriteLine("You either can't spell or picked a number outside of the criteria that I gave you. Shame on you!");
                    break;
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void WhichNameIsLonger()
        {
            // Ask the user for their first and last name.

            // Print the user's full name.
            // If the first name is longer than the last name, print "First is longer."
            // If the first name and last name are the same length, print "Same-sies!"
            // Otherwise, print "Last must be longer!"

            Console.Clear();
            Console.WriteLine("WHICH NAME IS LONGER?\n");

            // Enter your solution here

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Nice to meet you, {firstName} {lastName}!");

            int firstNumber = firstName.Length;
            int lastNumber = lastName.Length;

            if (firstNumber > lastNumber)
                Console.WriteLine("First is longer.");
            else if (firstNumber == lastNumber)
                Console.WriteLine("Same-sies!");
            else
                Console.WriteLine("Last must be longer!");

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void AreNamesSame()
        {
            // Ask the user for 2 names.

            // If the two names are the same, print "The names are the same."
            // If they're not the same, print "The names are different."

            Console.Clear();
            Console.WriteLine("ARE THESE NAMES THE SAME?\n");

            // Enter your solution here

            Console.WriteLine("What is your middle name?");
            string middleName = Console.ReadLine();
            Console.WriteLine("What is the name of your best friend?");
            string bestFriend = Console.ReadLine();

            if (middleName.ToLower().Equals(bestFriend.ToLower()))
                Console.WriteLine("The names are the same");
            else
                Console.WriteLine("The names are different.");

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void NameAndBirthplace()
        {
            // Ask the user for their first name and where they were born.
            // Print a sentence to the console that repeats this information.

            Console.Clear();
            Console.WriteLine("NAME AND PLACE OF BIRTH\n");

            // Enter your solution here

            Console.WriteLine("What is your first name?");
            string userName = Console.ReadLine();
            Console.WriteLine("What city were you born in?");
            string cityName = Console.ReadLine();

            Console.WriteLine($"Nice to meet you {userName}!  I was also born in {cityName}!  Crazy, right?!?  Trust me, I'm just as shocked as you are.");

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

    }
}
