using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Business_Card.Model
{
    public class BusinessCard : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this,
              new PropertyChangedEventArgs(propertyName));
        }
        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
                OnPropertyChanged();
            }
        }

        public string CompanyName
        {
            get
            {
                return CompanyName;
            }
            set
            {
                CompanyName = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
                OnPropertyChanged();
            }
        }

        public string PhoneNumber
        {
            get
            {
                return PhoneNumber;
            }
            set
            {
                PhoneNumber = value;
                OnPropertyChanged();
            }
        }

        public string CardURL
        {
            get
            {
                return CardURL;
            }
            set
            {
                CardURL = value;
                OnPropertyChanged();
            }
        }
    }
}
