using AlunoConectadoV100.Droid.Util;
using AlunoConectadoV100.Interface;

using Xamarin.Forms;

[assembly: Dependency(typeof(FullScreenMode))]
namespace AlunoConectadoV100.Droid.Util
{
    public class FullScreenMode : IFullScreenMode
    {
        public void FullScreenModeActivate(bool activate)
        {
            if (activate)
            {
                if (activate)
                    CrossCurrentActivity.Current.Activity.Window.AddFlags(Android.Views.WindowManagerFlags.Fullscreen);
                else
                    CrossCurrentActivity.Current.Activity.Window.ClearFlags(Android.Views.WindowManagerFlags.Fullscreen);
            }
        }
    }

}
        
    
