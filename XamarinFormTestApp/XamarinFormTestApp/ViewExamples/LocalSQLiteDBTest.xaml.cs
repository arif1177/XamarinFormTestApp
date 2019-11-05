using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormTestApp.Service;

namespace XamarinFormTestApp.ViewExamples
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocalSQLiteDBTest : ContentPage
    {
        ObservableCollection<string> quoterList;
        public LocalSQLiteDBTest()
        {
            InitializeComponent();
            
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            List<Quoter> quoterListFromDB = await App.DBSQLite.GetAllQuoterAsync();
            if (quoterListFromDB == null || quoterListFromDB.Count == 0)
                await DisplayAlert("Oops", "No quoters found. Enter quoter first", "OK");
            else
            {
                //quoterPicker.Items.Clear();
                this.quoterList = new ObservableCollection<string>();
                foreach (Quoter q in quoterListFromDB)
                    this.quoterList.Add("" + q.QuoterID + "-" + q.QuoterName);
                quoterPicker.ItemsSource = quoterList;
            }

        }
        async private void InsertQuoterBtnClicked(object sender, EventArgs e)
        {   
            if (!string.IsNullOrWhiteSpace(quoterName.Text))
            {
                int x = await App.DBSQLite.SaveQuoterAsync(new Quoter
                {
                    QuoterName = quoterName.Text
                });
                
                this.quoterList.Add("" + x + "-" + quoterName.Text);
              //  checked the await function call please
                quoterName.Text = string.Empty;
            }
        }
        async private  void InsertQuoteBtnClicked(object sender, EventArgs e)
        {

            string s = quoterPicker.SelectedItem as string;
            if(string.IsNullOrEmpty(s) || s.Length < 3)
                await DisplayAlert("Oops", "Please select a quoter first. Or insert quoter if empty", "OK");
            else if (string.IsNullOrEmpty(quoteTxt.Text))
                await DisplayAlert("Oops", "Please enter a quote first", "OK");
            else//there is valid selection and quote. Get the quoter ID
            {
                int quoterID = int.Parse(s.Substring(0, s.IndexOf('-')));
                await App.DBSQLite.SaveQuoteAsync(new Quote
                {
                    QuoterID = quoterID,
                    QuoteTxt = quoteTxt.Text
                });
                quoterPicker.SelectedIndex = -1;
                quoteTxt.Text = string.Empty;
            }
        }
        async private void ViewAllQuotesBtnClicked(object sender, EventArgs e)
        {
            List<Quote> quotes = await App.DBSQLite.GetAllQuoteAsync();
            _ = Navigation.PushAsync(new DataBoundCollectionView(quotes, true));
        }
    }
}