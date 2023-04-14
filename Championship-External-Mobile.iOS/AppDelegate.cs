using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using Syncfusion.ListView.XForms.iOS;
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
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHRqVVhlWFpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF5jTX9QdkRnWXpcdXZRRQ==;Mgo+DSMBPh8sVXJ0S0J+XE9BclRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS31TckRgWX5acHFXQ2RYUg==;ORg4AjUWIQA/Gnt2VVhkQlFac1tJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkFiWn9fdHRQRGVaUEc=;MTcwNDg3MEAzMjMwMmUzNDJlMzBoWXU0VmdrZ0l6eHMxTzZMeDlBZ2U5Mk9TRDhGN2dpc2tUbTJHM0tNN3drPQ==;MTcwNDg3MUAzMjMwMmUzNDJlMzBXNzUzaXVPdHRUcUZ0aks5ZEZWaXRPemc2WVRxcHFmbm1FZ0Z6ZEhCdEZvPQ==;NRAiBiAaIQQuGjN/V0Z+WE9EaFpGVmJLYVB3WmpQdldgdVRMZVVbQX9PIiBoS35RdUVnWHxecXBVQ2JaVUJ1;MTcwNDg3M0AzMjMwMmUzNDJlMzBWSFU5K1hEbFpqYmZxMUpDa1l5TkRHaDJTaXhacHlwZ1BhTEIwRGZzYXAwPQ==;MTcwNDg3NEAzMjMwMmUzNDJlMzBWOGcxUUpINXJ2YjB5VVJNekZBcVl4VWp4Z0xTL2x5RTVBenZaOENwVGVVPQ==;Mgo+DSMBMAY9C3t2VVhkQlFac1tJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkFiWn9fdHRQRGdeU0c=;MTcwNDg3NkAzMjMwMmUzNDJlMzBsdEIrekpDQ1haWi9ZRXlCMy94cUpCdmU4THptbmloSzR3OHZjTXhHYlVZPQ==;MTcwNDg3N0AzMjMwMmUzNDJlMzBCc0dZRlJFbWtzNGsvVUlyeGt2aXNNRk9TdmJVeW80V2hrQnVlcW9UK0ZnPQ==;MTcwNDg3OEAzMjMwMmUzNDJlMzBWSFU5K1hEbFpqYmZxMUpDa1l5TkRHaDJTaXhacHlwZ1BhTEIwRGZzYXAwPQ===");
            global::Xamarin.Forms.Forms.Init();
            #region Synfusion Declaration
            Syncfusion.XForms.iOS.Expander.SfExpanderRenderer.Init();
            Syncfusion.XForms.iOS.Border.SfBorderRenderer.Init();
            Syncfusion.XForms.iOS.Buttons.SfButtonRenderer.Init();
            Syncfusion.XForms.iOS.Cards.SfCardViewRenderer.Init();
            Syncfusion.XForms.iOS.TabView.SfTabViewRenderer.Init();
            SfListViewRenderer.Init();
            #endregion
            LoadApplication(new App());            
            return base.FinishedLaunching(app, options);
        }
    }
}