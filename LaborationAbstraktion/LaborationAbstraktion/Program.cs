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
            leatherGloves.Name = "Leather Gloves";
            leatherGloves.Color = "Brown";
            leatherGloves.Cost = 135;
            accessories.Add(leatherGloves);

            var tophat = new Hat();
            tophat.Name = "a Tophat";
            tophat.Color = "Black";
            tophat.Cost = 255;
            accessories.Add(tophat);

            var rolex = new Watch();
            rolex.Name = "a Rolex Watch";
            rolex.Color = "Gold";
            rolex.Cost = 433000;
            accessories.Add(rolex);

            var polly = new Bird();
            polly.Name = "Polly";
            polly.Color = "Green";
            polly.NumberOfLimbs = 4;
            animals.Add(polly);

            var snowball = new Cat();
            snowball.Name = "Snowball";
            snowball.Color = "White";
            snowball.NumberOfLimbs = 4;
            animals.Add(snowball);

            var nemo = new Fish();
            nemo.Name = "Nemo";
            nemo.Color = "Orange";
            nemo.NumberOfLimbs = 0;
            animals.Add(nemo);

            foreach (var accesory in accessories)
            {
                Console.WriteLine();
                Console.WriteLine("This accesory is " + accesory.Name);
                Console.WriteLine("This accessory is the color " + accesory.Color);
                Console.WriteLine("This accessory costs " + accesory.Cost + " SEK");

                if (accesory is Gloves gloves)
                {
                    gloves.Usage();
                    gloves.Reaction();
                }

                else if (accesory is Hat hat)
                {
                    hat.Usage();
                    hat.Reaction();
                }

                else if (accesory is Watch watch)
                {
                    watch.Usage();
                    watch.Reaction();
                }
                
            }

            foreach (var animal in animals)
            {
                Console.WriteLine();
                Console.WriteLine("This animal's name is " + animal.Name);
                Console.WriteLine("This animal is the color " + animal.Color);
                Console.WriteLine("This animal has " + animal.NumberOfLimbs + " number of limbs");

                if (animal is Bird bird)
                {
                    bird.Move();
                    bird.Eat();
                }

                else if (animal is Cat cat)
                {
                    cat.Move();
                    cat.Eat();
                }

                else if (animal is Fish fish)
                {
                    fish.Move();
                    fish.Eat();
                }
            }
        }
    }
}
