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
    public partial class TabGridSpinnerForm : TabbedPage
    {
        public TabGridSpinnerForm()
        {
            InitializeComponent();
        }

        private void orderBtnClicked(object sender, EventArgs e)
        {
            DisplayAlert("Order placed","Order placed","OK");
        }
    }
}