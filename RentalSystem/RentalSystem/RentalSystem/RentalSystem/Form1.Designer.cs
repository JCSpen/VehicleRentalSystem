namespace RentalSystem
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.PasswordRegBox = new System.Windows.Forms.TextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.NewUserBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameBox
            // 
            this.UsernameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.UsernameBox.Location = new System.Drawing.Point(71, 27);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(1);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.PlaceholderText = "Username";
            this.UsernameBox.Size = new System.Drawing.Size(108, 23);
            this.UsernameBox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PasswordBox.Location = new System.Drawing.Point(71, 54);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(1);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.PlaceholderText = "Password";
            this.PasswordBox.Size = new System.Drawing.Size(108, 23);
            this.PasswordBox.TabIndex = 1;
            // 
            // PasswordRegBox
            // 
            this.PasswordRegBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PasswordRegBox.Location = new System.Drawing.Point(71, 79);
            this.PasswordRegBox.Margin = new System.Windows.Forms.Padding(1);
            this.PasswordRegBox.Name = "PasswordRegBox";
            this.PasswordRegBox.PasswordChar = '*';
            this.PasswordRegBox.PlaceholderText = "Password";
            this.PasswordRegBox.Size = new System.Drawing.Size(108, 23);
            this.PasswordRegBox.TabIndex = 2;
            this.PasswordRegBox.Visible = false;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SubmitBtn.Location = new System.Drawing.Point(84, 109);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(1);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(79, 22);
            this.SubmitBtn.TabIndex = 3;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // NewUserBtn
            // 
            this.NewUserBtn.Location = new System.Drawing.Point(84, 152);
            this.NewUserBtn.Margin = new System.Windows.Forms.Padding(1);
            this.NewUserBtn.Name = "NewUserBtn";
            this.NewUserBtn.Size = new System.Drawing.Size(79, 22);
            this.NewUserBtn.TabIndex = 4;
            this.NewUserBtn.Text = "New User?";
            this.NewUserBtn.UseVisualStyleBackColor = true;
            this.NewUserBtn.Click += new System.EventHandler(this.NewUserBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(250, 215);
            this.Controls.Add(this.NewUserBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.PasswordRegBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(266, 254);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(266, 254);
            this.Name = "Login";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox UsernameBox;
        private TextBox PasswordBox;
        private TextBox PasswordRegBox;
        private Button SubmitBtn;
        private Button NewUserBtn;
    }
}