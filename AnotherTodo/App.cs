using System;
using Xamarin.Forms;

namespace AnotherTodo
{
	public class App
	{
		public static Page GetMainPage()
		{	
			return new NavigationPage(new TodoListsPage());
		}
	}
}

