using System;
using Xamarin.Forms;

namespace AnotherTodo
{
	public class TodoListCell : ViewCell
	{
		public TodoListCell()
		{
			var titleLabel = new Label {
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand,
			};
			titleLabel.SetBinding(Label.TextProperty, "Title");

			// Creates a StackLayout view with the movie and vote average labels.
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

