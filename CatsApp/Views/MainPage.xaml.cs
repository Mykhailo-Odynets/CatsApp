using CatsApp.ViewModels;
using CatsApp.Models;

namespace CatsApp.Views;
public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
        BindingContext = new MainViewModel();
    }

    private void catsList_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        catsList.SelectedItem = null;
    }

    private async void catsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (catsList.SelectedItem == null) return;

        var selectedCat = (Cat)catsList.SelectedItem;
        await Shell.Current.GoToAsync(nameof(DetailsPage), true, new Dictionary<string, object>
        {
            { "SelectedCat", selectedCat }
        });
    }
}