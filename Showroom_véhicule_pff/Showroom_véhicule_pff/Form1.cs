using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Showroom_véhicule_pff
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;

        MySqlCommand command, cmd2, cmd3;
        MySqlDataAdapter adap;
        MySqlDataReader reader;
        DataSet dset;
        DataTable dt;
        MySqlCommandBuilder cb;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {// string connStr = "server=localhost;Port=1234;port=3306;Uid=root; Pwd=root; database=amine_achraf";
            MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
            conn_string.Server = "localhost";
            conn_string.UserID = "root";
            //conn_string.Password = "root";
            //     conn_string.Port = 3308;
            conn_string.Database = "pfe";
            MySqlConnection conn = new MySqlConnection(conn_string.ToString());



            try
            {
                conn.Open();
                conn.Close();

            }
            catch
            {
                MessageBox.Show("Non Connecté");
                // Console.WriteLine("Error: " + e);
                //Console.WriteLine(e.StackTrace);


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
            conn_string.Server = "localhost";
            conn_string.UserID = "root";
            //conn_string.Password = "root";
            //     conn_string.Port = 3308;
            conn_string.Database = "pfe";
            MySqlConnection conn = new MySqlConnection(conn_string.ToString());
            try
            {
                conn.Open();



                dset = new DataSet();
                adap = new MySqlDataAdapter("SELECT `Log_in`, `Mot_de_passe` FROM `users`", conn);
                adap.Fill(dset, "users");
                dt = dset.Tables["users"];
                Boolean connecter = false;
                for (int i = 0; i < dset.Tables["users"].Rows.Count; i++)
                {
                    if (textBox1.Text.Equals(dset.Tables["users"].Rows[i][0]) && textBox2.Text.Equals(dset.Tables["users"].Rows[i][1]))
                    {
                        connecter = true;

                        this.Hide();
                        Form2 a = new Form2();
                        a.Show();
                        break;
                    }
                }
                if (connecter == false)
                {

                    MessageBox.Show("Données érronées : login ou mot de passe invalide");
                    textBox1.Clear();
                    textBox2.Clear();

                }
                conn.Close();




            }
            catch
            {
                MessageBox.Show("erreur");
                // Console.WriteLine("Error: " + e);
                //Console.WriteLine(e.StackTrace);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }
    }
}
