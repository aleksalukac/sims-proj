using Hospital.Model;
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

namespace Hospital.Pages
{
    /// <summary>
    /// Interaction logic for SupplyProfilePage.xaml
    /// </summary>
    public partial class SupplyProfilePage : Page
    {
        public SupplyProfilePage(SupplyView supply)
        {
            InitializeComponent();

            nameTextBox.Text = supply.Type;
            idLabel.Content = supply.Id;
            countTextBox.Text = supply.Count.ToString();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            SupplyView newSupply = null;
            foreach (var supply in ResourcePage.SupplyList)
            {
                if (supply.Id == Int32.Parse(idLabel.Content.ToString()))
                {
                    newSupply = supply;
                    break;
                }
            }
            newSupply.Type = nameTextBox.Text;
            newSupply.Count = Int32.Parse(countTextBox.Text);
            var page = new Page();
            NavigationService.Navigate(page);
        }
    }
}
