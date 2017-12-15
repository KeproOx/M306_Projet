//==================================
//
// ------====== Auteurs ======------
//      Barbey Guillaume
//      Rausis Justin
//
// ---=== Version ===---
//      1.1
//
// ---=== Ajouts ===--
//      Ebauche d'interface graphique
//      avec nommage des objets
//      création des events button
//      ajout d'un opf pour lecture fichiers
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
//
using System.IO;
using Microsoft.Win32;


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
                grp.GrpPersonne[i] = pers;
                lstPersonnes.Items.Add(grp.GrpPersonne[i].Metier);
            }

            
        }

        /// <summary>
        /// Event pour le bouton "Ouvrir fichier texte"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenTxt_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.ShowDialog();

        }

        /// <summary>
        /// Event pour le bouton "Grouper aléatoirement"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGrouper_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
