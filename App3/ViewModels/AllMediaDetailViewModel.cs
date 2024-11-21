using App3.Contracts.ViewModels;
using App3.Core.Contracts.Services;
using App3.Core.Models;

using CommunityToolkit.Mvvm.ComponentModel;

namespace App3.ViewModels;

public partial class AllMediaDetailViewModel : ObservableRecipient, INavigationAware
{
    private readonly IMediaDataService _mediaDataService;

    [ObservableProperty]
    private Media? item;

    public AllMediaDetailViewModel(IMediaDataService mediaDataService)
    {
        _mediaDataService = mediaDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        if (parameter is int mediaID)
        {
            var data = await _mediaDataService.GetMediaByIdAsync(mediaID);
            Item = data;
        }
    }

    public void OnNavigatedFrom()
    {
    }
}
