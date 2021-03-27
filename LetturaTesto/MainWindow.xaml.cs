﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace LetturaTesto
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string fileName;
        string testo;
        int caratteri;

        public MainWindow()
        {
            InitializeComponent();

            fileName = "Data.txt";

            CalcolaCaratteri(fileName);
        }

        private async void CalcolaCaratteri(string name)
        {
            await Task.Run(() =>
            {
                using (StreamReader file = new StreamReader(name))
                {
                    testo = File.ReadAllText(name);
                }

                caratteri = testo.Length;
            });

        }
    }
}
