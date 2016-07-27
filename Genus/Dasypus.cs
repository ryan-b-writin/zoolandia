using System;

namespace Zoolandia
{
    public class Dasypus : Animal, IVermin
    {
        public Dasypus()
        {
        this.Genus = "Dasypus";
        this.CommonName = "Armadillo";
        }

        public string Diseased(int numOfDiseases)
        {
            return "I'm down with the sickness! currently carrying " + numOfDiseases + " diseases!!"; 
        }

        public bool IsItCute()
        {
            return false;
        }
        public override string MakeANoise()
        {
           return "snort " + "genus: " + Genus;
        }
        
    }

}