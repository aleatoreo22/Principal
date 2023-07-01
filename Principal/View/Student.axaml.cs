using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Principal.View;

public partial class Student : UserControl
{
    
    public Student()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}