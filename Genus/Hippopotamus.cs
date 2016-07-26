using System;

namespace Zoolandia
{
    public class Hippopotamus : Animal, ISeaCreatures
    {
        public string BlowBubbles(int numOfBubbles)
        {
            return numOfBubbles + " bubbles!!!!";
        }
        public bool HasGills()
        {
            return false;
        }
        public Hippopotamus()
        {
        this.Genus = "Hippopotamus";
        this.CommonName = "Hippo";
        }

        public override string MakeANoise()
        {
        return "FOOSH " + "genus: " + Genus;
        }
        
    }

}