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

namespace Game_of_thrones.Prozori
{
    /// <summary>
    /// Interaction logic for DodavanjeProzor.xaml
    /// </summary>
    public partial class DodavanjeProzor : Window
    {
        public DodavanjeProzor()
        {
            InitializeComponent();
        }

        private void buttonIzadji_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonDodaj_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
