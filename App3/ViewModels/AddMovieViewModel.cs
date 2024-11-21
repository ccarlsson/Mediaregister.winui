using App3.Contracts.Services;
using App3.Core.Contracts.Services;
using App3.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace App3.ViewModels;

public partial class AddMovieViewModel : ObservableRecipient
{
    private readonly IMediaDataService _mediaDataService;
    private readonly INavigationService _navigationService;
    public AddMovieViewModel(IMediaDataService mediaDataService, INavigationService navigationService)
    {
        _mediaDataService = mediaDataService;
        _navigationService = navigationService;
    }

    [ObservableProperty]
    private string _title = string.Empty;
    [ObservableProperty]
    private string _director = string.Empty;
    [ObservableProperty]
    private int _length;
    [ObservableProperty]
    private string _imageUri = string.Empty;

    [RelayCommand]
    private async void AddBook()
    {
        await _mediaDataService.AddMovieAsync(Title, Director, Length, ImageUri);
        // TODO: Maybe clear the fields and stay on the page?
        _navigationService.GoBack();
    }
}
