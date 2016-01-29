using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace MultiAssemblyNav.Droid1
{
    [Activity(
        Label = "MultiAssemblyNav.Droid1"
        , MainLauncher = true
        , Icon = "@drawable/icon"
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}
