using System;

namespace Zoolandia.Species
{
    public class CanisLatrans : Canis
    {
        public string Dog()
        {
            return "yarp yarp irm a darg";
        }
        public override string Eat(int numberOfFoods)
        {
            string animalEat = base.Eat(3);
            return animalEat + " you are a better person now because you fed a dog.";
        }
        public CanisLatrans()
        {
            this.Name = "Norbert";
        }
        public override string MakeANoise()
        {
            return this.Name + base.MakeANoise();
        }
    }
}