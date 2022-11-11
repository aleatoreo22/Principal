using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Principal.Control.SidePanel;
using Principal.Control.SidePanel.ButtonSidePanel;
using Principal.Enum;
using Principal.View;
using Principal.ViewModel;

namespace Principal;

public partial class MainWindow : Window
{
    //private static StackPanel _page = null!;
    private static Page _actualPage;
    private static Home? _home = new();
    private static User? _user;
    private static Student? _student;
    private MainWindowViewModel? _viewModel;

    public MainWindow()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
        _viewModel = (MainWindowViewModel?)this.DataContext;
        _viewModel.ActualPage = _home;
    }



    private void ChangePage(object? sender, RoutedEventArgs e)
    {
        try
        {
            var sidePanel = (SidePanel)sender!;
            if (_actualPage == sidePanel.Page) return;
            
            switch (sidePanel.Page)
            {
                case Principal.Enum.Page.Home:
                    _home ??= new Home();
                    _viewModel.ActualPage = _home;
                    break;
                case Principal.Enum.Page.User:
                    _user ??= new User();
                    _viewModel.ActualPage = _user;
                    break;
                case Principal.Enum.Page.Student:
                    _student ??= new Student();
                    _viewModel.ActualPage = _student;
                    break;
                default:
                    throw new Exception("Not Implemented");
            }
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
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