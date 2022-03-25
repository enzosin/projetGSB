using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using GstBdd;
using GestionMedicament.VueGael;
using ClassMetier;

namespace GestionMedicament.VueYanis
{
    /// <summary>
    /// Logique d'interaction pour Perturbateur.xaml
    /// </summary>
    public partial class Perturbateur : Window
    {
        private GstBDD gst;
        public Perturbateur(GstBDD unGst)
        {
            Gst = unGst;

            InitializeComponent();
        }
        public GstBDD Gst { get => gst; set => gst = value; }

        // Ajoute un médicament perturbateur à un médicament
        //actualsie les listes
        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            if (lstMedoc.SelectedItem != null)
            {
                if (lstMedocNonPer.SelectedItem != null)
                {
                    gst.InsertMedicamentPertubateur((lstMedocNonPer.SelectedItem as Medicament).IdMedicament, (lstMedoc.SelectedItem as Medicament).IdMedicament);
                }
            }
            lstMedicPertub.ItemsSource = gst.GetMedicamentPertubateurYanis((lstMedoc.SelectedItem as Medicament).IdMedicament);
            lstMedocNonPer.ItemsSource = gst.GetMedicamentNonPertubateurYanis((lstMedoc.SelectedItem as Medicament).IdMedicament);
        }

        // rempli les listes selon le médicament sélectionné
        private void lstMedoc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstMedoc.SelectedItem != null)
            {
                lstMedicPertub.ItemsSource = gst.GetMedicamentPertubateurYanis((lstMedoc.SelectedItem as Medicament).IdMedicament);
                lstMedocNonPer.ItemsSource = gst.GetMedicamentNonPertubateurYanis((lstMedoc.SelectedItem as Medicament).IdMedicament);
            }
        }

        // Au chargement rempli la liste de médicament
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gst = new GstBDD();
            lstMedoc.ItemsSource = gst.getLstMedicamentGael();
        }

        // Envoi vers la apge gstIndividu
        private void linkGstIdv_Click(object sender, RoutedEventArgs e)
        {
            GstIndividuYanis gstIndividu = new GstIndividuYanis(Gst);
            gstIndividu.Show();
            Close();
        }

        // Envoi vers la page gstMedicament
        private void linkgstMedoc_Click(object sender, RoutedEventArgs e)
        {
            GstMedicamentGael gstMedoc = new GstMedicamentGael(Gst);
            gstMedoc.Show();
            Close();
        }

        //Envoie vers la page graphique
        private void Graphiques_Click(object sender, RoutedEventArgs e)
        {
            PageGraphique frm = new PageGraphique();
            frm.Show();
            this.Close();
        }
    }
}

