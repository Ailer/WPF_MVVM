using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldWPF.ViewModels
{
    public class ContactViewModel
    {
        public string Name { get; set; }
        public string Birthday { get; set; }

        public ContactViewModel(string name, string birthday)
        {
            Name = name;
            Birthday = birthday;
        }
    }
}
