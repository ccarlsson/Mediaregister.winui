using System.Collections.ObjectModel;

using App3.Contracts.ViewModels;
using App3.Core.Contracts.Services;
using App3.Core.Models;

using CommunityToolkit.Mvvm.ComponentModel;

namespace App3.ViewModels;

public partial class ListBooksViewModel : ObservableRecipient, INavigationAware
{
//    private readonly ISampleDataService _sampleDataService;
    private readonly IMediaDataService _mediaDataService;

    [ObservableProperty]
    private Book? selected;

    public ObservableCollection<Book> SampleItems { get; private set; } = new();

    public ListBooksViewModel(IMediaDataService mediaDataService)
    {
        _mediaDataService = mediaDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        SampleItems.Clear();

        var data = await _mediaDataService.GetBooksAsync();

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
