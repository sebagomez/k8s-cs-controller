﻿using System;
using System.Threading.Tasks;
using K8sControllerSDK;
using NLog;

namespace mssql_db
{
	class MSSQLController
	{
		private static readonly Logger Log = LogManager.GetCurrentClassLogger();

		static void Main(string[] args)
		{
			try
			{
				string k8sNamespace = "default";
				if (args.Length > 1)
					k8sNamespace = args[0];

				Controller<MSSQLDB>.ConfigLogger();

				Log.Info($"=== {nameof(MSSQLController)} STARTING for namespace {k8sNamespace} ===");

				MSSQLDBOperationHandler handler = new MSSQLDBOperationHandler();
				Controller<MSSQLDB> controller = new Controller<MSSQLDB>(new MSSQLDB(), handler);
				Task reconciliation = controller.SatrtAsync(k8sNamespace);

				Log.Info($"=== {nameof(MSSQLController)} STARTED ===");

				reconciliation.ConfigureAwait(false).GetAwaiter().GetResult();

			}
			catch (Exception ex)
			{
				Log.Fatal(ex);
			}
			finally
			{
				Log.Warn($"=== {nameof(MSSQLController)} TERMINATING ===");
			}
		}
	}
}
