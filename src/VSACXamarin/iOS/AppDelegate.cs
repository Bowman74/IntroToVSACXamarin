using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace VSACXamarin.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication uiApplication, NSDictionary launchOptions)
        {
            AppCenter.Start("e0bb52e8-e079-466c-9a2c-6a13d5123d63",
                   typeof(Analytics), typeof(Crashes));
            
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

#if DEBUG || QA
            Xamarin.Calabash.Start();
#endif
            return base.FinishedLaunching(uiApplication, launchOptions);
        }
    }
}
