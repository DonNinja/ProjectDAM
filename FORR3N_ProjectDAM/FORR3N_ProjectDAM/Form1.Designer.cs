namespace FORR3N_ProjectDAM
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsern = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btSignIn = new System.Windows.Forms.Button();
            this.lbConnSucc = new System.Windows.Forms.Label();
            this.btNewUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password: ";
            // 
            // tbUsern
            // 
            this.tbUsern.Location = new System.Drawing.Point(126, 48);
            this.tbUsern.Name = "tbUsern";
            this.tbUsern.Size = new System.Drawing.Size(128, 20);
            this.tbUsern.TabIndex = 2;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(126, 106);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(128, 20);
            this.tbPass.TabIndex = 3;
            // 
            // btSignIn
            // 
            this.btSignIn.Location = new System.Drawing.Point(12, 150);
            this.btSignIn.Name = "btSignIn";
            this.btSignIn.Size = new System.Drawing.Size(156, 74);
            this.btSignIn.TabIndex = 4;
            this.btSignIn.Text = "Sign in";
            this.btSignIn.UseVisualStyleBackColor = true;
            this.btSignIn.Click += new System.EventHandler(this.btSignIn_Click);
            // 
            // lbConnSucc
            // 
            this.lbConnSucc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbConnSucc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbConnSucc.Location = new System.Drawing.Point(0, 0);
            this.lbConnSucc.Name = "lbConnSucc";
            this.lbConnSucc.Size = new System.Drawing.Size(347, 31);
            this.lbConnSucc.TabIndex = 5;
            this.lbConnSucc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btNewUser
            // 
            this.btNewUser.Location = new System.Drawing.Point(179, 150);
            this.btNewUser.Name = "btNewUser";
            this.btNewUser.Size = new System.Drawing.Size(156, 74);
            this.btNewUser.TabIndex = 6;
            this.btNewUser.Text = "Create new user\r\n(Opens another form)";
            this.btNewUser.UseVisualStyleBackColor = true;
            this.btNewUser.Click += new System.EventHandler(this.btNewUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 244);
            this.Controls.Add(this.btNewUser);
            this.Controls.Add(this.lbConnSucc);
            this.Controls.Add(this.btSignIn);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUsern);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSignIn;
        private System.Windows.Forms.Label lbConnSucc;
        public System.Windows.Forms.TextBox tbUsern;
        public System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btNewUser;


    }
}

