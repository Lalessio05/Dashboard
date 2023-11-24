using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Dashboard.ViewModels
{
    partial class Scelta3ViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _pathImmagine = @"C:\Users\catri\Downloads\DreamShaper_v7_Image_of_life_in_the_fields_in_Sicily_in_1800_I_3.jpg";
        [ObservableProperty]
        private string _nome = string.Empty;
        [ObservableProperty]
        private string _cognome = string.Empty;

        private void ClearTextBoxes()
        {
            Nome = string.Empty;
            Cognome = string.Empty;
            PathImmagine = @"C:\Users\catri\Downloads\DreamShaper_v7_Image_of_life_in_the_fields_in_Sicily_in_1800_I_3.jpg";
        }
        [RelayCommand]
        void Salva()
        {
            App.StudentService.Studenti.Add(new(Nome, Cognome, PathImmagine));
            ClearTextBoxes();
        }
    }
}
