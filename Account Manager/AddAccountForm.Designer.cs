namespace Account_Manager
{
    partial class AddAccountForm
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
            this.TitleLabelAdd = new System.Windows.Forms.Label();
            this.nameLabelAdd = new System.Windows.Forms.Label();
            this.nameTextBoxAdd = new System.Windows.Forms.TextBox();
            this.usernameAddLabel = new System.Windows.Forms.Label();
            this.usernameTextBoxAdd = new System.Windows.Forms.TextBox();
            this.passwordLabelAdd = new System.Windows.Forms.Label();
            this.passwordTextBoxAdd = new System.Windows.Forms.TextBox();
            this.saveButtonAdd = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.TitleLabelAdd);
            this.flowLayoutPanel1.Controls.Add(this.nameLabelAdd);
            this.flowLayoutPanel1.Controls.Add(this.nameTextBoxAdd);
            this.flowLayoutPanel1.Controls.Add(this.usernameAddLabel);
            this.flowLayoutPanel1.Controls.Add(this.usernameTextBoxAdd);
            this.flowLayoutPanel1.Controls.Add(this.passwordLabelAdd);
            this.flowLayoutPanel1.Controls.Add(this.passwordTextBoxAdd);
            this.flowLayoutPanel1.Controls.Add(this.saveButtonAdd);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(252, 181);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // TitleLabelAdd
            // 
            this.TitleLabelAdd.AutoSize = true;
            this.TitleLabelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabelAdd.Location = new System.Drawing.Point(3, 0);
            this.TitleLabelAdd.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.TitleLabelAdd.Name = "TitleLabelAdd";
            this.TitleLabelAdd.Size = new System.Drawing.Size(186, 25);
            this.TitleLabelAdd.TabIndex = 5;
            this.TitleLabelAdd.Text = "Ajouter un compte";
            // 
            // nameLabelAdd
            // 
            this.nameLabelAdd.AutoSize = true;
            this.nameLabelAdd.Location = new System.Drawing.Point(3, 35);
            this.nameLabelAdd.Name = "nameLabelAdd";
            this.nameLabelAdd.Size = new System.Drawing.Size(29, 13);
            this.nameLabelAdd.TabIndex = 6;
            this.nameLabelAdd.Text = "Nom";
            // 
            // nameTextBoxAdd
            // 
            this.nameTextBoxAdd.Location = new System.Drawing.Point(3, 51);
            this.nameTextBoxAdd.Name = "nameTextBoxAdd";
            this.nameTextBoxAdd.Size = new System.Drawing.Size(246, 20);
            this.nameTextBoxAdd.TabIndex = 7;
            // 
            // usernameAddLabel
            // 
            this.usernameAddLabel.AutoSize = true;
            this.usernameAddLabel.Location = new System.Drawing.Point(3, 74);
            this.usernameAddLabel.Name = "usernameAddLabel";
            this.usernameAddLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameAddLabel.TabIndex = 0;
            this.usernameAddLabel.Text = "Username";
            // 
            // usernameTextBoxAdd
            // 
            this.usernameTextBoxAdd.Location = new System.Drawing.Point(3, 90);
            this.usernameTextBoxAdd.Name = "usernameTextBoxAdd";
            this.usernameTextBoxAdd.Size = new System.Drawing.Size(246, 20);
            this.usernameTextBoxAdd.TabIndex = 2;
            // 
            // passwordLabelAdd
            // 
            this.passwordLabelAdd.AutoSize = true;
            this.passwordLabelAdd.Location = new System.Drawing.Point(3, 113);
            this.passwordLabelAdd.Name = "passwordLabelAdd";
            this.passwordLabelAdd.Size = new System.Drawing.Size(71, 13);
            this.passwordLabelAdd.TabIndex = 1;
            this.passwordLabelAdd.Text = "Mot de passe";
            // 
            // passwordTextBoxAdd
            // 
            this.passwordTextBoxAdd.Location = new System.Drawing.Point(3, 129);
            this.passwordTextBoxAdd.Name = "passwordTextBoxAdd";
            this.passwordTextBoxAdd.Size = new System.Drawing.Size(246, 20);
            this.passwordTextBoxAdd.TabIndex = 3;
            // 
            // saveButtonAdd
            // 
            this.saveButtonAdd.Location = new System.Drawing.Point(3, 155);
            this.saveButtonAdd.Name = "saveButtonAdd";
            this.saveButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.saveButtonAdd.TabIndex = 4;
            this.saveButtonAdd.Text = "Enregistrer";
            this.saveButtonAdd.UseVisualStyleBackColor = true;
            // 
            // AddAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AddAccountForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "AddAccountForm";
            this.Load += new System.EventHandler(this.AddAccountForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label TitleLabelAdd;
        private System.Windows.Forms.Label nameLabelAdd;
        private System.Windows.Forms.TextBox nameTextBoxAdd;
        private System.Windows.Forms.Label usernameAddLabel;
        private System.Windows.Forms.TextBox usernameTextBoxAdd;
        private System.Windows.Forms.Label passwordLabelAdd;
        private System.Windows.Forms.TextBox passwordTextBoxAdd;
        private System.Windows.Forms.Button saveButtonAdd;
    }
}