using MonDomaine.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Type = MonDomaine.DLL.Type;
using Rarete = MonDomaine.DLL.Rarete;


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

            Tests.demo1_creationObjets();
            //Tests.demo2_creationObjets();
            //Tests.demo1_ToStringPokemon();
            //Tests.demo1_ToStringDresseur();
            //Tests.demo1_subitDegats();
            //Tests.demo1_attaquer();
            //Tests.demo1_lancerCombat();
            //Tests.demo1_ExceptionAttraperPokemonDoublon();
            //Tests.demo2_ExceptionAttraperPokemonEcraseur();
            //Tests.demo1_ExceptionLancerCombatAbsencePokemon();


        }
    }
}
