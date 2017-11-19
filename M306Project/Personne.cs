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

namespace M306Project
{
    class Personne
    {
        #region Champs de classe

        private int iAgePersonne; // Contiendra l'âge de la personne
        private bool? iSexePersonne; // Contiendra le sexe de la personne, 0 est un homme, 1 une femme, et null indéfini
        private string sMetier; // Contiendra le métier de la personne

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
                sMetier = value;
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
        }

        #endregion Méthodes de classe
    }
}
