using System;
using System.Collections.ObjectModel;
using System.Text;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using Business_Card.Model;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Windows.Input;


//THIS IS BORKED. FIGURE OUT HOW TO USE COMMANDING IN XAMARIN
//Ok, according to the build, it has zero errors.
//I am assuming that it doesn't actually do what I want it to in actual use, but I am out of time right now to work on it

namespace Business_Card.ViewModel
{
    
    public class BusinessCardViewModel : INotifyPropertyChanged
    {

        private List<BusinessCard> businessCards;
        bool isEditing;
        public ICommand AddCardsCommand { private get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public List<BusinessCard> BusinessCards
        {
            get { return BusinessCards; }
            set { SetProperty(ref businessCards, value); }
        }

        public bool IsEditing
        {
            private set { SetProperty(ref isEditing, value); }
            get { return isEditing; }
        }

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

        public BusinessCardViewModel()
        {
            businessCards = new List<BusinessCard>();

            //Add business cards to View with Command AddCardsCommands
        }

    }
}


