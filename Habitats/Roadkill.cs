using System;
using System.Collections.Generic;

namespace Zoolandia
{
    public class Roadkill : Habitat
    {
            public Roadkill(string name) {
            this.Name = name;
            Inhabitants.Add(new Dasypus());
            Console.WriteLine(this.Name + " contains: " + Inhabitants[0].CommonName);
        }
      
    }
}