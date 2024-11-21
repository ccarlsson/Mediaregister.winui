using App3.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace App3.Views;

public sealed partial class AddBookPage : Page
{
    public AddBookViewModel ViewModel
    {
        get;
    }

    public AddBookPage()
    {
        ViewModel = App.GetService<AddBookViewModel>();
        
        InitializeComponent();
    }
}
