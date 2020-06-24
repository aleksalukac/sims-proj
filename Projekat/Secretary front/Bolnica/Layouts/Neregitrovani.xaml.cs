using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Bolnica.Layouts
{
    /// <summary>
    /// Interaction logic for Neregitrovani.xaml
    /// </summary>
    public partial class Neregitrovani : Page
    {
         public List<Lekar> myLekar { get; set; }

        public Neregitrovani()
        {
            InitializeComponent();


            DataContext = this;






        }

        private void Tutorijal(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Tutorijal());
            
        }

        private void Profil(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Profil());
        }

        private void Potvrdi(object sender, RoutedEventArgs e)
        {
            if ( ImePacijenta.Text.Length == 0 || PrezimePacijenta.Text.Length == 0 || BrZPacijenta.Text.Length != 11 || KontaktPacijenta.Text.Length == 0 )
            {
                MessageBox.Show("Neodgovarajući unos podataka");
                return;

            }
            MessageBoxResult result=MessageBox.Show("Da li zelite da potvrdite termin?", "Zakazivanje termina pacijentu", MessageBoxButton.YesNo, MessageBoxImage.Information);

            if (result.Equals(MessageBoxResult.Yes)) 
            {
                MessageBoxResult resul1 = MessageBox.Show("Uspesna zakazivanje termina pacijentu.", "Zakazivanje termina");
                App.ParentWindowRef.Parent.Navigate(new Profil());
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Opsta");
            comboBox1.Items.Add("Dermatologija");
            comboBox1.Items.Add("Hirurgija");
            comboBox1.Items.Add("ORL");
            comboBox1.Items.Add("Ocno");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox2.Items.Clear();
            if (comboBox1.SelectedItem == "Opsta")
            {
                comboBox2.Items.Add("Marina Marinkovic");
                comboBox2.Items.Add("Darko Gajic");
                comboBox2.Items.Add("Savo Mitrovic");
            }
            else if (comboBox1.SelectedItem == "Dermatologija")
            {
                comboBox2.Items.Add("Melinda Zdravkovic");
                comboBox2.Items.Add("Sasa Vacic");

            }
            else if (comboBox1.SelectedItem == "Hirurgija")
            {
                comboBox2.Items.Add("Jelena Ravanic");
                comboBox2.Items.Add("Aleksandar Arsic");

            }
            else if (comboBox1.SelectedItem == "Ocno")
            {
                comboBox2.Items.Add("Zaharije Trnavac");

            }
            else if (comboBox1.SelectedItem == "ORL")
            {
                comboBox2.Items.Add("Tuhomir Tatic");
                comboBox2.Items.Add("Stefan Davidovic");

            }
        }


    }
}
