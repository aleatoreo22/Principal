using System;
using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Principal.Control.SidePanel;

public partial class ButtonSidePanel : UserControl 
{
    public Page Page { get;}
    public Button Button { get; }
    
    private EventHandler<RoutedEventArgs> _buttonClick;
    
    public ButtonSidePanel(string name, string content, EventHandler<RoutedEventArgs> click, Page page)
    {
        InitializeComponent();
        Button = this.FindControl<Button>("BtnSample");
        Button.Name = name;
        Button.Content = content;
        _buttonClick = click;
        Page = page;
    }
   
    public ButtonSidePanel()
    {
    }
    
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void BtnSample_OnClick(object? sender, RoutedEventArgs e)
    {
        _buttonClick(this, e);
    }
}