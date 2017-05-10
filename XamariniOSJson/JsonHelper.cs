using System;
using System.IO;
using Newtonsoft.Json.Linq;
namespace XamariniOSJson
{
	public class JsonHelper
	{
		public static string fileextension = ".json";
		public static string Folderpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

		public static bool JsonWrite(string filename, string JsonData)
		{
			try
			{
				var filepath = Path.Combine(Folderpath, filename + fileextension);
				File.WriteAllText(filepath, JsonData);
				Console.WriteLine(true.ToString());
				return true;
			}
			catch(Exception e)
			{
				Console.WriteLine(e.ToString());
				return false;
			}
		}

	}
}
