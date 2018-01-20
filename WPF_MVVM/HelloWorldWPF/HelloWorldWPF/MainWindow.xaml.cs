using HelloWorldWPF.ViewModels;
using System.Collections.Generic;
using System.Windows;

namespace HelloWorldWPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new MainWindowViewModel("Max");
        }
    }
}