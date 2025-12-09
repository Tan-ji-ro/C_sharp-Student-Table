namespace Bai5_2
{
    partial class Login_form
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
            this.Login_group = new System.Windows.Forms.GroupBox();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Login_button = new System.Windows.Forms.Button();
            this.Change_button = new System.Windows.Forms.Button();
            this.Pass_box = new System.Windows.Forms.TextBox();
            this.Pass_label = new System.Windows.Forms.Label();
            this.User_box = new System.Windows.Forms.TextBox();
            this.Usertext = new System.Windows.Forms.Label();
            this.W_label = new System.Windows.Forms.Label();
            this.Login_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_group
            // 
            this.Login_group.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_group.Controls.Add(this.Exit_button);
            this.Login_group.Controls.Add(this.Login_button);
            this.Login_group.Controls.Add(this.Change_button);
            this.Login_group.Controls.Add(this.Pass_box);
            this.Login_group.Controls.Add(this.Pass_label);
            this.Login_group.Controls.Add(this.User_box);
            this.Login_group.Controls.Add(this.Usertext);
            this.Login_group.Location = new System.Drawing.Point(76, 140);
            this.Login_group.Name = "Login_group";
            this.Login_group.Size = new System.Drawing.Size(660, 144);
            this.Login_group.TabIndex = 0;
            this.Login_group.TabStop = false;
            this.Login_group.Text = "Đăng nhập";
            // 
            // Exit_button
            // 
            this.Exit_button.Location = new System.Drawing.Point(579, 108);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(75, 23);
            this.Exit_button.TabIndex = 6;
            this.Exit_button.Text = "Thoát";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Login_button
            // 
            this.Login_button.Location = new System.Drawing.Point(317, 108);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(75, 23);
            this.Login_button.TabIndex = 5;
            this.Login_button.Text = "Đăng nhập";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Change_button
            // 
            this.Change_button.Location = new System.Drawing.Point(68, 108);
            this.Change_button.Name = "Change_button";
            this.Change_button.Size = new System.Drawing.Size(75, 23);
            this.Change_button.TabIndex = 4;
            this.Change_button.Text = "Đổi mã";
            this.Change_button.UseVisualStyleBackColor = true;
            // 
            // Pass_box
            // 
            this.Pass_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pass_box.Location = new System.Drawing.Point(68, 68);
            this.Pass_box.Name = "Pass_box";
            this.Pass_box.PasswordChar = '#';
            this.Pass_box.Size = new System.Drawing.Size(586, 20);
            this.Pass_box.TabIndex = 3;
            // 
            // Pass_label
            // 
            this.Pass_label.AutoSize = true;
            this.Pass_label.Location = new System.Drawing.Point(10, 71);
            this.Pass_label.Name = "Pass_label";
            this.Pass_label.Size = new System.Drawing.Size(52, 13);
            this.Pass_label.TabIndex = 2;
            this.Pass_label.Text = "Mật khẩu";
            // 
            // User_box
            // 
            this.User_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.User_box.Location = new System.Drawing.Point(68, 36);
            this.User_box.Name = "User_box";
            this.User_box.Size = new System.Drawing.Size(586, 20);
            this.User_box.TabIndex = 1;
            // 
            // Usertext
            // 
            this.Usertext.AutoSize = true;
            this.Usertext.Location = new System.Drawing.Point(7, 39);
            this.Usertext.Name = "Usertext";
            this.Usertext.Size = new System.Drawing.Size(55, 13);
            this.Usertext.TabIndex = 0;
            this.Usertext.Text = "Tài khoản";
            // 
            // W_label
            // 
            this.W_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.W_label.AutoSize = true;
            this.W_label.Location = new System.Drawing.Point(12, 428);
            this.W_label.Name = "W_label";
            this.W_label.Size = new System.Drawing.Size(53, 13);
            this.W_label.TabIndex = 1;
            this.W_label.Text = "Cảnh báo";
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.W_label);
            this.Controls.Add(this.Login_group);
            this.Name = "Login_form";
            this.Text = "Quản lý học sinh";
            this.Login_group.ResumeLayout(false);
            this.Login_group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Login_group;
        private System.Windows.Forms.TextBox Pass_box;
        private System.Windows.Forms.Label Pass_label;
        private System.Windows.Forms.TextBox User_box;
        private System.Windows.Forms.Label Usertext;
        private System.Windows.Forms.Button Change_button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Label W_label;
    }
}