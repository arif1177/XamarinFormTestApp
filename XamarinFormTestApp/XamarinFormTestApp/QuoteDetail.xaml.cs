using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormTestApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuoteDetail : ContentPage
    {
        public QuoteDetail()
        {
            InitializeComponent();
        }
        public QuoteDetail(Service.QuoterDetailsModel quoterDetailsModel)
        {
            InitializeComponent();
            BindingContext = quoterDetailsModel;
        }
    }
}