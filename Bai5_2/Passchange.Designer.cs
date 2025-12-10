namespace Bai5_2
{
    partial class Passchange
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
            this.Form_box = new System.Windows.Forms.GroupBox();
            this.Current_pass = new System.Windows.Forms.Label();
            this.New_pass = new System.Windows.Forms.Label();
            this.Retype = new System.Windows.Forms.Label();
            this.Retype_box = new System.Windows.Forms.TextBox();
            this.New_pass_box = new System.Windows.Forms.TextBox();
            this.Current_passbox = new System.Windows.Forms.TextBox();
            this.Change_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.P_alert = new System.Windows.Forms.Label();
            this.Form_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // Form_box
            // 
            this.Form_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Form_box.Controls.Add(this.P_alert);
            this.Form_box.Controls.Add(this.Exit_btn);
            this.Form_box.Controls.Add(this.Change_btn);
            this.Form_box.Controls.Add(this.Current_passbox);
            this.Form_box.Controls.Add(this.New_pass_box);
            this.Form_box.Controls.Add(this.Retype_box);
            this.Form_box.Controls.Add(this.Retype);
            this.Form_box.Controls.Add(this.New_pass);
            this.Form_box.Controls.Add(this.Current_pass);
            this.Form_box.Location = new System.Drawing.Point(154, 137);
            this.Form_box.Name = "Form_box";
            this.Form_box.Size = new System.Drawing.Size(508, 191);
            this.Form_box.TabIndex = 0;
            this.Form_box.TabStop = false;
            this.Form_box.Text = "Đổi mật khẩu";
            // 
            // Current_pass
            // 
            this.Current_pass.AutoSize = true;
            this.Current_pass.Location = new System.Drawing.Point(7, 20);
            this.Current_pass.Name = "Current_pass";
            this.Current_pass.Size = new System.Drawing.Size(92, 13);
            this.Current_pass.TabIndex = 0;
            this.Current_pass.Text = "Mật khẩu hiện giờ";
            // 
            // New_pass
            // 
            this.New_pass.AutoSize = true;
            this.New_pass.Location = new System.Drawing.Point(7, 46);
            this.New_pass.Name = "New_pass";
            this.New_pass.Size = new System.Drawing.Size(71, 13);
            this.New_pass.TabIndex = 1;
            this.New_pass.Text = "Mật khẩu mới";
            // 
            // Retype
            // 
            this.Retype.AutoSize = true;
            this.Retype.Location = new System.Drawing.Point(7, 72);
            this.Retype.Name = "Retype";
            this.Retype.Size = new System.Drawing.Size(93, 13);
            this.Retype.TabIndex = 2;
            this.Retype.Text = "Nhập lại mật khẩu";
            // 
            // Retype_box
            // 
            this.Retype_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Retype_box.Location = new System.Drawing.Point(110, 65);
            this.Retype_box.Name = "Retype_box";
            this.Retype_box.PasswordChar = '#';
            this.Retype_box.Size = new System.Drawing.Size(392, 20);
            this.Retype_box.TabIndex = 3;
            // 
            // New_pass_box
            // 
            this.New_pass_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.New_pass_box.Location = new System.Drawing.Point(110, 38);
            this.New_pass_box.Name = "New_pass_box";
            this.New_pass_box.PasswordChar = '#';
            this.New_pass_box.Size = new System.Drawing.Size(392, 20);
            this.New_pass_box.TabIndex = 4;
            // 
            // Current_passbox
            // 
            this.Current_passbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Current_passbox.Location = new System.Drawing.Point(110, 12);
            this.Current_passbox.Name = "Current_passbox";
            this.Current_passbox.PasswordChar = '#';
            this.Current_passbox.Size = new System.Drawing.Size(392, 20);
            this.Current_passbox.TabIndex = 5;
            // 
            // Change_btn
            // 
            this.Change_btn.Location = new System.Drawing.Point(110, 91);
            this.Change_btn.Name = "Change_btn";
            this.Change_btn.Size = new System.Drawing.Size(75, 23);
            this.Change_btn.TabIndex = 6;
            this.Change_btn.Text = "Thay đổi";
            this.Change_btn.UseVisualStyleBackColor = true;
            this.Change_btn.Click += new System.EventHandler(this.Change_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(192, 92);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(75, 23);
            this.Exit_btn.TabIndex = 7;
            this.Exit_btn.Text = "Thoát";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // P_alert
            // 
            this.P_alert.AutoSize = true;
            this.P_alert.Location = new System.Drawing.Point(10, 172);
            this.P_alert.Name = "P_alert";
            this.P_alert.Size = new System.Drawing.Size(53, 13);
            this.P_alert.TabIndex = 8;
            this.P_alert.Text = "Cảnh báo";
            // 
            // Passchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Form_box);
            this.Name = "Passchange";
            this.Text = "Đổi mật khẩu";
            this.Form_box.ResumeLayout(false);
            this.Form_box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Form_box;
        private System.Windows.Forms.TextBox Current_passbox;
        private System.Windows.Forms.TextBox New_pass_box;
        private System.Windows.Forms.TextBox Retype_box;
        private System.Windows.Forms.Label Retype;
        private System.Windows.Forms.Label New_pass;
        private System.Windows.Forms.Label Current_pass;
        private System.Windows.Forms.Button Change_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Label P_alert;
    }
}