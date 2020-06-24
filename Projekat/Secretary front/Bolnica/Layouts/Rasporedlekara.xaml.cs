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
    /// Interaction logic for Rasporedlekara.xaml
    /// </summary>
    public partial class Rasporedlekara : Page
    {
        public List<Termin> myTermin { get; set; }
        
        public Rasporedlekara()
        {
           
            InitializeComponent();
            myTermin =new List<Termin>() ;
           
        }
        private void Tutorijal(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Tutorijal());
          
        }

        private void Profil(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.Parent.Navigate(new Profil());
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

        private void podaci_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void comboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {



            if (comboBox2.SelectedItem == "Darko Gajic") {
                podaci.Items.Clear();
                Termin termin1 = new Termin();
                termin1.Datum = "31.05.2020.";
                termin1.Vreme = "12:00";
                termin1.ImePrezime = "Milica Savić";
                termin1.ImePrezimeLekara = comboBox2.SelectedItem.ToString();
                termin1.Sala = "P101";
                termin1.Specijalnost = comboBox1.SelectedItem.ToString();

                Termin termin2 = new Termin();
                termin2.Datum = "31.05.2020.";
                termin2.Vreme = "12:30";
                termin2.ImePrezime = "";
                termin2.ImePrezimeLekara = comboBox2.SelectedItem.ToString();
                termin2.Sala = "";
                termin2.Specijalnost = comboBox1.SelectedItem.ToString();

                Termin termin3 = new Termin();
                termin3.Datum = "31.05.2020.";
                termin3.Vreme = "12:30";
                termin3.ImePrezime = "";
                termin3.ImePrezimeLekara = comboBox2.SelectedItem.ToString();
                termin3.Sala = "";
                termin3.Specijalnost = comboBox1.SelectedItem.ToString();

                Termin termin4 = new Termin();
                termin4.Datum = "31.05.2020.";
                termin4.Vreme = "14:30";
                termin4.ImePrezime = "Savo Ilic";
                termin4.ImePrezimeLekara = comboBox2.SelectedItem.ToString();
                termin4.Sala = "P201";
                termin4.Specijalnost = comboBox1.SelectedItem.ToString();





                podaci.Items.Add(termin1);
                podaci.Items.Add(termin2);
                podaci.Items.Add(termin3);
                podaci.Items.Add(termin4);




            }

            if (comboBox2.SelectedItem == "Jelena Ravanic")
            {
                podaci.Items.Clear();
                myTermin = new List<Termin>();
                Termin termin1 = new Termin();
                termin1.Datum = "31.05.2020.";
                termin1.Vreme = "08:00";
                termin1.ImePrezime = "Milica Savić";
                termin1.ImePrezimeLekara = comboBox2.SelectedItem.ToString();
                termin1.Sala = "P201";
                termin1.Specijalnost = comboBox1.SelectedItem.ToString();

                Termin termin2 = new Termin();
                termin2.Datum = "31.05.2020.";
                termin2.Vreme = "09:30";
                termin2.ImePrezime = "";
                termin2.ImePrezimeLekara = comboBox2.SelectedItem.ToString();
                termin2.Sala = "";
                termin2.Specijalnost = comboBox1.SelectedItem.ToString();

                Termin termin3 = new Termin();
                termin3.Datum = "31.05.2020.";
                termin3.Vreme = "10:30";
                termin3.ImePrezime = "";
                termin3.ImePrezimeLekara = comboBox2.SelectedItem.ToString();
                termin3.Sala = "";
                termin3.Specijalnost = comboBox1.SelectedItem.ToString();

                Termin termin4 = new Termin();
                termin4.Datum = "31.05.2020.";
                termin4.Vreme = "11:00";
                termin4.ImePrezime = "Milos Tadic";
                termin4.ImePrezimeLekara = comboBox2.SelectedItem.ToString();
                termin4.Sala = "P201";
                termin4.Specijalnost = comboBox1.SelectedItem.ToString();


                podaci.Items.Add(termin1);
                podaci.Items.Add(termin2);
                podaci.Items.Add(termin3);
                podaci.Items.Add(termin4);
               
            }

            
        }
    }
}
