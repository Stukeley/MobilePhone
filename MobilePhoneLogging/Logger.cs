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

		public int CurrentId { get; set; }

		private static Logger _instance;

		public static Logger Instance
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
			FilePath = Directory.GetCurrentDirectory() + @$"\Logs\Log {DateTime.Now:ddMM HHmm}" + ".txt";

			CurrentId = 1;

			InsertLog(new LogEntry("Logger set up successfully."));
		}

		public void InsertLog(LogEntry log)
		{
			using (var writer = new StreamWriter(FilePath, true))
			{
				writer.WriteLine($"{CurrentId++} {log.DateCreated} {log.Message}");
			}
		}
	}
}
