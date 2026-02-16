using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Account_Manager
{
    public partial class AddAccountForm : Form
    {
        public string UpdateName { get; set; }
        public string UpdateUsername { get; set; }
        public string UpdatePassword { get; set; }

        public AddAccountForm()
        {
            InitializeComponent();

            nameTextBoxAdd.Text = "";
            usernameTextBoxAdd.Text = "";
            passwordTextBoxAdd.Text = "";

            saveButtonAdd.Click += SaveChanges;
        }

        private void AddAccountForm_Load(object sender, EventArgs e)
        {

        }
        private void SaveChanges(object sender, EventArgs e)
        {
            UpdateName = nameTextBoxAdd.Text;
            UpdateUsername = usernameTextBoxAdd.Text;
            UpdatePassword = passwordTextBoxAdd.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
