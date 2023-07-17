using System;
using System.Windows.Input;
using Principal.Enum;
using Principal.ViewModel;

namespace Principal.Command;

#region Default Execution
public class MainWindowCommandDefault : ICommand
{
    protected MainWindowViewModel MainWindowViewModel { get; set; }

    protected MainWindowCommandDefault(MainWindowViewModel windowViewModel)
    {
        MainWindowViewModel = windowViewModel;
    }

    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        
    }
    
    public event EventHandler? CanExecuteChanged;
}
#endregion

#region Commands
public class ControlViewIsVisible : MainWindowCommandDefault
{
    public ControlViewIsVisible(MainWindowViewModel windowViewModel) : base(windowViewModel)
    {
    }

    public new void Execute(object? parameter)
    {
        this.MainWindowViewModel.ControlViewIsVisible((Page)(parameter ?? Page.Home));
    }
}

public class ControlSidePanelState : MainWindowCommandDefault
{
    public ControlSidePanelState(MainWindowViewModel windowViewModel) : base(windowViewModel)
    {
    }

    public new void Execute(object? parameter)
    {
        MainWindowViewModel.ControlSidePanelState();
    }
}
#endregion