using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormTestApp.ActionExamples
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IOExamples : ContentPage
    {
        public IOExamples()
        {
            InitializeComponent();
        }

        private void btnRandWriteClicked(object sender, EventArgs e)
        {
            double d = new Random().NextDouble();
            var path = System.IO.Path.Combine(FileSystem.AppDataDirectory, "randomDouble");
            using (var sWriter = new System.IO.StreamWriter(path))
                {
                    try {
                        sWriter.Write(d);                        
                            DisplayAlert("Success", "Successfully wrote " + d, "Back");
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine(ex.Message);
                    }
                }            
        }
           

        private void btnRandReadClicked(object sender, EventArgs e)
        {
            double d = -1;
            var path = System.IO.Path.Combine(FileSystem.AppDataDirectory, "randomDouble");
            if (System.IO.File.Exists(path))
            {
                using (var sReader = new System.IO.StreamReader(path))
                {
                    try
                    {
                        string str = sReader.ReadLine();
                        d = Double.Parse(str);
                        DisplayAlert("Success", "Read value is: " + d, "Back");
                    }
                    catch(Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine(ex.Message);
                    }
                }
            }
            else
                DisplayAlert("Error", "Path does not exist", "OK");
        }
    }
}