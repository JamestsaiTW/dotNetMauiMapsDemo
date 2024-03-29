using Microsoft.Maui.Maps;
using Microsoft.Maui.Controls;
using Map = Microsoft.Maui.Controls.Maps.Map;
using Microsoft.Maui.Devices.Sensors;

namespace MauiDemoApp.Pages;

public class DefaultMapsTWCSPage : ContentPage
{
	public DefaultMapsTWCSPage()
	{
        Title = "Default Maps Demo";

        var location = new Location(23.65743215, 120.9696147);
        var mapSpan = new MapSpan(location, 4, 1);

        Content = new Grid
		{
			Children = {
				new Map(mapSpan)
			}
		};
	}
}