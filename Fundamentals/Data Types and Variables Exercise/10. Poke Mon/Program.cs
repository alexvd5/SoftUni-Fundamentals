using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distanceBetweenTarget = int.Parse(Console.ReadLine());
            int exhaustFactor = int.Parse(Console.ReadLine());
            int pokedTargetsCount = 0;
            int originalPokePower = pokePower;


            while (pokePower >= distanceBetweenTarget)
            {
                pokePower -= distanceBetweenTarget;
                pokedTargetsCount++;

                if (originalPokePower * 0.5 == pokePower && exhaustFactor > 0)
                {
                    pokePower /= exhaustFactor;
                }

            }

            Console.WriteLine(pokePower);
            Console.WriteLine(pokedTargetsCount);
        }
    }
}
