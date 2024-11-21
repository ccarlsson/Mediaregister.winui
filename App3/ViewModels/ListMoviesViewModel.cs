using System.Collections.ObjectModel;

using App3.Contracts.ViewModels;
using App3.Core.Contracts.Services;
using App3.Core.Models;

using CommunityToolkit.Mvvm.ComponentModel;

namespace App3.ViewModels;

public partial class ListMoviesViewModel : ObservableRecipient, INavigationAware
{
    private readonly IMediaDataService _mediaDataService;

    [ObservableProperty]
    private Movie? selected;

    public ObservableCollection<Movie> SampleItems { get; private set; } = new ();

    public ListMoviesViewModel(IMediaDataService mediaDataService)
    {
        _mediaDataService = mediaDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        SampleItems.Clear();

        // TODO: Replace with real data.
        var data = await _mediaDataService.GetMoviesAsync();

        foreach (var item in data)
        {
            SampleItems.Add(item);
        }
    }

    public void OnNavigatedFrom()
    {
    }

    public void EnsureItemSelected()
    {
        Selected ??= SampleItems.First();
    }
}
