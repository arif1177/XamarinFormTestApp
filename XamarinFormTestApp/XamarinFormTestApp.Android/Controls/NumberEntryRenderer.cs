using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: Xamarin.Forms.ExportRenderer(typeof(XamarinFormTestApp.Controls.NumberEntry),typeof(XamarinFormTestApp.Droid.Controls.NumberEntryRenderer))]//Handler (first arg. is our shared class, i.e., NumberEntry), 2nd arg i.e, target is our local renderer here.
namespace XamarinFormTestApp.Droid.Controls
{
    class NumberEntryRenderer:EntryRenderer
    {
        public NumberEntryRenderer(Context ctx):base(ctx)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);//call base to handle all the basic functionalities
            if(Control != null)
            {
                Control.InputType = Android.Text.InputTypes.ClassNumber | Android.Text.InputTypes.NumberVariationNormal;
            }

        }
    }
}