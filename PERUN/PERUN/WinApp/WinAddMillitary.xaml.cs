using Microsoft.Win32;
using PERUN.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
using static System.Net.Mime.MediaTypeNames;

namespace PERUN.WinApp
{
    /// <summary>
    /// Логика взаимодействия для WinAddMillitary.xaml
    /// </summary>
    public partial class WinAddMillitary : Window
    {   
        Entiti context = new Entiti();
        public WinAddMillitary()
        {
            InitializeComponent();

            CBGender.ItemsSource = context.Gend.Select(i => i.NameGender).ToList();
        }

        private void BTNAddPhoto_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            if (fileDialog.ShowDialog() == true)
            {
                //fileDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
                string fileName = fileDialog.FileName;
                Photo.Source = new BitmapImage(new Uri(fileName));
                LUrlPhoto.Content = Photo.Source;
            }
        }

        private void BTNAdd_Click(object sender, RoutedEventArgs e)
        {

            string[] fio = TBName.Text.Split(' ');

            context.Military.Add(new Military
            {
                FirstName = fio[0],
                LastNAme = fio[1],
                Patronymic = fio[2],
                Photo = LUrlPhoto.Content.ToString(),
                Age = Convert.ToInt32(TBAge.Text.ToString()),
                IDGender = 1,
                Height = Convert.ToInt32(TBHeight.Text.ToString())
            }) ;

           context.SaveChanges();
           this.Close();

            
            
        }
    }
}
