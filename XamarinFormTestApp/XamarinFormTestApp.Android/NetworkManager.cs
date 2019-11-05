using System;
using Android.Content;
using Android.Net;


[assembly:Xamarin.Forms.Dependency(typeof(XamarinFormTestApp.Droid.NetworkManager))]
namespace XamarinFormTestApp.Droid
{
    public class NetworkManager : Service.INetworkManager
    {
        Context ctx = Android.App.Application.Context;
        public bool isNetworkConnected()
        {
            var cSvc = (ConnectivityManager)ctx.GetSystemService(Context.ConnectivityService);
            return cSvc.ActiveNetworkInfo != null && cSvc.ActiveNetworkInfo.IsConnected;
        }
    }
}