using System;
using System.Collections.ObjectModel;
using System.Text;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using Business_Card.Model;
using Xamarin.Forms;

public delegate void AddBusinessCardsDelegate(List<BusinessCard> Cards);

namespace Business_Card.ViewModel
{

    public class BusinessCardViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        

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
     

        public BusinessCardViewModel() {
            List<BusinessCard> BusinessCards = new List<BusinessCard>();
            var FillCards = new AddBusinessCardsDelegate(AddCards(BusinessCards));
            PropertyChanged();
        }

        public static void AddCards(ObservableCollection<BusinessCard> Cards)
        {
            foreach (BusinessCard card in Cards)
            {
                Cards.Add(card);
            }
        }
    }
}

