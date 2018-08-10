using System;
using System.IO;
using System.Windows;
using Microsoft.Win32;
using Newtonsoft.Json;

namespace Lean_System
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public void saveFile()
        {
            var asdf = new Person();
            var json = JsonConvert.SerializeObject(asdf);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine("C:\\Users\\Woojin\\Desktop", "test.json")))
            {
                    outputFile.WriteLine(json);
            }
        }

        public void openFile()
        {
            string test = "";

            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == true)
                test = File.ReadAllText(openFileDialog.FileName);

            try
            {
                Person jsonPerson = JsonConvert.DeserializeObject<Person>(test);
                MessageBox.Show(jsonPerson.getName());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void fileChanged(string name)
        {
            currentFileName.Text = name;
        }

        public MainWindow()
        {
            InitializeComponent();
            EPL.Click += (sender, e) => new PeopleList().ShowDialog();
            OF.Click += (sender, e) => openFile();
            SF.Click += (sender, e) => saveFile();
            fileChanged("asdf");
        }
    }
}