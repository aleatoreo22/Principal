using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Principal.Control.SidePanel;
using Principal.View;

namespace Principal;

public enum Page
{
    Home = 1,
    User = 2,
    Student = 3
}

public partial class MainWindow : Window
{
    private static StackPanel _page = null!;
    private static Page _actualPage;
    private static Home? _home;
    private static User? _user;
    private static Student? _student;
    public MainWindow()
    {
        InitializeComponent();
        this.AttachDevTools();
        var splitView = this.FindControl<StackPanel>("SidePanel");
        var buttonsSidePanel = LoadDefaultButtonSidePanel();
        splitView.Children.Add(new SidePanel(buttonsSidePanel));
        _page = this.FindControl<StackPanel>("Page");
        _home = new Home();
        _page.Children.Add(_home);
    }

    private static List<ButtonSidePanel> LoadDefaultButtonSidePanel()
    {
        try
        {
            var buttons = new List<ButtonSidePanel> 
            {
                new ButtonSidePanel("BtnHome","🏠 Home",ChangePage,Principal.Page.Home),
                new ButtonSidePanel("BtnUser","👨 User",ChangePage,Principal.Page.User),
                new ButtonSidePanel("BtnStudent","🎓 Student",ChangePage,Principal.Page.Student),
            };
            return buttons;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }


    private static void ChangePage(object? sender, RoutedEventArgs e)
    {
        try
        {
            var button = (ButtonSidePanel)sender!;
            if (_actualPage == button.Page) return;
            
            switch (button.Page)
            {
                case Principal.Page.Home:
                    _home ??= new Home();
                    _page.Children[0] = _home;
                    break;
                case Principal.Page.User:
                    _user ??= new User();
                    _page.Children[0] = _user;
                    break;
                case Principal.Page.Student:
                    _student ??= new Student();
                    _page.Children[0] = _student;
                    break;
                default:
                    throw new Exception("Not Implemented");
            }
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            throw;
        }
    }
    
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
    
    private void BtnSidePanelOpen_OnClick(object? sender, RoutedEventArgs e)
    {
        var button = (Button)sender!;
        var splitView = this.FindControl<SplitView>("SplitView1");
        splitView.IsPaneOpen =  !splitView.IsPaneOpen;
        button.Content = splitView.IsPaneOpen ? "←" : "→";
    }
}