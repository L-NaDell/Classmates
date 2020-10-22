using System;
using System.Linq;

namespace Classmates
{
    class Program
    {
        static string[] options = { "hometown", "favorite food", "music recomendation", "form of cookie dough" };
        static string[] studentsFirst = { "Akii", "Alex", "Barthelemy", "Brian", "Duncan", "Jean", "Kristen", "Lauren", "Lindsay", "Nick", "Pin", "Robert" };
        static string[] studentsLast = { "Christian", "Crang", "Martinon", "Stewart", "MacLachlan", "Thomas", "Harrell", "Jensen", "NaDell", "Hickman", "Vue", "Bizon" };
        static string[] hometown = { "San Francisco, CA", "New York, NY", "Seattle, WA", "Chicago, IL", "Austin, TX", "Detroit, MI", "Las Vegas, NV", "Miami, FL", "Ann Arbor, MI", "Indianapolis, ID", "Columbus, OH", "Nashville, TN" };
        static string[] favFood = { "pizza", "taco's", "salmon", "steak", "burgers", "salad", "pie", "cake", "tomatoes", "fruit", "scallops", "curry" };
        static string[] song = { "Eye of the Tiger by Survivor", "Sound The Alarm by Thievery Corporation", "ambient instramental music", "Tell Me by RL Grime & What So Not", "Stachybotrys by DjoHn", "Lose Yourself by Eminem", "Don't Stop Believin' by Journey", "I Can’t Stop by Flux Pavilion", "Imaginary Parties by Superfruit", "Tubthumping by Chumbawamba", "Sandstorm by Darude", "Spicy By The Glass by Terravita" };
        static string[] cookieDough = { "made into cookies", "in ice cream", "in ice cream", "in ice cream", "made into cookies", "made into cookies", "made into cookies", "in ice cream", "made into cookies", "in ice cream", "in ice cream", "in ice cream" };
        
        static void Main(string[] args)
        {
            string another = "y";

            Console.WriteLine("Welcome to our C# class!");

            while (another.ToLower() == "y")
            {
                Console.WriteLine("\nWhich student would you like to learn more about?");

                DisplayStudent();

                Console.Write("\nWould you like information about another student? (y/n)");
                another = Console.ReadLine();
            }
            Console.WriteLine("\nThanks!");
        }

        private static void DisplayStudent()
        {
            for (int i = 0; i < studentsFirst.Length; i++)
            {
                Console.WriteLine($"{ i + 1} { studentsFirst[i]}");
            }
            Console.WriteLine();
            try
            {
                string moreInfo = "yes";

                int student = int.Parse(Console.ReadLine()) - 1;

                if (student >= 0 && student <= 11)
                {
                    Console.WriteLine($"\nStudent {student + 1} is {studentsFirst[student]} {studentsLast[student]}.");

                    while (moreInfo.ToLower() == "yes")
                    {
                        Console.WriteLine($"\nWhat would you like to know about {studentsFirst[student]}?\n(choose between hometown, favorite food, music recomendation, and form of cookie dough):\n");
                        string request = Console.ReadLine().ToLower().Trim();

                        if (ValidRequest(options, request))
                        {
                            if (request == "hometown")
                            {
                                //BF's example of not useing Console.WriteLine

                                //PrintStudentInfo("\n{0} is from {1}", studentsFirst[student], hometown[student]);
                                Console.WriteLine($"\n{studentsFirst[student]} is from {hometown[student]}.");
                            }
                            else if (request == "favorite food")
                            {
                                //BF's example of not useing Console.WriteLine
                                //PrintStudentInfo("\nOne of {0}'s favorite foods is {1}.", studentsFirst[student], favFood[student]);
                                Console.WriteLine($"\nOne of {studentsFirst[student]}'s favorite foods is {favFood[student]}.");
                            }
                            else if (request == "music recomendation")
                            {
                                Console.WriteLine($"\nTo get pumped up, {studentsFirst[student]} recomends {song[student]}.");
                            }
                            else
                            {
                                Console.WriteLine($"\n{studentsFirst[student]} prefers that cookie dough is {cookieDough[student]}.");
                            }

                            Console.Write($"\nWould you like to know more about {studentsFirst[student]}?\n(enter 'yes' or 'no'):");
                            moreInfo = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine($"{request} does not exist. Please try again.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("That student does not exist. Please try again.\n(enter a number 1-12):");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("That is not a student. Please try again.", ex);
            }
        }

        public static bool ValidRequest(string[] options, string request)
        {
            if (options.Contains(request))
            {
                return true;
            }
            return false;
        }
        //BF's example of how to not use console.writeline
        //private static void PrintStudentInfo(string message, string name, string item)
        //{
        //    Console.WriteLine(message, name, item);
        //}

    }
}

