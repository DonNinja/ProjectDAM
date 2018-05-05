namespace FORR3N_ProjectDAM
{
    partial class account
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.tbReadUser = new System.Windows.Forms.TextBox();
            this.tbReadPass = new System.Windows.Forms.TextBox();
            this.tbOldUser = new System.Windows.Forms.TextBox();
            this.tbOldPass = new System.Windows.Forms.TextBox();
            this.tbOldEmail = new System.Windows.Forms.TextBox();
            this.tbNewEmail = new System.Windows.Forms.TextBox();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.tbNewUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(464, 45);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // tbReadUser
            // 
            this.tbReadUser.Location = new System.Drawing.Point(482, 12);
            this.tbReadUser.Name = "tbReadUser";
            this.tbReadUser.Size = new System.Drawing.Size(59, 20);
            this.tbReadUser.TabIndex = 3;
            this.tbReadUser.Visible = false;
            // 
            // tbReadPass
            // 
            this.tbReadPass.Location = new System.Drawing.Point(482, 37);
            this.tbReadPass.Name = "tbReadPass";
            this.tbReadPass.Size = new System.Drawing.Size(59, 20);
            this.tbReadPass.TabIndex = 4;
            this.tbReadPass.Visible = false;
            // 
            // tbOldUser
            // 
            this.tbOldUser.Enabled = false;
            this.tbOldUser.Location = new System.Drawing.Point(134, 102);
            this.tbOldUser.Name = "tbOldUser";
            this.tbOldUser.Size = new System.Drawing.Size(100, 20);
            this.tbOldUser.TabIndex = 5;
            // 
            // tbOldPass
            // 
            this.tbOldPass.Enabled = false;
            this.tbOldPass.Location = new System.Drawing.Point(134, 154);
            this.tbOldPass.Name = "tbOldPass";
            this.tbOldPass.Size = new System.Drawing.Size(100, 20);
            this.tbOldPass.TabIndex = 6;
            // 
            // tbOldEmail
            // 
            this.tbOldEmail.Enabled = false;
            this.tbOldEmail.Location = new System.Drawing.Point(134, 206);
            this.tbOldEmail.Name = "tbOldEmail";
            this.tbOldEmail.Size = new System.Drawing.Size(100, 20);
            this.tbOldEmail.TabIndex = 7;
            // 
            // tbNewEmail
            // 
            this.tbNewEmail.Location = new System.Drawing.Point(376, 206);
            this.tbNewEmail.Name = "tbNewEmail";
            this.tbNewEmail.Size = new System.Drawing.Size(100, 20);
            this.tbNewEmail.TabIndex = 11;
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(376, 154);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.Size = new System.Drawing.Size(100, 20);
            this.tbNewPass.TabIndex = 10;
            // 
            // tbNewUser
            // 
            this.tbNewUser.Location = new System.Drawing.Point(376, 102);
            this.tbNewUser.Name = "tbNewUser";
            this.tbNewUser.Size = new System.Drawing.Size(100, 20);
            this.tbNewUser.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Current Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Current Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Current Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "New Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "New Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "New Username:";
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(134, 248);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(199, 80);
            this.btUpdate.TabIndex = 19;
            this.btUpdate.Text = "Update user";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 346);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNewEmail);
            this.Controls.Add(this.tbNewPass);
            this.Controls.Add(this.tbNewUser);
            this.Controls.Add(this.tbOldEmail);
            this.Controls.Add(this.tbOldPass);
            this.Controls.Add(this.tbOldUser);
            this.Controls.Add(this.tbReadPass);
            this.Controls.Add(this.tbReadUser);
            this.Controls.Add(this.listView1);
            this.Name = "account";
            this.Text = "account";
            this.Load += new System.EventHandler(this.account_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox tbReadUser;
        private System.Windows.Forms.TextBox tbReadPass;
        private System.Windows.Forms.TextBox tbOldUser;
        private System.Windows.Forms.TextBox tbOldPass;
        private System.Windows.Forms.TextBox tbOldEmail;
        private System.Windows.Forms.TextBox tbNewEmail;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.TextBox tbNewUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btUpdate;
    }
}