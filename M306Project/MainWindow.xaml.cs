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
        Groupe grp; 


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
                int i = 0;
                grp.GrpPersonne = new List<Personne>();
                do
                {
               
                    
                    sLigne = readerFile.ReadLine();
                    if (sLigne != null)
                    {
                        Personne pers = new Personne();
                        grp.GrpPersonne.Add(pers);
                        string[] sTemp = sLigne.Split(';');
                        try
                        {
                            grp.GrpPersonne[i].Nom = sTemp[0];
                        }
                        catch (Exception)
                        {

                        }
                        try
                        {
                            grp.GrpPersonne[i].Prenom = sTemp[1];
                        }
                        catch (Exception)
                        {

                        }
                        try
                        {
                            grp.GrpPersonne[i].AgePersonne = int.Parse(sTemp[2]);
                        }
                        catch (Exception)
                        {

                        }
                        try
                        {
                            if (sTemp[3]=="h")
                            {
                                grp.GrpPersonne[i].SexePersonne = false;
                            }
                            else if (sTemp[3] =="f")
                            {
                                grp.GrpPersonne[i].SexePersonne = true;
                            }
                            else
                            {
                                grp.GrpPersonne[i].SexePersonne = null;
                            }
                            
                        }
                        catch (Exception)
                        {

                        }
                        try
                        {
                            grp.GrpPersonne[i].Metier = sTemp[4];
                        }
                        catch (Exception)
                        {

                        }
                        lstPersonnes.Items.Add(grp.GrpPersonne[i].Nom + " " + grp.GrpPersonne[i].Prenom);
                        i++;
                        
                    }
                } while (sLigne != null);
                readerFile.Close();
                lblPersTot.Content = i.ToString();
            }
            


        }

        /// <summary>
        /// Event pour le bouton "Grouper aléatoirement"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGrouper_Click(object sender, RoutedEventArgs e)
        {
            GrouperRandom();
        }

        private void btnGrouperSuite_Click(object sender, RoutedEventArgs e)
        {
            GrouperSuite();
        }

        private void GrouperSuite()
        {
            lstPersonnes.Items.Clear();
            int NbrePersonnesTot = int.Parse(lblPersTot.Content.ToString());
            int NbreGroupes = int.Parse(txtNbreGroupes.Text);
            if (NbrePersonnesTot % NbreGroupes == 0)
            {
                int idx = 0;
                int NbGrp = 1;
                lstPersonnes.Items.Add("Groupe " + NbGrp.ToString());
                foreach (Personne pers in grp.GrpPersonne)
                {
                    idx++;

                    if (idx <= NbrePersonnesTot / NbreGroupes)
                    {
                        lstPersonnes.Items.Add(pers.Nom + pers.Prenom);
                    }
                    else
                    {
                        NbGrp++;
                        lstPersonnes.Items.Add("Groupe " + NbGrp.ToString());
                        idx = 1;
                        lstPersonnes.Items.Add(pers.Nom + pers.Prenom);
                    }

                }
            }
            else
            {
                //recherche du nombre qui ferait modulo le plus proche
                bool ModuloPasCorrect = true;
                int iNbrePersonneTrop = 0;
                int iNbrePersonneCorrect = 0;
                while (ModuloPasCorrect)
                {
                    NbrePersonnesTot--;
                    iNbrePersonneTrop++;
                    if (NbrePersonnesTot % NbreGroupes == 0)
                    {
                        ModuloPasCorrect = false;
                        iNbrePersonneCorrect = NbrePersonnesTot;
                    }
                }
                int idx = 1;
                int NbGrp = 1;
                lstPersonnes.Items.Add("Groupe " + NbGrp.ToString());
                foreach (Personne pers in grp.GrpPersonne)
                {

                    if (idx < iNbrePersonneCorrect)
                    {
                        if (idx <= NbrePersonnesTot / NbreGroupes)
                        {
                            lstPersonnes.Items.Add(pers.Nom + pers.Prenom);
                            idx++;
                        }
                        else
                        {
                            NbGrp++;
                            lstPersonnes.Items.Add("Groupe " + NbGrp.ToString());
                            idx = 1;
                            lstPersonnes.Items.Add(pers.Nom + pers.Prenom);
                        }
                    }
                    else
                    {

                    }

                }
                //Affectation normale des personnes en se basant sur le nombre correct
            }
        }

        private void GrouperRandom()
        {
            lstPersonnes.Items.Clear();
            int idx = 0;
            Random rnd = new Random();
            //remplissage du tableau random
            List<Personne> persList = new List<Personne>();
            idx = 0;
            int NbrePersonnesTot = int.Parse(lblPersTot.Content.ToString());
            int NbreGroupes = int.Parse(txtNbreGroupes.Text);
            if (NbrePersonnesTot % NbreGroupes == 0)
            {
                List<int> iAncienRnd = new List<int>();
                int NbGrp = 1;
                lstPersonnes.Items.Add("Groupe " + NbGrp.ToString());
                while (persList.Count < grp.GrpPersonne.Count)
                {
                    int irnd = rnd.Next(grp.GrpPersonne.Count);
                    if (!iAncienRnd.Contains(irnd))
                    {
                        persList.Add(grp.GrpPersonne[irnd]);
                        iAncienRnd.Add(irnd);
                    }
                }
                idx = 1;
                foreach (Personne pers in persList)
                {
                    

                    if (idx <= NbrePersonnesTot / NbreGroupes)
                    {
                        lstPersonnes.Items.Add(pers.Nom + pers.Prenom);
                        idx++;
                    }
                    else
                    {
                        NbGrp++;
                        lstPersonnes.Items.Add("Groupe " + NbGrp.ToString());
                        idx = 1;
                        lstPersonnes.Items.Add(pers.Nom + pers.Prenom);
                    }
                }
            }
            else
            {
                //recherche du nombre qui ferait modulo le plus proche
                bool ModuloPasCorrect = true;
                int iNbrePersonneTrop = 0;
                int iNbrePersonneCorrect = 0;
                while (ModuloPasCorrect)
                {
                    NbrePersonnesTot--;
                    iNbrePersonneTrop++;
                    if (NbrePersonnesTot % NbreGroupes == 0)
                    {
                        ModuloPasCorrect = false;
                        iNbrePersonneCorrect = NbrePersonnesTot;
                    }
                }
                idx = 1;
                int NbGrp = 1;
                int iAncienRnd = 0;
                lstPersonnes.Items.Add("Groupe " + NbGrp.ToString());
                //Affectation normale des personnes en se basant sur le nombre correct
            }
        }
    }
}

