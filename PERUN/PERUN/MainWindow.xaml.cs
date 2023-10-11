﻿using PERUN.WinApp;
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

namespace PERUN
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTNLog_Click(object sender, RoutedEventArgs e)
        {
            if(TBLog.Text == "1" && TBPass.Text == "1")
            {
                StandartWindow standartWindow = new StandartWindow();
                standartWindow.Show();
                this.Close();
            }
            else
            {
                LError.Content = "*Неправильный логин или пароль";
            }
        }
    }
}
