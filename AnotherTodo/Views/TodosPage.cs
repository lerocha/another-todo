using System;
using Xamarin.Forms;
using System.Diagnostics;
using Microsoft.Practices.Unity;
using Unity=Microsoft.Practices.Unity;

namespace AnotherTodo
{
	public class TodosPage : ContentPage
	{
		public TodoList TodoList { get; set; }

		private ListView listView;
		private ITodoService todoService;

		public TodosPage([Unity.Dependency] ITodoService todoService)
		{
			this.todoService = todoService;
			listView = new ListView {
				RowHeight = 80
			};

			listView.ItemSelected += async (sender, e) => {
				var todo = (Todo)e.SelectedItem;
				await DisplayAlert("Tapped!", todo.Title + " was tapped.", "OK");
			};

			Content = new StackLayout {
				VerticalOptions = LayoutOptions.FillAndExpand,
				Children = { listView }
			};
		}

		/// <summary>
		/// Raises the appearing event.
		/// </summary>
		protected override async void OnAppearing()
		{
			base.OnAppearing();

			try {
				var response = await todoService.GetAllTodosAsync(TodoList.Id);
				listView.ItemsSource = response.Items;
				listView.ItemTemplate = new DataTemplate(typeof(TodoCell));
			} catch (Exception e) {
				// TODO: handle exception
				Debug.WriteLine(e);
			}
		}
	}
}

