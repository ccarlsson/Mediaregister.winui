using App3.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace App3.Views;

public sealed partial class AddMoviePage : Page
{
    public AddMovieViewModel ViewModel
    {
        get;
    }

    public AddMoviePage()
    {
        ViewModel = App.GetService<AddMovieViewModel>();
        InitializeComponent();
    }
}
