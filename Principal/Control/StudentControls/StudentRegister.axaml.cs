using System.Collections;
using System.Net.Mime;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Principal.Model;

namespace Principal.Control.StudentControls;

public partial class StudentRegister : UserControl
{
    public StudentRegister()
     {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}