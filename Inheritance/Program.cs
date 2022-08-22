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

            Bird Articuno = new Bird()
            {
                NumberOfLegs = 2,

                NeedsSleep = true,

                IsAlive = false,

                FoodType = "Eats Pokemon Trainers",

                FeatherColor = "has blue feathers",

                CanFly = true,

                BeakOrBill = "has beak",

                LaysEggs = false,





            };

            Console.WriteLine($" Articuno is a legendary bird who has {Articuno.NumberOfLegs} legs. Although it is {Articuno.NeedsSleep}" +
                $" he needs sleep, it is {Articuno.IsAlive} that he is alive. Articuno {Articuno.FoodType} for nourishment, and {Articuno.FeatherColor}. It is {Articuno.CanFly} that he can fly and he {Articuno.BeakOrBill}. It is {Articuno.LaysEggs} that he lays eggs ");

            Reptile Nagini = new Reptile()
            {
                NumberOfLegs = 0,

                NeedsSleep = true,

                IsAlive = false,

                FoodType = "Muggles",

                HasBackbone = true,

                IsColdBlooded = true,

                NumberofLungs = 1,

                IsPosionous = true,


            };

            Console.WriteLine($" Nagini has {Nagini.NumberOfLegs} legs because she is a snake. It is {Nagini.NeedsSleep} that she needs sleep" +
                $" but {Nagini.IsAlive} that she is alive since she was killed. Her favorite food is {Nagini.FoodType}" +
                $". It is {Nagini.HasBackbone} that she has a backbone, and {Nagini.IsColdBlooded} that she is coldblooded" +
                $". Although she only has {Nagini.NumberofLungs} lung it is {Nagini.IsPosionous} that she was extremely posionous");


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }



    }
}
