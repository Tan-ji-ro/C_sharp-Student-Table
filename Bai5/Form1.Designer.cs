namespace Bai5
{
    partial class Main_form
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
            this.L1 = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.Label();
            this.Length_box = new System.Windows.Forms.TextBox();
            this.Width_box = new System.Windows.Forms.TextBox();
            this.Calc_button = new System.Windows.Forms.Button();
            this.Res_box = new System.Windows.Forms.GroupBox();
            this.Res_label_1 = new System.Windows.Forms.Label();
            this.Res_label_2 = new System.Windows.Forms.Label();
            this.Res_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Location = new System.Drawing.Point(8, 13);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(51, 13);
            this.L1.TabIndex = 0;
            this.L1.Text = "Chiều dài";
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.Location = new System.Drawing.Point(8, 38);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(58, 13);
            this.L2.TabIndex = 0;
            this.L2.Text = "Chiều rộng";
            // 
            // Length_box
            // 
            this.Length_box.Location = new System.Drawing.Point(70, 13);
            this.Length_box.Name = "Length_box";
            this.Length_box.Size = new System.Drawing.Size(202, 20);
            this.Length_box.TabIndex = 1;
            // 
            // Width_box
            // 
            this.Width_box.Location = new System.Drawing.Point(70, 35);
            this.Width_box.Name = "Width_box";
            this.Width_box.Size = new System.Drawing.Size(202, 20);
            this.Width_box.TabIndex = 1;
            // 
            // Calc_button
            // 
            this.Calc_button.Location = new System.Drawing.Point(102, 61);
            this.Calc_button.Name = "Calc_button";
            this.Calc_button.Size = new System.Drawing.Size(75, 23);
            this.Calc_button.TabIndex = 2;
            this.Calc_button.Text = "Tính";
            this.Calc_button.UseVisualStyleBackColor = true;
            this.Calc_button.Click += new System.EventHandler(this.Calc_button_Click);
            // 
            // Res_box
            // 
            this.Res_box.Controls.Add(this.Res_label_2);
            this.Res_box.Controls.Add(this.Res_label_1);
            this.Res_box.Location = new System.Drawing.Point(11, 101);
            this.Res_box.Name = "Res_box";
            this.Res_box.Size = new System.Drawing.Size(261, 148);
            this.Res_box.TabIndex = 3;
            this.Res_box.TabStop = false;
            this.Res_box.Text = "Kết quả";
            // 
            // Res_label_1
            // 
            this.Res_label_1.AutoSize = true;
            this.Res_label_1.Location = new System.Drawing.Point(7, 20);
            this.Res_label_1.Name = "Res_label_1";
            this.Res_label_1.Size = new System.Drawing.Size(140, 13);
            this.Res_label_1.TabIndex = 0;
            this.Res_label_1.Text = "Chu vi của hình chữ nhật là:";
            // 
            // Res_label_2
            // 
            this.Res_label_2.AutoSize = true;
            this.Res_label_2.Location = new System.Drawing.Point(7, 44);
            this.Res_label_2.Name = "Res_label_2";
            this.Res_label_2.Size = new System.Drawing.Size(154, 13);
            this.Res_label_2.TabIndex = 0;
            this.Res_label_2.Text = "Diện tích của hình chữ nhật là:";
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Res_box);
            this.Controls.Add(this.Calc_button);
            this.Controls.Add(this.Width_box);
            this.Controls.Add(this.Length_box);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.L1);
            this.Name = "Main_form";
            this.Text = "Hình chữ nhật";
            this.Res_box.ResumeLayout(false);
            this.Res_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.TextBox Length_box;
        private System.Windows.Forms.TextBox Width_box;
        private System.Windows.Forms.Button Calc_button;
        private System.Windows.Forms.GroupBox Res_box;
        private System.Windows.Forms.Label Res_label_2;
        private System.Windows.Forms.Label Res_label_1;
    }
}

