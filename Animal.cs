using System;

namespace Zoolandia
{
    public class Animal
    {
        public string Name {get; set;}

        public string Saxophone(){
            return "careless whispers...";
        }
        public virtual string Eat(int numberOfFood)
        {
            return "nom";
        }
    }

}