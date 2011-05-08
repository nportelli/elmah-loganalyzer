﻿using Crepido.ElmahOfflineViewer.Core.Domain;

namespace Crepido.ElmahOfflineViewer.Core.Integrations
{
	public class GoogleErrorSearchLauncher : ErrorSearchLauncherBase
	{
		private const string UrlTemplate = "http://www.google.com/search?q={0}+{1}";

		public GoogleErrorSearchLauncher(ErrorLog errorLog) : base(errorLog)
		{
		}

		public override string BuildSearchUrl()
		{
			return string.Format(UrlTemplate, ErrorLog.Type, ErrorLog.Source);
		}
	}
}