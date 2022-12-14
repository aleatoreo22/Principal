using System;
using System.Collections.Generic;
using System.Dynamic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Principal.Enum;

namespace Principal.Control.SidePanel;

public partial class SidePanel : UserControl
{
    public Principal.Enum.Page Page { get; private set; }

    public event EventHandler<RoutedEventArgs> SideButtonClick
    {
        add => AddHandler(SideButtonClickProperty, value);
        remove => RemoveHandler(SideButtonClickProperty, value);
    }
    private static readonly RoutedEvent<RoutedEventArgs> SideButtonClickProperty =
        RoutedEvent.Register<Button,RoutedEventArgs>(nameof(SideButtonClick),RoutingStrategies.Bubble);
    
    public SidePanel()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void ButtonSidePanel_OnSideButtonClick(object? sender, RoutedEventArgs e)
    {
        var button = (ButtonSidePanel.ButtonSidePanel)sender!;
        Page = button.Page;
        var a = new RoutedEventArgs(SideButtonClickProperty);
        RaiseEvent(a);
    }
}