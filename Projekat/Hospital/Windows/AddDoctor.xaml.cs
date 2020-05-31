using Hospital.Model;
using Hospital.Pages;
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

namespace Hospital.Windows
{
    /// <summary>
    /// Interaction logic for AddDoctor.xaml
    /// </summary>
    public partial class AddDoctor : Window
    {
        public AddDoctor(int id)
        {
            InitializeComponent();
            idLabel.Content = (id + 1).ToString();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            Zaposlen lekar = new Zaposlen();
            lekar.Ime = this.imeTextBox.Text;
            lekar.Prezime = this.prezimeTextBox.Text;
            lekar.Id = Int32.Parse(idLabel.Content.ToString());
            //Hospital.Pages.ZaposleniPage.AddDoctor(lekar);
        }
    }
}
