﻿using System;
using System.Collections.Generic;
using System.Linq;
using FFImageLoading.Forms.Platform;
using Foundation;
using UIKit;
using Ziggeo;

namespace Ziggeo.Xamarin.NetStandard.Demo.iOS
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
            global::Xamarin.Forms.Forms.Init();
            global::Xamarin.Forms.FormsMaterial.Init();
            CachedImageRenderer.Init();
            CachedImageRenderer.InitImageSourceHandler();
            
            //todo ZVideoView need to be implemented in IOS
            // var ziggeoPlayer = new ZVideoView(this);
            // var playerView = ziggeoPlayer.ToView();

            LoadApplication(new App(new ZiggeoApplication(), 
                null, 
                null));

            return base.FinishedLaunching(app, options);
        }
    }
}