using App3.ViewModels;

using CommunityToolkit.WinUI.UI.Controls;

using Microsoft.UI.Xaml.Controls;

namespace App3.Views;

public sealed partial class ListBooksPage : Page
{
    public ListBooksViewModel ViewModel
    {
        get;
    }

    public ListBooksPage()
    {
        ViewModel = App.GetService<ListBooksViewModel>();
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
