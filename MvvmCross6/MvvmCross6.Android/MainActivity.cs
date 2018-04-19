// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Forms.Platforms.Android.Views;
using MvvmCross6.Core.ViewModels;
using MvvmCross6.Core;
using Android;

namespace MvvmCross6.Android
{
    [Activity(
        Label = "MvvmCross6.Forms",
        Icon = "@mipmap/icon",
        Theme = "@style/AppTheme",
         MainLauncher = true, // No Splash Screen: Uncomment this lines if removing splash screen
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
        LaunchMode = LaunchMode.SingleTask)]
    public class MainActivity
        //: MvxFormsAppCompatActivity<MainViewModel>

    // No Splash Screen: use this base instead
     : MvxFormsAppCompatActivity<Setup, Core.App, FormsApp, MainViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            base.OnCreate(bundle);
        }
    }
}
