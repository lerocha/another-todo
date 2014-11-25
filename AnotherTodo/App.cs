using System;
using Xamarin.Forms;

namespace AnotherTodo
{
	public class App
	{
		public static Page GetMainPage()
		{	
			return new ContentPage { 
				Content = new Label {
					Text = "Hello, AnotherTodo!",
					VerticalOptions = LayoutOptions.CenterAndExpand,
					HorizontalOptions = LayoutOptions.CenterAndExpand,
				},
			};
		}
	}
}

