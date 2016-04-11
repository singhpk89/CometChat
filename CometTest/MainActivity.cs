using Android.App;
using Android.Widget;
using Android.OS;
using Com.Inscripts.Cometchat.Sdk;
using Com.Inscripts.Interfaces;


namespace CometTest
{
	[Activity (Label = "CometTest", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity, ICallbacks
	{
		int count = 1;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			var chat = CometChat.GetInstance (this, "7808ebda5f6c611695c58f0911e9ff6f");
			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				chat.Login("test-48", "32123sdf", this);
				button.Text = string.Format ("{0} clicks!", count++);
			};
		}

		public void FailCallback (Org.Json.JSONObject p0)
		{
			throw new System.NotImplementedException ();
		}

		public void SuccessCallback (Org.Json.JSONObject p0)
		{
			throw new System.NotImplementedException ();
		}
	}
}


