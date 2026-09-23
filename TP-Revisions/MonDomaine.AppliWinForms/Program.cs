using MonDomaine.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonDomaine.AppliWinForms
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            Dresseur max = new Dresseur("Max", 9, 8);
            Pokemon pikachu = new Pokemon("Pikachu", 10, 100, Type.Electrique, "Légendaire");

            try
            {
                max.attraperPokemon(pikachu);
            }
            catch (Exception ex)
            {
                string messageErreur = ex.Message;

                if (ex.Data.Count > 0)
                {
                    List<Pokemon> lesPokemonTrouvees = (List<Pokemon>)ex.Data["dupliquer"];

                    messageErreur = ex.Message + "\n" + lesPokemonTrouvees.Count + " ingredient(s) a(ont) provoquÃ© l'allergie :\n";

                    foreach (Pokemon unPokemon in lesPokemonTrouvees)
                    {
                        messageErreur += "   - " + unPokemon.ToString() + "\n";
                    }
                }


                Console.WriteLine("Exception levÃ©e (v4) : \n" + messageErreur);
            }
        }
    }
}
