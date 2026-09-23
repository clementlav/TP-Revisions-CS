using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MonDomaine.DLL
{
    public class Combat
    {
        public static void LancerCombat(Pokemon pokemon1, Pokemon pokemon2)
        {
            Console.WriteLine($"Combat entre {pokemon1.Nom} et {pokemon2.Nom} !");

            while (pokemon1.EstVivant() && pokemon2.EstVivant())
            {
                pokemon1.Attaquer(pokemon2);

                if (pokemon2.EstVivant())
                {
                    pokemon2.Attaquer(pokemon1);
                }
            }

            if (pokemon1.EstVivant())
            {
                Console.WriteLine($"{pokemon1.Nom} a gagné le combat !");
            }
            else
            {
                Console.WriteLine($"{pokemon2.Nom} a gagné le combat !");
            }
        }

        
    }
}
