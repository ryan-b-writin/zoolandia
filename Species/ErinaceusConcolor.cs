using System;

namespace Zoolandia.Species
{
    public class ErinaceusConcolor : Erinaceus
    {
        public string CurlUp()
        {
            return "I'm in a ball now & you can't bother me";
        }
        public string GetRings()
        {
            return "If I can get 100 rings, I get an extra life!";
        }
        public override string Eat(int numberOfFoods)
        {
            string animalEat = base.Eat(3);
            return animalEat + " chili dogs...";
        }
        public ErinaceusConcolor()
        {
            this.Name = "Jeff";
        }
        public override string MakeANoise()
        {
            return this.Name + base.MakeANoise();
        }
    }
}