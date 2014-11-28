using System;
using System.Threading.Tasks;

namespace AnotherTodo
{
	public interface ITodoService
	{
		/// <summary>
		/// Returns all the authenticated user's task lists.
		/// </summary>
		/// <returns>The all task lists.</returns>
		Task<TodoListCollection> GetAllTodoListsAsync();

		/// <summary>
		/// Returns the authenticated user's specified task list.
		/// </summary>
		/// <returns>The task list.</returns>
		/// <param name="tasklist">Tasklist.</param>
		Task<TodoList> GetTodoListAsync(string id);

		/// <summary>
		/// Creates a new task list and adds it to the authenticated user's task lists.
		/// </summary>
		/// <returns>If successful, this method returns a Tasklists resource in the response body.</returns>
		/// <param name="todoList">Todo list.</param>
		Task<TodoList> AddTodoListAsync(TodoList todoList);

		/// <summary>
		/// Updates the authenticated user's specified task list.
		/// </summary>
		/// <returns>If successful, this method returns a Tasklists resource in the response body.</returns>
		/// <param name="todoList">Todo list.</param>
		Task<TodoList> UpdateTodoListAsync(TodoList todoList);

		/// <summary>
		/// Deletes the authenticated user's specified task list.
		/// </summary>
		/// <param name="tasklist">Tasklist.</param>
		Task DeleteTodoListAsync(string id);

		/// <summary>
		/// Returns all tasks in the specified task list.
		/// </summary>
		/// <returns>The all todos async.</returns>
		/// <param name="todoListId">Todo list identifier.</param>
		Task<TodoCollection> GetAllTodosAsync(string todoListId);

		/// <summary>
		/// Returns the specified task.
		/// </summary>
		/// <returns>The todo async.</returns>
		/// <param name="id">Task identifier.</param>
		/// <param name="todoListId">Task list identifier.</param>
		Task<Todo> GetTodoAsync(string id, string todoListId);

		/// <summary>
		/// Creates a new task on the specified task list.
		/// </summary>
		/// <returns>The todo async.</returns>
		/// <param name="todo">Todo.</param>
		/// <param name="previous">Previous sibling task identifier. If the task is created at the first position among its siblings, this parameter is omitted. Optional.</param>
		Task<Todo> AddTodoAsync(Todo todo, string previous);

		/// <summary>
		/// Updates the specified task. 
		/// </summary>
		/// <returns>The todo async.</returns>
		/// <param name="todo">Todo.</param>
		Task<Todo> UpdateTodoAsync(Todo todo);

		/// <summary>
		/// Deletes the specified task from the task list.
		/// </summary>
		/// <returns>The todo async.</returns>
		/// <param name="id">Identifier.</param>
		/// <param name="todoListId">Todo list identifier.</param>
		Task DeleteTodoAsync(string id, string todoListId);
	}
}
