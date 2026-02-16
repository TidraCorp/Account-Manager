namespace Account_Manager
{
    partial class EditAccountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TitleLabelEdit = new System.Windows.Forms.Label();
            this.nameLabelEdit = new System.Windows.Forms.Label();
            this.nameTextBoxEdit = new System.Windows.Forms.TextBox();
            this.usernameEditLabel = new System.Windows.Forms.Label();
            this.usernameTextBoxEdit = new System.Windows.Forms.TextBox();
            this.passwordLabelEdit = new System.Windows.Forms.Label();
            this.passwordTextBoxEdit = new System.Windows.Forms.TextBox();
            this.saveButtonEdit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.TitleLabelEdit);
            this.flowLayoutPanel1.Controls.Add(this.nameLabelEdit);
            this.flowLayoutPanel1.Controls.Add(this.nameTextBoxEdit);
            this.flowLayoutPanel1.Controls.Add(this.usernameEditLabel);
            this.flowLayoutPanel1.Controls.Add(this.usernameTextBoxEdit);
            this.flowLayoutPanel1.Controls.Add(this.passwordLabelEdit);
            this.flowLayoutPanel1.Controls.Add(this.passwordTextBoxEdit);
            this.flowLayoutPanel1.Controls.Add(this.saveButtonEdit);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 21);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(252, 181);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // TitleLabelEdit
            // 
            this.TitleLabelEdit.AutoSize = true;
            this.TitleLabelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabelEdit.Location = new System.Drawing.Point(3, 0);
            this.TitleLabelEdit.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.TitleLabelEdit.Name = "TitleLabelEdit";
            this.TitleLabelEdit.Size = new System.Drawing.Size(246, 25);
            this.TitleLabelEdit.TabIndex = 5;
            this.TitleLabelEdit.Text = "Modifier les informations";
            // 
            // nameLabelEdit
            // 
            this.nameLabelEdit.AutoSize = true;
            this.nameLabelEdit.Location = new System.Drawing.Point(3, 35);
            this.nameLabelEdit.Name = "nameLabelEdit";
            this.nameLabelEdit.Size = new System.Drawing.Size(29, 13);
            this.nameLabelEdit.TabIndex = 6;
            this.nameLabelEdit.Text = "Nom";
            // 
            // nameTextBoxEdit
            // 
            this.nameTextBoxEdit.Location = new System.Drawing.Point(3, 51);
            this.nameTextBoxEdit.Name = "nameTextBoxEdit";
            this.nameTextBoxEdit.Size = new System.Drawing.Size(246, 20);
            this.nameTextBoxEdit.TabIndex = 7;
            // 
            // usernameEditLabel
            // 
            this.usernameEditLabel.AutoSize = true;
            this.usernameEditLabel.Location = new System.Drawing.Point(3, 74);
            this.usernameEditLabel.Name = "usernameEditLabel";
            this.usernameEditLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameEditLabel.TabIndex = 0;
            this.usernameEditLabel.Text = "Username";
            // 
            // usernameTextBoxEdit
            // 
            this.usernameTextBoxEdit.Location = new System.Drawing.Point(3, 90);
            this.usernameTextBoxEdit.Name = "usernameTextBoxEdit";
            this.usernameTextBoxEdit.Size = new System.Drawing.Size(246, 20);
            this.usernameTextBoxEdit.TabIndex = 2;
            // 
            // passwordLabelEdit
            // 
            this.passwordLabelEdit.AutoSize = true;
            this.passwordLabelEdit.Location = new System.Drawing.Point(3, 113);
            this.passwordLabelEdit.Name = "passwordLabelEdit";
            this.passwordLabelEdit.Size = new System.Drawing.Size(71, 13);
            this.passwordLabelEdit.TabIndex = 1;
            this.passwordLabelEdit.Text = "Mot de passe";
            // 
            // passwordTextBoxEdit
            // 
            this.passwordTextBoxEdit.Location = new System.Drawing.Point(3, 129);
            this.passwordTextBoxEdit.Name = "passwordTextBoxEdit";
            this.passwordTextBoxEdit.Size = new System.Drawing.Size(246, 20);
            this.passwordTextBoxEdit.TabIndex = 3;
            // 
            // saveButtonEdit
            // 
            this.saveButtonEdit.Location = new System.Drawing.Point(3, 155);
            this.saveButtonEdit.Name = "saveButtonEdit";
            this.saveButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.saveButtonEdit.TabIndex = 4;
            this.saveButtonEdit.Text = "Enregistrer";
            this.saveButtonEdit.UseVisualStyleBackColor = true;
            // 
            // EditAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "EditAccountForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "EditAccountForm";
            this.Load += new System.EventHandler(this.EditAccountForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label TitleLabelEdit;
        private System.Windows.Forms.Label usernameEditLabel;
        private System.Windows.Forms.TextBox usernameTextBoxEdit;
        private System.Windows.Forms.Label passwordLabelEdit;
        private System.Windows.Forms.TextBox passwordTextBoxEdit;
        private System.Windows.Forms.Button saveButtonEdit;
        private System.Windows.Forms.Label nameLabelEdit;
        private System.Windows.Forms.TextBox nameTextBoxEdit;
    }
}