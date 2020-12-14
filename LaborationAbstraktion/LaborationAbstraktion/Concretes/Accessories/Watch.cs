using LaborationAbstraktion.Abstracts;
using LaborationAbstraktion.Interfaces.Accessories;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaborationAbstraktion.Concretes.Accessories
{
    class Watch : Accessory, IReaction, IUsage
    {
        public void Reaction()
        {
            Console.WriteLine("Well that person will always be on time!");
        }

        public void Usage()
        {
            Console.WriteLine("Look upon to clock to discern the time!");
        }
    }
}
