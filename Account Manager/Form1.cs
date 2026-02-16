using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
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
            buttonsFlowLayoutPanel.Controls.Clear();

            foreach (var account in accountsDatas)
            {
                FlowLayoutPanel row = new FlowLayoutPanel();
                row.AutoSize = true;
                row.FlowDirection = FlowDirection.LeftToRight;
                row.WrapContents = false;
                row.Margin = new Padding(5);

                Button btnEdit = new Button();
                btnEdit.Text = "Modifier";
                btnEdit.Size = new Size(80, 40);
                btnEdit.Tag = account;
                btnEdit.ForeColor = Color.White;
                btnEdit.Click += EditAccount;

                Button btnDelete = new Button();
                btnDelete.Text = "Supprimer";
                btnDelete.Size = new Size(80, 40);
                btnDelete.ForeColor = Color.White;
                btnDelete.Tag = account;
                btnDelete.Click += DeleteAccount;

                Button btnAccount = new Button();
                btnAccount.Text = account.Name;
                btnAccount.Size = new Size(200, 40);
                btnAccount.BackColor = ColorTranslator.FromHtml("#C8AA6E");
                btnAccount.FlatStyle = FlatStyle.Flat;
                btnAccount.FlatAppearance.BorderColor = Color.White;
                btnAccount.FlatAppearance.BorderSize = 3;

                btnAccount.Tag = account;

                btnAccount.Click += ButtonClick;

                row.Controls.Add(btnAccount);
                row.Controls.Add(btnEdit);
                row.Controls.Add(btnDelete);

                buttonsFlowLayoutPanel.Controls.Add(row);
            }

            Button btnAdd = new Button();
            btnAdd.Text = "Ajouter";
            btnAdd.Size = new Size(80, 40);
            btnAdd.ForeColor = Color.White;
            btnAdd.Click += AddAccount;
            buttonsFlowLayoutPanel.Controls.Add(btnAdd);
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

        private void AddAccount(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                AddAccountForm addForm = new AddAccountForm();

                addForm.StartPosition = FormStartPosition.Manual;

                Point buttonScreenPosition = btn.PointToScreen(Point.Empty);

                int x = buttonScreenPosition.X + btn.Width;
                int y = buttonScreenPosition.Y + btn.Height;

                addForm.Location = new Point(x, y);

                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    AddAccountInJson(addForm.UpdateName, addForm.UpdateUsername, addForm.UpdatePassword);
                }
            }
        }

        private void EditAccount(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is AccountData account)
            {
                EditAccountForm editForm = new EditAccountForm(account.Name, account.Username, account.Password);

                editForm.StartPosition = FormStartPosition.Manual;

                Point buttonScreenPosition = btn.PointToScreen(Point.Empty);

                int x = buttonScreenPosition.X + btn.Width;
                int y = buttonScreenPosition.Y + btn.Height;

                editForm.Location = new Point(x, y);

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    UpdateAccountInJson(account, editForm.UpdateName, editForm.UpdateUsername, editForm.UpdatePassword);
                }
            }
        }

        private void AddAccountInJson(string newName, string newUsername, string newPassword)
        {
            string path = Path.Combine(Application.StartupPath, "accounts.json");

            string json = File.ReadAllText(path);

            List<AccountData> accounts = JsonSerializer.Deserialize<List<AccountData>>(json);

            var newAccount = new AccountData();
            newAccount.Name = newName;
            newAccount.Username = newUsername;
            newAccount.Password = newPassword;

            accounts.Add(newAccount);

            string updatedJson = JsonSerializer.Serialize(accounts, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(path, updatedJson);

            CreateButtons(accounts);
        }

        private void UpdateAccountInJson(AccountData account, string newName, string newUsername, string newPassword)
        {
            string path = Path.Combine(Application.StartupPath, "accounts.json");

            string json = File.ReadAllText(path);

            List<AccountData> accounts = JsonSerializer.Deserialize<List<AccountData>>(json);

            var accountToUpdate = accounts.FirstOrDefault(a => a.Name == account.Name);

            if(accountToUpdate != null)
            {
                accountToUpdate.Name = newName;
                accountToUpdate.Username = newUsername;
                accountToUpdate.Password = newPassword;

                string updatedJson = JsonSerializer.Serialize(accounts, new JsonSerializerOptions
                {
                    WriteIndented = true
                });

                File.WriteAllText(path, updatedJson);

                CreateButtons(accounts);
            }
        }

        private void DeleteAccount(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is AccountData account)
            {
                var confirm = MessageBox.Show(
                    $"Supprimer {account.Name} ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo
                );

                if (confirm == DialogResult.Yes)
                {
                    DeleteAccountFromJson(account);
                }
            }
        }

        private void DeleteAccountFromJson(AccountData account)
        {
            string path = Path.Combine(Application.StartupPath, "accounts.json");

            string json = File.ReadAllText(path);

            List<AccountData> accounts = JsonSerializer.Deserialize<List<AccountData>>(json);

            accounts.RemoveAll(a => a.Name == account.Name);

            string updatedJson = JsonSerializer.Serialize(accounts, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(path, updatedJson);

            CreateButtons(accounts);
        }
    }
}
