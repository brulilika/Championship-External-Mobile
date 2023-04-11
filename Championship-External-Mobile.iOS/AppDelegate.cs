using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace Championship_External_Mobile.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHRqVVhkVFpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF5jS39XdEVgUH1ZdnxWRg==;Mgo+DSMBPh8sVXJ0S0J+XE9AflRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS31TdERnW39deXZSTmVZVw==;ORg4AjUWIQA/Gnt2VVhkQlFacldJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkdiXX1ec31XTmBVVEQ=;MTEzMTYxMEAzMjMwMmUzNDJlMzBZNStuTVB5dEY0c3pUVkhJbkRoZlcrUXV2L2ZsTHc3LzE5d3I1anpWMngwPQ==;MTEzMTYxMUAzMjMwMmUzNDJlMzBKWWlqNWFGRmJJbWRRbWg2NkwxeGlQL1ZaL0hDRnhvby9FQXBlZXZyNU1JPQ==;NRAiBiAaIQQuGjN/V0Z+WE9EaFtKVmJLYVB3WmpQdldgdVRMZVVbQX9PIiBoS35RdUVhWHtccHdcRGlcUUB3;MTEzMTYxM0AzMjMwMmUzNDJlMzBQS0d0RWxaL3IzclV2UUZ5Q3dzYk5Kc1JkaG03VEtEeWpjSXpocnBpbG5rPQ==;MTEzMTYxNEAzMjMwMmUzNDJlMzBjWFdqbjl2bVBlNHBPMFROZUpTbDFsMUxWSkpRdkxuMElweCs0WkNFZWFBPQ==;Mgo+DSMBMAY9C3t2VVhkQlFacldJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkdiXX1ec31XT2lcUEU=;MTEzMTYxNkAzMjMwMmUzNDJlMzBDY1MveGZIK0JxeG4zclg4OXV2eFl6MFVXa0g0S2M5YUFlRTFIaDZnRXFFPQ==;MTEzMTYxN0AzMjMwMmUzNDJlMzBXR29NZWI1NDBZK1NSa055a3BkRUJWZDE3cTUwTGZWZGdTaDJLOGd1L0tZPQ==;MTEzMTYxOEAzMjMwMmUzNDJlMzBQS0d0RWxaL3IzclV2UUZ5Q3dzYk5Kc1JkaG03VEtEeWpjSXpocnBpbG5rPQ==");
            global::Xamarin.Forms.Forms.Init();
            Syncfusion.XForms.iOS.Cards.SfCardViewRenderer.Init();
            LoadApplication(new App());
            #region Synfusion Declaration
            Syncfusion.XForms.iOS.Border.SfBorderRenderer.Init();
            Syncfusion.XForms.iOS.Buttons.SfButtonRenderer.Init();
            
            #endregion
            return base.FinishedLaunching(app, options);
        }
    }
}