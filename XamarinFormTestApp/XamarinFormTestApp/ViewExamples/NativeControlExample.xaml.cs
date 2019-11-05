using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormTestApp.ViewExamples
{
    [XamlCompilation(XamlCompilationOptions.Skip)]//we are skipping compiling cos a native control is there (rating control)
    public partial class NativeControlExample : ContentPage
    {
        public NativeControlExample()
        {
            InitializeComponent();            
            BindingContext = new Rating();//Built a native class that holds the currentRating, an int value. Did not find more elegant way.
        }

        private void getStatusBtnClicked(object sender, EventArgs e)
        {
            int m = (BindingContext as Rating).currentRating;            
            DisplayAlert("Status", "Current rating is " + m, "OK");
        }

        private class Rating
        {
            public int currentRating{get;set;}
        }
    }
}