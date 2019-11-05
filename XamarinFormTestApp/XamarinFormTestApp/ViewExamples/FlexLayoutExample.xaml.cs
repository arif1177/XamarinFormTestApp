using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormTestApp.ViewExamples
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlexLayoutExample : ContentPage
    {
        public FlexLayoutExample()
        {
            InitializeComponent();
        }

        private void FlexMenuClicked(object sender, EventArgs e)
        {
            DisplayAlert("Clicked", "Menu Item Clicked, ID is " + ((TappedEventArgs)e).Parameter, "Ok");
        }

    }
}