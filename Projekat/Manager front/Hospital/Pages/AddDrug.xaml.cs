﻿using Hospital.Model;
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
    /// Interaction logic for AddDrug.xaml
    /// </summary>
    public partial class AddDrug : Page
    {
        public AddDrug(int id)
        {
            InitializeComponent();
            listView.ItemsSource = DrugPage.drugList;
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}