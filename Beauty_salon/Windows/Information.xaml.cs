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
using System.Windows.Shapes;

namespace Beauty_salon.Window
{
    /// <summary>
    /// Логика взаимодействия для Information.xaml
    /// </summary>
    public partial class Information : System.Windows.Window
    {
        public Information(string message)
        {
            InitializeComponent();
            textBlockInformation.Text = message;
        }

        public void ButtonClickOk(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
