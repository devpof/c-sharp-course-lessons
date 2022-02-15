using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module07Lesson04WindowsFormsAppMessageWall
{
    public partial class Dashboard : Form
    {
        BindingList<string> messages = new BindingList<string>();

        public Dashboard()
        {
            InitializeComponent();

            // InitializedComponent will create the form items
            WireUpLists();
        }

        private void WireUpLists()
        {
            messageListBox.DataSource = messages;

            // for objects you cannot just do the one above because
            // by default an object.ToString() will return namespace.className
            // you will have to do this, if for example PersonModel has a prop of FirstName
            // messageListBox.DisplayMember = "FirstName" but instead of using string
            // you can use nameof(PersonModel.FirstName);
        }

        private void AddMessage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(messageText.Text))
            {
                MessageBox.Show("Please enter a message before trying to add it to the list.",
                    "Blank Message Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                messages.Add(messageText.Text);
                messageText.Text = "";
            }
            messageText.Focus(); // put the cursor back in the Message Text Box
        }
    }
}
