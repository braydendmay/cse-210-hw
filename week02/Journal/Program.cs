using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool run = true;
        while (run)
        {

        Console.WriteLine("\nJournal App Menu:");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Exit");

        Console.Write("Choose 1-5:");
        String choose = Console.ReadLine();

        switch(choose)
        {
          case "1":
          string prompt = PromptGenerator.GetRandomPrompt();
          Console.WriteLine($"Prompt: {prompt}");
          Console.Write("Enter your response: ");
          string response = Console.ReadLine();
          journal.AddEntry(prompt, response);
          break;  

          case "2":
          if (journal.EntriesCount() == 0)
          {
              Console.WriteLine("The journal is empty. Add some entries first.");
          }
          else
          {
              journal.DisplayEntries();
          }
          break;

        case "3":
          Console.Write("Enter the file name to save: ");
          string saveFileName = Console.ReadLine();
          journal.SaveToFile(saveFileName);
          Console.WriteLine("Journal saved successfully.");
          break;

        case "4":
          Console.Write("Enter the file name to load: ");
          string loadFileName = Console.ReadLine();
          journal.LoadFromFile(loadFileName);
          Console.WriteLine("Journal loaded successfully.");
          break;

        case "5":
          run = false;
          break;
        }
        }
    }
}