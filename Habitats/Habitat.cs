using System;
using System.Collections.Generic;

namespace Zoolandia
{
    public class Habitat
    {
        public string Name {get; set;}
        public List<Animal> Inhabitants = new List<Animal>();
    }
}