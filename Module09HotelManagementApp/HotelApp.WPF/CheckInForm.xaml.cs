using HotelAppLibrary.Data;
using HotelAppLibrary.Models;
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
using System.Windows.Shapes;

namespace HotelApp.WPF
{
    /// <summary>
    /// Interaction logic for CheckInForm.xaml
    /// </summary>
    public partial class CheckInForm : Window
    {
        private readonly IDatabaseData db;
        private BookingFullModel data = null;

        public CheckInForm(IDatabaseData db)
        {
            InitializeComponent();
            this.db = db;
        }

        public void PopulateCheckInInfo(BookingFullModel data)
        {
            this.data = data;
            firstNameText.Text = this.data.FirstName;
            lastNameText.Text = this.data.LastName;
            titleText.Text = this.data.Title;
            roomNumberText.Text = this.data.RoomNumber;
            totalCostText.Text = String.Format("{0:C}", this.data.TotalCost);
        }

        private void checkInUser_Click(object sender, RoutedEventArgs e)
        {
            this.db.CheckInGuest(this.data.Id);
            this.Close();
        }
    }
}
