using LaborationAbstraktion.Abstracts;
using LaborationAbstraktion.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaborationAbstraktion.Concretes
{
    class Bird : Animal, IEat, IMove
    {
        public void Eat()
        {
            Console.WriteLine("Bird is pecking the ground for food!");
        }

        public void Move()
        {
            Console.WriteLine("Bird is soaring trough the sky!");
        }
    }
}
