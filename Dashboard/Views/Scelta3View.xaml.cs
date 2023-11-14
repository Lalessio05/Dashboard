using Dashboard.ViewModels;
using Microsoft.Win32;
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

namespace Dashboard.Views
{
    /// <summary>
    /// Logica di interazione per Scelta3View.xaml
    /// </summary>
    public partial class Scelta3View : UserControl
    {
        public Scelta3View()
        {
            InitializeComponent();
            DataContext = new Scelta3ViewModel();
        }
        private void ShowFilesDialog(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new();
            openFileDialog.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                Immagine.Source = new BitmapImage(new Uri(openFileDialog.FileName)) ;
            }
        }
    }
}
