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
    public partial class Form6 : Form
    {
        MySqlConnection conn;

        MySqlCommand command, cmd2, cmd3;
        MySqlDataAdapter adap;
        MySqlDataReader reader;
        DataSet dset;
        DataTable dt;
        MySqlCommandBuilder cb;

        int currRowIndex;
        String table = "client";
        public Form6()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                currRowIndex = Convert.ToInt32(row.Cells[0].Value);
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
                textBox5.Text = row.Cells[4].Value.ToString();
                textBox6.Text = row.Cells[5].Value.ToString();

                /*txt_adherant_addresse.Text = row.Cells[3].Value.ToString();
                txt_adherant_email.Text = row.Cells[4].Value.ToString();
                txt_adherant_tel.Text = row.Cells[5].Value.ToString();
                btn_adherant_delete.Enabled = true;
                btn_adherant_update.Enabled = true;
                btn_adherant_add.Enabled = false;
                */
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox1.Text == "")
            {
                DialogResult dialogClose = MessageBox.Show("Veuillez renseigner tous les champs", "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                try
                {
                    conn.Open();
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "INSERT INTO `client`(`Cin_Client`, `Nom`, `Prenom`, `Adresse`, `Numéro_telephone`, `Ville`)" + "VALUES(@Cin_Client, @Nom, @Prenom, @Adresse, @Numéro_telephone, @Ville)";
                    cmd.Parameters.AddWithValue("@Cin_Client", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Nom", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Prenom", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Adresse", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Numéro_telephone", textBox5.Text);
                    cmd.Parameters.AddWithValue("@Ville", textBox6.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    this.loadData();
                    MessageBox.Show("l adhérent " + textBox2.Text.ToString() + " " + textBox3.Text.ToString() + "est bien ajouté");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogUpdate = MessageBox.Show("Voulez-vous vraiment modifier les informations sur cette Adhérant", "Modifier une Adhérant", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogUpdate == DialogResult.OK)
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    DialogResult dialogClose = MessageBox.Show("Veuillez renseigner tous les champs", "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {

                    try
                    {
                        conn.Open();
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "UPDATE `client` SET `Cin_Client`= @Cin_Client,`Nom`=@Nom, `Prenom`=@Prenom, `Adresse`=@Adresse, `Numéro_telephone`=@Numéro_telephone, `Ville`=@Ville" + " WHERE `Cin_Client`=" + currRowIndex;
                        cmd.Parameters.AddWithValue("@Cin_Client", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Nom", textBox2.Text);
                        cmd.Parameters.AddWithValue("@Prenom", textBox3.Text);
                        cmd.Parameters.AddWithValue("@Adresse", textBox4.Text);
                        cmd.Parameters.AddWithValue("@Numéro_telephone", textBox5.Text);
                        cmd.Parameters.AddWithValue("@Ville", textBox6.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        this.loadData();
                        MessageBox.Show("l adhérent " + textBox2.Text.ToString() + " " + textBox3.Text.ToString() + "est bien modifié");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        conn.Close();
                    }


                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            Console.WriteLine(rowIndex);
            DialogResult dialogDelete = MessageBox.Show("voulez-vous vraiment supprimer cette Client", "Supprimer un Client", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogDelete == DialogResult.OK)
            {
                dataGridView1.Rows.RemoveAt(rowIndex);

                try
                {
                    conn.Open();
                    MySqlCommand cmd = conn.CreateCommand();
                    textBox1.Text = currRowIndex.ToString();
                    cmd.CommandText = "DELETE FROM `client` WHERE `Cin_Client` = " + currRowIndex;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    this.loadData();
                    MessageBox.Show("l adhérent " + textBox2.Text.ToString() + " " + textBox3.Text.ToString() + "est bien supprimé");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }


            }
        }

        private void ajouterVoituresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 a = new Form3();
            a.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        private void ajouterClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 a = new Form6();
            a.Show();
        }

        private void modifierClientsToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void Form6_Load(object sender, EventArgs e)
        {
            this.loadData();
        }
        private void loadData()
        {
            try
            {
                MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
                conn_string.Server = "localhost";
                conn_string.UserID = "root";
                //conn_string.Password = "root";           
                conn_string.Database = "pfe";
                conn = new MySqlConnection(conn_string.ToString());

                conn.Open();
                command = new MySqlCommand("Select * FROM `client`", conn);
                command.ExecuteNonQuery();
                dt = new DataTable();
                adap = new MySqlDataAdapter(command);
                adap.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
                conn.Close();
                //btn_adherant_update.Enabled = false;
                //btn_adherant_delete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // btn_adherant_add.Enabled = true;
            //btn_adherant_update.Enabled = false;
            //btn_adherant_delete.Enabled = false;
        }
    }
}
