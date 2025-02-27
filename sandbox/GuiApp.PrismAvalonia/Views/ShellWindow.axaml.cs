using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace GuiApp.PrismAvalonia.Views
{
  public partial class ShellWindow : Window
  {
    public ShellWindow()
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
}
