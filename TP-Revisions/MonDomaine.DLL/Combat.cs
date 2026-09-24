using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MonDomaine.DLL
{
    public class Combat
    {
        private DateTime dateCombat = DateTime.Now;
        private string resultat;
        private Dresseur dresseur1;
        private Dresseur dresseur2;

        public Dresseur Dresseur1
        {
            get { return dresseur1; }
            set { dresseur1 = value; }
        }

        public Dresseur Dresseur2
        {
            get { return dresseur2; }
            set { dresseur2 = value; }
        }

        public Combat(Dresseur dresseur1, Dresseur dresseur2)
        {
            this.dresseur1 = dresseur1;
            this.dresseur2 = dresseur2;
        }
        public string LancerCombat(Pokemon pokemon1, Pokemon pokemon2)
        {
            string messageCombatException = "";

            if (!dresseur1.verifierPokemonEquipe(pokemon1))
            {
                Exception PokemonCombatException = new Exception(messageCombatException);
                PokemonCombatException.Data["absence"] = pokemon1.nom;
                throw PokemonCombatException;
            }

            if (!dresseur2.verifierPokemonEquipe(pokemon2))
            {
                Exception PokemonCombatException = new Exception(messageCombatException);
                PokemonCombatException.Data["absence"] = pokemon2.nom;
                throw PokemonCombatException;
            }

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
                resultat = $"{dresseur1.Nom} a remporter le combat avec {pokemon1.Nom} !";
            }
            else
            {
                resultat = $"{dresseur2.Nom} a remporter le combat avec {pokemon2.Nom} !";
            }
            return resultat;
        }

        
    }
}
