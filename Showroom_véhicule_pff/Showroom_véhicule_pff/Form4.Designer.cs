
namespace Showroom_véhicule_pff
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label1 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            gestionDesVoituresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ajouterVoituresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            modifierVoituresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            suppriméVoituresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            gestionDesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ajouterClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            modifierClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            suppriméClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            gestionDesCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ajouterCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            modifierCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            suppriméCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(36, 92);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(247, 34);
            label1.TabIndex = 0;
            label1.Text = "Supprimé pieces";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.Gold;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(36, 142);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(366, 231);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Info ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(202, 147);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(60, 25);
            label6.TabIndex = 5;
            label6.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(202, 95);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 25);
            label5.TabIndex = 4;
            label5.Text = "label5";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(186, 36);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(121, 32);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(52, 147);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(82, 24);
            label4.TabIndex = 2;
            label4.Text = "Modéle";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(52, 95);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(85, 24);
            label3.TabIndex = 1;
            label3.Text = "Marque";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(52, 44);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(101, 24);
            label2.TabIndex = 0;
            label2.Text = "Matricule";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(111, 401);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(88, 33);
            button1.TabIndex = 6;
            button1.Text = "Supprimé";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(249, 401);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 33);
            button2.TabIndex = 7;
            button2.Text = "Annulé";
            button2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.Gold;
            menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fichierToolStripMenuItem, gestionDesVoituresToolStripMenuItem, gestionDesClientsToolStripMenuItem, gestionDesCommandesToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new System.Drawing.Point(957, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(155, 528);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new System.Drawing.Size(142, 19);
            fichierToolStripMenuItem.Text = "Fichier";
            // 
            // gestionDesVoituresToolStripMenuItem
            // 
            gestionDesVoituresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { ajouterVoituresToolStripMenuItem, modifierVoituresToolStripMenuItem, suppriméVoituresToolStripMenuItem });
            gestionDesVoituresToolStripMenuItem.Name = "gestionDesVoituresToolStripMenuItem";
            gestionDesVoituresToolStripMenuItem.Size = new System.Drawing.Size(142, 19);
            gestionDesVoituresToolStripMenuItem.Text = "Gestion des voitures";
            // 
            // ajouterVoituresToolStripMenuItem
            // 
            ajouterVoituresToolStripMenuItem.Name = "ajouterVoituresToolStripMenuItem";
            ajouterVoituresToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            ajouterVoituresToolStripMenuItem.Text = "Ajouter voitures";
            // 
            // modifierVoituresToolStripMenuItem
            // 
            modifierVoituresToolStripMenuItem.Name = "modifierVoituresToolStripMenuItem";
            modifierVoituresToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            modifierVoituresToolStripMenuItem.Text = "Modifier voitures";
            // 
            // suppriméVoituresToolStripMenuItem
            // 
            suppriméVoituresToolStripMenuItem.Name = "suppriméVoituresToolStripMenuItem";
            suppriméVoituresToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            suppriméVoituresToolStripMenuItem.Text = "Supprimé voitures";
            suppriméVoituresToolStripMenuItem.Click += suppriméVoituresToolStripMenuItem_Click;
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
            gestionDesCommandesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { ajouterCommandesToolStripMenuItem, modifierCommandesToolStripMenuItem, suppriméCommandesToolStripMenuItem });
            gestionDesCommandesToolStripMenuItem.Name = "gestionDesCommandesToolStripMenuItem";
            gestionDesCommandesToolStripMenuItem.Size = new System.Drawing.Size(142, 19);
            gestionDesCommandesToolStripMenuItem.Text = "Gestion des commandes";
            // 
            // ajouterCommandesToolStripMenuItem
            // 
            ajouterCommandesToolStripMenuItem.Name = "ajouterCommandesToolStripMenuItem";
            ajouterCommandesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            ajouterCommandesToolStripMenuItem.Text = "Ajouter commandes";
            ajouterCommandesToolStripMenuItem.Click += ajouterCommandesToolStripMenuItem_Click;
            // 
            // modifierCommandesToolStripMenuItem
            // 
            modifierCommandesToolStripMenuItem.Name = "modifierCommandesToolStripMenuItem";
            modifierCommandesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            modifierCommandesToolStripMenuItem.Text = "Modifier Commandes";
            modifierCommandesToolStripMenuItem.Click += modifierCommandesToolStripMenuItem_Click;
            // 
            // suppriméCommandesToolStripMenuItem
            // 
            suppriméCommandesToolStripMenuItem.Name = "suppriméCommandesToolStripMenuItem";
            suppriméCommandesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            suppriméCommandesToolStripMenuItem.Text = "Supprimé commandes";
            suppriméCommandesToolStripMenuItem.Click += suppriméCommandesToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(142, 19);
            toolStripMenuItem1.Text = "?";
            // 
            // Form4
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new System.Drawing.Size(1112, 528);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesVoituresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterVoituresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierVoituresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppriméVoituresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppriméClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppriméCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}