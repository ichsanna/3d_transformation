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
using System.Windows.Media.Media3D;

namespace _3D_Transformation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Model3DGroup objects = new Model3DGroup();
        public MainWindow()
        {
            InitializeComponent();
            initcomboboxnewshape();
        }
        private void initcomboboxnewshape()
        {
            comboboxnewshape.Items.Add("Persegi Panjang");
            comboboxnewshape.Items.Add("Bola");
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
