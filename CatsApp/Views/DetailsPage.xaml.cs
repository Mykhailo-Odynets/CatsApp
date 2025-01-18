using CatsApp.Models;
using Microsoft.Maui.Controls;
using System.Diagnostics;

namespace CatsApp.Views;
[QueryProperty(nameof(SelectedCat), "SelectedCat")]
public partial class DetailsPage : ContentPage
{
    private Cat selectedCat;
    public DetailsPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    public Cat SelectedCat
    {
        get => selectedCat;
        set
        {
            selectedCat = value;
            string show1 = selectedCat?.breed?.name ?? "No breed, ";
            string show2 = selectedCat?.category?.name ?? "No category";
            DisplayAlert("Title", show1 + show2, "OK");
            OnPropertyChanged();
        }
    }
}
