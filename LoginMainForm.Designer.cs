namespace A6_AB_LTA_OOP_Polymorphism
{
    partial class LoginMainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginMainForm));
            this.loginButton = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.adminPasswordTextBox = new System.Windows.Forms.TextBox();
            this.adminPasswordLabel = new System.Windows.Forms.Label();
            this.adminLoginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.americanBankNewDataSet = new A6_AB_LTA_OOP_Polymorphism.AmericanBankNewDataSet();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter = new A6_AB_LTA_OOP_Polymorphism.AmericanBankNewDataSetTableAdapters.LoginTableAdapter();
            this.tableAdapterManager = new A6_AB_LTA_OOP_Polymorphism.AmericanBankNewDataSetTableAdapters.TableAdapterManager();
            this.adminLoginTableAdapter = new A6_AB_LTA_OOP_Polymorphism.AmericanBankNewDataSetTableAdapters.AdminLoginTableAdapter();
            this.companyLogoPictureBox = new System.Windows.Forms.PictureBox();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adminLoginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.americanBankNewDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.ForeColor = System.Drawing.Color.White;
            usernameLabel.Location = new System.Drawing.Point(14, 81);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(87, 20);
            usernameLabel.TabIndex = 42;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.ForeColor = System.Drawing.Color.White;
            passwordLabel.Location = new System.Drawing.Point(14, 119);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(82, 20);
            passwordLabel.TabIndex = 43;
            passwordLabel.Text = "Password:";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(18, 187);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(258, 38);
            this.loginButton.TabIndex = 28;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(107, 78);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(169, 26);
            this.usernameTextBox.TabIndex = 34;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(107, 116);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(169, 26);
            this.passwordTextBox.TabIndex = 36;
            // 
            // adminPasswordTextBox
            // 
            this.adminPasswordTextBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.adminPasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminLoginBindingSource, "AdminPassword", true));
            this.adminPasswordTextBox.Location = new System.Drawing.Point(158, 152);
            this.adminPasswordTextBox.Name = "adminPasswordTextBox";
            this.adminPasswordTextBox.PasswordChar = '#';
            this.adminPasswordTextBox.Size = new System.Drawing.Size(118, 26);
            this.adminPasswordTextBox.TabIndex = 41;
            // 
            // adminPasswordLabel
            // 
            this.adminPasswordLabel.AutoSize = true;
            this.adminPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.adminPasswordLabel.Location = new System.Drawing.Point(14, 155);
            this.adminPasswordLabel.Name = "adminPasswordLabel";
            this.adminPasswordLabel.Size = new System.Drawing.Size(131, 20);
            this.adminPasswordLabel.TabIndex = 44;
            this.adminPasswordLabel.Text = "Admin Password:";
            // 
            // adminLoginBindingSource
            // 
            this.adminLoginBindingSource.DataMember = "AdminLogin";
            this.adminLoginBindingSource.DataSource = this.americanBankNewDataSet;
            // 
            // americanBankNewDataSet
            // 
            this.americanBankNewDataSet.DataSetName = "AmericanBankNewDataSet";
            this.americanBankNewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "Login";
            this.loginBindingSource.DataSource = this.americanBankNewDataSet;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminLoginTableAdapter = this.adminLoginTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LoginTableAdapter = this.loginTableAdapter;
            this.tableAdapterManager.TransactionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = A6_AB_LTA_OOP_Polymorphism.AmericanBankNewDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // adminLoginTableAdapter
            // 
            this.adminLoginTableAdapter.ClearBeforeFill = true;
            // 
            // companyLogoPictureBox
            // 
            this.companyLogoPictureBox.Image = global::A6_AB_LTA_OOP_Polymorphism.Properties.Resources.CommerceBankLogo;
            this.companyLogoPictureBox.Location = new System.Drawing.Point(29, 12);
            this.companyLogoPictureBox.Name = "companyLogoPictureBox";
            this.companyLogoPictureBox.Size = new System.Drawing.Size(232, 55);
            this.companyLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.companyLogoPictureBox.TabIndex = 30;
            this.companyLogoPictureBox.TabStop = false;
            // 
            // LoginMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(294, 239);
            this.Controls.Add(this.adminPasswordLabel);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.adminPasswordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.companyLogoPictureBox);
            this.Controls.Add(this.loginButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginMainForm";
            this.Text = "Commerce Bank";
            this.Load += new System.EventHandler(this.LoginMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminLoginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.americanBankNewDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox companyLogoPictureBox;
        private System.Windows.Forms.Button loginButton;
        private AmericanBankNewDataSet americanBankNewDataSet;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private AmericanBankNewDataSetTableAdapters.LoginTableAdapter loginTableAdapter;
        private AmericanBankNewDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AmericanBankNewDataSetTableAdapters.AdminLoginTableAdapter adminLoginTableAdapter;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.BindingSource adminLoginBindingSource;
        private System.Windows.Forms.TextBox adminPasswordTextBox;
        private System.Windows.Forms.Label adminPasswordLabel;
    }
}

