using System;
using System.Collections.Generic;

namespace GarbageCollectorApp
{
    class Program
    {
        private static List<object> Generation2Objects = new List<object>(); // Static list to retain long-lived objects

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=========================================================");
            Console.WriteLine("         Welcome to the Garbage Collector Simulator!");
            Console.WriteLine("=========================================================");
            Console.ResetColor();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("[1] Create Generation 0 garbage (Short-lived)");
                Console.WriteLine("[2] Create Generation 1 garbage (Medium-lived)");
                Console.WriteLine("[3] Create Generation 2 garbage (Long-lived)");
                Console.WriteLine("[4] Simulate garbage collection");
                Console.WriteLine("[0] Exit");
                Console.ResetColor();

                var input = Console.ReadLine();

                if (input == "0")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Goodbye!");
                    Console.ResetColor();
                    break;
                }

                switch (input)
                {
                    case "1":
                        CreateGeneration0Garbage();
                        break;
                    case "2":
                        CreateGeneration1Garbage();
                        break;
                    case "3":
                        CreateGeneration2Garbage();
                        break;
                    case "4":
                        SimulateGarbageCollection();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input. Please try again.");
                        Console.ResetColor();
                        break;
                }
            }
        }

        // Generation 0: Short-lived objects
        static void CreateGeneration0Garbage()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Creating Generation 0 garbage...");
            for (int i = 0; i < 100; i++)
            {
                var garbage = new object(); // Creates short-lived objects
            }
            Console.WriteLine("Generation 0 garbage created and discarded.");
            Console.ResetColor();
        }

        // Generation 1: Objects that survive one collection
        static void CreateGeneration1Garbage()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Creating Generation 1 garbage...");
            var generation1Garbage = new List<object>();
            for (int i = 0; i < 10; i++)
            {
                generation1Garbage.Add(new object()); // Objects retained temporarily in memory
            }

            Console.WriteLine("Forcing garbage collection to promote Generation 1 objects...");
            GC.Collect(); // Force garbage collection to promote objects
            GC.WaitForPendingFinalizers();

            Console.WriteLine("Generation 1 garbage created and promoted temporarily.");
            Console.ResetColor();
        }

        // Generation 2: Long-lived objects
        static void CreateGeneration2Garbage()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Creating Generation 2 garbage...");
            for (int i = 0; i < 5; i++)
            {
                Generation2Objects.Add(new object()); // Simulate long-lived objects by retaining them in a static list
            }
            Console.WriteLine("Generation 2 garbage created and retained long-term.");
            Console.ResetColor();
        }

        static void SimulateGarbageCollection()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Simulating garbage collection...");

            // Forcing garbage collection
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("Garbage collection completed!");

            Console.WriteLine($"Current number of Generation 2 objects: {Generation2Objects.Count}");
            Console.ResetColor();
        }
    }
}
