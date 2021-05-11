
namespace GestionInventaireWinForms
{
    partial class AjoutCommande
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Titre_Commande = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_ArticlesCommande = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox_PrixTotal = new System.Windows.Forms.TextBox();
            this.button_AjoutCommande = new System.Windows.Forms.Button();
            this.button_FinCommande = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(533, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(859, 533);
            this.dataGridView1.TabIndex = 0;
            // 
            // Titre_Commande
            // 
            this.Titre_Commande.AutoSize = true;
            this.Titre_Commande.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Titre_Commande.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre_Commande.Location = new System.Drawing.Point(205, 9);
            this.Titre_Commande.Name = "Titre_Commande";
            this.Titre_Commande.Size = new System.Drawing.Size(153, 31);
            this.Titre_Commande.TabIndex = 1;
            this.Titre_Commande.Text = "Commande";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Produits :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantité  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prix Total  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date :";
            // 
            // comboBox_ArticlesCommande
            // 
            this.comboBox_ArticlesCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ArticlesCommande.FormattingEnabled = true;
            this.comboBox_ArticlesCommande.Location = new System.Drawing.Point(211, 124);
            this.comboBox_ArticlesCommande.Name = "comboBox_ArticlesCommande";
            this.comboBox_ArticlesCommande.Size = new System.Drawing.Size(199, 24);
            this.comboBox_ArticlesCommande.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(211, 245);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(199, 22);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(210, 455);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // textBox_PrixTotal
            // 
            this.textBox_PrixTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PrixTotal.Location = new System.Drawing.Point(211, 353);
            this.textBox_PrixTotal.Name = "textBox_PrixTotal";
            this.textBox_PrixTotal.Size = new System.Drawing.Size(199, 22);
            this.textBox_PrixTotal.TabIndex = 9;
            // 
            // button_AjoutCommande
            // 
            this.button_AjoutCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AjoutCommande.Location = new System.Drawing.Point(210, 586);
            this.button_AjoutCommande.Name = "button_AjoutCommande";
            this.button_AjoutCommande.Size = new System.Drawing.Size(200, 41);
            this.button_AjoutCommande.TabIndex = 10;
            this.button_AjoutCommande.Text = "Ajouter les articles";
            this.button_AjoutCommande.UseVisualStyleBackColor = true;
            this.button_AjoutCommande.Click += new System.EventHandler(this.button_AjoutCommande_Click);
            // 
            // button_FinCommande
            // 
            this.button_FinCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_FinCommande.Location = new System.Drawing.Point(768, 586);
            this.button_FinCommande.Name = "button_FinCommande";
            this.button_FinCommande.Size = new System.Drawing.Size(390, 41);
            this.button_FinCommande.TabIndex = 11;
            this.button_FinCommande.Text = "Terminer la commande";
            this.button_FinCommande.UseVisualStyleBackColor = true;
            this.button_FinCommande.Click += new System.EventHandler(this.button_FinCommande_Click);
            // 
            // AjoutCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 689);
            this.Controls.Add(this.button_FinCommande);
            this.Controls.Add(this.button_AjoutCommande);
            this.Controls.Add(this.textBox_PrixTotal);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox_ArticlesCommande);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Titre_Commande);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AjoutCommande";
            this.Text = "AjoutCommande";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Titre_Commande;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_ArticlesCommande;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox_PrixTotal;
        private System.Windows.Forms.Button button_AjoutCommande;
        private System.Windows.Forms.Button button_FinCommande;
    }
}