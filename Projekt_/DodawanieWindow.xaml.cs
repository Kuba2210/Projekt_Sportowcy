﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Projekt
{
    /// <summary>
    /// Logika interakcji dla klasy DodawanieWindow.xaml
    /// </summary>
    public partial class DodawanieWindow : Window
    {
        private MainWindow MainWindow;
        public DodawanieWindow(MainWindow window)
        {
            this.MainWindow = window;
            this.DataContext = this.MainWindow.EdytowanaOsoba;
            InitializeComponent();
        }

        private void ButtonZapisz_Click(object sender, RoutedEventArgs e)
        {
            this.MainWindow.dodajDoListy();
            this.Close();
        }
    }
}