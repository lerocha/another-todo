using System;
using Xamarin.Forms;

namespace AnotherTodo
{
	public class TodoListCell : ViewCell
	{
		public TodoListCell()
		{
			var titleLabel = new Label {
				HorizontalOptions = LayoutOptions.FillAndExpand
			};
			titleLabel.SetBinding(Label.TextProperty, "Title");

			// Movie tagline label.
			var detailLabel = new Label {
				HorizontalOptions = LayoutOptions.FillAndExpand
			};
			detailLabel.SetBinding(Label.TextProperty, "Id");

			// Creates a StackLayout view with the movie and vote average labels.
			View = new StackLayout {
				HorizontalOptions = LayoutOptions.StartAndExpand,
				Orientation = StackOrientation.Vertical,
				Children = {
					titleLabel, detailLabel
				}
			};
		}
	}
}

