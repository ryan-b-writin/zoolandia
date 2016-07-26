using System;

namespace Zoolandia
{
    public class Dasypus : Animal
    {
        public Dasypus()
        {
        this.Genus = "Dasypus";
        }
        public override string MakeANoise()
        {
           return "snort " + "genus: " + Genus;
        }
        
    }

}