using ReactiveUI;

namespace FocusingTreeviewOnRefresh.ViewModels;

public class CustomTreeWrapperViewModel : ViewModelBase, IRoutableViewModel
{
    public CustomTreeViewModel TreeViewModel { get; set; }
    public CustomTreeWrapperViewModel(IScreen hostScreen)
    {
        HostScreen = hostScreen;
        TreeViewModel = new CustomTreeViewModel(hostScreen);
    }
    
    public string? UrlPathSegment => "wrapper";
    public IScreen HostScreen { get; }
}