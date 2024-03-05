using Android.App;
using Android.Runtime;

namespace MauiDemoApp
{
    [Application]
    //[MetaData("com.google.android.maps.v2.API_KEY", Value = "PASTE-YOUR-API-KEY-HERE")]
    //[MetaData("com.google.android.gms.version", Value = "@integer/google_play_services_version")]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}
