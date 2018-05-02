using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORR3N_ProjectDAM
{
    public partial class Form1 : Form
    {
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();
        account acctform = new account();

        public Form1()
        {
            InitializeComponent();

            try
            {
                gagnagrunnur.TengingVidGagnagrunn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btSignIn_Click(object sender, EventArgs e)
        {
            if (gagnagrunnur.LogIn(tbUsern.Text, tbPass.Text) == true)
            {
                MessageBox.Show("Login successful");
                acctform.Show();
                
            }
            else
            {
                lbConnSucc.Text = "Connection unsuccessful";
                lbConnSucc.ForeColor = System.Drawing.Color.Red;
                lbConnSucc.Font = new Font(lbConnSucc.Font, FontStyle.Bold);
            }

        }
    }
}
