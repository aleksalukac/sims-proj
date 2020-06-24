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
    /// Interaction logic for Regitrovani.xaml
    /// </summary>
    public partial class Regitrovani : Page
    {
        public List<Lekar> myLekar { get; set; }
         ObservableCollection<Pacijenti2> pacijenti2 { get; set; }
        public Regitrovani()
        {
            InitializeComponent();
            


            pacijenti2= Registruj.pacijenti2;


            lvUsers.ItemsSource = pacijenti2;

            DataContext = this;

           


        }

      
        private void txtFilter_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

            var temp = new ObservableCollection<Pacijenti2>(from x in Registruj.pacijenti2 select (Pacijenti2)x.Clone());
            var filter = new ObservableCollection<Pacijenti2>();
            foreach (var resource in temp)
            {
                if (resource.Contains(txtFilter.Text.ToUpper()))
                {
                    filter.Add(resource);
                    lvUsers.ItemsSource = filter;
                }
            }
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
            MessageBoxResult result = MessageBox.Show("Da li zelite da potvrdite termin?", "Zakazivanje termina pacijentu", MessageBoxButton.YesNo, MessageBoxImage.Information);

            if (result.Equals(MessageBoxResult.Yes))
            {
                MessageBoxResult resul1 = MessageBox.Show("Uspesno zauzimanje termina pacijentu.", "Zakazivanje termina");
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