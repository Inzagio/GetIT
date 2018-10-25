using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using Calculator.Annotations;

namespace Calculator
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


        private void ApplyButton_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The Description is: {Environment.NewLine}{DescriptionText.Text}");
        }

        private void ResetButton_OnClick(object sender, RoutedEventArgs e)
        {
            var left = CheckBoxLeft.Children.OfType<CheckBox>();
            var right = CheckBoxRight.Children.OfType<CheckBox>();
            var collection = left.Union(right);
            foreach (var ctl in collection)
            {
                ctl.IsChecked = false;
            }
        }

        private void CheckBox_OnChecked(object sender, RoutedEventArgs e)
        {
            //Handle(sender as CheckBox);
            LengthTextBox.Text += ((CheckBox) sender).Content + " ";
        }


        private void CheckBox_OnUnchecked(object sender, RoutedEventArgs e)
        {
           // //Handle(sender as CheckBox);
           LengthTextBox.Text = LengthTextBox.Text.Replace(((CheckBox)sender).Content.ToString(), string.Empty);
        }

        //void Handle(CheckBox checkBox)
        //{
           
           
        //        LengthTextBox.Text += CheckBox.Content + " ";
           
        
        //}
        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            FinishDropdown_OnSelectionChanged(this.FinishDropdown, null);
        }

        private void FinishDropdown_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (NoteText == null) return;

            var combo = (ComboBox) sender;
            var value = (ComboBoxItem) combo.SelectedValue;

            NoteText.Text = (string) value.Content;
        }

        private void SupplierName_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            MassText.Text = SupplierName.Text;
        }
    }
}
