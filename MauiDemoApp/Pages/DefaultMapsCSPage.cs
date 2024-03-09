using Map = Microsoft.Maui.Controls.Maps.Map;

namespace MauiDemoApp.Pages;

public class DefaultMapsCSPage : ContentPage
{
	public DefaultMapsCSPage()
	{
		Content = new Grid
		{
			Children = {
				new Map()
			}
		};
	}
}