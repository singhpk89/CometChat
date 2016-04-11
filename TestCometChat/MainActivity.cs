using Android.App;
using Android.Widget;
using Android.OS;
using Com.Inscripts.Cometchat.Sdk;
using Com.Inscripts.Interfaces;

namespace TestCometChat
{
	[Activity (Label = "TestCometChat", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity, ICallbacks
	{
		int count = 1;
		CometChat cometChat;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);

			cometChat = CometChat.GetInstance (this, "10415x77177883eedf5255554e825180e563c1");

			button.Click += delegate {
				cometChat.Login("test-48", "32123sdf", this);
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


