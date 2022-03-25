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

namespace GestionMedicament.VueGael
{
    /// <summary>
    /// Logique d'interaction pour CreerPrescriptionGael.xaml
    /// </summary>
    public partial class CreerPrescriptionGael : Window
    {
        private GstBDD gst;
        private int idMedoc;
        public CreerPrescriptionGael(GstBDD unGst, int unIdMedoc)
        {
            Gst = unGst;
            IdMedoc = unIdMedoc;

            InitializeComponent();
        }

        public GstBDD Gst { get => gst; set => gst = value; }
        public int IdMedoc { get => idMedoc; set => idMedoc = value; }

        // Au chargement, rempli les deux comboBox
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cboDosage.ItemsSource = Gst.getLstDosageGael();
            cboIndividu.ItemsSource = Gst.GetTypeIndividusYanis();
        }
        // Verifie Si tous les champs sont remplis
        //PUIS vérifie si cette prescription n'est pas attribué
        //ENFIN ajoute la prescription en base de données
        private void btnCreerPrescription_Click(object sender, RoutedEventArgs e)
        {
            if (cboDosage.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un dosage", "Erreur de sélection", MessageBoxButton.OK, MessageBoxImage.Error);
            }   
            else if (cboIndividu.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un type individu", "Erreur de sélection", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (txtPosologie.Text == "")
            {
                MessageBox.Show("Veuillez entrer une posologie", "Erreur de sélection", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                int idDosage = (cboDosage.SelectedItem as Dosage).IdDosage;
                int idIndividu = (cboIndividu.SelectedItem as TypeIndividu).IdType;
                if (gst.VerifPrescription(idIndividu, idMedoc, idDosage))
                {
                    MessageBox.Show("Cette prescription est déjà attribué", "Erreur de sélection", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    Gst.addPrescriptionGael(idMedoc, idIndividu, idDosage, txtPosologie.Text);
                    GstMedicamentGael gstMedoc = new GstMedicamentGael(Gst);
                    gstMedoc.Show();
                    Close();
                }
            }
        }
        // envoi vers la page gstIndividu
        private void linkGstIdv_Click(object sender, RoutedEventArgs e)
        {
            GstIndividuYanis gstIndividu = new GstIndividuYanis(Gst);
            gstIndividu.Show();
            Close();
        }
        // envoi vers la page gstIndividu
        private void linkgstMedoc_Click(object sender, RoutedEventArgs e)
        {
            GstMedicamentGael gstMedoc = new GstMedicamentGael(Gst);
            gstMedoc.Show();
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
