using System.Windows.Input;
using Principal.Command;

namespace Principal.ViewModel;

public class StudentViewModel : DefaultNotifyProperty
{
    private bool _registerIsVisible;
    private bool _searchIsVisible = true;

    public bool RegisterIsVisible
    {
        get => _registerIsVisible;
        set
        {
            if (SetField(ref _registerIsVisible, value))
                SearchIsVisible = !value;
        }
    }
    
    public bool SearchIsVisible
    {
        get => _searchIsVisible;
        set
        {
            if (SetField(ref _searchIsVisible, value))
                RegisterIsVisible = !value;
        }
    }

    public int A()
    {
        return 0;
    }
}