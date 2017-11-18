//==================================
//
// ------====== Auteurs ======------
//      Barbey Guillaume
//      Rausis Justin
//
// ---=== Version ===---
//      1.05
//
// ---=== Ajouts ===--
//      Ajout du struct Groupe
//      pour la relation Personne - Groupe
//      boucle de test pour remplissage d'un groupe
//==================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace M306Project
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Structure permettant de stocker plusieurs personnes dans plusieurs groupes
        /// </summary>
        struct Groupe
        {
            public Personne[] GrpPersonne;
        }


        public MainWindow()
        {
            InitializeComponent();
            Groupe grp;
            grp.GrpPersonne = new Personne[10];
            for (int i = 0; i < 10; i++)
            {
                Personne pers;
                pers = new Personne();
                pers.AgePersonne = i+1;
                grp.GrpPersonne[i] = pers;
            }
        }
    }
}
