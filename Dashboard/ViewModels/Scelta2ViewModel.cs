using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Dashboard.Models;
using System.Collections.ObjectModel;

namespace Dashboard.ViewModels
{
    partial class Scelta2ViewModel : ObservableObject
    {
        public ObservableCollection<Studente> ListaStudenti => App.StudentService.Studenti;
        [ObservableProperty]
        public Studente? _studenteSelezionato = null;

        [RelayCommand]
        public void RemoveItem()
        {
            if (StudenteSelezionato is not null)
                ListaStudenti.Remove(StudenteSelezionato);
        }
    }
}
