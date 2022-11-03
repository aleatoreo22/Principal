using System;
using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Principal.Control.SidePanel;

public partial class SidePanel : UserControl
{
    public SidePanel(List<ButtonSidePanel> buttonsSidePanel)
    {
        InitializeComponent();
        StackPanel stackPanelSidePanel = this.FindControl<StackPanel>("StackPanelSidePanel");
        foreach (var item in buttonsSidePanel)
        {
            stackPanelSidePanel.Children.Add(item);
        }
    }

    public SidePanel()
    {
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}