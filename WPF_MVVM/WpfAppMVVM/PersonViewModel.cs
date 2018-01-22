using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppMVVM
{
    class PersonViewModel
    {
        private Person pers = new Person();
        string txtPersonName;
        int txtPersonAge;
        bool isMarried;

        public string TxtPersonName { get => txtPersonName; set => txtPersonName = value; }
        public int TxtPersonAge { get => txtPersonAge; set => txtPersonAge = value; }
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
