using Avalonia;
using Avalonia.Controls;

namespace Principal.ViewModel;

public class MainWindowViewModel : DefaultNotifyProperty
{
    private Avalonia.Controls.Control _actualPage;
    public Avalonia.Controls.Control ActualPage
    {
        get => _actualPage;
        set
        {
            SetField(ref _actualPage, value);
        } 
    }
}