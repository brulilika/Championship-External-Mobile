using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;

namespace Championship_External_Mobile.Droid
{
    [Activity(Label = "Championship_External_Mobile", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHRqVVhkVFpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF5jS39XdEVgUH1ZdnxWRg==;Mgo+DSMBPh8sVXJ0S0J+XE9AflRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS31TdERnW39deXZSTmVZVw==;ORg4AjUWIQA/Gnt2VVhkQlFacldJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkdiXX1ec31XTmBVVEQ=;MTEzMTYxMEAzMjMwMmUzNDJlMzBZNStuTVB5dEY0c3pUVkhJbkRoZlcrUXV2L2ZsTHc3LzE5d3I1anpWMngwPQ==;MTEzMTYxMUAzMjMwMmUzNDJlMzBKWWlqNWFGRmJJbWRRbWg2NkwxeGlQL1ZaL0hDRnhvby9FQXBlZXZyNU1JPQ==;NRAiBiAaIQQuGjN/V0Z+WE9EaFtKVmJLYVB3WmpQdldgdVRMZVVbQX9PIiBoS35RdUVhWHtccHdcRGlcUUB3;MTEzMTYxM0AzMjMwMmUzNDJlMzBQS0d0RWxaL3IzclV2UUZ5Q3dzYk5Kc1JkaG03VEtEeWpjSXpocnBpbG5rPQ==;MTEzMTYxNEAzMjMwMmUzNDJlMzBjWFdqbjl2bVBlNHBPMFROZUpTbDFsMUxWSkpRdkxuMElweCs0WkNFZWFBPQ==;Mgo+DSMBMAY9C3t2VVhkQlFacldJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkdiXX1ec31XT2lcUEU=;MTEzMTYxNkAzMjMwMmUzNDJlMzBDY1MveGZIK0JxeG4zclg4OXV2eFl6MFVXa0g0S2M5YUFlRTFIaDZnRXFFPQ==;MTEzMTYxN0AzMjMwMmUzNDJlMzBXR29NZWI1NDBZK1NSa055a3BkRUJWZDE3cTUwTGZWZGdTaDJLOGd1L0tZPQ==;MTEzMTYxOEAzMjMwMmUzNDJlMzBQS0d0RWxaL3IzclV2UUZ5Q3dzYk5Kc1JkaG03VEtEeWpjSXpocnBpbG5rPQ==");
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
