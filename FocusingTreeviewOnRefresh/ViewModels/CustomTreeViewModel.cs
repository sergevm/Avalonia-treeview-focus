using System;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using FocusingTreeviewOnRefresh.Models;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace FocusingTreeviewOnRefresh.ViewModels;

public class CustomTreeViewModel : ViewModelBase, IRoutableViewModel
{
    [Reactive] public TreeViewNode Root { get; set; } = new();
    [Reactive] public ICommand RefreshCommand { get; set; }
    [Reactive] public bool IsLoading { get; set; }
    public CustomTreeViewModel(IScreen hostScreen)
    {
        HostScreen = hostScreen;

        var level1 = new TreeViewNode { Name = "Level 1" };

        Root.Children.Add(level1);

        level1.Children.Add(new TreeViewNode { Name = "Item 1-1" });
        level1.Children.Add(new TreeViewNode { Name = "Item 1-2" });
        level1.Children.Add(new TreeViewNode { Name = "Item 1-3" });

        RefreshCommand = ReactiveCommand.Create(() =>
        {
            IsLoading = true;
            Console.WriteLine("Refreshing...");
            IsLoading = false;
        });
    }

    public string UrlPathSegment => "Treeview";
    public IScreen HostScreen { get; }
    [Reactive] public TreeViewNode? SelectedNode { get; set; }
}