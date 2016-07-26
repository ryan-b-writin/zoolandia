using System;

namespace Zoolandia
{
    public class Manta : Animal, ISeaCreatures
    {
        public string BlowBubbles(int numOfBubbles)
        {
            return numOfBubbles + " bubbles!!";
        }

        public bool HasGills()
        {
            return true;
        }
        public Manta()
        {
        this.Genus = "Manta";
        this.CommonName = "Manta";
        }

        public override string MakeANoise()
        {
        return "wooosh " + "genus: " + Genus;
        }
        
    }

}