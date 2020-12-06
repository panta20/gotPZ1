using System;
using System.Collections.Generic;
using Game_of_thrones.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Game_of_thrones.Prozori;

namespace Game_of_thrones
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public BindingList<Lik> Likovi
        {
            get; set;
        }
        public object Dodavanje { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            Likovi = new BindingList<Lik>();
            Likovi.Add(new Lik("Ned", "Stark", "Najjaci lik ikada. REALNO.", new DateTime(1996, 3, 30), 1, "nedStark.jpg"));
            //dataGridLikovi.ItemsSource = likovi;
            DataContext = this;
        }

        private void buttonIzmeni_Click(object sender, RoutedEventArgs e)
        {
            IzmenaProzor prozor1 = new IzmenaProzor();
            prozor1.ShowDialog();
        }

        private void buttonObrisi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonDetalji_Click(object sender, RoutedEventArgs e)
        {
            PregledProzor prozor2 = new PregledProzor();
            prozor2.ShowDialog();
        }

        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            DodavanjeProzor prozor3 = new DodavanjeProzor();
            prozor3.ShowDialog();
        }
    }
}
