
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
            this.SuspendLayout();
            // 
            // txt_AddPost
            // 
            this.txt_AddPost.Location = new System.Drawing.Point(189, 98);
            this.txt_AddPost.Multiline = true;
            this.txt_AddPost.Name = "txt_AddPost";
            this.txt_AddPost.Size = new System.Drawing.Size(428, 74);
            this.txt_AddPost.TabIndex = 0;
            // 
            // btn_AddPost
            // 
            this.btn_AddPost.Location = new System.Drawing.Point(347, 226);
            this.btn_AddPost.Name = "btn_AddPost";
            this.btn_AddPost.Size = new System.Drawing.Size(107, 33);
            this.btn_AddPost.TabIndex = 1;
            this.btn_AddPost.Text = "Add";
            this.btn_AddPost.UseVisualStyleBackColor = true;
            this.btn_AddPost.Click += new System.EventHandler(this.btn_AddPost_Click);
            // 
            // Add_Post_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_AddPost);
            this.Controls.Add(this.txt_AddPost);
            this.Name = "Add_Post_Form";
            this.Text = "Add_Post_Form";
            this.Load += new System.EventHandler(this.Add_Post_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_AddPost;
        private System.Windows.Forms.Button btn_AddPost;
    }
}