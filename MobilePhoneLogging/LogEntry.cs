using System;

namespace MobilePhone.Logging
{
	public class LogEntry
	{
		public string Message { get; set; }
		public DateTime DateCreated { get; set; }

		public LogEntry(string message)
		{
			Message = message;
			DateCreated = DateTime.Now;
		}
	}
}
