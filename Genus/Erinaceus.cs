using System;

namespace Zoolandia
{
    public class Erinaceus : Animal
    {
        public Erinaceus()
        {
        this.Genus = "Erinaceus";
        }

        public override string MakeANoise()
        {
         return "fsssss " + "genus: " + Genus;
        }
        
    }

}