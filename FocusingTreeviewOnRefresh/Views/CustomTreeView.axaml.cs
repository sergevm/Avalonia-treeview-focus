using System.Reactive.Disposables;
using Avalonia.ReactiveUI;
using FocusingTreeviewOnRefresh.ViewModels;
using ReactiveUI;

namespace FocusingTreeviewOnRefresh.Views;

public partial class CustomTreeView : ReactiveUserControl<CustomTreeViewModel>
{
    public CustomTreeView()
    {
        InitializeComponent();
        
        this.WhenActivated((CompositeDisposable disposables) =>
        {
        });
    }
}