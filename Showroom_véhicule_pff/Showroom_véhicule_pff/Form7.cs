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
    public partial class Form7 : Form
    {
        MySqlConnection conn;

        MySqlCommand command, cmd2, cmd3;
        MySqlDataAdapter adap;
        MySqlDataReader reader;
        DataSet dset;
        DataTable dt;
        MySqlCommandBuilder cb;

        int currRowIndex;
        String table = "Commandes";

        private void loadclient()
        {
            try
            {
                conn.Open();
                command = new MySqlCommand("SELECT `Cin_Client` FROM `client`", conn);
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

        private void Form7_Load(object sender, EventArgs e)
        {
            //  Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            // string connStr = "server=localhost;Port=1234;port=3306;Uid=root; Pwd=root; database=amine_achraf";
            MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
            conn_string.Server = "localhost";
            conn_string.UserID = "root";
            // conn_string.Password = "";
            //conn_string.Port = 3308;
            conn_string.Database = "showroom_pff";

            conn = new MySqlConnection(conn_string.ToString());


            try
            {
                conn.Open();

                // MessageBox.Show("Connecté");
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
                loadclient();



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
            
            try
            {
                conn.Open();
                textBox1.Text = dateTimePicker1.Value.ToShortDateString().ToString();

                String s = "INSERT INTO `commandes`(`Numéro_commande`, `Marque`, `Modéle`, `Mode de paiment`, `Date de commande`, `Cin_Client`, `Montant`, `Remise`, `Avance`, `Reste`) VALUES ('" + textBox6.Text.ToString() + "','" + comboBox3.SelectedItem.ToString() + "','" + comboBox4.SelectedItem.ToString() + "','" + comboBox2.SelectedItem.ToString() + "','" + dateTimePicker1.Value.Date.Year + "-"  + dateTimePicker1.Value.Date.Month + "-" + dateTimePicker1.Value.Date.Day + "','" + comboBox1.SelectedItem.ToString() + "' , '" + textBox4.Text.ToString() + "','" + comboBox5.SelectedItem.ToString() + "','" + textBox7.Text.ToString() + "','" + label20.Text.ToString() + "')";
                //  String s = "INSERT INTO `club`(`ID_Club`, `Nom Du Club`, `Nombre MAX`, `Date de creation`, `Catégorie`) VALUES ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + dateTimePicker1.Value.ToShortDateString() + "','sportive')";

                //String s = "insert into Club (ID_Club,Nom Du Club,Date De Creation,Categorie,Nombre MAX,Nom Du Fondateur) Values('achraf','arroud')";
                command = new MySqlCommand();
                command = conn.CreateCommand();
                command.CommandText = s;
                command.ExecuteNonQuery();
                MessageBox.Show("La commande"+ textBox6.Text.ToString()+"est bien insérrée dans la base");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            if (comboBox3.SelectedItem.Equals("Peougot"))
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("206");
                comboBox4.Items.Add("208");
                comboBox4.Items.Add("308");
                comboBox4.Items.Add("407");
            }
            else if (comboBox3.SelectedItem.Equals("Volkswage"))
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("GOLF 4");
                comboBox4.Items.Add("GOLF 5");
                comboBox4.Items.Add("GOLF 6");
                comboBox4.Items.Add("GOLF 7");
            }
            else if (comboBox3.SelectedItem.Equals("BMW"))
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("GOLF ");
                comboBox4.Items.Add("GOLF ");
                comboBox4.Items.Add("GOLF ");
                comboBox4.Items.Add("GOLF ");
            }
            else if (comboBox3.SelectedItem.Equals("Mercedes"))
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("GOLF 4");
                comboBox4.Items.Add("GOLF 5");
                comboBox4.Items.Add("GOLF 6");
                comboBox4.Items.Add("GOLF 7");
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem.Equals("206"))
            {
                textBox4.Text = "15000";
               
               
            }
            else if (comboBox4.SelectedItem.Equals("208"))
            {
                textBox4.Text = "18000";
            
                           }
            else if (comboBox4.SelectedItem.Equals("308"))
            {
                textBox4.Text = "20000";


            }
            else if (comboBox4.SelectedItem.Equals("407"))
            {
                textBox4.Text = "30000";


            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            label19.Text =( Int32.Parse(textBox4.Text) * Int32.Parse(comboBox5.SelectedItem.ToString()) / 100).ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            label20.Text= (Int32.Parse(textBox4.Text)-Int32.Parse(label19.Text) - Int32.Parse(textBox7.Text) ).ToString();
        }

        private void ajouterVoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 a = new Form3();
            a.Show();
        }

        private void modifierVoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 a = new Form5();
            a.Show();
        }

        private void suppriméVoitireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 a = new Form4();
            a.Show();
        }

        private void ajouterClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 a = new Form6();
            a.Show();
        }

        private void modifierClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 a = new Form6();
            a.Show();
        }

        private void suppriméClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 a = new Form6();
            a.Show();
        }

        private void ajouterCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 a = new Form7();
            a.Show();
        }

        private void modifierCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 a = new Form8();
            a.Show();
        }

        private void suppriméCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 a = new Form8();
            a.Show();
        }

        public Form7()
        {
            InitializeComponent();

       
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();


                String sql = "SELECT `Cin_Client`, `Nom`, `Prenom`, `Adresse`  FROM `client` WHERE `Cin_Client`='" + comboBox1.SelectedItem + "'";

                command = new MySqlCommand(sql, conn);
                {

                    reader = command.ExecuteReader();
                    {
                        while (reader.Read())
                        {
                            textBox1.Text = reader.GetString(1);
                            textBox2.Text = reader.GetString(2);
                            textBox3.Text = reader.GetString(3);

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
    }
}
