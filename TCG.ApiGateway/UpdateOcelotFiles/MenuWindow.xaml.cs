﻿using System;
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

namespace UpdateOcelotFiles
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void BtnRoute_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new RoutesWindow();
            newForm.Show();
            this.Close();
        }

        private void BtnEndPoint_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
