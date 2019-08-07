using System;
using System.Collections.ObjectModel;
using System.Text;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using Business_Card.Model;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Windows.Input;
using System.Diagnostics;
using System.Linq;



namespace Business_Card.ViewModel
{
    
    public partial class BusinessCardViewModel : INotifyPropertyChanged
    {

        private List<BusinessCard> businessCards;

        public BusinessCardViewModel() { }

      //  public ICommand AddCardsCommand { private get; set; }

        new public event PropertyChangedEventHandler PropertyChanged;

        public List<BusinessCard> Business_Cards
        {
            get { if (businessCards == null) {
                    businessCards = new List<BusinessCard>();
                    return businessCards;
                        }
                else
                {
                    return businessCards;
                }
            }
            set { SetProperty(ref businessCards, value); }
        }

        bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(storage, value))
            {
                return false;
            }
            else
            {
                storage = value;
                OnPropertyChanged(propertyName);
                return true;
            }
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public List<BusinessCard> AddCardsToBusinessCardList()
        {
            //This is still returning null and can not be null
            int isEmpty = businessCards.Count();
            if (isEmpty == 0)
            {
                MockDataClass InitMockData = new MockDataClass();
                
                foreach(BusinessCard Card in InitMockData)
                {
                    businessCards.Add(Card);
                }
            }
            return businessCards;
        }

    }
}


