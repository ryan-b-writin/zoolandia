using System;

namespace Zoolandia.Species
{
    public class HippopotamusBehemoth : Hippopotamus
    {
        public string Spray()
        {
            return "hippopotamuses spray things and it's super gross";
        }
        public string Bite()
        {
            return "chomp i got four big teef";
        }
          public override string Eat(int numberOfFoods)
        {
            string animalEat = base.Eat(3);
            return animalEat + " I'M HUNGRY, HUNGRY!!";
        }
        public HippopotamusBehemoth()
        {
            this.Name = "Phil";
        }
        public override string MakeANoise()
        {
            return this.Name + base.MakeANoise();
        }
    }
}