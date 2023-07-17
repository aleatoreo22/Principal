using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Principal.Control.StudentControls;

public partial class SearchStudent : UserControl
{
    public SearchStudent()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}