
namespace HotelManagement.AppForm
{
    partial class LoginForm
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
            this.Username_textBox = new System.Windows.Forms.TextBox();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Login_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Username_Label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Title_pictureBox = new System.Windows.Forms.PictureBox();
            this.ForgetPassword = new System.Windows.Forms.LinkLabel();
            this.password_ttip = new System.Windows.Forms.ToolTip(this.components);
            this.username_ttip = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Title_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // Username_textBox
            // 
            this.errorProvider1.SetError(this.Username_textBox, "Hay nhap username");
            this.Username_textBox.Location = new System.Drawing.Point(195, 110);
            this.Username_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Username_textBox.Name = "Username_textBox";
            this.Username_textBox.Size = new System.Drawing.Size(242, 26);
            this.Username_textBox.TabIndex = 0;
            this.username_ttip.SetToolTip(this.Username_textBox, "Nhap username");
            this.Username_textBox.TextChanged += new System.EventHandler(this.Username_textBox_TextChanged);
            // 
            // Password_textBox
            // 
            this.errorProvider2.SetError(this.Password_textBox, "Hay nhap password");
            this.Password_textBox.Location = new System.Drawing.Point(195, 161);
            this.Password_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(242, 26);
            this.Password_textBox.TabIndex = 1;
            this.password_ttip.SetToolTip(this.Password_textBox, "Nhap Password");
            this.Password_textBox.UseSystemPasswordChar = true;
            this.Password_textBox.TextChanged += new System.EventHandler(this.Password_textBox_TextChanged);
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.SpringGreen;
            this.Login_button.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.Login_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Login_button.Location = new System.Drawing.Point(298, 249);
            this.Login_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(162, 57);
            this.Login_button.TabIndex = 2;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.Color.Tomato;
            this.Cancel_button.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.Cancel_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Cancel_button.Location = new System.Drawing.Point(33, 249);
            this.Cancel_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(162, 57);
            this.Cancel_button.TabIndex = 3;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = false;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold);
            this.Username_Label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Username_Label.Location = new System.Drawing.Point(38, 104);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(157, 38);
            this.Username_Label.TabIndex = 4;
            this.Username_Label.Text = "Username";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold);
            this.Password_label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Password_label.Location = new System.Drawing.Point(38, 154);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(151, 38);
            this.Password_label.TabIndex = 5;
            this.Password_label.Text = "Password";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.Title.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Title.Location = new System.Drawing.Point(182, 31);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(236, 45);
            this.Title.TabIndex = 6;
            this.Title.Text = "Account Login";
            // 
            // Title_pictureBox
            // 
            this.Title_pictureBox.Image = global::HotelManagement.Properties.Resources.User;
            this.Title_pictureBox.Location = new System.Drawing.Point(58, 10);
            this.Title_pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Title_pictureBox.Name = "Title_pictureBox";
            this.Title_pictureBox.Size = new System.Drawing.Size(90, 80);
            this.Title_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Title_pictureBox.TabIndex = 7;
            this.Title_pictureBox.TabStop = false;
            // 
            // ForgetPassword
            // 
            this.ForgetPassword.AutoSize = true;
            this.ForgetPassword.LinkColor = System.Drawing.Color.White;
            this.ForgetPassword.Location = new System.Drawing.Point(109, 213);
            this.ForgetPassword.Name = "ForgetPassword";
            this.ForgetPassword.Size = new System.Drawing.Size(175, 20);
            this.ForgetPassword.TabIndex = 8;
            this.ForgetPassword.TabStop = true;
            this.ForgetPassword.Text = "Forgot your password ?";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(497, 317);
            this.Controls.Add(this.ForgetPassword);
            this.Controls.Add(this.Title_pictureBox);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Username_Label);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.Username_textBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.Text = "QLSV Ngo Minh Dat 19110115";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Title_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username_textBox;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox Title_pictureBox;
        private System.Windows.Forms.LinkLabel ForgetPassword;
        private System.Windows.Forms.ToolTip password_ttip;
        private System.Windows.Forms.ToolTip username_ttip;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}