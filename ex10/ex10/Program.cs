﻿using System.Xml.Serialization;

namespace ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("***************");
            Console.WriteLine("Menu: ");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Options");
            Console.WriteLine("4 - Quit");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("***************");
            Console.WriteLine("");

            //Promtp choices
            Console.WriteLine("Enter your choice (1, 2, 3, 4)");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            while (choice < 4) 

            {
                if (choice == 1)
                {
                    Console.WriteLine("Starting New Game...");
                    Console.WriteLine("");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Loading Save File...");
                    Console.WriteLine("");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Loading Options...");
                    Console.WriteLine("");
                }
                else if (choice == 4)
                {
                     
                }
               

                Console.WriteLine("***************");
                Console.WriteLine("Menu: ");
                Console.WriteLine("1 - New Game");
                Console.WriteLine("2 - Load Game");
                Console.WriteLine("3 - Options");
                Console.WriteLine("4 - Quit");
                Console.WriteLine("Hello, World!");
                Console.WriteLine("***************");
                Console.WriteLine("");

                //Promtp choices
                Console.WriteLine("Enter your choice (1, 2, 3, 4)");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine();



                
            } // end of while
            
                    
        
                 
        }
    }
}