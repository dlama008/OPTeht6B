using System;

namespace OPTeht6B
{
    class Program
    {
        static void Main(string[] args)
        {
            int kantaluku, eksponentti;
            Console.Write("Anna kantaluku:");
            string annettuArvo = Console.ReadLine();
            while (!Int32.TryParse(annettuArvo, out kantaluku))
            {
                Console.Write("Väärä tyyppi, yritä uudelleen: ");
                annettuArvo = Console.ReadLine();
            }
            Console.Write("Anna eksponentti:");
            annettuArvo = Console.ReadLine();
            while (!Int32.TryParse(annettuArvo, out eksponentti))
            {
                Console.Write("Väärä tyyppi, yritä uudelleen: ");
                annettuArvo = Console.ReadLine();
            }
            //Metodin kutsu:
            int tulos = KorotaPotenssiin(kantaluku, eksponentti);
            Console.WriteLine("Vastaus: {0}", tulos) ;
            Console.WriteLine("Luku {0} potenssiin {1} = {2}", kantaluku, eksponentti, tulos);

        }
        //Määrittely
        private static int KorotaPotenssiin(int kanta, int ekspo)
        {
            int vastaus = 1;
            for(int i = 1; i <=ekspo; i++)
            {
                vastaus = vastaus * kanta;
            }
            return vastaus;

        }
        
        
    }
}
