using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.ViewModels
{
    partial class Scelta3ViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _pathImmagine = @"C:\Users\catri\Downloads\DreamShaper_v7_Image_of_life_in_the_fields_in_Sicily_in_1800_I_3.jpg";
        
    }
}
