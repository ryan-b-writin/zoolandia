using System;

namespace Zoolandia
{
    public class Hippopotamus : Animal
    {
        public Hippopotamus()
        {
        this.Genus = "Hippopotamus";
        }

        public override string MakeANoise()
        {
        return "FOOSH " + "genus: " + Genus;
        }
        
    }

}