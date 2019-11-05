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
    public partial class MasDetPgExample : MasterDetailPage
    {
        public MasDetPgExample()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            TapGestureRecognizer tapPg1 = new TapGestureRecognizer();
            tapPg1.Tapped += (sender, e) =>//hell of a shortcut
            {
                Detail = new NavigationPage(new MasDetPgExampleDetailPg1());
                IsPresented = false;
            };
            TapGestureRecognizer tapPg2 = new TapGestureRecognizer();
            tapPg2.Tapped += (sender, e) =>//hell of a shortcut
            {
                Detail = new NavigationPage(new MasDetPgExampleDetailPg2());
                IsPresented = false;
            };
            lblPg1.GestureRecognizers.Add(tapPg1);
            lblPg2.GestureRecognizers.Add(tapPg2);

            Detail = new NavigationPage(new MasDetPgExampleDetailPg1());  //initially show Page 1
        }      
    }
}