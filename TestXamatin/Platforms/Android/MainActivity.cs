using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;

namespace TestXamatin;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnResume()
    {
        Window?.ClearFlags(WindowManagerFlags.Secure);
        base.OnResume();
    }

    protected override void OnPause()
    {
        Window?.SetFlags(WindowManagerFlags.Secure, WindowManagerFlags.Secure);
        base.OnPause();
    }
}
