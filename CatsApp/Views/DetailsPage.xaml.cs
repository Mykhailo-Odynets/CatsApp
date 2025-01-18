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
            //DisplayAlert("Info", $"{selectedCat?.breeds?.Count} breeds, {selectedCat?.categories?.Count} categories", "OK");
            OnPropertyChanged();
        }
    }
}
