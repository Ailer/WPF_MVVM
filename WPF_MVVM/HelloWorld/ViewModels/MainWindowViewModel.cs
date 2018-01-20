using System;
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

        public ICommand HelloWorld
        {
            get
            {
                if (_helloWorld == null)
                {
                    // Legt den Befehl fest der ausgeführt wird und den Befehl zum aktivieren bzw. deaktivieren des Buttons.
                    _helloWorld = new DelegateCommand(new Action<object>(HelloWorldExecute),
                                                      new Func<object, bool>(HelloWorldCanExecute));
                }

                return _helloWorld;
            }
        }


        // object ist nur ein Platzhalter.
        private void HelloWorldExecute(object o)
        {
            MessageBox.Show($"Hello {this.Name}");
        }

        // object ist nur ein Platzhalter
        private bool HelloWorldCanExecute(object o)
        {
            // Aktiviert deaktiviert Button. 
            return !string.IsNullOrWhiteSpace(this.Name);
        }

        public MainWindowViewModel(string name)
        {
            Name = name;
        }
    }
}