using System;
using System.Windows.Input;
using FocusingTreeviewOnRefresh.Models;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace FocusingTreeviewOnRefresh.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        [Reactive] public TreeViewNode Root { get; set; } = new();
        [Reactive] public ICommand RefreshCommand { get; set; }

        public MainWindowViewModel()
        {
            var level1 = new TreeViewNode() { Name = "Level 1"};
            Root.Children.Add(level1);
            level1.Children.Add(new TreeViewNode {Name = "Item 1-1"});
            level1.Children.Add(new TreeViewNode {Name = "Item 1-2"});
            level1.Children.Add(new TreeViewNode {Name = "Item 1-3"});

            RefreshCommand = ReactiveCommand.Create(() =>
            {
                Console.WriteLine("Refreshing...");
            });
        }
    }
}