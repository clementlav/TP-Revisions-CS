using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonDomaine.DLL
{
    public class Pokemon
    {
        #region Champs privés
        public string descriptionAttaque = "";
        public string nom = "Inconnu";
        public int niveau = 0;
        public int attaque = 0;
        public int pointsDeVie = 0;
        public List<Type> lesTypes = new List<Type>();
        public Rarete rarete = DLL.Rarete.Inconnue;
        private Dresseur monDresseur;   
        #endregion
        #region Propriétés
        public string Nom
        {
            get { return nom; }
            private set { nom = value; }
        }
        public int Niveau
        {
            get { return niveau; }
            private set { niveau = value; }
        }
        public int PointsDeVie
        {
            get { return pointsDeVie; }
            private set { pointsDeVie = value; }
        }
      
        
        public Dresseur MonDresseur
        {
            get { return monDresseur; }
            private set { monDresseur = value; }
        }
        #endregion
        #region Constructeurs
        public Pokemon(string nom, int niveau, int pointsDeVie, List<Type> lesTypes, Rarete rarete, int attaque)
        {
            this.nom = nom;
            this.niveau = niveau;
            this.pointsDeVie = pointsDeVie;
            this.lesTypes = lesTypes;
            this.rarete = rarete;
            this.attaque = attaque;
        }
        public Pokemon(string nom, int niveau, int pointsDeVie, List<Type> lesTypes)
        {
            this.nom = nom;
            this.niveau = niveau;
            this.pointsDeVie = pointsDeVie;
        }
        public Pokemon(string nom, int niveau, int pointsDeVie)
        {
            this.nom = nom;
            this.niveau = niveau;
            this.pointsDeVie = pointsDeVie;
            this.lesTypes = new List<Type>();
        }
        
        public Pokemon(string nom, int niveau)
        {
            this.nom = nom;
            this.niveau = niveau;
            this.pointsDeVie = 0;
        }
        public Pokemon()
        {
        }
        #endregion
        #region Accesseurs
        public string getNom()
        {
            return nom;
        }
        public int getNiveau()
        {
            return niveau;
        }
        public int getPointsDeVie()
        {
            return pointsDeVie;
        }
        
        
        public List<Type> getType()
        {
            return lesTypes;
        }
        public Rarete getRarete()
        {
            return rarete;
        }
        private void setNom(string nom)
        {
            this.nom = nom;
        }
        private void setNiveau(int niveau)
        {
            this.niveau = niveau;
        }
        private void setPointsDeVie(int pointsDeVie)
        {
            this.pointsDeVie = pointsDeVie;
        }
       
        private void setRarete(Rarete rarete)
        {
            this.rarete = rarete;
        }
        
        #endregion
        #region Méthodes

        public void manger() 
        {
            this.niveau += 1;
        }
        public void dormir()
        {
            this.pointsDeVie += 10;
        }
        public override string ToString()
        {
            return $"Nom : {nom} | Niveau : {niveau} | Point de vie : {pointsDeVie} | Type : {string.Join(", ", lesTypes)} | Rarete : {rarete}";
        }

        public string Attaquer(Pokemon defenseur)
        {
            defenseur.SubirDegats(attaque);
            return $"Le Pokémon {this.nom} attaque {defenseur.nom}";
        }

        public string SubirDegats(int degats)
        {
            pointsDeVie -= degats;
            return $"Le Pokémon {this.nom} subit {degats} dégâts";
             
        }
        public bool EstVivant()
        {
            return pointsDeVie > 0;
        }
        #endregion
    }
}
