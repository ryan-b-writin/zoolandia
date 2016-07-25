using System;

namespace Zoolandia.Species
{
    public class DasypusSabanicola : Dasypus
    {
        public string Leprosy()
        {
            return "hey pal want some leprosy??";
        }
        public string Dumb()
        {
            return "hey there I'm an armadillo I'm dumb and mean";
        }
        public override string Eat(int numberOfFoods)
        {
            string animalEat = base.Eat(3);
            return animalEat + " hey BUDDY gimmie more food";
        }
        public DasypusSabanicola()
        {
            this.Name = "Jonny";
        }
        public override string MakeANoise()
        {
            return this.Name + base.MakeANoise();
        }
    }
}