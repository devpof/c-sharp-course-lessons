using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Module07Lesson06WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BindingList<string> messages = new BindingList<string>();

        public MainWindow()
        {
            InitializeComponent();

            // messageList is the name of the listbox in your XAML.
            messageList.ItemsSource = messages;
        }

        private void AddMessage_Click(object sender, RoutedEventArgs e)
        {
            // messageText is the name of the textbox in your XAML.
            messages.Add(messageText.Text);
            messageText.Text = "";
        }
    }
}
