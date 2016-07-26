using System;
using Zoolandia.Species; 

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
          MantaBirostris Manta = new MantaBirostris();
          DasypusNovemcinctus Armadillo = new DasypusNovemcinctus();
          ErinaceusConcolor Hedgehog = new ErinaceusConcolor();
          HippopotamusAmphibius Hippo = new HippopotamusAmphibius();

          Manta.Name = "hello";

          Console.WriteLine("The manta says:" + Manta.WriteNovel()+ " If you feed one, it says: " + Manta.Eat(2));
          Console.WriteLine("The armadillo says:" + Armadillo.Leprosy()+ " If you feed one, it says: " + Armadillo.Eat(2));
          Console.WriteLine("The hedgehog says:" + Hedgehog.GetRings()+ " If you feed one, it says: " + Hedgehog.Eat(2));
          Console.WriteLine("The hippo says:" + Hippo.Bite()+ " If you feed one, it says: " + Hippo.Eat(2));

          Console.WriteLine("Hippo's name: " + Hippo.Name + " Manta's name: " + Manta.Name );
          Console.WriteLine("Hedgehog's name: " + Hedgehog.Name + " Armadillo's name: " + Armadillo.Name);

          Console.WriteLine(Armadillo.MakeANoise());
          Console.WriteLine("Hedgehog noise!! " + Hedgehog.MakeANoise());

          
        }
    }
}
