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
using System.IO.Ports;

namespace WpfTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Reserveer plaats voor een verwijzing naar een object van de klasse SerialPort
        // en maak het object aan.
        SerialPort serialPort = new SerialPort();
        public MainWindow()
        {
            // Mijn commentaar....
            InitializeComponent();
        }
    }
}
