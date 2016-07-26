using System;

namespace Zoolandia
{
    public class Canis : Animal, IDomesticPets
    {
        public Canis()
        {
        this.Genus = "Canis";
        }

        public string BegForTreat(int numOfTreats)
        {
            return "oh thank you for these " + numOfTreats + " wonderful treats human!!";
        }

        public bool WearsACollar()
        {
            return true;
        }
        public override string MakeANoise()
        {
        return "woof "+ "genus: " + Genus;
        }
        
    }

}