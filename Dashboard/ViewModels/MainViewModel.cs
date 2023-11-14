using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
namespace Dashboard.ViewModels;

internal partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    object? currentView;
    [RelayCommand]
    Task ScegliView(string n)
    {
        CurrentView = n switch
        {
            "1" => new Scelta1ViewModel(),
            "2" => new Scelta2ViewModel(),
            "3" => new Scelta3ViewModel(),
            _ => new object()
        } ;
        return Task.CompletedTask;
    }
}
