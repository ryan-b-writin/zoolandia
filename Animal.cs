using System;

namespace Zoolandia
{
    public class Animal
    {
        public string Name {get; set;}

        public virtual string Eat(int numberOfFoodz)
        {
            return "nom";
        }
    }

}