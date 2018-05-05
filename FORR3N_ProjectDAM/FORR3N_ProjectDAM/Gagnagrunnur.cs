using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace FORR3N_ProjectDAM
{
    class Gagnagrunnur
    {
        //server: segir til um hvar serverinn er hýstur, hjá okkur er það localhost
        private string server;
        //database: nafnið á gagnagrunninum sem verið er að nota
        private string database;
        //uid: er MySQL notendanafnið
        private string uid;
        //password. er MySQL lykilorðið
        private string password;
        //tengistrengur: contains the connection string to connect to the database and will be assigned to the connection variable
        string tengistrengur = null;
        //fyrirspurn: inniheldur viðeigandi fyrirspurn hverju sinni.
        string fyrirspurn = null;

        MySqlConnection sqltenging; //Þetta er notað til þess að opna tengingu við gagnagrunn
        MySqlCommand nySQLskipun; //Þetta er notað til þess að framkvæma SQL fyrirspurna
        MySqlDataReader sqllesari = null; //Lesari sem getur lesið úr SQL gagnagrunninum

        //Þessi aðferð tengir notanda við gagnagrunninn, þannig að þið breytið viðeigandi upplýsingum sem á við
        public void TengingVidGagnagrunn()
        {
            server = "10.200.10.24";
            database = "2605993489_projectdam";
            uid = "2605993489";
            password = "mypassword";

            tengistrengur = "server = " + server + ";userid = " + uid + ";password = " + password + ";database = " + database;
            sqltenging = new MySqlConnection(tengistrengur);
        }

        private bool OpenConnection()
        {
            try
            {
                sqltenging.Open();
                //MessageBox.Show("You connected"); //<--- If I did this then it would open every time a change to the database would occur
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Failed to connect"); //Runs this message if it isn't able to connect to the database
                throw ex;
            }
        }

        //Þessi aðferð lokar tengingu eftir notkun
        private bool CloseConnection()
        {
            try
            {
                sqltenging.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        public List<string> LesautSQLTofluBasic(string uname, string pword)
        {
            List<string> faerslur = new List<string>();
            string lina = null;
            if (OpenConnection() == true)
            {
                //fyrirspurn = "SELECT license_plate, year_built, brand, price, owner_name FROM cars";
                fyrirspurn = "SELECT u_name, p_word, email, accd FROM account WHERE u_name = '" + uname + "' AND p_word = '" + pword + "'";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                //ExecuteReader: Used to execute a command that will return 0 or more records
                sqllesari = nySQLskipun.ExecuteReader();
                while (sqllesari.Read())
                {
                    for (int i = 0; i < sqllesari.FieldCount; i++)
                    {
                        lina += (sqllesari.GetValue(i).ToString()) + ":";
                    }
                    faerslur.Add(lina);
                    lina = null;
                }
                CloseConnection();
                return faerslur;
            }
            return faerslur;
        }

        public bool LogIn(string usern, string passw)
        {
            List<string> faerslur = new List<string>();
            string lina = null;
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT * FROM account WHERE u_name = '" + usern + "' AND p_word = '" + passw + "'";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = nySQLskipun.ExecuteReader();
                while (sqllesari.Read())
                {
                    for (int i = 0; i < sqllesari.FieldCount; i++)
                    {
                        lina += (sqllesari.GetValue(i).ToString()) + ":";
                    }
                    faerslur.Add(lina);
                    lina = null;
                }
                CloseConnection();
                if (faerslur.Count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Connection failed");
                return false;
            }
        }

        public void LoggedIn(string usern, string passw)
        {
            if (OpenConnection() == true)
            {
                fyrirspurn = "UPDATE account SET login_count = login_count + 1 WHERE u_name = '" + usern + "' AND p_word = '" + passw + "'";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                nySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void NewUser(string usern, string passw, string email)
        {
            if (OpenConnection() == true)
            {
                fyrirspurn = "INSERT INTO account(u_name, p_word, email, accd, login_count) VALUES ('" + usern + "', '" + passw + "', '" + email + "', NOW(), 0)";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                nySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void UpdateUser(string newusern, string newpassw, string newemail, string oldusern, string oldpassw, string oldemail)
        {
            if (OpenConnection() == true)
            {
                fyrirspurn = "UPDATE account SET u_name = '" + newusern + "', p_word = '" + newpassw + "', email = '" + newemail + "' WHERE u_name = '" + oldusern + "' AND p_word = '" + oldpassw + "' AND email = '" + oldemail + "'";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                nySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
        }
    }
}
