using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Manager
{
    public partial class EditAccountForm : Form
    {
        public string UpdateName { get; set; }
        public string UpdateUsername { get; set; }
        public string UpdatePassword { get; set; }
        public EditAccountForm(string name, string username, string password)
        {
            InitializeComponent();

            nameTextBoxEdit.Text = name;
            usernameTextBoxEdit.Text = username;
            passwordTextBoxEdit.Text = password;

            saveButtonEdit.Click += SaveChanges;
        }


        private void EditAccountForm_Load(object sender, EventArgs e)
        {

        }

        private void SaveChanges(object sender, EventArgs e)
        {
            UpdateName = nameTextBoxEdit.Text;
            UpdateUsername = usernameTextBoxEdit.Text;
            UpdatePassword = passwordTextBoxEdit.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
