using Avalonia.ReactiveUI;
using FocusingTreeviewOnRefresh.ViewModels;

namespace FocusingTreeviewOnRefresh.Views;

public partial class CustomTreeWrapperView : ReactiveUserControl<CustomTreeWrapperViewModel>
{
    public CustomTreeWrapperView()
    {
        InitializeComponent();
    }
}