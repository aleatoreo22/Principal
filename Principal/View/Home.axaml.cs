using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Principal.View;

public partial class Home : UserControl
{
    public Home()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}