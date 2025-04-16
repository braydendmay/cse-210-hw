using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            

            GoalManager goalManager = new GoalManager();

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"\nYou have {goalManager.GetScore()} points.\n"); 

                Console.WriteLine("\nMenu Options:");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Quit");
                Console.Write("Select an option from the menu (type a number): ");

                string option = Console.ReadLine();
                Console.Clear();

                switch (option)
                {
                    case "1":
                        goalManager.CreateGoal();
                        break;
                    case "2":
                        goalManager.ListGoalNames();
                        break;
                    case "3":
                        goalManager.SaveGoals();
                        break;
                    case "4":
                        goalManager.LoadGoals();
                        break;
                    case "5":
                        goalManager.RecordEvent();
                        break;
                    case "6":
                        Console.WriteLine("Exiting the program...");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
            }
        }
    }
}