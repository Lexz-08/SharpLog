using System;

namespace SharpLog
{
	public struct Event
	{
		private string eventThatOccured;
		private bool
			showDate,
			showTime;

		public Event(string EventThatOccured, bool ShowDate = true, bool ShowTime = true)
		{
			eventThatOccured = EventThatOccured;

			showDate = ShowDate;
			showTime = ShowTime;
		}

		public string EventThatOccured
		{
			get
			{
				string date = string.Format("{0:D2}/{1:D2}/{2:D4}", DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Year);
				string time = string.Format("{0:D2}:{1:D2}:{2:D2}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);

				string str_eventThatOccured = string.Empty;
				if (showDate && showTime)
				{
					str_eventThatOccured = string.Format("[{0}, {1}] {2}", date, time, eventThatOccured);
				}
				else if (showDate && !showTime)
				{
					str_eventThatOccured = string.Format("[{0}] {1}", date, eventThatOccured);
				}
				else if (!showDate && showTime)
				{
					str_eventThatOccured = string.Format("[{0}] {1}", date, eventThatOccured);
				}
				else if (!showDate && !showTime)
				{
					str_eventThatOccured = string.Format("{0}", eventThatOccured);
				}

				return str_eventThatOccured;
			}
		}

		public string Date
		{
			get
			{
				return string.Format("{0:D2}/{1:D2}/{3:D4}", DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Year);
			}
		}

		public string Time
		{
			get
			{
				return string.Format("{0:D2}:{1:D2}:{2:D2}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
			}
		}
	}

	public class Logger
	{
		public static string LogEvent(object sender, string eventThatOccured, bool showDate = true, bool showTime = true)
		{
			Event @event = new Event(sender + ": " + eventThatOccured, showDate, showTime);
			return @event.EventThatOccured;
		}

		public static string LogEvent_OnlyEvent(object sender, string eventThatOccured)
		{
			return LogEvent(sender, eventThatOccured, false, false);
		}

		public static string LogEvent_IncludeDate(object sender, string eventThatOccured)
		{
			return LogEvent(sender, eventThatOccured, default, false);
		}

		public static string LogEvent_IncludeTime(object sender, string eventThatOccured)
		{
			return LogEvent(sender, eventThatOccured, false);
		}
	}
}
