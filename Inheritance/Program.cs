using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class


            var birb = new Bird();
            birb.WingColor = "green";
            birb.Wings = 2;
            birb.CanFly = true;
            birb.CanBeep = true;
            Console.WriteLine($"Hello! my bird's name is {birb.Name}.");
            Console.WriteLine($"His wings are {birb.WingColor}.");
            Console.WriteLine($"He can fly, that is {birb.CanFly}.");
            Console.WriteLine($"He beeps instead of honks, that is very {birb.CanBeep}!");
            Console.WriteLine("=============================================================================");
            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var lizard = new Reptiles();
            lizard.Scaly = true;
            lizard.Hostile = false;
            lizard.Diet = "bugs";
            lizard.Habitat = "dry";
            Console.WriteLine($"My lizard's name is, {lizard.Name}.");
            Console.WriteLine($"It's {lizard.Scaly} that he is very scaly.");
            Console.WriteLine($"People think he is hostile, that is {lizard.Hostile}!");
            Console.WriteLine($"His diet consists of {lizard.Diet}.");
            Console.WriteLine($"He lives in a {lizard.Habitat} habitat.");
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
