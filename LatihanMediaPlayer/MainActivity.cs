using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Media;

namespace LatihanMediaPlayer
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        MediaPlayer player;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            player = MediaPlayer.Create(this, Resource.Raw.test);
            var playButton = FindViewById<Button>(Resource.Id.play);
            playButton.Click += delegate {
                player.Start();
            };

            player = MediaPlayer.Create(this, Resource.Raw.test);
            var pauseButton = FindViewById<Button>(Resource.Id.pause);
            pauseButton.Click += delegate {
                player.Pause();
            };

            player = MediaPlayer.Create(this, Resource.Raw.test);
            var stopButton = FindViewById<Button>(Resource.Id.stop);
            stopButton.Click += delegate {
                player.Stop();
            };
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}