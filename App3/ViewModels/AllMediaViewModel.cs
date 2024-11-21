using System.Collections.ObjectModel;
using System.Windows.Input;

using App3.Contracts.Services;
using App3.Contracts.ViewModels;
using App3.Core.Contracts.Services;
using App3.Core.Models;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace App3.ViewModels;

public partial class AllMediaViewModel : ObservableRecipient, INavigationAware
{
    private readonly INavigationService _navigationService;
//    private readonly ISampleDataService _sampleDataService;
    private readonly IMediaDataService _mediaDataService;

    public ObservableCollection<Media> Source { get; } = new();

    public AllMediaViewModel(INavigationService navigationService, IMediaDataService mediaDataService)
    {
        _navigationService = navigationService;
        _mediaDataService = mediaDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        Source.Clear();

        // TODO: Replace with real data.
        var data = await _mediaDataService.GetAllMedia();
        foreach (var item in data)
        {
            Source.Add(item);
        }
    }

    public void OnNavigatedFrom()
    {
    }

    [RelayCommand]
    private void OnItemClick(Media? clickedItem)
    {
        if (clickedItem != null)
        {
            _navigationService.SetListDataItemForNextConnectedAnimation(clickedItem);
            _navigationService.NavigateTo(typeof(AllMediaDetailViewModel).FullName!, clickedItem.Id);
        }
    }
}
