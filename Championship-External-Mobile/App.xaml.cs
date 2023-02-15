using System;
using ChampionshipExternalMobile.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Championship_External_Mobile
{
    public partial class App : Application
    {
        public App ()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHRqVVhkVFpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF5jS39XdEVgUH1ZdnxWRg==;Mgo+DSMBPh8sVXJ0S0J+XE9AflRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS31TdERnW39deXZSTmVZVw==;ORg4AjUWIQA/Gnt2VVhkQlFacldJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkdiXX1ec31XTmBVVEQ=;MTEzMTYxMEAzMjMwMmUzNDJlMzBZNStuTVB5dEY0c3pUVkhJbkRoZlcrUXV2L2ZsTHc3LzE5d3I1anpWMngwPQ==;MTEzMTYxMUAzMjMwMmUzNDJlMzBKWWlqNWFGRmJJbWRRbWg2NkwxeGlQL1ZaL0hDRnhvby9FQXBlZXZyNU1JPQ==;NRAiBiAaIQQuGjN/V0Z+WE9EaFtKVmJLYVB3WmpQdldgdVRMZVVbQX9PIiBoS35RdUVhWHtccHdcRGlcUUB3;MTEzMTYxM0AzMjMwMmUzNDJlMzBQS0d0RWxaL3IzclV2UUZ5Q3dzYk5Kc1JkaG03VEtEeWpjSXpocnBpbG5rPQ==;MTEzMTYxNEAzMjMwMmUzNDJlMzBjWFdqbjl2bVBlNHBPMFROZUpTbDFsMUxWSkpRdkxuMElweCs0WkNFZWFBPQ==;Mgo+DSMBMAY9C3t2VVhkQlFacldJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkdiXX1ec31XT2lcUEU=;MTEzMTYxNkAzMjMwMmUzNDJlMzBDY1MveGZIK0JxeG4zclg4OXV2eFl6MFVXa0g0S2M5YUFlRTFIaDZnRXFFPQ==;MTEzMTYxN0AzMjMwMmUzNDJlMzBXR29NZWI1NDBZK1NSa055a3BkRUJWZDE3cTUwTGZWZGdTaDJLOGd1L0tZPQ==;MTEzMTYxOEAzMjMwMmUzNDJlMzBQS0d0RWxaL3IzclV2UUZ5Q3dzYk5Kc1JkaG03VEtEeWpjSXpocnBpbG5rPQ==");

            InitializeComponent();

            MainPage = new NavigationPage(new InitialBoard());
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

