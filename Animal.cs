using System;

namespace Zoolandia
{
    public class Animal
    {
        public string Name {get; set;}
        public int Legs {get; set;}

        public string Genus {get; set;}

        public Animal()
        {

        }
        public Animal(string name)
        {
            this.Name = name;
        }
        public Animal(int legs)
        {
            this.Legs = legs;
        }
        public Animal(string name, int legs)
        {
            this.Name = name;
            this.Legs = legs;
        }
        public string Saxophone(){
            return "careless whispers...";
        }
        public virtual string Eat(int numberOfFood)
        {
            return "nom";
        }
       public virtual string MakeANoise()
       {
           return "honk";
       }
    }

}