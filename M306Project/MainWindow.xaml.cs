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
            public List<Personne> GrpPersonne;
        }


        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event pour le bouton "Ouvrir fichier texte"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenTxt_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            FileInfo fFichierTexte;
            StreamReader readerFile;
            opf.ShowDialog();

            if (opf.FileName != "")
            {
                string sLigne = "";
                fFichierTexte = new FileInfo(opf.FileName);
                readerFile = new StreamReader(fFichierTexte.FullName);
                Groupe grp;
                int i = 0;
                grp.GrpPersonne = new List<Personne>();
                do
                {
                       
                    Personne pers = new Personne();
                    grp.GrpPersonne.Add(pers);
                    sLigne = readerFile.ReadLine();
                    if (sLigne != null)
                    {
                        i++;
                        string[] sTemp = sLigne.Split(';');
                        grp.GrpPersonne[i].Nom = sTemp[i];
                        grp.GrpPersonne[i].Prenom = sTemp[i + 1];
                        
                    }
                } while (sLigne != null);
            }


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
