using PERUN.Pages;
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

namespace PERUN.WinApp
{
    /// <summary>
    /// Логика взаимодействия для StandartWindow.xaml
    /// </summary>
    public partial class StandartWindow : Window

    {
        private string userName; 
        public StandartWindow(string nameUSer)
        {
            InitializeComponent();
            userName = nameUSer;
            LNameUser.Content = userName;
        }

        public StandartWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LNameUser.Content = "Ghtrgt";
        }

        private void BTNExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BTNAddMilitary_Click(object sender, RoutedEventArgs e)
        {
            WinAddMillitary winAddMillitary = new WinAddMillitary();
            winAddMillitary.InitializeComponent();
            winAddMillitary.Show();
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            NavigationWindow win =  new NavigationWindow();
            win.Content = new MainPage();
            win.Show();
        }
    }
}
