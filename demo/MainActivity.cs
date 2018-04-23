using System;
using System.Threading.Tasks;
using Android.App;
using Android.OS;
using Android.Util;
using Android.Widget;
using Com.Airbnb.Lottie;

namespace demo
{
	[Activity (Label = "demo", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
        Button button;
		private LottieAnimationView animationView;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.Main);
            this.button = FindViewById<Button>(Resource.Id.bt);

			this.animationView = FindViewById<LottieAnimationView> (Resource.Id.animation_view);

            button.Click += Button_Click;
		}

        private void Button_Click(object sender, EventArgs e)
        {
            this.animationView.Progress = 0f;
            this.animationView.PlayAnimation();

            StartLogin();
        }

        protected override void OnStop ()
		{
			base.OnStop ();
			this.animationView.CancelAnimation();
		}

        private async void StartLogin()
        {
            await Task.Delay(5000);
            Log.Error("lv","====================");
        }
    }
}

