using System;
using System.Collections.Generic;

namespace Zoolandia
{
    public class Water : Habitat
    {
            public Water(string name) {
            this.Name = name;
            Inhabitants.Add(new Hippopotamus());
            Inhabitants.Add(new Manta());
            Console.WriteLine(this.Name + " contains: " + Inhabitants[0].CommonName + ", " + Inhabitants[1].CommonName);
        }
    }
}