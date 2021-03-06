﻿using System;
using System.Collections.Generic;

namespace ElmahLogAnalyzer.Core.Domain
{
	public interface IErrorLogRepository
	{
		event EventHandler<RepositoryInitializedEventArgs> OnInitialized; 

		string Connection { get; }
		
		void Initialize();
		
		List<ErrorLog> GetAll();
		
		IList<ErrorLog> GetWithFilter(SearchErrorLogQuery filter);

		List<string> GetApplications();

		List<string> GetTypes();
		
		List<string> GetSources();
		
		List<string> GetUsers();

		List<string> GetUrls();
	}
}
