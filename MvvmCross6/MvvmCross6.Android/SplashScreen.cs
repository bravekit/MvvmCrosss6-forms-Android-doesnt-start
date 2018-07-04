// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Core;
using MvvmCross.Forms.Platforms.Android.Views;
using MvvmCross6.Core;

namespace MvvmCross6.Android
{
    // No Splash Screen: To remove splash screen, remove this class and uncomment lines in MainActivity
    [Activity(
        Label = "MvvmCross6_test"
        , MainLauncher = true
        , Icon = "@mipmap/icon"
        , Theme = "@style/AppTheme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen
        : MvxFormsSplashScreenActivity<Setup, App, FormsApp>
        //: MvvmCross.Platforms.Android.Views.MvxSplashScreenActivity
    {

        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }

        protected override object GetAppStartHint(object hint = null)
        {
            return base.GetAppStartHint(hint);
        }

        protected override void RunAppStart(Bundle bundle)
        {
            StartActivity(typeof(MainActivity));
            base.RunAppStart(bundle);
        }
    }
}
