using MonDomaine.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Type = MonDomaine.DLL.Type;

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

            Dresseur max = new Dresseur("Max",11);
            Pokemon pikachu = new Pokemon("Pikachu", 10, 100, Type.Electrique, "Légendaire", 10);
            Pokemon Df = new Pokemon("Df", 10, 100, Type.Electrique, "Légendaire", 20);

            Combat.LancerCombat(pikachu, Df);
            try
            {

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
