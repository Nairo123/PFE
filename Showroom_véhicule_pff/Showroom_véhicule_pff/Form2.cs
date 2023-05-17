using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Showroom_véhicule_pff
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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

        private void suppriméVoitureToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void suppriméClientsToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 a = new Form3();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 a = new Form7();
            a.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Hide();
            Form7 a = new Form7();
            a.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
