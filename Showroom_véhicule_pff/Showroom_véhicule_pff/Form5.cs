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
    public partial class Form5 : Form
    {
        MySqlConnection conn;

        MySqlCommand command, cmd2, cmd3;
        MySqlDataAdapter adap;
        MySqlDataReader reader;
        DataSet dset;
        DataTable dt;
        MySqlCommandBuilder cb;
        public Form5()
        {
            InitializeComponent();
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
                            label10.Text = reader.GetString(1);
                            label11.Text = reader.GetString(2);
                            label12.Text = reader.GetString(7);
                            textBox1.Text = reader.GetString(3);
                            textBox2.Text = reader.GetString(5);
                            comboBox2.Text = reader.GetString(4);
                            comboBox3.Text = reader.GetString(6);

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
                String s = "UPDATE `voiture` SET `Puissance Fiscale`=" + textBox1.Text.ToString() + ",`Kélometrage`=" + textBox2.Text.ToString() + ",`Boite`='" + comboBox3.SelectedItem + "' , `Carburant`='" + comboBox2.SelectedItem + "' WHERE `Matricule`='" + comboBox1.SelectedItem + "'";
                //  String s = "INSERT INTO `club`(`ID_Club`, `Nom Du Club`, `Nombre MAX`, `Date de creation`, `Catégorie`) VALUES ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + dateTimePicker1.Value.ToShortDateString() + "','sportive')";

                //                String s = "insert into Club (ID_Club,Nom Du Club,Date De Creation,Categorie,Nombre MAX,Nom Du Fondateur) Values('achraf','arroud')";
                conn.Open();
                command = new MySqlCommand();
                command = conn.CreateCommand();
                command.CommandText = s;
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("la modification du voiture " + comboBox1.Text.ToString() + " est bien validée");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ajouterClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 a = new Form3();
            a.Show();
        }

        private void modifierClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 a = new Form5();
            a.Show();
        }

        private void suppriméClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 a = new Form4();
            a.Show();
        }

        private void ajouterClientsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 a = new Form6();
            a.Show();
        }

        private void modifierClientsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 a = new Form6();
            a.Show();
        }

        private void suppriméClientsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 a = new Form6();
            a.Show();
        }

        private void ajouterCommamnDesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 a = new Form7();
            a.Show();
        }

        private void modiierCommamndesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 a = new Form8();
            a.Show();
        }

        private void supprméCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 a = new Form8();
            a.Show();
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
        private void Form5_Load(object sender, EventArgs e)
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

        private void gestionDesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
