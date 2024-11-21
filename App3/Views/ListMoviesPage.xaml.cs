using App3.ViewModels;

using CommunityToolkit.WinUI.UI.Controls;

using Microsoft.UI.Xaml.Controls;

namespace App3.Views;

public sealed partial class ListMoviesPage : Page
{
    public ListMoviesViewModel ViewModel
    {
        get;
    }

    public ListMoviesPage()
    {
        ViewModel = App.GetService<ListMoviesViewModel>();
        InitializeComponent();
    }

    private void OnViewStateChanged(object sender, ListDetailsViewState e)
    {
        if (e == ListDetailsViewState.Both)
        {
            ViewModel.EnsureItemSelected();
        }
    }
}
