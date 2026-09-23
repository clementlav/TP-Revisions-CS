using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MonDomaine.DLL
{
    public class Dresseur
    {
        #region Champs Privés

        private string nom = "inconnu";

        //private int nbDeVictoire = 0;

        //private int ndDeDefaite = 0;

        //private Type faiblesse = Type.Inconnu;

        private int puissance = 0;

        private List<Pokemon> monEquipe = new List<Pokemon>();

        private bool isContent;



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

        public Dresseur(string nom, int puissance)
        {
            this.nom = nom;
            this.puissance = puissance;
        }

        public Dresseur(string nom, int puissance, List<Pokemon> monEquipe)
        {
            this.nom = nom;
            this.puissance = puissance;
            this.monEquipe = monEquipe;
        }

        #endregion


        #region Méthodes
        //public void AddPokemon(Pokemon Pokemon)
        //{
        //    monEquipe.Add(Pokemon);
        //}

        //public void RemovePokemon(Pokemon Pokemon)
        //{
        //    monEquipe.Remove(Pokemon);
        //}

        //public void setFaiblesse(Type type)
        //{
        //    faiblesse = type;
        //}

        //public void removeFaiblesse(Type Type)
        //{
        //    faiblesse = Type.Inconnu;
        //}

        public void GetEquipe()
        {
            List<Pokemon> monEquipeDoublons = new List<Pokemon>();
            foreach (Pokemon pokemon in monEquipe)
            {
                monEquipeDoublons.Add(pokemon);
            }
            Console.WriteLine("Voici les Pokemons dans votre équipe : ");
            foreach (Pokemon Pokemon in monEquipeDoublons)
            {
                Console.WriteLine("- " + Pokemon.Nom );
            }

        }

        public void AttraperPokemon(Pokemon Pokemon)
        {

            List<Pokemon> pokemonCapture = new List<Pokemon>();
            string messageException = "";

            if (monEquipe.Contains(Pokemon))
            {
                this.isContent = false;
                messageException += "\nLe Pokemon " + Pokemon.nom + " est déja dans l'équipe !!!";
            }

            if (messageException != "")
            {
                Exception PokemonException = new Exception(messageException);
                PokemonException.Data["doublon"] = Pokemon.Nom;
                throw PokemonException;
            }


            if (this.puissance < Pokemon.niveau)
            {
                this.isContent = false;
                messageException += "\nAttention le Pokemon " + Pokemon.nom + " va vous écraser !!! (il te manque : " + (Pokemon.niveau -= this.puissance) + " niveau(x) pour le battre)";
            }
            if (messageException != "")
            {
                Exception PokemonException = new Exception(messageException);
                PokemonException.Data["ecraseur"] = Pokemon.Nom;
                PokemonException.Data["niveau"] = Pokemon.Niveau;
                throw PokemonException;
            }
            if (this.puissance >= Pokemon.niveau)
            {
                monEquipe.Add(Pokemon);
                Console.WriteLine("Le Pokemon " + Pokemon.Nom + " à rejoint votre équipe.");
            }
        }

        public void RelacherPokemon(Pokemon Pokemon)
        {

            List<Pokemon> pokemonCapture = new List<Pokemon>();
            string messageException = "";

            if (!monEquipe.Contains(Pokemon))
            {
                this.isContent = false;
                messageException += "\nLe Pokemon " + Pokemon.nom + " est déja dans l'équipe !!!";
            }

            if (messageException != "")
            {
                Exception PokemonException = new Exception(messageException);
                PokemonException.Data["doublon"] = Pokemon.Nom;
                throw PokemonException;
            }
            if (monEquipe.Contains(Pokemon))
            {
                monEquipe.Remove(Pokemon);
                Console.WriteLine("Le Pokemon " + Pokemon.Nom + " à rejoint votre équipe.");
            }
        }
        #endregion


        #region Méthodes Redéfinies
        public override string ToString()
                {
                     return $"Nom : {nom} | Puissance : {puissance} | Équipe : {string.Join(", ", monEquipe)}";
                }

        #endregion
    }
    }

