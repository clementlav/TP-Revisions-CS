using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonDomaine.DLL
{
    internal class Dresseur
    {
        #region Champs Privés

        private string nom = "inconnu";

        private int nbDeVictoire = 0;

        private int ndDeDefaite = 0;

        private List<Pokemon> monEquipe = new List<Pokemon>();

        #endregion


        #region Propriétés
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        #endregion


        #region Constructeurs
        public Dresseur(string nom)
        {
            this.nom = nom;
        }

        public Dresseur(string nom, int nbDeVictoire, int ndDeDefaite)
        {
            this.nom = nom;
            this.nbDeVictoire = nbDeVictoire;
            this.ndDeDefaite = ndDeDefaite;
        }

        public Dresseur(string nom, int nbDeVictoire, int ndDeDefaite, List<Pokemon> monEquipe)
        {
            this.nom = nom;
            this.nbDeVictoire = nbDeVictoire;
            this.ndDeDefaite = ndDeDefaite;
            this.monEquipe = monEquipe;
        }

        #endregion


        #region Méthodes
        public void AddPokemon(Pokemon Pokemon)
        {
            monEquipe.Add(Pokemon);
        }

        public void RemovePokemon(Pokemon Pokemon)
        {
            monEquipe.Remove(Pokemon);
        }

        public void GetEquipe()
        {
            foreach Pokemon in monEquipe
                {
                Console.WriteLine(Pokemon.Nom);
            }

        }

        #endregion


        #region Méthodes Redéfinies

        #endregion
    }
}
