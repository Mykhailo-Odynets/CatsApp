using CatsApp.ViewModels;

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

    private void catsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(DetailsPage));
    }

    //  private void btnDetailsPage_Clicked(object sender, EventArgs e)
    //  {
    //Shell.Current.GoToAsync(nameof(DetailsPage));
    //  }
}