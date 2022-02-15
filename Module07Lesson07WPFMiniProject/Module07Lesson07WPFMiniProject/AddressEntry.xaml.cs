using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Module07Lesson07WPFMiniProject
{
    /// <summary>
    /// Interaction logic for AddressEntry.xaml
    /// </summary>
    public partial class AddressEntry : Window
    {
        ISaveAddress _parent;

        public AddressEntry(ISaveAddress parent)
        {
            InitializeComponent();

            _parent = parent;
        }

        private void AddAddress_Click(object sender, RoutedEventArgs e)
        {
            AddressModel address = new AddressModel
            {
                StreetAddress = streetText.Text,
                City = cityText.Text,
                State = stateText.Text,
                ZipCode = zipText.Text
            };

            _parent.SaveAddress(address);

            this.Close();
        }
    }
}
