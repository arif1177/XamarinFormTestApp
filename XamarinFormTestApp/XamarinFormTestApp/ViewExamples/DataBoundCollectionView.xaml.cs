using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormTestApp.Service;

namespace XamarinFormTestApp.ViewExamples
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataBoundCollectionView : ContentPage
    {
        private QuoteRepo quoteRepo;
        private bool isCalledFromLocalDB = false;//checks if it is called from Repo or LocalMySQLite DB
        public DataBoundCollectionView(QuoteRepo quoteRepo)
        {
            InitializeComponent();            
            this.quoteRepo = quoteRepo;
            this.isCalledFromLocalDB = false;
            var quotes = quoteRepo.getTopQuotes();
            BindingContext = quotes;
        }
        public DataBoundCollectionView(List<Quote> quotes, bool isCalledFromLocalDB)
        {
            InitializeComponent();
            BindingContext = quotes;
            this.isCalledFromLocalDB = isCalledFromLocalDB;
        }
        public void Item_Selected(object sender, SelectionChangedEventArgs e)
        {
            if (this.isCalledFromLocalDB)
                return;
            Service.Quote quote = e.CurrentSelection.First() as Service.Quote;
            QuoterDetailsModel qdm = new QuoterDetailsModel();
            qdm.QuoterName = (quoteRepo.getQuoterNameByQuoterID(quote.QuoterID));
            qdm.QuoteTxt = quote.QuoteTxt;
            Navigation.PushAsync(new QuoteDetail(qdm));            
        }
        
    }
}
