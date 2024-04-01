using System;
using System.Collections.Generic;
using Assignment_B_Mobile_App.Properties;

namespace Assignment_B_Mobile_App
{
    internal class Program
    {
       private static FileOutput _outFile = new FileOutput("animals.txt");
        //private static FileInput _inFile = new FileInput("animals.txt");
        private static AnimalService _animalService = new AnimalService();
        
        public static void Main(string[] args)
        {

            List<ITalkable> zoo = new List<ITalkable>();
            /*zoo.Add(new Cat(9,"Charlie"));
            zoo.Add(new Dog("Bean",true));
            zoo.Add(new Teacher(44,"Stacy Read"));*/
            _animalService.Menu(zoo);
            


            for (int i = 0; i < zoo.Count; i++)
            {
                Console.WriteLine(zoo[i]);
            }
            
            _outFile.FileClose();
            /*_inFile.FileRead();
            _inFile.FileClose();*/
            
            FileInput inData = new FileInput("animals.txt");

            string line;
            while ((line = inData.FileReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
        
        public static void printOut(ITalkable p) {
            Console.WriteLine($"{p.GetName()} says {p.Talk()}");
            _outFile.FileWrite($"{p.GetName()}" );

        }
    }
}