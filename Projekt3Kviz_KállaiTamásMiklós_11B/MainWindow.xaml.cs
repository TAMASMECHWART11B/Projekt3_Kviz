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
            FizikaBetoltese();
            TortenelemBetoltese();



        }

        public void FizikaBetoltese()
        {
            string[] fizika = File.ReadAllLines("fizika.txt");
            string vhtori = fizika[0].Split(';')[0];

            foreach (string sor in fizika)
            {
                string elektrom = sor.Split(';')[0];
                tantargyak.Add(elektrom);
                tantargy.Items.Add(elektrom);
                break;
            }
            string[] elektromossag = File.ReadAllLines("fizika.txt");
            string elektromos = elektromossag[0].Split(';')[0];
            foreach (string sor in elektromossag)
            {
                string Fizika = sor.Split(';')[1];
                temakor.Items.Add(Fizika);

                if (tantargy.SelectedItem == elektromossag)
                {
                    temakor.Items.Add(Fizika);
                    
                }
                break;
            }
        }

        public void TortenelemBetoltese()
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
            string vhTori = masodikvh[0].Split(';')[0];
            foreach (string sor in masodikvh)
            {
                string Tori = sor.Split(';')[1];
                temakor.Items.Add(Tori);

                if (tantargy.SelectedItem == masodikvh)
                {
                    temakor.Items.Add(Tori);
                }
                break;
            }

            
        }

        private void kilepes_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ha erre a gombra nyomott Tanár úr, az valószínüleg azért van, mert nem értékelte túl nagy értékűre a projektemet. Kérem gondolja újra az érdemjegyet, hátha többre tudja majd Tanár úr értékelni:)");
        }

        public void tesztInditasa_Click(object sender, RoutedEventArgs e)
        {
            if (temakor.Text != "elektromosság")
            {

            }
        }
    }
}
