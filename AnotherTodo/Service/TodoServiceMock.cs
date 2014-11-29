using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AnotherTodo
{
	public class TodoServiceMock : ITodoService
	{
		private Dictionary<string, TodoList> todoListDict = new Dictionary<string, TodoList>();
		private Dictionary<string, Dictionary<string, Todo>> todoDictionaries = new Dictionary<string, Dictionary<string, Todo>>();

		public TodoServiceMock()
		{
			PopulateData();
		}

		public async Task<TodoListCollection> GetAllTodoListsAsync()
		{
			TodoListCollection result = new TodoListCollection();
			await Task.Run(() => {
				result.Items = new List<TodoList>();
				foreach (var entry in todoListDict) {
					result.Items.Add(entry.Value);
				}
			});
			return result;
		}

		public async Task<TodoList> GetTodoListAsync(string id)
		{
			TodoList result = null;
			await Task.Run(() => {
				if (todoListDict.ContainsKey(id)) {
					result = todoListDict[id];
				}
			});
			return result;
		}

		public async Task<TodoList> AddTodoListAsync(TodoList todoList)
		{
			await Task.Run(() => {
				todoList.Id = Guid.NewGuid().ToString();
				todoListDict[todoList.Id] = todoList;
				todoDictionaries.Add(todoList.Id, new Dictionary<string, Todo>());
			});
			return todoList;
		}

		public async Task<TodoList> UpdateTodoListAsync(TodoList todoList)
		{
			await Task.Run(() => {
				todoListDict[todoList.Id] = todoList;
			});
			return todoList;
		}

		public async Task DeleteTodoListAsync(string id)
		{
			await Task.Run(() => {
				if (todoListDict.ContainsKey(id)) {
					todoListDict.Remove(id);
				}
			});
		}

		public async Task<TodoCollection> GetAllTodosAsync(string todoListId)
		{
			TodoCollection result = new TodoCollection();
			await Task.Run(() => {
				result.Items = new List<Todo>();
				if (todoDictionaries.ContainsKey(todoListId)) {
					foreach (var entry in todoDictionaries[todoListId]) {
						entry.Value.TodoListId = todoListId;
						result.Items.Add(entry.Value);
					}
				}
			});
			return result;
		}

		public async Task<Todo> GetTodoAsync(string id, string todoListId)
		{
			Todo result = null;
			await Task.Run(() => {
				if (todoDictionaries.ContainsKey(todoListId) && todoDictionaries[todoListId].ContainsKey(id)) {
					result = todoDictionaries[todoListId][id];
					result.TodoListId = todoListId;
				}
			});
			return result;
		}

		public async Task<Todo> AddTodoAsync(Todo todo, string previous)
		{
			await Task.Run(() => {
				if (todoDictionaries.ContainsKey(todo.TodoListId)) {
					todo.Id = Guid.NewGuid().ToString();
					todoDictionaries[todo.TodoListId][todo.Id] = todo;
				}
			});
			return todo;
		}

		public async Task<Todo> UpdateTodoAsync(Todo todo)
		{
			await Task.Run(() => {
				if (todoDictionaries.ContainsKey(todo.TodoListId) && todoDictionaries[todo.TodoListId].ContainsKey(todo.Id)) {
					todoDictionaries[todo.TodoListId][todo.Id] = todo;
				}
			});
			return todo;
		}

		public async Task DeleteTodoAsync(string id, string todoListId)
		{
			await Task.Run(() => {
				if (todoDictionaries.ContainsKey(todoListId) && todoDictionaries[todoListId].ContainsKey(id)) {
					todoDictionaries[todoListId].Remove(id);
				}
			});
		}

		private void PopulateData()
		{
			var todoList = addTodoList(new TodoList {
				Id = Guid.NewGuid().ToString(),
				Title = "Personal",
				Updated = DateTime.UtcNow,
			});

			addTodo(new Todo {
				Id = Guid.NewGuid().ToString(),
				TodoListId = todoList.Id,
				Title = "Personal Task # 1",
				Updated = DateTime.UtcNow,
			});

			addTodo(new Todo {
				Id = Guid.NewGuid().ToString(),
				TodoListId = todoList.Id,
				Title = "Personal Task # 2",
				Updated = DateTime.UtcNow,
			});

			var todo = addTodo(new Todo {
				Id = Guid.NewGuid().ToString(),
				TodoListId = todoList.Id,
				Title = "Personal Task # 3",
				Updated = DateTime.UtcNow,
			});

			addTodo(new Todo {
				Id = Guid.NewGuid().ToString(),
				TodoListId = todoList.Id,
				Title = "Personal Task # 3.1",
				Updated = DateTime.UtcNow,
				Parent = todo.Id,
			});

			addTodo(new Todo {
				Id = Guid.NewGuid().ToString(),
				TodoListId = todoList.Id,
				Title = "Personal Task # 3.2",
				Updated = DateTime.UtcNow,
				Parent = todo.Id,
			});

			addTodo(new Todo {
				Id = Guid.NewGuid().ToString(),
				TodoListId = todoList.Id,
				Title = "Personal Task # 4",
				Updated = DateTime.UtcNow,
			});

			var todoList2 = addTodoList(new TodoList {
				Id = Guid.NewGuid().ToString(),
				Title = "Business",
				Updated = DateTime.UtcNow,
			});

			addTodo(new Todo {
				Id = Guid.NewGuid().ToString(),
				TodoListId = todoList2.Id,
				Title = "Business Task # 1",
				Updated = DateTime.UtcNow,
			});

			addTodo(new Todo {
				Id = Guid.NewGuid().ToString(),
				TodoListId = todoList2.Id,
				Title = "Business Task # 2",
				Updated = DateTime.UtcNow,
			});

			addTodo(new Todo {
				Id = Guid.NewGuid().ToString(),
				TodoListId = todoList2.Id,
				Title = "Business Task # 3",
				Updated = DateTime.UtcNow,
			});
		}

		private TodoList addTodoList(TodoList todoList)
		{
			todoList.Id = Guid.NewGuid().ToString();
			todoListDict[todoList.Id] = todoList;
			todoDictionaries.Add(todoList.Id, new Dictionary<string, Todo>());
			return todoList;
		}

		private Todo addTodo(Todo todo)
		{
			if (todoDictionaries.ContainsKey(todo.TodoListId)) {
				todo.Id = Guid.NewGuid().ToString();
				todoDictionaries[todo.TodoListId][todo.Id] = todo;
			}
			return todo;
		}
	}
}
