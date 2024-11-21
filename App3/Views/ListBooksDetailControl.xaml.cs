using App3.Core.Models;

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace App3.Views;

public sealed partial class ListBooksDetailControl : UserControl
{
    public Book? ListDetailsMenuItem
    {
        get => GetValue(ListDetailsMenuItemProperty) as Book;
        set => SetValue(ListDetailsMenuItemProperty, value);
    }

    public static readonly DependencyProperty ListDetailsMenuItemProperty = DependencyProperty.Register("ListDetailsMenuItem", typeof(SampleOrder), typeof(ListBooksDetailControl), new PropertyMetadata(null, OnListDetailsMenuItemPropertyChanged));

    public ListBooksDetailControl()
    {
        InitializeComponent();
    }

    private static void OnListDetailsMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is ListBooksDetailControl control)
        {
            control.ForegroundElement.ChangeView(0, 0, 1);
        }
    }
}
