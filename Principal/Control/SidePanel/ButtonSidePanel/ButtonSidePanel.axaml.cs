using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Principal.Enum;

namespace Principal.Control.SidePanel.ButtonSidePanel;

public partial class ButtonSidePanel : UserControl 
{
    public event EventHandler<RoutedEventArgs> SideButtonClick
    {
        add => AddHandler(SideButtonClickProperty, value);
        remove => RemoveHandler(SideButtonClickProperty, value);
    }
    private static readonly RoutedEvent<RoutedEventArgs> SideButtonClickProperty =
        RoutedEvent.Register<Button,RoutedEventArgs>(nameof(SideButtonClick),RoutingStrategies.Bubble);


    public Page Page
    {
        get => GetValue(PageProperty)!;
        set => SetValue(PageProperty!, value);
    }
    private static readonly StyledProperty<Page> PageProperty =
        AvaloniaProperty.Register<Button,Page>(nameof(Page));
    
    public string? Label
    {
        get => GetValue(LabelProperty)!;
        set => SetValue(LabelProperty!, value);
    }
    private static readonly StyledProperty<string> LabelProperty =
        AvaloniaProperty.Register<TextBlock,string>(nameof(Label),"Sample");
    
    public ButtonSidePanel()
    {
        InitializeComponent();
    }
    
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void BtnSample_OnClick(object? sender, RoutedEventArgs e)
    {
        var a = new RoutedEventArgs(SideButtonClickProperty);
        RaiseEvent(a);
    }
}