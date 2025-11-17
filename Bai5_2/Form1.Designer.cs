namespace Bai5_2
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
            this.Name_box = new System.Windows.Forms.TextBox();
            this.L2 = new System.Windows.Forms.Label();
            this.Math_box = new System.Windows.Forms.TextBox();
            this.L3 = new System.Windows.Forms.Label();
            this.Lit_box = new System.Windows.Forms.TextBox();
            this.Add_button = new System.Windows.Forms.Button();
            this.Res_box = new System.Windows.Forms.GroupBox();
            this.Data_table = new System.Windows.Forms.DataGridView();
            this.L_Warning = new System.Windows.Forms.Label();
            this.Save_bt = new System.Windows.Forms.Button();
            this.Load_bt = new System.Windows.Forms.Button();
            this.Res_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_table)).BeginInit();
            this.SuspendLayout();
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Location = new System.Drawing.Point(109, 10);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(69, 13);
            this.L1.TabIndex = 0;
            this.L1.Text = "Tên học sinh";
            // 
            // Name_box
            // 
            this.Name_box.Location = new System.Drawing.Point(184, 7);
            this.Name_box.Name = "Name_box";
            this.Name_box.Size = new System.Drawing.Size(285, 20);
            this.Name_box.TabIndex = 1;
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.Location = new System.Drawing.Point(109, 36);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(59, 13);
            this.L2.TabIndex = 0;
            this.L2.Text = "Điểm Toán";
            // 
            // Math_box
            // 
            this.Math_box.Location = new System.Drawing.Point(184, 33);
            this.Math_box.Name = "Math_box";
            this.Math_box.Size = new System.Drawing.Size(285, 20);
            this.Math_box.TabIndex = 1;
            // 
            // L3
            // 
            this.L3.AutoSize = true;
            this.L3.Location = new System.Drawing.Point(109, 62);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(53, 13);
            this.L3.TabIndex = 0;
            this.L3.Text = "Điểm Văn";
            // 
            // Lit_box
            // 
            this.Lit_box.Location = new System.Drawing.Point(184, 59);
            this.Lit_box.Name = "Lit_box";
            this.Lit_box.Size = new System.Drawing.Size(285, 20);
            this.Lit_box.TabIndex = 1;
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(192, 85);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(75, 23);
            this.Add_button.TabIndex = 2;
            this.Add_button.Text = "Thêm";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Res_box
            // 
            this.Res_box.Controls.Add(this.Data_table);
            this.Res_box.Location = new System.Drawing.Point(12, 113);
            this.Res_box.Name = "Res_box";
            this.Res_box.Size = new System.Drawing.Size(579, 178);
            this.Res_box.TabIndex = 3;
            this.Res_box.TabStop = false;
            this.Res_box.Text = "Kết quả";
            // 
            // Data_table
            // 
            this.Data_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_table.Location = new System.Drawing.Point(7, 20);
            this.Data_table.Name = "Data_table";
            this.Data_table.Size = new System.Drawing.Size(566, 150);
            this.Data_table.TabIndex = 0;
            // 
            // L_Warning
            // 
            this.L_Warning.AutoSize = true;
            this.L_Warning.Location = new System.Drawing.Point(16, 294);
            this.L_Warning.Name = "L_Warning";
            this.L_Warning.Size = new System.Drawing.Size(39, 13);
            this.L_Warning.TabIndex = 4;
            this.L_Warning.Text = "Lưu ý: ";
            // 
            // Save_bt
            // 
            this.Save_bt.Location = new System.Drawing.Point(273, 85);
            this.Save_bt.Name = "Save_bt";
            this.Save_bt.Size = new System.Drawing.Size(75, 23);
            this.Save_bt.TabIndex = 5;
            this.Save_bt.Text = "Lưu kết quả";
            this.Save_bt.UseVisualStyleBackColor = true;
            this.Save_bt.Click += new System.EventHandler(this.Save_bt_Click);
            // 
            // Load_bt
            // 
            this.Load_bt.Location = new System.Drawing.Point(355, 86);
            this.Load_bt.Name = "Load_bt";
            this.Load_bt.Size = new System.Drawing.Size(75, 23);
            this.Load_bt.TabIndex = 6;
            this.Load_bt.Text = "Nhập";
            this.Load_bt.UseVisualStyleBackColor = true;
            this.Load_bt.Click += new System.EventHandler(this.Load_bt_Click);
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 316);
            this.Controls.Add(this.Load_bt);
            this.Controls.Add(this.Save_bt);
            this.Controls.Add(this.L_Warning);
            this.Controls.Add(this.Res_box);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Lit_box);
            this.Controls.Add(this.L3);
            this.Controls.Add(this.Math_box);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.Name_box);
            this.Controls.Add(this.L1);
            this.Name = "Main_form";
            this.Text = "Quản lý học sinh";
            this.Res_box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Data_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.TextBox Name_box;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.TextBox Math_box;
        private System.Windows.Forms.Label L3;
        private System.Windows.Forms.TextBox Lit_box;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.GroupBox Res_box;
        private System.Windows.Forms.Label L_Warning;
        private System.Windows.Forms.DataGridView Data_table;
        private System.Windows.Forms.Button Save_bt;
        private System.Windows.Forms.Button Load_bt;
    }
}

