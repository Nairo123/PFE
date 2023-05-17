
namespace Showroom_véhicule_pff
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            gestionDesVoitureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ajouterVoituresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            modifierVoituresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            suppriméVoitureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            gestionDesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ajouterClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            modifierClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            suppriméClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            gestionDesCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ajouterCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            modifierCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            suppriméVoituresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            valide = new System.Windows.Forms.Button();
            comboBox1 = new System.Windows.Forms.ComboBox();
            comboBox2 = new System.Windows.Forms.ComboBox();
            comboBox3 = new System.Windows.Forms.ComboBox();
            panel1 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.Gold;
            menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fichierToolStripMenuItem, gestionDesVoitureToolStripMenuItem, gestionDesClientsToolStripMenuItem, gestionDesCommandesToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new System.Drawing.Point(1215, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(155, 575);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new System.Drawing.Size(142, 19);
            fichierToolStripMenuItem.Text = "Fichier";
            // 
            // gestionDesVoitureToolStripMenuItem
            // 
            gestionDesVoitureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { ajouterVoituresToolStripMenuItem, modifierVoituresToolStripMenuItem, suppriméVoitureToolStripMenuItem });
            gestionDesVoitureToolStripMenuItem.Name = "gestionDesVoitureToolStripMenuItem";
            gestionDesVoitureToolStripMenuItem.Size = new System.Drawing.Size(142, 19);
            gestionDesVoitureToolStripMenuItem.Text = "Gestion des Voiture";
            // 
            // ajouterVoituresToolStripMenuItem
            // 
            ajouterVoituresToolStripMenuItem.Name = "ajouterVoituresToolStripMenuItem";
            ajouterVoituresToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            ajouterVoituresToolStripMenuItem.Text = "Ajouter pieces";
            ajouterVoituresToolStripMenuItem.Click += ajouterVoituresToolStripMenuItem_Click;
            // 
            // modifierVoituresToolStripMenuItem
            // 
            modifierVoituresToolStripMenuItem.Name = "modifierVoituresToolStripMenuItem";
            modifierVoituresToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            modifierVoituresToolStripMenuItem.Text = "Modifier ";
            modifierVoituresToolStripMenuItem.Click += modifierVoituresToolStripMenuItem_Click;
            // 
            // suppriméVoitureToolStripMenuItem
            // 
            suppriméVoitureToolStripMenuItem.Name = "suppriméVoitureToolStripMenuItem";
            suppriméVoitureToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            suppriméVoitureToolStripMenuItem.Text = "Supprimé";
            suppriméVoitureToolStripMenuItem.Click += suppriméVoitureToolStripMenuItem_Click;
            // 
            // gestionDesClientsToolStripMenuItem
            // 
            gestionDesClientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { ajouterClientsToolStripMenuItem, modifierClientsToolStripMenuItem, suppriméClientsToolStripMenuItem });
            gestionDesClientsToolStripMenuItem.Name = "gestionDesClientsToolStripMenuItem";
            gestionDesClientsToolStripMenuItem.Size = new System.Drawing.Size(142, 19);
            gestionDesClientsToolStripMenuItem.Text = "Gestion des clients";
            // 
            // ajouterClientsToolStripMenuItem
            // 
            ajouterClientsToolStripMenuItem.Name = "ajouterClientsToolStripMenuItem";
            ajouterClientsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            ajouterClientsToolStripMenuItem.Text = "Ajouter clients";
            ajouterClientsToolStripMenuItem.Click += ajouterClientsToolStripMenuItem_Click;
            // 
            // modifierClientsToolStripMenuItem
            // 
            modifierClientsToolStripMenuItem.Name = "modifierClientsToolStripMenuItem";
            modifierClientsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            modifierClientsToolStripMenuItem.Text = "Modifier clients";
            modifierClientsToolStripMenuItem.Click += modifierClientsToolStripMenuItem_Click;
            // 
            // suppriméClientsToolStripMenuItem
            // 
            suppriméClientsToolStripMenuItem.Name = "suppriméClientsToolStripMenuItem";
            suppriméClientsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            suppriméClientsToolStripMenuItem.Text = "Supprimé clients";
            suppriméClientsToolStripMenuItem.Click += suppriméClientsToolStripMenuItem_Click;
            // 
            // gestionDesCommandesToolStripMenuItem
            // 
            gestionDesCommandesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { ajouterCommandesToolStripMenuItem, modifierCommandesToolStripMenuItem, suppriméVoituresToolStripMenuItem });
            gestionDesCommandesToolStripMenuItem.Name = "gestionDesCommandesToolStripMenuItem";
            gestionDesCommandesToolStripMenuItem.Size = new System.Drawing.Size(142, 19);
            gestionDesCommandesToolStripMenuItem.Text = "Gestion des commandes";
            // 
            // ajouterCommandesToolStripMenuItem
            // 
            ajouterCommandesToolStripMenuItem.Name = "ajouterCommandesToolStripMenuItem";
            ajouterCommandesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            ajouterCommandesToolStripMenuItem.Text = "Ajouter commandes ";
            ajouterCommandesToolStripMenuItem.Click += ajouterCommandesToolStripMenuItem_Click;
            // 
            // modifierCommandesToolStripMenuItem
            // 
            modifierCommandesToolStripMenuItem.Name = "modifierCommandesToolStripMenuItem";
            modifierCommandesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            modifierCommandesToolStripMenuItem.Text = "Modifier commandes";
            // 
            // suppriméVoituresToolStripMenuItem
            // 
            suppriméVoituresToolStripMenuItem.Name = "suppriméVoituresToolStripMenuItem";
            suppriméVoituresToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            suppriméVoituresToolStripMenuItem.Text = "Supprimé voitures";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(142, 19);
            toolStripMenuItem1.Text = "?";
            // 
            // valide
            // 
            valide.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            valide.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            valide.ForeColor = System.Drawing.Color.Black;
            valide.Location = new System.Drawing.Point(1129, 285);
            valide.Name = "valide";
            valide.Size = new System.Drawing.Size(88, 52);
            valide.TabIndex = 4;
            valide.Text = "valide";
            valide.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Alfa romeo", "Audi ", "Bentley", "Bmw ", "Bugatti", "cadillac", "Citroen", "Dacia", "Dodge", "Ferrari", "Fiat", "Ford ", "Gmc", "Honda", "Hummer", "Isuzu", "Jaguar", "Jeep ", "Kia", "Lamborghini", "Land rover", "Maserati", "Maybach", "Mazda", "Mclaren", "Mercedes-benz", "Mitsubishi", "Nissan", "Opel", "Peugoet", "Porshe", "Renault", "Rolls-royce", "Seat", "Subaro", "Toyota", "Volkswagen" });
            comboBox1.Location = new System.Drawing.Point(158, 301);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(232, 23);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "Choisir la marque";
            comboBox1.UseWaitCursor = true;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "2023", "2022", "2021", "2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996" });
            comboBox2.Location = new System.Drawing.Point(405, 301);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(229, 23);
            comboBox2.TabIndex = 6;
            comboBox2.Text = "Année";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new System.Drawing.Point(646, 301);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new System.Drawing.Size(234, 23);
            comboBox3.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Gold;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new System.Drawing.Point(-8, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1225, 131);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(33, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(160, 87);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new System.Drawing.Size(1370, 575);
            Controls.Add(panel1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(valide);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesVoitureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterVoituresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierVoituresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppriméVoitureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppriméClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem suppriméVoituresToolStripMenuItem;
        private System.Windows.Forms.Button valide;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}