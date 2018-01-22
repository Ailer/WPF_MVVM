using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppMVVM
{
    class Person
    {
        string name;
        int age;
        bool married;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public bool Married { get => married; set => married = value; }
    }
}
