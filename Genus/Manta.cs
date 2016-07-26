using System;

namespace Zoolandia
{
    public class Manta : Animal
    {
        public Manta()
        {
        this.Genus = "Manta";
        }

        public override string MakeANoise()
        {
        return "wooosh " + "genus: " + Genus;
        }
        
    }

}