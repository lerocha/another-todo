using System;
using System.Collections.Generic;

namespace AnotherTodo
{
	/// <summary>
	/// Model for Task resource.
	/// https://developers.google.com/google-apps/tasks/v1/reference/tasks
	/// </summary>
	public class Todo
	{
		/// <summary>
		/// Type of the resource. This is always "tasks#task".
		/// </summary>
		/// <value>The kind.</value>
		public string Kind { get; set; }

		/// <summary>
		/// Task identifier.
		/// </summary>
		/// <value>The identifier.</value>
		public string Id { get; set; }

		/// <summary>
		/// ETag of the resource.
		/// </summary>
		/// <value>The etag.</value>
		public string Etag { get; set; }

		/// <summary>
		/// Title of the task.
		/// </summary>
		/// <value>The title.</value>
		public string Title { get; set; }

		/// <summary>
		/// Last modification time of the task (as a RFC 3339 timestamp).
		/// </summary>
		/// <value>The updated.</value>
		public DateTime? Updated { get; set; }

		/// <summary>
		/// URL pointing to this task. Used to retrieve, update, or delete this task.
		/// </summary>
		/// <value>The self link.</value>
		public string SelfLink { get; set; }

		/// <summary>
		/// Parent task identifier. This field is omitted if it is a top-level task. This field is read-only. 
		/// Use the "move" method to move the task under a different parent or to the top level.
		/// </summary>
		/// <value>The parent.</value>
		public string Parent { get; set; }

		/// <summary>
		/// String indicating the position of the task among its sibling tasks under the same parent task or at the top level. 
		/// If this string is greater than another task's corresponding position string according to lexicographical ordering, 
		/// the task is positioned after the other task under the same parent task (or at the top level). 
		/// This field is read-only. Use the "move" method to move the task to another position.
		/// </summary>
		/// <value>The position.</value>
		public string Position { get; set; }

		/// <summary>
		/// Notes describing the task. Optional.
		/// </summary>
		/// <value>The notes.</value>
		public string Notes { get; set; }

		/// <summary>
		/// Status of the task. This is either "needsAction" or "completed".
		/// </summary>
		/// <value>The status.</value>
		public string Status { get; set; }

		/// <summary>
		/// Due date of the task (as a RFC 3339 timestamp). Optional.
		/// </summary>
		/// <value>The due.</value>
		public DateTime? Due { get; set; }

		/// <summary>
		/// Completion date of the task (as a RFC 3339 timestamp). This field is omitted if the task has not been completed.
		/// </summary>
		/// <value>The completed.</value>
		public DateTime? Completed { get; set; }

		/// <summary>
		/// Flag indicating whether the task has been deleted. The default if False.
		/// </summary>
		/// <value>The delted.</value>
		public Boolean Deleted { get; set; }

		/// <summary>
		/// Flag indicating whether the task is hidden. This is the case if the task had been marked completed when the task list was last cleared. 
		/// The default is False. This field is read-only.
		/// </summary>
		/// <value>The hidden.</value>
		public Boolean Hidden { get; set; }

		/// <summary>
		/// Collection of links. This collection is read-only.	
		/// </summary>
		/// <value>The links.</value>
		public List<TodoLink> Links { get; set; }
	}
}

