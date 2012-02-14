﻿using ElmahLogAnalyzer.Core.Domain;

namespace ElmahLogAnalyzer.Core.Infrastructure.Dependencies
{
	public static class DataSourceScopeController
	{
		private static object _keepAlive = new object();

		public static ErrorLogSourcesEnum Source { get; private set; }
		
		public static string Connection { get; private set; }

		public static object KeepAlive
		{
			get { return _keepAlive; }
		}

		public static void SetNewSource(ErrorLogSourcesEnum source, string connection)
		{
			Source = source;
			Connection = connection;

			_keepAlive = new object();
		}
	}
}