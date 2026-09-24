using MonDomaine.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = MonDomaine.DLL.Type;

namespace MonDomaine.AppliWinForms
{
    public static class Tests
    {

        /// <summary>
        /// Création des objets Dresseur et Pokemon pour réaliser les différents tests
        /// </summary>
        public static void demo1_creationObjets()
        {
            Dresseur max = new Dresseur("Max", 11);
            Dresseur lea = new Dresseur("lea", 11);
            Pokemon pikachu = new Pokemon("Pikachu", 10, 100, new List<Type> { Type.Electrique, Type.Feu }, Rarete.Legendaire, 10);
            Pokemon Df = new Pokemon("Df", 10, 100, new List<Type> { Type.Feu }, Rarete.Legendaire, 20);
            Pokemon carapuce = new Pokemon("Carapuce", 10, 100, new List<Type> { Type.Eau }, Rarete.Commun, 5);
        }

        /// <summary>
        /// Création des objets Dresseur et Pokemon, test de la methode AttraperPokemon
        /// </summary>
        public static void demo2_creationObjets()
        {
            Dresseur max = new Dresseur("Max", 11);
            Dresseur lea = new Dresseur("lea", 11);
            Pokemon pikachu = new Pokemon("Pikachu", 10, 100, new List<Type> { Type.Electrique, Type.Feu }, Rarete.Legendaire, 10);
            Pokemon Dracaufeu = new Pokemon("Dracaufeu", 10, 100, new List<Type> { Type.Feu }, Rarete.Legendaire, 20);
            Pokemon carapuce = new Pokemon("Carapuce", 10, 100, new List<Type> { Type.Eau }, Rarete.Commun, 5);
            max.AttraperPokemon(pikachu);
            lea.AttraperPokemon(carapuce);
            max.GetEquipe();
            lea.GetEquipe();
        }

        /// <summary>
        /// Affichage du ToString de la classe Pokemon
        /// </summary>
        public static void demo1_ToStringPokemon()
        {
            Pokemon pikachu = new Pokemon("Pikachu", 10, 100, new List<Type> { Type.Electrique, Type.Feu }, Rarete.Legendaire, 10);
            Console.WriteLine(pikachu.ToString());
        }

        /// <summary>
        /// Affichage du ToString de la classe Dresseur
        /// </summary>
        public static void demo1_ToStringDresseur()
        {
            Dresseur max = new Dresseur("Max", 11);
            Console.WriteLine(max.ToString());
        }

        /// <summary>
        /// Test de la méthode LancerCombat
        /// </summary>
        public static void demo1_lancerCombat()
        {
            Dresseur max = new Dresseur("Max", 11);
            Dresseur lea = new Dresseur("lea", 11);
            Pokemon pikachu = new Pokemon("Pikachu", 10, 100, new List<Type> { Type.Electrique, Type.Feu }, Rarete.Legendaire, 10);
            Pokemon carapuce = new Pokemon("Carapuce", 10, 100, new List<Type> { Type.Eau }, Rarete.Commun, 5);
            Combat combat1 = new Combat(max, lea);
            Console.WriteLine(combat1.LancerCombat(pikachu, carapuce));
        }

        /// <summary>
        /// Test de la méthode Attaque
        /// </summary>
        public static void demo1_attaquer()
        {
            Pokemon pikachu = new Pokemon("Pikachu", 10, 100, new List<Type> { Type.Electrique, Type.Feu }, Rarete.Legendaire, 10);
            Pokemon carapuce = new Pokemon("Carapuce", 10, 100, new List<Type> { Type.Eau }, Rarete.Commun, 5);
            Console.WriteLine(pikachu.Attaquer(carapuce));
        }

        /// <summary>
        /// Test de la méthode SubirDegats
        /// </summary>
        public static void demo1_subitDegats()
        {
            Pokemon pikachu = new Pokemon("Pikachu", 10, 100, new List<Type> { Type.Electrique, Type.Feu }, Rarete.Legendaire, 10);
            Console.WriteLine(pikachu.ToString());
            Console.WriteLine(pikachu.SubirDegats(10));
            Console.WriteLine(pikachu.ToString());
        }

        /// <summary>
        /// Exception de la méthode lancerCombat quand un dresseur ne posséde pas le pokémon dans son équipe
        /// </summary>
        public static void demo1_ExceptionLancerCombatAbsencePokemon()
        {
            Dresseur max = new Dresseur("Max", 11);
            Dresseur lea = new Dresseur("lea", 11);
            Pokemon pikachu = new Pokemon("Pikachu", 10, 100, new List<Type> { Type.Electrique, Type.Feu }, Rarete.Legendaire, 10);
            Pokemon carapuce = new Pokemon("Carapuce", 10, 100, new List<Type> { Type.Eau }, Rarete.Commun, 5);
            Pokemon Dracaufeu = new Pokemon("Dracaufeu", 10, 100, new List<Type> { Type.Feu }, Rarete.Legendaire, 20);
            Combat combat1 = new Combat(max, lea);
            max.AttraperPokemon(pikachu);
            lea.AttraperPokemon(carapuce);

            try
            {
                combat1.LancerCombat(pikachu, Dracaufeu);
            }
            catch (Exception ex)
            {
                string messageErreur = ex.Message;

                if (ex.Data.Count > 0)
                {
                    string lePokemonAbsent = (string)ex.Data["absence"];


                    if (lePokemonAbsent != "")
                    {
                        messageErreur = ex.Message + "\n" + lePokemonAbsent + " n'est pas dans votre Equipe !\n";
                    }
                }

                Console.WriteLine("Exception levÃ©e (v4) : \n" + messageErreur);
            }
        }

        /// <summary>
        /// Exception de la méthode AttraperPokemon quand un dresseur posséde deja le pokémon dans son équipe
        /// </summary>
        public static void demo1_ExceptionAttraperPokemonDoublon()
        {
            Pokemon pikachu = new Pokemon("Pikachu", 10, 100, new List<Type> { Type.Electrique, Type.Feu }, Rarete.Legendaire, 10);
            Dresseur max = new Dresseur("Max", 11);
            max.AttraperPokemon(pikachu);

            try
            {
                max.AttraperPokemon(pikachu);
            }
            catch (Exception ex)
            {
                string messageErreur = ex.Message;

                if (ex.Data.Count > 0)
                {
                    string leDoublonTrouvees = (string)ex.Data["doublon"];
                    string lePokemonEcraseur = (string)ex.Data["ecraseur"];

                    if (leDoublonTrouvees != "")
                    {
                        messageErreur = ex.Message + "\n" + leDoublonTrouvees + " est déjà dans votre Equipe !\n";
                    }

                    if (lePokemonEcraseur == "")
                    {
                        messageErreur = ex.Message + "\n" + lePokemonEcraseur + " vous à écraser ...\n";
                    }
                }

                Console.WriteLine("Exception levÃ©e (v4) : \n" + messageErreur);
            }
        }
            /// <summary>
            /// Exception de la méthode AttraperPokemon quand un dresseur est trop faible pour attraper le pokemon
            /// </summary>
        public static void demo2_ExceptionAttraperPokemonEcraseur()
        {
            Pokemon pikachu = new Pokemon("Pikachu", 10, 100, new List<Type> { Type.Electrique, Type.Feu }, Rarete.Legendaire, 10);
            Dresseur max = new Dresseur("Max", 8);

            try
            {
                max.AttraperPokemon(pikachu);
            }
            catch (Exception ex)
            {
                string messageErreur = ex.Message;

                if (ex.Data.Count > 0)
                {
                    string leDoublonTrouvees = (string)ex.Data["doublon"];
                    string lePokemonEcraseur = (string)ex.Data["ecraseur"];

                    if (leDoublonTrouvees != "")
                    {
                        messageErreur = ex.Message + "\n" + leDoublonTrouvees + " est déjà dans votre Equipe !\n";
                    }

                    if (lePokemonEcraseur == "")
                    {
                        messageErreur = ex.Message + "\n" + lePokemonEcraseur + " vous à écraser ...\n";
                    }
                }

                Console.WriteLine("Exception levÃ©e (v4) : \n" + messageErreur);
            }
        }
    }
}
