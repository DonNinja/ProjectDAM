namespace FORR3N_ProjectDAM
{
    partial class NewUser
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
            this.tbNewUsern = new System.Windows.Forms.TextBox();
            this.tbNewPassw = new System.Windows.Forms.TextBox();
            this.tbNewEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNewUsern
            // 
            this.tbNewUsern.Location = new System.Drawing.Point(112, 16);
            this.tbNewUsern.Name = "tbNewUsern";
            this.tbNewUsern.Size = new System.Drawing.Size(100, 20);
            this.tbNewUsern.TabIndex = 0;
            // 
            // tbNewPassw
            // 
            this.tbNewPassw.Location = new System.Drawing.Point(112, 68);
            this.tbNewPassw.Name = "tbNewPassw";
            this.tbNewPassw.Size = new System.Drawing.Size(100, 20);
            this.tbNewPassw.TabIndex = 1;
            // 
            // tbNewEmail
            // 
            this.tbNewEmail.Location = new System.Drawing.Point(112, 120);
            this.tbNewEmail.Name = "tbNewEmail";
            this.tbNewEmail.Size = new System.Drawing.Size(100, 20);
            this.tbNewEmail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email:";
            // 
            // btUser
            // 
            this.btUser.Location = new System.Drawing.Point(42, 163);
            this.btUser.Name = "btUser";
            this.btUser.Size = new System.Drawing.Size(147, 62);
            this.btUser.TabIndex = 7;
            this.btUser.Text = "Create new user";
            this.btUser.UseVisualStyleBackColor = true;
            this.btUser.Click += new System.EventHandler(this.btUser_Click);
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 254);
            this.Controls.Add(this.btUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNewEmail);
            this.Controls.Add(this.tbNewPassw);
            this.Controls.Add(this.tbNewUsern);
            this.Name = "NewUser";
            this.Text = "NewUser";
            this.Load += new System.EventHandler(this.NewUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNewUsern;
        private System.Windows.Forms.TextBox tbNewPassw;
        private System.Windows.Forms.TextBox tbNewEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btUser;
    }
}