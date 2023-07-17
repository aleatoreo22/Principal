using System;
using Principal.Command;
using Principal.Enum;
using Principal.View;

namespace Principal.ViewModel;

public class MainWindowViewModel : DefaultNotifyProperty
{
    public ControlSidePanelState ControlSidePanel { get; set; }
    public ControlViewIsVisible ControlView { get; set; }

    private Home? _home;
    private User? _user;
    private Student? _student;
    
    public MainWindowViewModel()
    {
        ControlSidePanel = new ControlSidePanelState(this);
        ControlView = new ControlViewIsVisible(this);
        _home = new Home();
        _actualPageControl = _home;
        _actualPage = Page.Home;
    }
    
    private Avalonia.Controls.Control? _actualPageControl;
    public Avalonia.Controls.Control? ActualPageControl
    {
        get => _actualPageControl;
        set => SetField(ref _actualPageControl, value);
    }

    private Page _actualPage;
    public Page ActualPage
    {
        get => _actualPage;
        set => SetField(ref _actualPage, value);
    }
    
    private string _buttonSidePanelLabel = "←";
    public string ButtonSidePanelLabel
    {
        get => _buttonSidePanelLabel;
        set => SetField(ref _buttonSidePanelLabel, value);
    }

    private bool _sidePanelIsOpen = true;
    public bool SidePanelIsOpen
    {
        get => _sidePanelIsOpen;
        set => SetField(ref _sidePanelIsOpen, value);
    }

    public void ControlSidePanelState()
    {
        SidePanelIsOpen =  !_sidePanelIsOpen;
        ButtonSidePanelLabel = _sidePanelIsOpen ? "←" : "→";
    }

    public void ControlViewIsVisible(Page page)
    {
        try
        {
            if (_actualPage == page) return;
            _actualPage = page;
            
            switch (page)
            {
                case Page.Home:
                    _home ??= new Home();
                    ActualPageControl = _home;
                    break;
                case Page.User:
                    _user ??= new User();
                    ActualPageControl = _user;
                    break;
                case Page.Student:
                    _student ??= new Student();
                    ActualPageControl = _student;
                    break;
                default:
                    throw new Exception("Not Implemented");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}