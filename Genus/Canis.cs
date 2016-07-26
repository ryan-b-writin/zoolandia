using System;

namespace Zoolandia
{
    public class Canis : Animal
    {
        public Canis()
        {
        this.Genus = "Canis";
        }

        public override string MakeANoise()
        {
        return "woof "+ "genus: " + Genus;
        }
        
    }

}