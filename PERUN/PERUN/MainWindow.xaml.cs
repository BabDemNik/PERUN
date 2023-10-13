using PERUN.DataBase;
using PERUN.WinApp;
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
    {   Entitie entities = new Entitie();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTNLog_Click(object sender, RoutedEventArgs e)
        {
            var loginPassUser = entities.User
                .Where(i => i.Login == TBLog.Text && i.Password == TBPass.Text)
                .ToList();

            if (loginPassUser.Count > 0) 
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
