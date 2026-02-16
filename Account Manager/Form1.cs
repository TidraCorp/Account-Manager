using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += OnAccountManagerLoad;
        }

        private void OnAccountManagerLoad(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "accounts.json");

            if(!File.Exists(path))
            {
                MessageBox.Show("Les données n'ont pas été trouvées, vous avez un problème avec le accounts.json");
                return;
            }

            string json = File.ReadAllText(path);

            List<AccountData> accountsDatas = JsonSerializer.Deserialize<List<AccountData>>(json);

            CreateButtons(accountsDatas);
        }

        private void CreateButtons(List<AccountData> accountsDatas)
        {
            foreach (var account in accountsDatas)
            {
                Button btn = new Button();
                btn.Text = account.Name;
                btn.Size = new Size(150, 40);
                btn.BackColor = ColorTranslator.FromHtml("#C8AA6E");
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.White;
                btn.FlatAppearance.BorderSize = 3;


                btn.Tag = account;

                btn.Click += ButtonClick;

                buttonsFlowLayoutPanel.Controls.Add(btn);
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            AccountData accountData = btn.Tag as AccountData;

            SendKeys.Send("%{TAB}");
            SendKeys.Send(accountData.Username);
            SendKeys.Send("{TAB}");
            SendKeys.Send(accountData.Password);
        }
    }
}
