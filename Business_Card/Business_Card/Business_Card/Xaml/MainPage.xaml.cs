using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Card.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Business_Card.Model;

namespace Business_Card
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            try
            {
                BindingContext = new Business_Card.ViewModel.BusinessCardViewModel();
            }
            catch (Exception e)
            {
                throw new Exception("Error Binding Context has not been assigned to", e);
            }
            
        }
    }
}