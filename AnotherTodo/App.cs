using System;
using Xamarin.Forms;
using Microsoft.Practices.Unity;

namespace AnotherTodo
{
	public class App
	{
		public static UnityContainer Container { get; set; }

		public static Page GetMainPage()
		{
			// Register types in DI container.
			App.Container = new UnityContainer();
			App.Container.RegisterType<ITodoService, TodoServiceMock> ();

			// Gets the main page and wraps within a NavigationPage.
			var mainPage = App.Container.Resolve<TodoListsPage>();
			return new NavigationPage(mainPage);
		}
	}
}

