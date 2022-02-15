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
    public partial class AddressForm : Form
    {
        public BindingList<string> Addresses { get; private set; } = new BindingList<string>();

        public AddressForm()
        {
            InitializeComponent();
        }

        private void AddAddress_Click(object sender, EventArgs e)
        {
            string streetText = this.streetText.Text;
            string cityText = this.cityText.Text;
            string stateText = this.stateText.Text;
            string zipText = this.zipCodeText.Text;

            if (string.IsNullOrWhiteSpace(streetText) || string.IsNullOrWhiteSpace(cityText)
                || string.IsNullOrWhiteSpace(stateText) || string.IsNullOrWhiteSpace(zipText))
            {
                MessageBox.Show("All fields are required", "Invalid Address",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Addresses.Add($"{streetText} {cityText}, {stateText} {zipText}");
                ResetFields();
                this.Hide();
            }
        }

        private void ResetFields()
        {
            streetText.Text = "";
            cityText.Text = "";
            stateText.Text = "";
            zipCodeText.Text = "";
        }
    }
}
