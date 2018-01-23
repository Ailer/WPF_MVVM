using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Person pers = new Person();
        public MainWindow()
        {
            InitializeComponent();
            pers.Name = "Max";
            pers.Age = 18;
            pers.Married = true;
            printPers(pers);
        }

        private void printPers(Person p)
        {
            txtName.Text = p.Name;
            txtAge.Text = Convert.ToString(p.Age);

            if (p.Age >= 18)
            {
                lAgeOK.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                lAgeOK.Background = new SolidColorBrush(Colors.Red);
            }

            if (p.Married == true)
            {
                chkMarried.IsChecked = true;
            }
            else
            {
                chkMarried.IsChecked = false;
            }
        }

        private void txtAge_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                pers.Age = Convert.ToInt32(txtAge.Text);
                printPers(pers);
            }
            catch { }
            
            
        }
    }
}
