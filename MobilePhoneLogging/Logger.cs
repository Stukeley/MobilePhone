using System;
using System.IO;

namespace MobilePhone.Logging
{
	/// <summary>
	/// Class responsible for logging exceptions & status messages to a text file.
	/// Implemented pattern: Singleton
	/// </summary>
	public class Logger
	{
		private string FilePath { get; set; }

		private Logger _instance;

		public Logger Instance
		{
			get
			{
				if (_instance is null)
				{
					_instance = new Logger();
				}
				return _instance;
			}
		}

		public Logger()
		{
			FilePath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @$"\Logs\Logs {DateTime.Now.ToString("ddMM HHmm")}";
		}

		public void EnterLog(LogEntry log)
		{
			using (var writer = new StreamWriter(FilePath))
			{
				writer.WriteLine($"{log.Id} {log.DateCreated} {log.Message}");
			}
		}
	}
}
