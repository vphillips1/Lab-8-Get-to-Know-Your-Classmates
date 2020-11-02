using System;
using System.Collections.Generic;

namespace Lab_8_Get_to_Know_Your_Classmates
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] students = new string[]

            {
               "James", "Veronica", "Mike", "Jack", "Victor", "Kiara", "Valerie", "Jeff", "Linda", "Evan", "Mary",
               "Jamar", "Kayla", " Nick", "Gary", "Leslie", "Erin", "Larry", "Zack", " Ashanti"
            };


            string[] homeTown = new string[]

            {"Detroit, MI", " Flint, MI", " San Antonio,TX ", "Ann Arbor, MI", "Warren, MI", "Orlando, FL", "Houston, TX", " Baltimore, MD", "Miami, Fl","Tampa, Fl",
             "Jacksonville, Fl", "San Franciso, CA", "San Diego, CA", "Riverside,CA", "Burbank, CA","Dallas, TX", "Ferndale, MI", "Royal Oak, MI", "Seattle, WA", "Tacoma, WA"

            };

            string[] favoriteFood = new string[]

            { "Icecream", "chicken", "pizza", " lobster", " spaghetti", " macaroni", " bread", " tacos", " nachos", "salad",
                "steak"," Bacon", "waffles", "pancakes", "eggs", "pasta", "sushi", "turkey", "hamburgers", "ham",

            };

            Console.WriteLine(" Welcome to our C# class!");

            Console.WriteLine(" Which student would you like to learn more about?(enter a number 1 - 20):");

            

            bool shouldContinue = true;

            try
            {

                while (shouldContinue)
                {


                    if (int.TryParse(Console.ReadLine(), out int userSelection) && userSelection < 21)

                    {

                        int userIndex = userSelection - 1;
                        Console.WriteLine($"Student {userSelection} is {students[userSelection - 1]}.");


                    }


                    else
                    {
                        shouldContinue = true;
                        Console.WriteLine(" That student does not exist. Please try again. (enter a number 1 - 20):");
                        continue;
                    }


                    bool again = true;
                    while (again)
                    {
                        Console.WriteLine($"What would you like to know about {students[userSelection - 1]} ? (enter hometown or favorite food:)");
                        string userChoice = Console.ReadLine();
                      

                        if (userChoice.Equals("hometown", StringComparison.OrdinalIgnoreCase))

                        {
                            Console.WriteLine($"{students[userSelection - 1]} is from {homeTown[userSelection - 1]}.");
                            break;
                        }

                        else if (userChoice.Equals("favorite food", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine($"{students[userSelection - 1]}'s favorite food is {favoriteFood[userSelection - 1]}.");
                            break;
                        }
                        else 

                        {
                            again = true;
                            Console.WriteLine("That data does not exist. Please try again.");

                            continue;
                        }



                    }


                   Console.WriteLine("Would you like to know more? (enter yes or no:)");

                    string selection = Console.ReadLine();
                    bool cont = true;
                    while (cont)

                    {

                       

                        if (selection.Equals("yes", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine($"What would you like to know ? (Enter favorite food or hometown:)");
                            string answer = Console.ReadLine();
                            if (answer.Equals("hometown", StringComparison.OrdinalIgnoreCase))

                            {
                                Console.WriteLine($"{students[userSelection - 1]} is from {homeTown[userSelection - 1]}.");
                                break;
                            }

                            else if (answer.Equals("favorite food", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine($"{students[userSelection - 1]}'s favorite food is {favoriteFood[userSelection - 1]}.");
                                break;
                            }

                            cont = true;
                            break;
                        }


                        else if (selection.Equals("no", StringComparison.OrdinalIgnoreCase))

                        {
                            Console.WriteLine(" Have a great day! Thanks! ");
                            cont = false;
                        }

                        else
                        {
                            cont = true;
                            Console.WriteLine("Error. Try again");
                            break;
                        }


                    }


                    break;


                }
                 

                   
                
            }

            catch

            {

                Console.WriteLine("Error. Out of Range.");


            }








        }


    }
}
