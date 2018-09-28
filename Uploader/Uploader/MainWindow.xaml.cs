using System.Collections.Generic;
using System.Windows;
using Localization = Uploader.Resources.Localization;

namespace Uploader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Area> Area = new List<Area>();
        
        public MainWindow()
        {
            InitializeComponent();
            Area.Add(new Area { AreaName = " Horten VTS" });
            Area.Add(new Area { AreaName = " Brevik VTS" });
            Area.Add(new Area { AreaName = " Kvitsøy VTS" });
            Area.Add(new Area { AreaName = " Fedje VTS" });
            Area.Add(new Area { AreaName = " Vardø VTS" });

            MyComboBox.ItemsSource = Area;
            
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello {InputUserNameText.Text}");
        }
    }
}
