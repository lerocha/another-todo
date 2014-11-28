using System;
using System.Threading.Tasks;

namespace AnotherTodo
{
	public class TodoService : ITodoService
	{
		public Task<TodoListCollection> GetAllTodoListsAsync()
		{
			throw new NotImplementedException();
		}

		public Task<TodoList> GetTodoListAsync(string id)
		{
			throw new NotImplementedException();
		}

		public Task<TodoList> AddTodoListAsync(TodoList todoList)
		{
			throw new NotImplementedException();
		}

		public Task<TodoList> UpdateTodoListAsync(TodoList todoList)
		{
			throw new NotImplementedException();
		}

		public Task DeleteTodoListAsync(string id)
		{
			throw new NotImplementedException();
		}

		public Task<TodoCollection> GetAllTodosAsync(string todoListId)
		{
			throw new NotImplementedException();
		}

		public Task<Todo> GetTodoAsync(string id, string todoListId)
		{
			throw new NotImplementedException();
		}

		public Task<Todo> AddTodoAsync(Todo todo, string previous)
		{
			throw new NotImplementedException();
		}

		public Task<Todo> UpdateTodoAsync(Todo todo)
		{
			throw new NotImplementedException();
		}

		public Task DeleteTodoAsync(string id, string todoListId)
		{
			throw new NotImplementedException();
		}
	}
}
