using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentNov16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a menu with the following options and let the user enter a choice 
            //to go to one or print an error and let them try again. If they select Exit just let them leave
            //a. 1. Inputs and Printing
            //b. 2. Conditionals
            //c. 3. Looping
            //d. 4. Lists and Arrays
            //e. 5. Dictionaries 
            //f. 6. Exit

            bool MenuReturn = true;
            while (MenuReturn == true) 
            {

                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. Inputs and Printing");
                Console.WriteLine("2. Conditionals");
                Console.WriteLine("3. Looping");
                Console.WriteLine("4. Lists and Arrays");
                Console.WriteLine("5. Dictionaries");
                Console.WriteLine("6. Exit");

                string useroption = Console.ReadLine();
                //1. Inputs and Printing: user should be prompted for a name, then be prompted for a name 
                //which should be displayed back on the screen in some kind of sentence 
                //Then be prompted for a number which will then print the number squared
                if (useroption == "1")
                {
                    Console.WriteLine("Well hello there. And what may I call you?");
                    string username = Console.ReadLine();

                    Console.WriteLine($"Hi {username}. What's your favorite number?");

                    int usernum = int.Parse(Console.ReadLine());
                    int squared = usernum * usernum;

                    Console.WriteLine($"That's a great number, {username}! {usernum} squared is {squared}.");
                    Console.WriteLine("Press Enter to return to the menu");
                    Console.ReadKey();
                    Console.Clear();
                    MenuReturn = true;
                }
                //2. Conditionals. User will be asked for two numbers. Print if the first number
                //is bigger, smaller, or the same as the second number. Then ask a question of the user and print
                //if their answer is correct or not. 
                if (useroption == "2")
                {
                    Console.WriteLine("Another number game for you. What is your favorite number?");
                    int favnum = int.Parse(Console.ReadLine());

                    Console.WriteLine("And your second favorite number?");
                    int num2 = int.Parse(Console.ReadLine());

                    if (favnum > num2)
                    {
                        Console.WriteLine($"{favnum} is greater than {num2}");
                    }
                    else if (favnum < num2)
                    {
                        Console.WriteLine($"{favnum} is less than {num2}");
                    }
                    else if (favnum == num2)
                    {
                        Console.WriteLine($"{favnum} is equal to {num2}");
                    }

                    bool QuizRedo = true;
                    while (QuizRedo == true)
                    {
                        Console.WriteLine("Quiz time! Is Lansing the capital of Michigan? Y/N?");
                        string response = Console.ReadLine().ToLower();

                        if (response == "y" || response == "yes")
                        {
                            Console.WriteLine("Correctomundo!");
                            QuizRedo = false;
                        }

                        else if (response == "n" || response == "no")
                        {
                            Console.WriteLine("Wrongo! Time to get you a map!");
                            QuizRedo = false;
                        }

                        else
                        {
                            Console.WriteLine("That is not a valid response");
                            QuizRedo = true;
                        }
                    }
                    Console.WriteLine("Press Enter to return to the menu");
                    Console.ReadKey();
                    Console.Clear();
                    MenuReturn = true;
                }

                //3. Looping. Ask the user for a number and print all numbers from 1 to that number. 
                //Ask the user for a word and display it a number of times equal to the prior number. You 
                //MUST use two different loops for each of these. 

                if (useroption == "3")
                {
                    Console.WriteLine("We really like numbers here. What's another good number for you?");

                    int loopnum1 = int.Parse(Console.ReadLine());

                    for (int i = 1; i < loopnum1 + 1; i++)
                    {
                        Console.WriteLine(i);
                    }

                    Console.WriteLine("Nice list. How about your favorite word? Let's keep it short, please!");
                    string wordentry = Console.ReadLine();

                    for (int i = 0; i < loopnum1; i++)
                    {
                        Console.WriteLine(wordentry);
                    }
                    Console.WriteLine("Press Enter to return to the menu");
                    Console.ReadKey();
                    Console.Clear();
                    MenuReturn = true;
                }

                //4. Lists and Arrays. Ask the user for 5 names and add them to a list. Then print the list. 
                //Have the computer ask if it can also be the user's friend. If the user says yes, add computer to list and print again.
                //If the user says no, send message to user and return to menu. 

                if (useroption == "4")
                {
                    Console.WriteLine("You've got friends, right? At least a few? Enter 5 of their names:");
                    string friend1 = Console.ReadLine();
                    string friend2 = Console.ReadLine();
                    string friend3 = Console.ReadLine();
                    string friend4 = Console.ReadLine();
                    string friend5 = Console.ReadLine();
                    string potentialfriend = "Computer (the coolest friend ever!)";
                    List<string> friends = new List<string>();

                    friends.Add(friend1);
                    friends.Add(friend2);
                    friends.Add(friend3);
                    friends.Add(friend4);
                    friends.Add(friend5);

                    Console.WriteLine("Wow, so many friends! Look at 'em all!");
                    foreach (var item in friends)
                    {
                        Console.WriteLine(item);
                    }

                    Console.WriteLine("Can I...be your friend too? Y/N?");

                    string reply = Console.ReadLine().ToLower();

                    if (reply == "y" || reply == "yes")
                    {
                        Console.WriteLine("Aww! You're so nice! Thank you, friend!");
                        friends.Add(potentialfriend);
                        foreach (var item in friends)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("Press Enter to return to the menu");
                        Console.ReadKey();
                        Console.Clear();
                        MenuReturn = true;
                    }

                    if (reply == "n" || reply == "no")
                    {
                        Console.WriteLine("Meanie! Fine, I don't want to be your friend anyways!");
                        Console.WriteLine("Press Enter to return to the menu");
                        Console.ReadKey();
                        Console.Clear();
                        MenuReturn = true;
                    }

                    else
                    {
                        int test = 0;

                        while (!int.TryParse(reply, out test))
                        {
                            Console.WriteLine("That's not an option, man!");
                            break;
                        }
                        Console.WriteLine("Press Enter to return to the menu");
                        Console.ReadKey();
                        Console.Clear();
                        MenuReturn = true;
                    }
                    
                }
                //5. Dictionaries. Make a loop that keeps adding words and their definitions until user enters a keyword to stop. 
                //after stopping entries the computer should display back the words and their definitions. 

                if (useroption == "5")
                {
                    

                    Console.WriteLine("Let's learn some words! Type STOP instead of a new word if you've had enough!");
                    Dictionary<string, string> words = new Dictionary<string, string>();

                    bool EnterAgain = true;
                    while (EnterAgain == true)
                    {
                        Console.WriteLine("Enter a word:");
                        string wordentry = Console.ReadLine();

                        if (wordentry != "STOP")
                        {
                            Console.WriteLine("Enter your definition for that word:");
                            string defentry = Console.ReadLine();

                            words.Add(wordentry, defentry);
                            EnterAgain = true;
                        }


                        else
                        {
                            Console.WriteLine("Your dictionary:");
                            foreach (var item in words)
                            {
                                Console.WriteLine(item);
                            }
                            EnterAgain = false;
                        }
                    }

                    Console.WriteLine("Press Enter to return to the menu");
                    Console.ReadKey();
                    Console.Clear();
                    MenuReturn = true;
                }
                if (useroption == "6")
                {
                    Console.WriteLine("Goodbye!");
                    MenuReturn = false;
                }

                else
                {
                    int id = 0;

                    while (!int.TryParse(useroption, out id))
                    {
                       Console.WriteLine("Nice try.");
                        break;
                    }

                }
            }
        }
    }
}
