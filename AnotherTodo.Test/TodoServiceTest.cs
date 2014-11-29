using NUnit.Framework;
using System;

namespace AnotherTodo.Test
{
	[TestFixture()]
	public class TodoServiceTest
	{
		private ITodoService service = new TodoServiceMock();

		[Test()]
		public void GetAllTodoLists()
		{
			var result = service.GetAllTodoListsAsync().Result;
			Assert.NotNull(result);
			Assert.NotNull(result.Items);
			Assert.IsTrue(result.Items.Count > 0);
			foreach(TodoList item in result.Items) {
				Console.WriteLine(String.Format("id={0}; title={1}", item.Id, item.Title));
			}
		}
	}
}

