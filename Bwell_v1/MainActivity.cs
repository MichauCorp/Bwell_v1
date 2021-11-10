using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace Bwell_v1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button btnOptions, btnNew, btnEdit;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            btnNew = (Button)FindViewById(Resource.Id.btnNew);
            btnEdit = (Button)FindViewById(Resource.Id.btnEdit);

            btnNew.Click += BtnNew_Click;
            btnEdit.Click += BtnEdit_Click;
        }

        private void BtnEdit_Click(object sender, System.EventArgs e)
        {
            Intent i = new Intent(this, typeof(ActivityEdit));
            StartActivity(i);
        }

        private void BtnNew_Click(object sender, System.EventArgs e)
        {
            Intent i = new Intent(this, typeof(ActivityCreate));
            StartActivity(i);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}