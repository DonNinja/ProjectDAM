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
    public partial class NewUser : Form
    {
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();

        public NewUser()
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

        private void NewUser_Load(object sender, EventArgs e)
        {

        }

        private void btUser_Click(object sender, EventArgs e)
        {
            gagnagrunnur.NewUser(tbNewUsern.Text, tbNewPassw.Text, tbNewEmail.Text);
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }
    }
}
