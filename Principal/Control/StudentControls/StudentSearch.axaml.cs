using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Principal.Control.StudentControls;

public partial class StudentSearch : UserControl
{
    public StudentSearch()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}