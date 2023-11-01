using System;
using System.Reactive;
using System.Reactive.Disposables;
using System.Windows.Input;
using ReactiveUI;

namespace FocusingTreeviewOnRefresh.ViewModels
{
    public class MainWindowViewModel : ViewModelBase, IScreen, IActivatableViewModel
    {
        public ICommand LoadTreeViewCommand { get; set; }

        public MainWindowViewModel()
        {
            LoadTreeViewCommand = ReactiveCommand.CreateFromObservable(() => 
                Router.Navigate.Execute(new CustomTreeWrapperViewModel(this)));
            
            this.WhenActivated((CompositeDisposable disposable) => { });
        }

        public RoutingState Router { get; } = new();
        public ViewModelActivator Activator { get; } = new();
    }
}