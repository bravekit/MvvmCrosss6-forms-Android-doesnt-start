using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Core;
using MvvmCross.Forms.Platforms.Android.Core;
using MvvmCross.Forms.Platforms.Android.Views;
using MvvmCross.Logging;
using MvvmCross.ViewModels;
using MvvmCross6.Core;
using Serilog;

namespace MvvmCross6.Android
{
    public class Setup : MvxFormsAndroidSetup<App, FormsApp>
    {
        public override MvxLogProviderType GetDefaultLogProviderType()
            => MvxLogProviderType.Serilog;

        protected override IMvxLogProvider CreateLogProvider()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.AndroidLog()
                .CreateLogger();
            return base.CreateLogProvider();
        }

        protected override IMvxApplication CreateApp()
        {
            var app = base.CreateApp();
            return app;
        }
    }
}