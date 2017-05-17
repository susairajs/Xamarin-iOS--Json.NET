using System;

using UIKit;
using Newtonsoft.Json.Linq;

namespace XamariniOSJson
{
	public partial class ViewController : UIViewController
	{
		public static string filename = "JsonFile";
		public static string name = "Name";
		JObject js = new JObject();
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		partial void BtnRead_TouchUpInside(UIButton sender)
		{
			lblDisplay.Text = "Name:" + JsonHelper.JsonReader(filename,name);
		}

		partial void BtnWrite_TouchUpInside(UIButton sender)
		{
			js.Add(name, txtInput.Text);
			JsonHelper.JsonWrite(filename, js.ToString());
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
