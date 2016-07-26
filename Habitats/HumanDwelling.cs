using System;
using System.Collections.Generic;

namespace Zoolandia
{
    public class HumanDwelling : Habitat
    {
        public HumanDwelling(string name) {
            this.Name = name;
            Inhabitants.Add(new Canis());
            Inhabitants.Add(new Erinaceus());
            Console.WriteLine(this.Name + " contains: " + Inhabitants[0].CommonName + ", " + Inhabitants[1].CommonName);
        }

    }
}