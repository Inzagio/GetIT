using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Markup;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void TestThis()
        {
            string hei = DoSomething.GenerateMarkUp.XmlMarkup(4, 5);

            var test = (UIElement) XamlReader.Parse(hei);
            this.TestGrid.Children.Add(test);
        }

        public void SaveFile()
        {
            List xamlItems = new List();
            var path = Assembly.GetExecutingAssembly().ToString();
            using (StreamWriter write = new StreamWriter(path))
            {
                foreach (var item in )
                {
                    
                }
            }
        }
    }
}
