﻿using System;
using Xamarin.Forms;
using System.Diagnostics;

namespace AnotherTodo
{
	public class TodoListsPage : ContentPage
	{
		private ListView listView;
		private ITodoService todoService = new TodoServiceMock();

		public TodoListsPage()
		{
			Title = "My Lists";

			listView = new ListView {
				RowHeight = 80
			};

			listView.ItemSelected += async (sender, e) => {
				var todoList = (TodoList)e.SelectedItem;
				var todosPage = new TodosPage(todoList);
				await Navigation.PushAsync(todosPage);			
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
				var response = await todoService.GetAllTodoListsAsync();
				listView.ItemsSource = response.Items;
				listView.ItemTemplate = new DataTemplate(typeof(TodoListCell));
			} catch (Exception e) {
				// TODO: handle exception
				Debug.WriteLine(e);
			}
		}
	}
}

