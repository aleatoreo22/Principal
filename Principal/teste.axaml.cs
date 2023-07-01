using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Principal;

public partial class teste : Window
{
    public teste()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}