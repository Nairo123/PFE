
namespace Showroom_véhicule_pff
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            label9 = new System.Windows.Forms.Label();
            comboBox2 = new System.Windows.Forms.ComboBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            textBox1 = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            comboBox4 = new System.Windows.Forms.ComboBox();
            comboBox3 = new System.Windows.Forms.ComboBox();
            label8 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            gestionDesVoituresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ajouterVoituresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            modifierVoituresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            suppriméVoituresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            gestionDesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            modifierClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            modifierCliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            suppriméClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            gestionDesCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ajouterCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            modifierCommamndesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            suppriméCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(24, 43);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(295, 45);
            label1.TabIndex = 0;
            label1.Text = "Gestion des pieces";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.Gold;
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(24, 129);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(423, 157);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Infos génerales";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(207, 119);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            dateTimePicker1.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(33, 116);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(166, 23);
            label9.TabIndex = 4;
            label9.Text = "Date de fabrication";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new System.Drawing.Point(207, 82);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(195, 31);
            comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Volkswagen", "Peugoet", "Bmw", "Mercedes", "Fiat", "Renault", "MG", "Kia", "Hyundai", "Toyota", "Haval", "Seat", "Nissan" });
            comboBox1.Location = new System.Drawing.Point(207, 46);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(195, 31);
            comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(207, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(195, 26);
            textBox1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(38, 89);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(62, 18);
            label4.TabIndex = 2;
            label4.Text = "Marque";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(38, 53);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(65, 18);
            label3.TabIndex = 1;
            label3.Text = "Modéle ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(38, 22);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(74, 18);
            label2.TabIndex = 0;
            label2.Text = "Matricule";
            label2.Click += label2_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = System.Drawing.Color.Gold;
            groupBox2.Controls.Add(comboBox4);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox2.Location = new System.Drawing.Point(24, 292);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(423, 156);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Critéres";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Automatique", "Manuelle" });
            comboBox4.Location = new System.Drawing.Point(207, 91);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new System.Drawing.Size(192, 26);
            comboBox4.TabIndex = 8;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Essence", "Diesel" });
            comboBox3.Location = new System.Drawing.Point(207, 31);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new System.Drawing.Size(192, 26);
            comboBox3.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(38, 95);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(46, 18);
            label8.TabIndex = 3;
            label8.Text = "Boite";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(38, 31);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(135, 18);
            label5.TabIndex = 0;
            label5.Text = "Puissance Fiscale";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Yellow;
            button1.ForeColor = System.Drawing.Color.Black;
            button1.Location = new System.Drawing.Point(43, 468);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(138, 36);
            button1.TabIndex = 3;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Yellow;
            button2.ForeColor = System.Drawing.Color.Black;
            button2.Location = new System.Drawing.Point(237, 468);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(135, 36);
            button2.TabIndex = 4;
            button2.Text = "Annuler";
            button2.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.Gold;
            menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fichierToolStripMenuItem, gestionDesVoituresToolStripMenuItem, gestionDesClientsToolStripMenuItem, gestionDesCommandesToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new System.Drawing.Point(915, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            menuStrip1.Size = new System.Drawing.Size(152, 516);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new System.Drawing.Size(145, 19);
            fichierToolStripMenuItem.Text = "Fichier";
            // 
            // gestionDesVoituresToolStripMenuItem
            // 
            gestionDesVoituresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { ajouterVoituresToolStripMenuItem, modifierVoituresToolStripMenuItem, suppriméVoituresToolStripMenuItem });
            gestionDesVoituresToolStripMenuItem.Name = "gestionDesVoituresToolStripMenuItem";
            gestionDesVoituresToolStripMenuItem.Size = new System.Drawing.Size(145, 19);
            gestionDesVoituresToolStripMenuItem.Text = "Gestion des voitures";
            // 
            // ajouterVoituresToolStripMenuItem
            // 
            ajouterVoituresToolStripMenuItem.Name = "ajouterVoituresToolStripMenuItem";
            ajouterVoituresToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            ajouterVoituresToolStripMenuItem.Text = "Ajouter voitures";
            ajouterVoituresToolStripMenuItem.Click += ajouterVoituresToolStripMenuItem_Click;
            // 
            // modifierVoituresToolStripMenuItem
            // 
            modifierVoituresToolStripMenuItem.Name = "modifierVoituresToolStripMenuItem";
            modifierVoituresToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            modifierVoituresToolStripMenuItem.Text = "Modifier voitures";
            modifierVoituresToolStripMenuItem.Click += modifierVoituresToolStripMenuItem_Click;
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
            gestionDesClientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { modifierClientsToolStripMenuItem, modifierCliToolStripMenuItem, suppriméClientsToolStripMenuItem });
            gestionDesClientsToolStripMenuItem.Name = "gestionDesClientsToolStripMenuItem";
            gestionDesClientsToolStripMenuItem.Size = new System.Drawing.Size(145, 19);
            gestionDesClientsToolStripMenuItem.Text = "Gestion des clients";
            // 
            // modifierClientsToolStripMenuItem
            // 
            modifierClientsToolStripMenuItem.Name = "modifierClientsToolStripMenuItem";
            modifierClientsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            modifierClientsToolStripMenuItem.Text = "Ajouter clients";
            modifierClientsToolStripMenuItem.Click += modifierClientsToolStripMenuItem_Click;
            // 
            // modifierCliToolStripMenuItem
            // 
            modifierCliToolStripMenuItem.Name = "modifierCliToolStripMenuItem";
            modifierCliToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            modifierCliToolStripMenuItem.Text = "Modifier Clients";
            modifierCliToolStripMenuItem.Click += modifierCliToolStripMenuItem_Click;
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
            gestionDesCommandesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { ajouterCommandesToolStripMenuItem, modifierCommamndesToolStripMenuItem, suppriméCommandesToolStripMenuItem });
            gestionDesCommandesToolStripMenuItem.Name = "gestionDesCommandesToolStripMenuItem";
            gestionDesCommandesToolStripMenuItem.Size = new System.Drawing.Size(145, 19);
            gestionDesCommandesToolStripMenuItem.Text = "Gestion des commandes";
            // 
            // ajouterCommandesToolStripMenuItem
            // 
            ajouterCommandesToolStripMenuItem.Name = "ajouterCommandesToolStripMenuItem";
            ajouterCommandesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            ajouterCommandesToolStripMenuItem.Text = "Ajouter commandes";
            ajouterCommandesToolStripMenuItem.Click += ajouterCommandesToolStripMenuItem_Click;
            // 
            // modifierCommamndesToolStripMenuItem
            // 
            modifierCommamndesToolStripMenuItem.Name = "modifierCommamndesToolStripMenuItem";
            modifierCommamndesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            modifierCommamndesToolStripMenuItem.Text = "Modifier commamndes";
            // 
            // suppriméCommandesToolStripMenuItem
            // 
            suppriméCommandesToolStripMenuItem.Name = "suppriméCommandesToolStripMenuItem";
            suppriméCommandesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            suppriméCommandesToolStripMenuItem.Text = "Supprimé Commandes";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(145, 19);
            toolStripMenuItem1.Text = "?";
            // 
            // Form3
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new System.Drawing.Size(1067, 516);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesVoituresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterVoituresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierVoituresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppriméVoituresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierCliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppriméClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierCommamndesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppriméCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}