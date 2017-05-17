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
		public static string JsonReader(string filename, string fieldname)
		{
			try
			{
				var filepath = Path.Combine(Folderpath, filename + fileextension);
				var content = File.ReadAllText(filepath);
				JObject obj = JObject.Parse(content);
				return obj[fieldname].ToString();

			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				return null;
			}
				
		}

	}
}
