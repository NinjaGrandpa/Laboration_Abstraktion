using LaborationAbstraktion.Abstracts;
using LaborationAbstraktion.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaborationAbstraktion.Concretes
{
    class Cat : Animal, IEat, IMove
    {
        public void Eat()
        {
            Console.WriteLine("Cat is playing with it's food!");
        }

        public void Move()
        {
            Console.WriteLine("Cat is sneaking!");
        }
    }
}
