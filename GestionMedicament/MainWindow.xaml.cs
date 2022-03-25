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
using ClassMetier;
using GstBdd;
using GestionMedicament.VueGael;
using GestionMedicament.VueYanis;

namespace GestionMedicament
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        GstBDD gst;

        private void linkgstMedoc_Click(object sender, RoutedEventArgs e)
        {
            gst = new GstBDD();

            GstMedicamentGael gstMedoc = new GstMedicamentGael(gst);
            gstMedoc.Show();
            this.Close();
        }
        private void linkGstIdv_Click(object sender, RoutedEventArgs e)
        {
            GstIndividuYanis gstIndividu = new GstIndividuYanis(gst);
            gstIndividu.Show();
            this.Close();
        }

        private void btnGraph_Click(object sender, RoutedEventArgs e)
        {
            PageGraphique frm = new PageGraphique();
            frm.Show();
            this.Close();
        }
    }
}
