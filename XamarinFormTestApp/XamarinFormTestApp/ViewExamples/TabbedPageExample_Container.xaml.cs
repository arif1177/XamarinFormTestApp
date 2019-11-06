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
    public partial class TabbedPageExample_Container : TabbedPage
    {
        public TabbedPageExample_Container()
        {
            InitializeComponent();
        }
    }
}