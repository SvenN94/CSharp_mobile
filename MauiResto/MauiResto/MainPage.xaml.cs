﻿namespace MauiResto;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}
	

	private async void Button_Clicked_Resto(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(RestaurantPage));
	}

	private async void Button_Clicked_About(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(AboutPage));
	}
}

