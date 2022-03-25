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
using ClassMetier;
using GestionMedicament.VueYanis;
using GestionMedicament.VueEnzo;

namespace GestionMedicament.VueGael
{
    /// <summary>
    /// Logique d'interaction pour GstMedicamentGael.xaml
    /// </summary>
    public partial class GstMedicamentGael : Window
    {
        private GstBDD gst;
        public GstMedicamentGael(GstBDD ungst)
        {
            Gst = ungst;
            InitializeComponent();
        }
        public GstBDD Gst { get => gst; set => gst = value; }

        // Au chargement, rempli la liste et la cbo
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Gst = new GstBDD();
            lstTotalMedoc.ItemsSource = Gst.getLstMedicamentGael();
            cboFamille.ItemsSource = Gst.getLstFamilleGael();
        }

        // Vérifie si un Medicament est sélectionné
        // Puis envoi vers la Page Description
        // ENVOYER id médicament
        private void btnLinkDescription_Click(object sender, RoutedEventArgs e)
        {
            if (lstTotalMedoc.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélecctionner un medicament", "Erreur de sélection", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                int idMedoc = (lstTotalMedoc.SelectedItem as Medicament).IdMedicament;
                ModifMedicamentEnzo modifMedoc = new ModifMedicamentEnzo(Gst, idMedoc);
                modifMedoc.Show();
            }
            this.Close();
        }
        
        // Vérifier si un médicament est sélectionné
        // Puis envoi vers la page Prescription
        // ENVOYER id Medicament
        private void btnLinkPrescription_Click(object sender, RoutedEventArgs e)
        {
            if (lstTotalMedoc.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélecctionner un medicament", "Erreur de sélection", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                int idMed = (lstTotalMedoc.SelectedItem as Medicament).IdMedicament;
                CreerPrescriptionGael creerPrescription = new CreerPrescriptionGael(Gst, idMed);
                creerPrescription.Show();
                Close();
            }
            
        }
        // Vérifier si tous les champs sont rempli
        // Ajouter le médicament en base de données
        private void btnCreerMedoc_Click(object sender, RoutedEventArgs e)
        {
            if (txtNom.Text == "")
            {
                MessageBox.Show("Veuillez entrer un nom ", "Erreur de sélection", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (cboFamille.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une famille ", "Erreur de sélection", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (txtComposition.Text == "")
            {
                MessageBox.Show("Veuillez entrer une composition ", "Erreur de sélection", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (txtContreIndic.Text == "")
            {
                MessageBox.Show("Veuillez entrer une contre Indication ", "Erreur de sélection", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (txtEffet.Text == "")
            {
                MessageBox.Show("Veuillez entrer un effet ", "Erreur de sélection", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (txtPrix.Text == "")
            {
                MessageBox.Show("Veuillez entrer un prix ", "Erreur de sélection", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                string nom = txtNom.Text;
                int idFam = (cboFamille.SelectedItem as Famille).IdFamille;
                string composition = txtComposition.Text;
                string effet = txtEffet.Text;
                string contreIndic = txtContreIndic.Text;
                string unPrix = txtPrix.Text;
                double prix = Convert.ToDouble(unPrix);

                Gst.addMedicamentGael(nom, idFam, composition, effet, contreIndic, prix);
                lstTotalMedoc.ItemsSource = Gst.getLstMedicamentGael();
            }

        }
        // Envoi vers la page des médicaments perturbateurs
        private void btnLinkPerturbateur_Click(object sender, RoutedEventArgs e)
        {
            Perturbateur vuePerturbateur = new Perturbateur(Gst);
            vuePerturbateur.Show();
            Close();
        }
        // Envoi vers la page gstIndividu
        private void linkGstIdv_Click(object sender, RoutedEventArgs e)
        {
            GstIndividuYanis gstIndividu = new GstIndividuYanis(Gst);
            gstIndividu.Show();
            Close();
        }
        private void Graphiques_Click(object sender, RoutedEventArgs e)
        {
            PageGraphique frm = new PageGraphique();
            frm.Show();
            this.Close();
        }
    }
}
