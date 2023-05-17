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
    public partial class Form8 : Form
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
        public Form8()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                currRowIndex = Convert.ToInt32(row.Cells[0].Value);
               comboBox1.Text = row.Cells[0].Value.ToString();
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                textBox3.Text = row.Cells[3].Value.ToString();
                label13.Text = row.Cells[4].Value.ToString();
                textBox3.Text = row.Cells[5].Value.ToString();

                /*txt_adherant_addresse.Text = row.Cells[3].Value.ToString();
                txt_adherant_email.Text = row.Cells[4].Value.ToString();
                txt_adherant_tel.Text = row.Cells[5].Value.ToString();
                btn_adherant_delete.Enabled = true;
                btn_adherant_update.Enabled = true;
                btn_adherant_add.Enabled = false;
                */
            }
        }

        private void Form8_Load(object sender, EventArgs e)
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
                    conn_string.Database = "Showroom_pff";
                    conn = new MySqlConnection(conn_string.ToString());

                    conn.Open();
                    command = new MySqlCommand("Select * FROM `commandes`", conn);
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

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult dialogUpdate = MessageBox.Show("Voulez-vous vraiment modifier les informations sur cette commande", "Modifier une commande", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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
                        cmd.CommandText = "UPDATE `commandes` SET `Numéro_commande`= @Numéro_commande,`Marque`=@Marque, `Modéle`=@Modéle, `Mode de paiment`=@Mode de paiment, `Date de commande`=@Date de commande, `Cin_Client`=@Cin_Client" + " WHERE `Numéro_commande`=" + currRowIndex;
                        cmd.Parameters.AddWithValue("@Numéro_commande", comboBox1.Text);
                        cmd.Parameters.AddWithValue("@Marque", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Modéle", textBox2.Text);
                        cmd.Parameters.AddWithValue("@Mode de paiment", textBox3.Text);
                      cmd.Parameters.AddWithValue("@Date de commande", label13.Text);
                       cmd.Parameters.AddWithValue("@Cin_Client", textBox4.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        this.loadData();
                        MessageBox.Show("la commande " + textBox2.Text.ToString() + " " + textBox3.Text.ToString() + "est bien modifiée");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                      
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        conn.Close();
                    }


                }

            }
        }

        private void modifierClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 a = new Form5();
            a.Show();
        }

        private void geToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajouterClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 a = new Form3();
            a.Show();
        }

        private void suppriméClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 a = new Form4();
            a.Show();
        }

        private void ajouterClientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 a = new Form6();
            a.Show();
        }

        private void modifierClientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 a = new Form6();
            a.Show();
        }

        private void suppriméClientToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            Console.WriteLine(rowIndex);
            DialogResult dialogDelete = MessageBox.Show("voulez-vous vraiment supprimer cette commande", "Supprimer une commande", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogDelete == DialogResult.OK)
            {
                dataGridView1.Rows.RemoveAt(rowIndex);

                try
                {
                    conn.Open();
                    MySqlCommand cmd = conn.CreateCommand();
                    textBox1.Text = currRowIndex.ToString();
                    cmd.CommandText = "DELETE FROM `commandes` WHERE `Numéro_commande` = " + currRowIndex;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    this.loadData();
                    MessageBox.Show("la commande " + textBox2.Text.ToString() + " " + textBox3.Text.ToString() + "est bien supprimée");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }


            }
        }
    }
}
