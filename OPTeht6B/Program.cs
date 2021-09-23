using System;

namespace OPTeht6B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna lause: ");
            string tutkittava = Console.ReadLine();
            //Metodin kutsu:
            int tulos = LaskeVL(tutkittava);
            string yksMoni = tulos == 1 ? "kappale" : "kappaletta";
            Console.WriteLine("Välilyöntien lukumäärä lauseessa \"{0}\" on {1} {2}.", tutkittava, tulos, yksMoni);

        }
        //Määrittely
        private static int LaskeVL(string str)
        {
            int lukumaara = 0;
            string str1;
            for (int i = 0; i < str.Length; i++)
            {
                str1 = str.Substring(i, 1);
                if (str1 == " ")
                    lukumaara++;
            }
            return lukumaara;
        }
    }
}
