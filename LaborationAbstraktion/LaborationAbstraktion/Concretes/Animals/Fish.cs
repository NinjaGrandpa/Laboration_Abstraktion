using LaborationAbstraktion.Abstracts;
using LaborationAbstraktion.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaborationAbstraktion.Concretes
{
    class Fish : Animal, IEat, IMove
    {


        public void Eat()
        {
            Console.WriteLine("Fish is sucking in food!");
        }

        public void Move()
        {
            Console.WriteLine("Fish is swimming forward!");
        }
    }
}
