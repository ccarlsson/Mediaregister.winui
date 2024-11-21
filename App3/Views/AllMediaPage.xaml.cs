using App3.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace App3.Views;

public sealed partial class AllMediaPage : Page
{
    public AllMediaViewModel ViewModel
    {
        get;
    }

    public AllMediaPage()
    {
        ViewModel = App.GetService<AllMediaViewModel>();
        InitializeComponent();
    }
}
