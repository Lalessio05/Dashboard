using Dashboard.ViewModels;
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
using System.Windows.Shapes;

namespace Dashboard.Views
{
    /// <summary>
    /// Logica di interazione per Scelta1View.xaml
    /// </summary>
    public partial class Scelta1View : UserControl
    {
        public Scelta1View()
        {
            InitializeComponent();
            DataContext = new Scelta1ViewModel();
        }
    }
}
