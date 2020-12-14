using LaborationAbstraktion.Abstracts;
using LaborationAbstraktion.Interfaces.Accessories;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaborationAbstraktion.Concretes.Accessories
{
    class Gloves : Accessory, IReaction, IUsage
    {
        public void Reaction()
        {
            Console.WriteLine("Wow! Those hands won't be cold in the winter!");
        }

        public void Usage()
        {
            Console.WriteLine("Put them on your hands to be warm!");
        }
    }
}
