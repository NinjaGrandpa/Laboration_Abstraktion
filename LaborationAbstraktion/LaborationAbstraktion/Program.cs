using LaborationAbstraktion.Abstracts;
using LaborationAbstraktion.Concretes;
using LaborationAbstraktion.Concretes.Accessories;
using System;
using System.Collections.Generic;

namespace LaborationAbstraktion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Accessory> accessories = new List<Accessory>();
            List<Animal> animals = new List<Animal>();

            var leatherGloves = new Gloves();
            leatherGloves.Color = "Brown";
            leatherGloves.Cost = 135;

            var tophat = new Hat();
            tophat.Color = "Black";
            tophat.Cost = 255;

            var rolex = new Watch();
            rolex.Color = "Gold";
            rolex.Cost = 433000;

            var polly = new Bird();
            polly.Color = "Green";
            polly.NumberOfLimbs = 4;

            var snowball = new Cat();
            snowball.Color = "White";
            snowball.NumberOfLimbs = 4;

            var nemo = new Fish();
            nemo.Color = "Orange";
            nemo.NumberOfLimbs = 0;

            foreach (var accesory in accessories)
            {
                Console.WriteLine("This accessory is " + accesory.Color);
                Console.WriteLine("This accessory costs " + accesory.Cost + " SEK");
                
                
            }

            foreach (var animal in animals)
            {
                Console.WriteLine("This animal is " + animal.Color);
                Console.WriteLine("This animal has " + animal.NumberOfLimbs + " number of limbs");


            }
        }
    }
}
