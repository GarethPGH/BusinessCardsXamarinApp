using System;
using System.Collections.ObjectModel;
using System.Text;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using Business_Card.Model;
using Xamarin.Forms;


//THIS IS BORKED. FIGURE OUT HOW TO USE COMMANDING IN XAMARIN

//Figure out how to properly implement INotifyPropertyChanged and PropertyChanged interfaces
//Docs: https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/data-binding/commanding
//Docs: https://devblogs.microsoft.com/xamarin/simplifying-events-with-commanding/
namespace Business_Card.ViewModel
{

    public class BusinessCardViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand FillBusinessCardsCommand { get; private set; }

        bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(storage, value))
                return false;

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        ///Commanding Still Borked

        public BusinessCardViewModel() {
            ObservableCollection<BusinessCard> BusinessCards = new ObservableCollection<BusinessCard>();
            var FillCards = new Command (AddCards);
            PropertyChanged();//Xaml placeholder
        }

        private void AddCards(ObservableCollection<BusinessCard> Cards)
        {
                foreach (BusinessCard card in Cards)
                {
                    Cards.Add(card);
                }
        }

        /// <summary>
        /// Dont forget to make your XAML File use the command when it works.
        /// </summary>
    }
}
//This is supposed to add cards to the collection using a xaml Binding such as {Binding CommandName} to a ViewCell, or other layout item

