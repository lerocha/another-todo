using System;
using Xamarin.Forms;
using System.Diagnostics;

namespace AnotherTodo
{
	public class TodosPage : ContentPage
	{
		private ListView listView;
		private ITodoService todoService = new TodoServiceMock();
		private string todoListId;

		public TodosPage(TodoList todoList)
		{
			this.todoListId = todoList.Id;
			Title = todoList.Title;

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
				var response = await todoService.GetAllTodosAsync(this.todoListId);
				listView.ItemsSource = response.Items;
				listView.ItemTemplate = new DataTemplate(typeof(TodoCell));
			} catch (Exception e) {
				// TODO: handle exception
				Debug.WriteLine(e);
			}
		}
	}
}

