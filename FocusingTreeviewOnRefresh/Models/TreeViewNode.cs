using System.Collections.Generic;
using ReactiveUI.Fody.Helpers;

namespace FocusingTreeviewOnRefresh.Models;

public class TreeViewNode
{
    [Reactive ]public string Name { get; set; } = "<No name assigned>";
    [Reactive] public List<TreeViewNode> Children { get; set; } = new();
}