using System;

namespace Zoolandia.Species
{
    public class HippoPotamusAmphibius : Animal
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
        public HippoPotamusAmphibius()
        {
            this.Name = "Pat";
        }
    }
}