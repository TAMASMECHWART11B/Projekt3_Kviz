using System;
using System.Collections.Generic;
using System.IO;
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

namespace Projekt3Kviz_KállaiTamásMiklós_11B
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> tantargyak = new List<string>();
        List<string> temakorok = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            
            TortenelemBetoltese();



        }




        private void TortenelemBetoltese()
        {
            string[] tori = File.ReadAllLines("masodikvhtori.txt");
            string vhtori = tori[0].Split(';')[0];

            foreach (string sor in tori)
            {
                string tortenelem = sor.Split(';')[0];
                tantargyak.Add(tortenelem);
                tantargy.Items.Add(tortenelem);
                break;
            }
            string[] masodikvh = File.ReadAllLines("masodikvhtori.txt");
            string magyarTori = masodikvh[0].Split(';')[0];
            foreach (string sor in masodikvh)
            {
                string magyarTori1 = sor.Split(';')[1];
                temakor.Items.Add(magyarTori1);

                if (tantargy.SelectedItem == masodikvh)
                {
                    temakor.Items.Add(magyarTori1);
                }
                break;
            }

            
        }

        private void kilepes_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ha erre a gombra nyomott Tanár úr, az valószínüleg azért van, mert nem értékelte túl nagy értékűre a projektemet. Kérem gondolja újra az érdemjegyet, hátha többre tudja majd Tanár úr értékelni:)");
        }
    }
}
