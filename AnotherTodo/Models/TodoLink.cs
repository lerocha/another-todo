using System;

namespace AnotherTodo
{
	public class TodoLink
	{
		/// <summary>
		/// Type of the link, e.g. "email".
		/// </summary>
		/// <value>The type.</value>
		public string Type { get; set; }

		/// <summary>
		/// The description. In HTML speak: Everything between <a> and </a>.	
		/// </summary>
		/// <value>The description.</value>
		public string Description { get; set; }

		/// <summary>
		/// The URL.
		/// </summary>
		/// <value>The URL.</value>
		public string Link { get; set; }
	}
}

