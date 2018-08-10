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

namespace Lean_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public void FileChanged(String name)
        {
            currentFileName.Text = name;
        }
        public MainWindow()
        {
            InitializeComponent();
            EPL.Click += new RoutedEventHandler((object sender, RoutedEventArgs e) => (new PeopleList()).ShowDialog());
            FileChanged("asdf");
        }
    }
}
