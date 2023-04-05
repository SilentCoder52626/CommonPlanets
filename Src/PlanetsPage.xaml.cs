using CommonPlanets.Models;
using CommonPlanets.Services;

namespace CommonPlanets;

public partial class PlanetsPage : ContentPage
{
    private const uint AnimationDuration = 800u;
    public PlanetsPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        lstPopularPlanets.ItemsSource = PlanetService.GetFeaturedPlanets();
        lstAllPlanets.ItemsSource = PlanetService.GetAllPlanets();
    }

    async void Planets_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
    {
        await Navigation.PushAsync(new PlanetDetailsPage(e.CurrentSelection.First() as Planet));
    }

}