using System;
using System.Windows.Input;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Principal.ViewModel;
using ReactiveUI;

namespace Principal.Control.FrameButton;

public partial class FrameButton : UserControl
{
    /*
    public static readonly DirectProperty<FrameButton, bool> ConfirmFrameIsVisibleProperty =
        AvaloniaProperty.RegisterDirect<FrameButton, bool>(nameof(ConfirmFrameIsVisible), o => o.ConfirmFrameIsVisible,
            (o, v) => o.ConfirmFrameIsVisible = v);

    private bool _confirmFrameIsVisible = false;

    public bool ConfirmFrameIsVisible
    {
        get { return _confirmFrameIsVisible; }
        set { _confirmFrameIsVisible = value; }
    }
    */

    public FrameButton()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}