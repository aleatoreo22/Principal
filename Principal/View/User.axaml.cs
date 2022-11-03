using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Principal.View;

public partial class User : UserControl
{
    public User()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}