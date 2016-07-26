using System;

namespace Zoolandia
{
    public class Erinaceus : Animal, IDomesticPets, IVermin
    {
        public Erinaceus()
        {
        this.Genus = "Erinaceus";
        }
        public string Diseased(int numOfDiseases)
        {
            return "I'm down with the sickness! currently carrying " + numOfDiseases + " diseases!!"; 
        }

        public bool IsItCute()
        {
            return true;
        }
        public string BegForTreat(int numOfTreats)
        {
            return "oh thank you for these " + numOfTreats + " wonderful treats human!!";
        }

        public bool WearsACollar()
        {
            return false;
        }

        public override string MakeANoise()
        {
         return "fsssss " + "genus: " + Genus;
        }
        
    }

}