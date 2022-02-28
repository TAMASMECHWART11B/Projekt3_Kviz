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

namespace Projekt3Kviz_KállaiTamásMiklós_11B
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> tantargyak = new List<string>();
        List<string> temakor = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            ToriBeolvasas();
        }

        private void ToriBeolvasas()
        {
            
        }
    }
}
