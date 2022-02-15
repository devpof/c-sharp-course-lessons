using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module07Lesson05WindowsFormsMiniProject
{
    public partial class PersonForm : Form
    {
        //public BindingList<string> Addresses { private get; set; }
        //BindingList<string> Addresses = new BindingList<string>();

        AddressForm addressForm = new AddressForm();

        public PersonForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            addressListBox.DataSource = addressForm.Addresses;
        }

        private void AddAddress_Click(object sender, EventArgs e)
        {
            addressForm.Show();
        }
    }
}
