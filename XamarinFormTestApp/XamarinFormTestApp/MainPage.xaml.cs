using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinFormTestApp.Service;

namespace XamarinFormTestApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public static QuoteRepo quoteRepo;
        public MainPage()
        {
            InitializeComponent();
            quoteRepo = new QuoteRepo();
        }
        
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private void quoteListBtnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewExamples.DataBoundCollectionView(quoteRepo));
        }

        private void tabGridSpinnerBtnClicked(object sender, EventArgs e)
        {
            DisplayAlert("Info", "Tab grid spinner, also shows StaticResource styles, triggered style, styling in res. dict. (local)", "Go");
            Navigation.PushAsync(new ViewExamples.TabGridSpinnerForm());
        }

        private void networkChkBtnClicked(object sender, EventArgs e)
        {
            INetworkManager mgr = DependencyService.Get<INetworkManager>();
            if(mgr != null && mgr.isNetworkConnected())            
                DisplayAlert("Connected", "You are connected to the internet", "BACK");            
            else
                DisplayAlert("Error", "You are not connected to the internet", "BACK");
        }

        private void IOTestBtnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ActionExamples.IOExamples());
        }

        private void nativeControlBtnClicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new ViewExamples.NativeControlExample());
        }

        private void customCntrlNumPadBtnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewExamples.CustomControlRenderer());
        }

        private void LocalDBTestBtnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewExamples.LocalSQLiteDBTest());
        }

        private void MasterDetailPgBtnClicked(object sender, EventArgs e)
        {
            DisplayAlert("Info", "Master detail page example, shows button-like labels, Offed Navigation Bar.", "Go");
            Navigation.PushAsync(new ViewExamples.MasDetPgExample());
        }
        
        private void FlexLayoutClicked(object sender, EventArgs e)
        {
            DisplayAlert("Info", "Started Flex layout example, no nav bar, parameterised tap gesture handler", "Go");
            Page page = new ViewExamples.FlexLayoutExample();            
            Navigation.PushAsync(page);
            NavigationPage.SetHasNavigationBar(page,false);
        }
    }
}
