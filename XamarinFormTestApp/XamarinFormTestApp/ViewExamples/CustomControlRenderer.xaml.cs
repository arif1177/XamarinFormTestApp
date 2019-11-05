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
    public partial class CustomControlRenderer : ContentPage
    {
        public CustomControlRenderer()
        {
            InitializeComponent();
            BindingContext = new SampleIntEntryClass();
        }

        private class SampleIntEntryClass
        {
            public int currentVal { get; set; }
            public SampleIntEntryClass()                
            {
                currentVal = 0;
            }
        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            this.numberEntry.Text = (BindingContext as SampleIntEntryClass).currentVal.ToString();            
            
        }

        private void entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.stepper.Value = (BindingContext as SampleIntEntryClass).currentVal;                        
        }
    }
}