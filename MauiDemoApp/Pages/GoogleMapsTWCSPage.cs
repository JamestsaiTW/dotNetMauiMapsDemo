using Maui.GoogleMaps;
using Map = Maui.GoogleMaps.Map;

namespace MauiDemoApp.Pages;

public class GoogleMapsTWCSPage : ContentPage
{
	public GoogleMapsTWCSPage()
	{
		Title = "Google Maps Demo";
		Content = new Grid
		{
			Children = {
				new Map()
				{
					InitialCameraUpdate = CameraUpdateFactory
							.NewPositionZoom(new Position(23.65743215, 120.9696147), 8d)
				}
			}
		};
	}
}