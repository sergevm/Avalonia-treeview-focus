using Avalonia.ReactiveUI;
using FocusingTreeviewOnRefresh.ViewModels;

namespace FocusingTreeviewOnRefresh.Views
{
    public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}