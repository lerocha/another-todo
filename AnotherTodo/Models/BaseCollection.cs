using System;
using System.Collections.Generic;

namespace AnotherTodo
{
	public class BaseCollection<T> where T : new()
	{
		/// <summary>
		/// Type of the resource. This is always "tasks#taskLists".
		/// </summary>
		/// <value>The kind.</value>
		public string Kind { get; set; }

		/// <summary>
		/// ETag of the resource.
		/// </summary>
		/// <value>The etag.</value>
		public string Etag { get; set; }

		/// <summary>
		/// Token that can be used to request the next page of this result.
		/// </summary>
		/// <value>The next page token.</value>
		public string NextPageToken { get; set; }

		/// <summary>
		/// Collection of task lists.
		/// </summary>
		/// <value>The items.</value>
		public List<T> Items { get; set; }
	}
}

