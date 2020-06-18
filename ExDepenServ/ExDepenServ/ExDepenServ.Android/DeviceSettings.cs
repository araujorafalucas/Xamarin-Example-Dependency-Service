using Android.Content.Res;
using ExDepenServ.Droid;
using System;
using Xamarin.Forms;

[assembly: Dependency(typeof(DeviceSettings))]
namespace ExDepenServ.Droid
{
    public class DeviceSettings : IDeviceSettings
    {
        public int GetHeight()
        {
            return Resources.System.DisplayMetrics.HeightPixels;
        }

        public int GetWidth()
        {
            return Resources.System.DisplayMetrics.WidthPixels;
        }
    }
}