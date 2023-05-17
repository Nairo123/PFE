using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Showroom_véhicule_pff
{
    public partial class Form4 : Form
    {
        MySqlConnection conn;

        MySqlCommand command, cmd2, cmd3;
        MySqlDataAdapter adap;
        MySqlDataReader reader;
        DataSet dset;
        DataTable dt;
        MySqlCommandBuilder cb;
        public Form4()
        {
            InitializeComponent();
        }
        private void loadclub()
        {
            try
            {
                conn.Open();
                command = new MySqlCommand("SELECT `Matricule`, `Modéle`, `Marque` FROM `voiture`", conn);
                command.ExecuteNonQuery();
                dt = new DataTable();
                adap = new MySqlDataAdapter(command);
                adap.Fill(dt);

                //comboBox_exemplaire.Items.Clear();
                //comboBox_exemplaire.Text = "" ;
                foreach (DataRow row in dt.Rows)
                {
                    comboBox1.Items.Add(row.ItemArray[0].ToString());

                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();


                String sql = "SELECT `Matricule`, `Modéle`, `Marque`, `Puissance Fiscale`, `Carburant`, `Kélometrage`, `Boite`, `Date de fabrication` FROM `voiture`  WHERE `Matricule`='" + comboBox1.SelectedItem + "'";

                command = new MySqlCommand(sql, conn);
                {

                    reader = command.ExecuteReader();
                    {
                        while (reader.Read())
                        {
                            label5.Text = reader.GetString(1);
                            label6.Text = reader.GetString(2);

                        }
                    }
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // textBox1.Text = dateTimePicker1.Value.ToShortDateString().ToString();
                String s = "DELETE FROM `voiture` WHERE `Matricule`='" + comboBox1.SelectedItem + "'";
                //  String s = "INSERT INTO `club`(`ID_Club`, `Nom Du Club`, `Nombre MAX`, `Date de creation`, `Catégorie`) VALUES ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + dateTimePicker1.Value.ToShortDateString() + "','sportive')";

                //                String s = "insert into Club (ID_Club,Nom Du Club,Date De Creation,Categorie,Nombre MAX,Nom Du Fondateur) Values('achraf','arroud')";
                conn.Open();
                command = new MySqlCommand();
                command = conn.CreateCommand();
                command.CommandText = s;
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void suppriméVoituresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 a = new Form4();
            a.Show();
        }

        private void ajouterClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 a = new Form6();
            a.Show();
        }

        private void suppriméClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 a = new Form6();
            a.Show();
        }

        private void ajouterCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 a = new Form7();
            a.Show();
        }

        private void modifierCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 a = new Form8();
            a.Show();
        }

        private void suppriméCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 a = new Form8();
            a.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {


            //  Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            // string connStr = "server=localhost;Port=1234;port=3306;Uid=root; Pwd=root; database=amine_achraf";
            MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
            conn_string.Server = "localhost";
            conn_string.UserID = "root";
            // conn_string.Password = "";
            //conn_string.Port = 3308;
            conn_string.Database = "pfe";

            conn = new MySqlConnection(conn_string.ToString());


            try
            {
                conn.Open();

                MessageBox.Show("Connecté");
                /*
                                String sql = "SELECT ID_Club,Nom Du Club,Date De Creation,Categorie,Nombre MAX,Nom Du Fondateur  FROM Club";

                                command = new MySqlCommand(sql, conn);
                                {

                                    reader = command.ExecuteReader();
                                    {
                                        while (reader.Read())
                                        {
                                            Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
                                            label1.Text = reader.GetString(0);
                                        }
                                    }
                                }*/

                conn.Close();
                loadclub();



            }
            catch
            {
                MessageBox.Show("Non Connecté");
                // Console.WriteLine("Error: " + e);
                //Console.WriteLine(e.StackTrace);
            }
        }


    }
}
