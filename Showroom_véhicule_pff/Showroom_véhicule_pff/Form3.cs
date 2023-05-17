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
    public partial class Form3 : Form
    {
        MySqlConnection conn;

        MySqlCommand command, cmd2, cmd3;
        MySqlDataAdapter adap;
        MySqlDataReader reader;
        DataSet dset;
        DataTable dt;
        MySqlCommandBuilder cb;

        private void button1_Click(object sender, EventArgs e)
        {
            //  Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            // string connStr = "server=localhost;Port=1234;port=3306;Uid=root; Pwd=root; database=amine_achraf";
            MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
            conn_string.Server = "localhost";
            conn_string.UserID = "root";
            // conn_string.Password = "";
            //  conn_string.Port = 3308;
            conn_string.Database = "pfe";

            conn = new MySqlConnection(conn_string.ToString());

            try
            {
                conn.Open();
                // textBox1.Text = dateTimePicker1.Value.ToShortDateString().ToString();
                String s = "INSERT INTO `voiture`(`Matricule`, `Modéle`, `Marque`, `Puissance Fiscale`, `Carburant`, `Kélometrage`, `Boite`, `Date de fabrication`) VALUES ('" + textBox1.Text.ToString() + "','" + comboBox1.SelectedItem + "','" + comboBox2.SelectedItem + "','" +  "','" + comboBox3.SelectedItem + "','" +  "','" + comboBox4.SelectedItem + "','" + dateTimePicker1.Value.Date.Year + "-" + dateTimePicker1.Value.Date.Month + "-" + dateTimePicker1.Value.Date.Day + "')";
                //  String s = "INSERT INTO `club`(`ID_Club`, `Nom Du Club`, `Nombre MAX`, `Date de creation`, `Catégorie`) VALUES ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + dateTimePicker1.Value.ToShortDateString() + "','sportive')";

                //                String s = "insert into Club (ID_Club,Nom Du Club,Date De Creation,Categorie,Nombre MAX,Nom Du Fondateur) Values('achraf','arroud')";
                command = new MySqlCommand();
                command = conn.CreateCommand();
                command.CommandText = s;
                command.ExecuteNonQuery();
                MessageBox.Show("La voiture" + textBox1.Text.ToString() + "est bien insérrée dans la base");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void modifierClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 a = new Form6();
            a.Show();
        }

        private void ajouterVoituresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 a = new Form3();
            a.Show();
        }

        private void modifierVoituresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 a = new Form5();
            a.Show();
        }

        private void suppriméVoituresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 a = new Form4();
            a.Show();
        }

        private void modifierCliToolStripMenuItem_Click(object sender, EventArgs e)
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

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //  Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            // string connStr = "server=localhost;Port=1234;port=3306;Uid=root; Pwd=root; database=amine_achraf";
            MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
            conn_string.Server = "localhost";
            conn_string.UserID = "root";
            // conn_string.Password = "";
            //  conn_string.Port = 3308;
            conn_string.Database = "pfe";

            conn = new MySqlConnection(conn_string.ToString());



            try
            {
                conn.Open();
                /*
                                MessageBox.Show("Connecté");

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

            }
            catch
            {
                MessageBox.Show("Non Connecté");
                // Console.WriteLine("Error: " + e);
                //Console.WriteLine(e.StackTrace);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
