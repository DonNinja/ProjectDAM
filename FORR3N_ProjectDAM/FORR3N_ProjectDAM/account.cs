﻿using System;
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
    public partial class account : Form
    {
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();

        /*Þetta er listinn sem lesinn er upp úr gagnagrunninum*/
        List<string> linur = new List<string>();


        private void account_Load(object sender, EventArgs e)
        {
            SkrifaUt();
        }

        public account(string usern, string passw)
        {
            InitializeComponent();
            tbReadUser.Text = usern;
            tbReadPass.Text = passw;

            try
            {
                gagnagrunnur.TengingVidGagnagrunn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void SkrifaUt()
        {
            /*Þetta eru dálkarnir sem eru efst í listViewinu*/
            listView1.Columns.Add("Username", 100);
            listView1.Columns.Add("Password", 100);
            listView1.Columns.Add("Email", 100);
            listView1.Columns.Add("Account creation date", 130);

            /*Þetta er arrayin sem er notaður til þess að bæta inn í listviewið*/
            string[] arr = new string[4];

            /*Þetta heldur utam um itemin sem eru bætt við í hverja línu í listviewinu*/
            ListViewItem itm;

            try
            {
                linur = gagnagrunnur.LesautSQLTofluBasic(tbReadUser.Text, tbReadPass.Text);

                foreach (string lin in linur)
                {
                    /*Hérna er verið að splitta upp línunu sem kemur frá grunninum*/
                    string[] linaUrLista = lin.Split(':');
                    string u_name = linaUrLista[0];
                    string p_word = linaUrLista[1];
                    string email = linaUrLista[2];
                    string accd = linaUrLista[3];

                    /*Hefði líka verið hægt að gera þetta svona arr[0] = linaUrlista[0]*/
                    arr[0] = u_name;
                    arr[1] = p_word;
                    arr[2] = email;
                    arr[3] = accd;

                    /*sett inn í ListViewItemið og bætt svo inn í listView-ið*/
                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);

                    tbOldUser.Text = u_name;
                    tbOldPass.Text = p_word;
                    tbOldEmail.Text = email;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            tbReadUser.Text = tbNewUser.Text;
            tbReadPass.Text = tbNewPass.Text;
            gagnagrunnur.UpdateUser(tbNewUser.Text, tbNewPass.Text, tbNewEmail.Text, tbOldUser.Text, tbOldPass.Text, tbOldEmail.Text);
            listView1.Clear();

            SkrifaUt();
        }
    }
}
