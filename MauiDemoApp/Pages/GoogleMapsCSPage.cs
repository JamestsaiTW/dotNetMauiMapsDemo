using Microsoft.Maui.Controls;
using Map = Maui.GoogleMaps.Map;

namespace MauiDemoApp.Pages;

public class GoogleMapsCSPage : ContentPage
{
	public GoogleMapsCSPage()
	{
        Title = "Google Maps Demo";
        Content = new Grid
		{
			Children = {
				new Map()
			}
		};
	}
}