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
        public string nom = "Inconnu";
        public int niveau = 0;
        public int pointsDeVie = 0;
        public Type type = Type.Inconnu;
        public string rarete = "Inconnu";
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
       
        public Type Type
        {
            get { return type; }
            private set { type = value; }
        }
        public string Rarete
        {
            get { return rarete; }
            private set { rarete = value; }
        }
        #endregion
        #region Constructeurs
        public Pokemon(string nom, int niveau, int pointsDeVie, Type type, string rarete)
        {
            this.nom = nom;
            this.niveau = niveau;
            this.pointsDeVie = pointsDeVie;
      
            this.type = type;
            this.rarete = rarete;
        }
        public Pokemon(string nom, int niveau, int pointsDeVie, Type type)
        {
            this.nom = nom;
            this.niveau = niveau;
            this.pointsDeVie = pointsDeVie;
            
            this.type = type;
            this.rarete = "Inconnu";
        }
        public Pokemon(string nom, int niveau, int pointsDeVie)
        {
            this.nom = nom;
            this.niveau = niveau;
            this.pointsDeVie = pointsDeVie;
            this.type = Type.Inconnu;
            this.rarete = "Inconnu";
        }
        
        public Pokemon(string nom, int niveau)
        {
            this.nom = nom;
            this.niveau = niveau;
            this.pointsDeVie = 0;
            this.type = Type.Inconnu;
            this.rarete = "Inconnu";
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
        
        
        public Type getType()
        {
            return type;
        }
        public string getRarete()
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
        
        private void setType(Type type)
        {
            this.type = type;
        }
        private void setRarete(string rarete)
        {
            this.rarete = rarete;
        }
        private void setRarete(Type rarete)
        {
            this.rarete = rarete.ToString();
        }
        #endregion
        #region Méthodes

        public void manger(Pokemon pokemon) 
        {
            pokemon.niveau += 1;
        }
        public void dormir(Pokemon pokemon)
        {
            pokemon.pointsDeVie += 10;
        }
        #endregion
    }
}
