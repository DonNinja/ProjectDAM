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
            this.tbTakenUser = new System.Windows.Forms.TextBox();
            this.tbTakenPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(529, 185);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // tbTakenUser
            // 
            this.tbTakenUser.Location = new System.Drawing.Point(81, 49);
            this.tbTakenUser.Name = "tbTakenUser";
            this.tbTakenUser.Size = new System.Drawing.Size(100, 20);
            this.tbTakenUser.TabIndex = 3;
            // 
            // tbTakenPass
            // 
            this.tbTakenPass.Location = new System.Drawing.Point(81, 96);
            this.tbTakenPass.Name = "tbTakenPass";
            this.tbTakenPass.Size = new System.Drawing.Size(100, 20);
            this.tbTakenPass.TabIndex = 4;
            // 
            // account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 454);
            this.Controls.Add(this.tbTakenPass);
            this.Controls.Add(this.tbTakenUser);
            this.Controls.Add(this.listView1);
            this.Name = "account";
            this.Text = "account";
            this.Load += new System.EventHandler(this.account_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox tbTakenUser;
        private System.Windows.Forms.TextBox tbTakenPass;
    }
}