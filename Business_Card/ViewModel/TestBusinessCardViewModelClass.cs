using System;
using System.Collections.ObjectModel;
using System.Text;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using Business_Card.Model;

//Code here will be edited and then copied into BusinessCardViewModel if it works
//Code copied from MSDN Xamarin Commanding docs 
public class TestBusinessCardViewModel : INotifyPropertyChanged
{
    TestBusinessCardViewModel businesscardEdit;
    bool isEditing;

    public event PropertyChangedEventHandler PropertyChanged;

    public bool IsEditing
    {
        private set { SetProperty(ref isEditing, value); }
        get { return isEditing; }
    }
   
    public ICommand NewCommand { private set; get; }

    public ICommand SubmitCommand { private set; get; }

    public ICommand CancelCommand { private set; get; }

    public ObservableCollection<TestBusinessCardViewModel> Cards { get; } = new ObservableCollection<TestBusinessCardViewModel>();

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