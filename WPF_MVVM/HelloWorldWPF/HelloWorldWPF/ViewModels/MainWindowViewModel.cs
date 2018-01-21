using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using WPF.Common.Helper;
using WPF.Common.ViewModels;

namespace HelloWorldWPF.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _name;
        private ICommand _helloWorld;
        private ObservableCollection<ContactViewModel> _contacts;
        private ICommand _add;
        private string _birthday;

        // Property zum binden
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                base.OnPropertyChanged("Name");
            }
        }

        public string Birthday
        {
            get
            {
                return _birthday;
            }
            set
            {
                _birthday = value;
                base.OnPropertyChanged("Birthday");
            }
        }

        public ObservableCollection<ContactViewModel> Contacts
        {
            get
            {
                return _contacts;
            }
            set
            {
                _contacts = value;
                base.OnPropertyChanged("Contacts");
            }
        }

        public ICommand Add
        {
            get
            {
                if (_add == null)
                {
                    _add = new DelegateCommand(AddExecute, AddCanExecute);
                }

                return _add;
            }
        }

        private void AddExecute(object o)
        {
            this.Contacts.Add(new ContactViewModel(this.Name, this.Birthday));
        }

        private bool AddCanExecute(object o)
        {
            return !string.IsNullOrWhiteSpace(this.Name) &&
                   !string.IsNullOrWhiteSpace(this.Birthday);
        }

        public MainWindowViewModel(string name)
        {
            Name = name;
            Contacts = new ObservableCollection<ContactViewModel>();
            Contacts.Add(new ContactViewModel("Fritz Walter", "31.12"));
            Contacts.Add(new ContactViewModel("Max Mustermann", "24.01"));
            Contacts.Add(new ContactViewModel("John Doe", "20.10"));
        }
    }
}