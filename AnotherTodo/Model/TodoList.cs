using System;

namespace AnotherTodo
{
	/// <summary>
	/// Model for a Tasklist resource.
	/// https://developers.google.com/google-apps/tasks/v1/reference/tasklists
	/// </summary>
	public class TodoList
	{
		/// <summary>
		/// Type of the resource. This is always "tasks#taskList".
		/// </summary>
		/// <value>The kind.</value>
		public string Kind { get; set; }

		//// <summary>
		/// Task list identifier.
		/// </summary>
		/// <value>The identifier.</value>
		public string Id { get; set; }

		/// <summary>
		/// ETag of the resource.
		/// </summary>
		/// <value>The etag.</value>
		public string Etag { get; set; }

		/// <summary>
		/// Title of the task list.
		/// </summary>
		/// <value>The title.</value>
		public string Title { get; set; }

		/// <summary>
		/// Last modification time of the task list (as a RFC 3339 timestamp).
		/// </summary>
		/// <value>The updated.</value>
		public DateTime? Updated { get; set; }

		/// <summary>
		/// URL pointing to this task list. Used to retrieve, update, or delete this task list.
		/// </summary>
		/// <value>The self link.</value>
		public string SelfLink { get; set; }	
	}
}

