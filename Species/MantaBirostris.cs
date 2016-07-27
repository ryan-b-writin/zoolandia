using System;

namespace Zoolandia.Species
{
    public class MantaBirostris : Animal
    {
        public string Swim()
        {
            return "glub glub";
        }
        public string WriteNovel()
        {
            return "Here is my novel I wrote. I appreciate any criticism. please read it";
        }
        public override string Eat(int numberOfFoods)
        {
            string animalEat = base.Eat(3);
            return animalEat + " I'm a majestic sea creature and I just ate food";
        }
        public MantaBirostris()
        {
            this.Name = "Joan";
        }
        public override string MakeANoise()
        {
            return this.Name + base.MakeANoise();
        }
    }
}