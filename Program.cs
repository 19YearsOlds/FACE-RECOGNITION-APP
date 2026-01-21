using System;
using System.Collections.Generic;

class FaceRecognitionApp
{
    static Dictionary<string, string> faceDatabase = new Dictionary<string, string>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nFace Recognition System");
            Console.WriteLine("1. Register a new face");
            Console.WriteLine("2. Find a face");
            Console.WriteLine("3. Exit");
            Console.Write("Chose an option (1-3): ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                RegisterFace();
            }
            else if (choice == "2")
            {
                FindFace();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Exiting...");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice! Try again.");
            }
        }
    }

    static void RegisterFace()
    {
        Console.Write("Enter a name: ");
        string name = Console.ReadLine();

        if (faceDatabase.ContainsKey(name))
        {
            Console.WriteLine("Face already registered!");
        }
        else
        {
            faceDatabase[name] = "Face Data";
            Console.WriteLine($"{name}'s face registered successfully.");
        }
    }

    static void FindFace()
    {
        Console.Write("Enter a name to research: ");
        string name = Console.ReadLine();

        if (faceDatabase.ContainsKey(name))
        {
            Console.WriteLine($"Face found: {name}");
        }
        else
        {
            Console.WriteLine("Face not found!");
        }
    }
}