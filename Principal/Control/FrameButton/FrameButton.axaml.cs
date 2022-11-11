using System;
using System.Windows.Input;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Principal.Control.FrameButton;

public partial class FrameButton : UserControl
{
    public static readonly StyledProperty<ICommand> SearchClickProperty = AvaloniaProperty.Register<FrameButton, ICommand>(nameof(SearchClick));
    public static readonly StyledProperty<ICommand> InsertClickProperty = AvaloniaProperty.Register<FrameButton, ICommand>("InsertClick");

    public FrameButton()
    {
        InitializeComponent();
    }

    public ICommand SearchClick
    {
        get => GetValue(SearchClickProperty);
        set => SetValue(SearchClickProperty, value);
    }

    public ICommand InsertClick
    {
        get => GetValue(InsertClickProperty);
        set => SetValue(InsertClickProperty, value);
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}