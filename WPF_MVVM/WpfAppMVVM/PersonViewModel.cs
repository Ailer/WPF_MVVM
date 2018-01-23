using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Common.ViewModels;

namespace WpfAppMVVM
{
    class PersonViewModel : ViewModelBase
    {
        private Person pers = new Person();
        string txtPersonName;
        int txtPersonAge;
        bool isMarried;

        public string TxtPersonName { get => txtPersonName; set => txtPersonName = value; }
        public int TxtPersonAge
        {
            get => txtPersonAge; set
            {
                pers.Age = value;
                txtPersonAge = value;
                base.OnPropertyChanged("TxtPersonAge");
                base.OnPropertyChanged("lAgeColor");
            }
        }
        public bool IsMarried { get => isMarried; set => isMarried = value; }

        public string lAgeColor //String fuer Wiederverwendbarkeit, nicht UI-spezifisch
        {
            get
            {
                if (pers.Age >= 18)
                {
                    return "Green";
                }
                return "Red";
            }
        }


    }
}
