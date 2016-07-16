using System;
using Zoolandia.Species; 

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
          MantaBirostris Manta = new MantaBirostris();

          Manta.Name = "hello";

          Manta.ToString();
        }
    }
}
