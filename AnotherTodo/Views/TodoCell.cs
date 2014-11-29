using System;
using Xamarin.Forms;

namespace AnotherTodo
{
	public class TodoCell : ViewCell
	{
		public TodoCell()
		{
			var titleLabel = new Label {
				HorizontalOptions = LayoutOptions.FillAndExpand
			};
			titleLabel.SetBinding(Label.TextProperty, "Title");

			View = new StackLayout {
				HorizontalOptions = LayoutOptions.StartAndExpand,
				Orientation = StackOrientation.Vertical,
				Children = {
					titleLabel
				}
			};
		}
	}
}

