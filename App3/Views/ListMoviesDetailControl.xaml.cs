using App3.Core.Models;

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace App3.Views;

public sealed partial class ListMoviesDetailControl : UserControl
{
    public Movie? ListDetailsMenuItem
    {
        get => GetValue(ListDetailsMenuItemProperty) as Movie;
        set => SetValue(ListDetailsMenuItemProperty, value);
    }

    public static readonly DependencyProperty ListDetailsMenuItemProperty = DependencyProperty.Register("ListDetailsMenuItem", typeof(SampleOrder), typeof(ListMoviesDetailControl), new PropertyMetadata(null, OnListDetailsMenuItemPropertyChanged));

    public ListMoviesDetailControl()
    {
        InitializeComponent();
    }

    private static void OnListDetailsMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is ListMoviesDetailControl control)
        {
            control.ForegroundElement.ChangeView(0, 0, 1);
        }
    }
}
