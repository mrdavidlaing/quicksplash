using System;
using System.IO;

namespace Splashscreen
{
    public class SplashscreenController
    {
		/// <summary>
		/// The lockfile name will be passed automatically by Splash.exe as a  
		/// command line arg -lockfile="c:\temp\C1679A85-A4FA-48a2-BF77-E74F73E08768.lock"
		/// </summary>
		/// <returns>Lock file path</returns>
		private static string GetLockFile()
		{
			foreach (string arg in Environment.GetCommandLineArgs())
			{
				if (arg.StartsWith("-lockfile="))
				{
					return arg.Replace("-lockfile=",String.Empty);
				}
			}
			//Couldn't find correct argument, so throw error
			throw new ArgumentNullException("Must call EXE with -lockfile= command line argument");
		}

		public static void UpdateStatusLabel(string comment)
		{
			TextWriter tw = new StreamWriter(GetLockFile(), false);
			tw.WriteLine(comment);
			tw.Close();
		}

		public static void CloseSplash()
		{
			File.Delete(GetLockFile());
		}
    }
}

