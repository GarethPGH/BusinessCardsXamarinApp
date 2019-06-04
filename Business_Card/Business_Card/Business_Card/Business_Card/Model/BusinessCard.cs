using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Business_Card.Model
{
    public class BusinessCard : INotifyPropertyChanged
    {
        string name;
        string companyname;
        string email;
        string phonenumber;
        string cardurl;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                SetProperty(ref name, value);
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
                SetProperty(ref companyname, value);
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
                SetProperty(ref email, value);
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
                SetProperty(ref phonenumber, value);
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
                SetProperty(ref cardurl, value);
            }
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
    }
}
