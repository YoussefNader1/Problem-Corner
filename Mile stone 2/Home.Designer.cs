﻿namespace Mile_stone_2
{
    partial class Home
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Add_Homeform = new System.Windows.Forms.Button();
            this.btn_Logout_from_home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(134, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Posts and Questions";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Add_Homeform
            // 
            this.btn_Add_Homeform.Location = new System.Drawing.Point(12, 12);
            this.btn_Add_Homeform.Name = "btn_Add_Homeform";
            this.btn_Add_Homeform.Size = new System.Drawing.Size(97, 30);
            this.btn_Add_Homeform.TabIndex = 2;
            this.btn_Add_Homeform.Text = "Add Post";
            this.btn_Add_Homeform.UseVisualStyleBackColor = true;
            this.btn_Add_Homeform.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Logout_from_home
            // 
            this.btn_Logout_from_home.Location = new System.Drawing.Point(951, 485);
            this.btn_Logout_from_home.Name = "btn_Logout_from_home";
            this.btn_Logout_from_home.Size = new System.Drawing.Size(96, 30);
            this.btn_Logout_from_home.TabIndex = 3;
            this.btn_Logout_from_home.Text = "Log Out";
            this.btn_Logout_from_home.UseVisualStyleBackColor = true;
            this.btn_Logout_from_home.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1059, 527);
            this.Controls.Add(this.btn_Logout_from_home);
            this.Controls.Add(this.btn_Add_Homeform);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Home";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Add_Homeform;
        private System.Windows.Forms.Button btn_Logout_from_home;
    }
}