using System;
using Xamarin.Forms;

namespace AnotherTodo
{
	public class TodoCell : ViewCell
	{
		public TodoCell()
		{
			var titleLabel = new Label {
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand,
			};
			titleLabel.SetBinding(Label.TextProperty, "Title");

			View = new StackLayout {
				HorizontalOptions = LayoutOptions.StartAndExpand,
				Orientation = StackOrientation.Vertical,
				Padding = 12,
				Children = {
					titleLabel
				}
			};
		}
	}
}

