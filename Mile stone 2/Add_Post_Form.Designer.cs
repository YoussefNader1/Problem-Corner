
namespace Mile_stone_2
{
    partial class Add_Post_Form
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
            this.txt_AddPost = new System.Windows.Forms.TextBox();
            this.btn_AddPost = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_AddPost
            // 
            this.txt_AddPost.Location = new System.Drawing.Point(15, 57);
            this.txt_AddPost.Multiline = true;
            this.txt_AddPost.Name = "txt_AddPost";
            this.txt_AddPost.Size = new System.Drawing.Size(480, 111);
            this.txt_AddPost.TabIndex = 0;
            this.txt_AddPost.TextChanged += new System.EventHandler(this.txt_AddPost_TextChanged);
            // 
            // btn_AddPost
            // 
            this.btn_AddPost.Location = new System.Drawing.Point(388, 195);
            this.btn_AddPost.Name = "btn_AddPost";
            this.btn_AddPost.Size = new System.Drawing.Size(107, 33);
            this.btn_AddPost.TabIndex = 1;
            this.btn_AddPost.Text = "Add";
            this.btn_AddPost.UseVisualStyleBackColor = true;
            this.btn_AddPost.Click += new System.EventHandler(this.btn_AddPost_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Your Post Here";
            // 
            // Add_Post_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(519, 250);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AddPost);
            this.Controls.Add(this.txt_AddPost);
            this.Name = "Add_Post_Form";
            this.Text = "Add_Post_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_Post_Form_FormClosing);
            this.Load += new System.EventHandler(this.Add_Post_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_AddPost;
        private System.Windows.Forms.Button btn_AddPost;
        private System.Windows.Forms.Label label1;
    }
}