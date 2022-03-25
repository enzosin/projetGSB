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
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Definitions.Series;
using Separator = LiveCharts.Wpf.Separator;
using GstBdd;
using GestionMedicament.VueGael;
using GestionMedicament.VueYanis;
using ClassMetier;
using System.ComponentModel;
using System.Media;

namespace GestionMedicament
{
    /// <summary>
    /// Logique d'interaction pour PageGraphique.xaml
    /// </summary>
    public partial class PageGraphique : Window
    {
        public PageGraphique()
        {
            InitializeComponent();
        }
        GstBDD gst;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GstBDD gst = new GstBDD();

            /////////////////////////////// PREMIER GRAPHE ///////////////////////////////////
            
            foreach (datagraphe dt  in gst.GetDataGrapheYan())
            {
               
                PieSeries psa = new PieSeries();
                ChartValues<int> line = new ChartValues<int>();
                psa.Title = dt.NomFamille;
                line.Add(dt.IdMedicament);
               
                psa.Values = line;
                
                psa.DataLabels = true;
                monGraph2.Series.Add(psa);
            }
            monGraph2.LegendLocation = LegendLocation.Bottom;
            monGraph2.ChartLegend.Foreground = Brushes.White;

            ColumnSeries cs = new ColumnSeries();
            cs.Fill = Brushes.Red;
            ChartValues<int> lines = new ChartValues<int>();

            /////////////////////////////// SECOND GRAPHE ///////////////////////////////////

            List<string> lesNoms = new List<string>();

            foreach (DataGraphMedocPertub dga in gst.getDataGraphEnzo())
            {
                lines.Add(dga.IdMedicamentPerturbe);
                lesNoms.Add(dga.NomMedicamentEnzo1);
            }
            cs.Values = lines;
            cs.Title = "Nombres de medicament : ";

            Axis axe = new Axis();
            axe.Labels = lesNoms;
           
            grapheEnzo.AxisX.Add(axe);
            grapheEnzo.Series.Add(cs); 
            grapheEnzo.ChartLegend.Foreground = Brushes.White;


            /////////////////////////////// DERNIER GRAPHE ///////////////////////////////////

            foreach (GraphTypePersonne tp in gst.GetGraphTypePersonnes())
            {

                RowSeries rs = new RowSeries();
                ChartValues<int> line = new ChartValues<int>();

                rs.Title = tp.LibelleTypeIndividu;
                rs.Foreground = Brushes.White;
                line.Add(tp.NbTypeIndivu);
       
                rs.Values = line;

                rs.DataLabels = true;
                typePersonneGraph.Series.Add(rs);

            }
            typePersonneGraph.LegendLocation = LegendLocation.Bottom;
            typePersonneGraph.ChartLegend.Foreground = Brushes.White;

        }
        private void linkgstMedoc_Click(object sender, RoutedEventArgs e)
        {
            gst = new GstBDD();

            GstMedicamentGael gstMedoc = new GstMedicamentGael(gst);
            gstMedoc.Show();
            Close();
        }

        private void linkGstIdv_Click(object sender, RoutedEventArgs e)
        {
            GstIndividuYanis gstIndividu = new GstIndividuYanis(gst);
            gstIndividu.Show();
            Close();
        }

        
    }
}
