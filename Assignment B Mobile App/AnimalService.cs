using System;
using System.Collections.Generic;
using Assignment_B_Mobile_App.Properties;

namespace Assignment_B_Mobile_App;

public class AnimalService
{
    public void Menu(List<ITalkable> zooList)
    {
        char menuAnswer = 'z';

        while (menuAnswer != 'e')
        {

            Console.WriteLine("What type of animal do you want to create?");
            Console.WriteLine("Enter 1 for a new cat");
            Console.WriteLine("Enter 2 for a new dog");
            Console.WriteLine(".........................................");
            Console.Write("Please Enter Menu Number (e to end): ");
            
            try
            {
                menuAnswer = Console.ReadLine().ToLower()[0];
                if (menuAnswer == '1')
                {
                    AddCat(zooList);
                }
                
                else if (menuAnswer == '2')
                {
                    AddDog(zooList);

                }
                else if (menuAnswer == 'e')
                {

                    End();
                }
                else
                {
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Try again\n\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine($"Pick a valid key");

            }
        }


    }

    public void AddDog(List<ITalkable> zooList)
    {
       
        Console.WriteLine("Enter Dog's name:");
        string dogName = Console.ReadLine();
        
        Console.WriteLine("Is dog friendly? (true/false)");
        string dogFriendly = Console.ReadLine().ToLower();
        bool dogFriendlyBool = true;

            if (dogFriendly == "true")
            {
                dogFriendlyBool = true;
            }
                
            else if (dogFriendly == "false")
            {
                dogFriendlyBool = false;

            }
            else
            {
                throw new Exception("Entered invalid value");
            }
            
            
        Dog newDog = new Dog(dogName,dogFriendlyBool);
        
        zooList.Add(newDog);

    }

    public void AddCat(List<ITalkable> zooList)
    {
        Console.WriteLine("Enter Cat's name:");
        string catName = Console.ReadLine();
        
        Console.WriteLine("How many mice has it killed? (number)");
        string catMouseKilled = Console.ReadLine().ToLower();
        int catMouseKilledNumber = 0;
        try
        {
            catMouseKilledNumber = Convert.ToInt32(catMouseKilled);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            Console.WriteLine($"Entered invalid value");

        }

        Cat newCat = new Cat(catMouseKilledNumber,catName);
        
        zooList.Add(newCat);

    }

    public string End()
    {
        return $"Ending new animal creation";
    }
}
