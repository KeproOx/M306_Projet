//==================================
//
// ------====== Auteurs ======------
//      Barbey Guillaume
//
// ---=== Version ===---
//      V.1.1
//
// ---=== Ajouts ===---
//      Ajout des propriétés
//      Ajout de trois constructeurs
//      Ajout des champs de classe
//      Ajout d'une méthode
// Possibilité de créer un objet de la classe
//===================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Text.RegularExpressions;

namespace M306Project
{
    class Personne
    {
        #region Champs de classe

        private int iAgePersonne; // Contiendra l'âge de la personne
        private bool? iSexePersonne; // Contiendra le sexe de la personne, 0 est un homme, 1 une femme, et null indéfini
        private string sMetier; // Contiendra le métier de la personne
        private string sNom; // Contiendra le nom de la personne
        private string sPrenom; // Contiendra le prénom de la personne

        

        #endregion Champs de classe

        #region Constructeurs

        /// <summary>
        /// Constructeur générant une personne sans paramètres particuliers
        /// </summary>
        public Personne()
        {
            GenererParDefaut();
        }

        /// <summary>
        /// Constructeur générant une personne
        /// </summary>
        /// <param name="age">Âge de la personne</param>
        public Personne(int age)
        {
            GenererParDefaut();
            this.AgePersonne = age;
        }

        /// <summary>
        /// Constructeur générant une personne
        /// </summary>
        /// <param name="age">Âge de la personne</param>
        /// <param name="sexePersonne">Sexe de la personne, 0 = homme, 1 = femme, null = indéfini</param>
        /// <param name="metier">Métier de la personne</param>
        public Personne(int age, bool? sexePersonne, string metier)
        {
            this.AgePersonne = age;
            this.SexePersonne = sexePersonne;
            this.Metier = metier;
        }

        #endregion Constructeurs

        #region Propriétés

        /// <summary>
        /// Définit ou retourne l'âge de la personne
        /// </summary>
        public int AgePersonne
        {
            get { return iAgePersonne; }
            set
            {
                if (value > 0)
                {
                    iAgePersonne = value;
                }
                else
                {
                    iAgePersonne = 1;
                }
            }
        }

        /// <summary>
        /// Définit ou retourne le sexe de la personne : 0 = homme, femme = 1, indéfini = null
        /// </summary>
        public bool? SexePersonne
        {
            get { return iSexePersonne; }
            set
            {
                iSexePersonne = value;
            }
        }

        /// <summary>
        ///  Définit ou retourne le métier de la personne
        /// </summary>
        public string Metier
        {

            get { return sMetier; }
            set
            {
                if (value != null)
                {
                    sMetier = value;
                }
                else
                {
                    sMetier = "Indéfini";
                }

            }
        }

        /// <summary>
        /// Définit ou retourne le nom de la personne
        /// </summary>
        public string Nom
        {
            get { return sNom; }
            set
            {
                if (value != null)
                {
                    sNom = value;
                }
                else
                {
                    sNom = "Indéfini";
                }
            }
        }

        /// <summary>
        /// Définit ou retourne le nom de la personne
        /// </summary>
        public string Prenom
        {
            get { return sPrenom; }
            set
            {
                if (value != null)
                {
                    sPrenom = value;
                }
                else
                {
                    sPrenom = "Indéfini";
                }
            }
        }
        #endregion Propriétés

        #region Méthodes de classe

        /// <summary>
        /// Méthode générant les champs de classe par défaut
        /// </summary>
        private void GenererParDefaut()
        {
            this.AgePersonne = 0;
            this.SexePersonne = null;
            this.Metier = "Indéfini";
            this.Nom = "Indéfini";
            this.Prenom = "Indéfini";
        }

        /// <summary>
        /// Méthode permettant de modifier l'âge de la personne
        /// </summary>
        /// <param name="age"></param>
        public void ModifierAge(int age)
        {
            this.AgePersonne = age;
        }

        /// <summary>
        /// Méthode permettant le tri d'un tableau de personne
        /// </summary>
        /// <param name="tabPersonne">Tableau à trier</param>
        /// <returns>Retourne le tableau trié</returns>
        public Personne[] TrierPersonnes(Personne[] tabPersonne)
        {
            return tabPersonne;
        }
            #endregion Méthodes de classe
    }
}
