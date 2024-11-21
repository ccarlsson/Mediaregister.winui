using App3.Contracts.Services;
using App3.Core.Contracts.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace App3.ViewModels;

public partial class AddBookViewModel : ObservableRecipient
{
    private readonly IMediaDataService _mediaDataService;
    private readonly INavigationService _navigationService;
    public AddBookViewModel(IMediaDataService mediaDataService, INavigationService navigationService)
    {
        _mediaDataService = mediaDataService;
        _navigationService = navigationService;
    }

    [ObservableProperty]
    private string _title = string.Empty;
    [ObservableProperty]
    private string _author = string.Empty;
    [ObservableProperty]
    private int _pages;
    [ObservableProperty]
    private string _imageUri = string.Empty;

    [RelayCommand]
    private async void AddBook()
    {
        await _mediaDataService.AddBookAsync(Title, Author, Pages, ImageUri);
        // TODO: Maybe clear the fields and stay on the page?
        _navigationService.GoBack();
    }
}
