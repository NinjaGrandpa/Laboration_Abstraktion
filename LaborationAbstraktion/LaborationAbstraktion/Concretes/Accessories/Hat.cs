using LaborationAbstraktion.Abstracts;
using LaborationAbstraktion.Interfaces.Accessories;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaborationAbstraktion.Concretes.Accessories
{
    class Hat : Accessory, IReaction, IUsage
    {
        public void Reaction()
        {
            Console.WriteLine("Such a fancy hat! I wonder if he owns alot of money!");
        }

        public void Usage()
        {
            Console.WriteLine("Put it on your head to look fancy!");
        }
    }
}
