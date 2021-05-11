
namespace GestionInventaireWinForms
{
    partial class AjoutArticle
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
            this.label1_nomArticle = new System.Windows.Forms.Label();
            this.label_fournisseurArticle = new System.Windows.Forms.Label();
            this.label_categorieArticle = new System.Windows.Forms.Label();
            this.label_domaineArticle = new System.Windows.Forms.Label();
            this.label_descriptionArticle = new System.Windows.Forms.Label();
            this.label_urlImgArticle = new System.Windows.Forms.Label();
            this.label_volumeArticle = new System.Windows.Forms.Label();
            this.label_prixArticle = new System.Windows.Forms.Label();
            this.textBox_nomArticle = new System.Windows.Forms.TextBox();
            this.textBox_domaineArticle = new System.Windows.Forms.TextBox();
            this.textBox_descriptionArticle = new System.Windows.Forms.TextBox();
            this.textBox_urlImgArticle = new System.Windows.Forms.TextBox();
            this.textBox_volumeArticle = new System.Windows.Forms.TextBox();
            this.textBox_prixArticle = new System.Windows.Forms.TextBox();
            this.comboBox_fournisseurArticle = new System.Windows.Forms.ComboBox();
            this.comboBox_categorieArticle = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_AjoutArticle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1_nomArticle
            // 
            this.label1_nomArticle.AutoSize = true;
            this.label1_nomArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_nomArticle.Location = new System.Drawing.Point(74, 66);
            this.label1_nomArticle.Name = "label1_nomArticle";
            this.label1_nomArticle.Size = new System.Drawing.Size(49, 18);
            this.label1_nomArticle.TabIndex = 0;
            this.label1_nomArticle.Text = "Nom :";
            this.label1_nomArticle.Click += new System.EventHandler(this.label1_nomArticle_Click);
            // 
            // label_fournisseurArticle
            // 
            this.label_fournisseurArticle.AutoSize = true;
            this.label_fournisseurArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fournisseurArticle.Location = new System.Drawing.Point(74, 129);
            this.label_fournisseurArticle.Name = "label_fournisseurArticle";
            this.label_fournisseurArticle.Size = new System.Drawing.Size(95, 18);
            this.label_fournisseurArticle.TabIndex = 1;
            this.label_fournisseurArticle.Text = "Fournisseur :";
            // 
            // label_categorieArticle
            // 
            this.label_categorieArticle.AutoSize = true;
            this.label_categorieArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_categorieArticle.Location = new System.Drawing.Point(74, 204);
            this.label_categorieArticle.Name = "label_categorieArticle";
            this.label_categorieArticle.Size = new System.Drawing.Size(80, 18);
            this.label_categorieArticle.TabIndex = 2;
            this.label_categorieArticle.Text = "Catégorie :";
            // 
            // label_domaineArticle
            // 
            this.label_domaineArticle.AutoSize = true;
            this.label_domaineArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_domaineArticle.Location = new System.Drawing.Point(74, 280);
            this.label_domaineArticle.Name = "label_domaineArticle";
            this.label_domaineArticle.Size = new System.Drawing.Size(76, 18);
            this.label_domaineArticle.TabIndex = 3;
            this.label_domaineArticle.Text = "Domaine :";
            // 
            // label_descriptionArticle
            // 
            this.label_descriptionArticle.AutoSize = true;
            this.label_descriptionArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_descriptionArticle.Location = new System.Drawing.Point(74, 363);
            this.label_descriptionArticle.Name = "label_descriptionArticle";
            this.label_descriptionArticle.Size = new System.Drawing.Size(91, 18);
            this.label_descriptionArticle.TabIndex = 4;
            this.label_descriptionArticle.Text = "Description :";
            // 
            // label_urlImgArticle
            // 
            this.label_urlImgArticle.AutoSize = true;
            this.label_urlImgArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_urlImgArticle.Location = new System.Drawing.Point(74, 447);
            this.label_urlImgArticle.Name = "label_urlImgArticle";
            this.label_urlImgArticle.Size = new System.Drawing.Size(90, 18);
            this.label_urlImgArticle.TabIndex = 5;
            this.label_urlImgArticle.Text = "URL image :";
            // 
            // label_volumeArticle
            // 
            this.label_volumeArticle.AutoSize = true;
            this.label_volumeArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_volumeArticle.Location = new System.Drawing.Point(74, 536);
            this.label_volumeArticle.Name = "label_volumeArticle";
            this.label_volumeArticle.Size = new System.Drawing.Size(66, 18);
            this.label_volumeArticle.TabIndex = 6;
            this.label_volumeArticle.Text = "Volume :";
            // 
            // label_prixArticle
            // 
            this.label_prixArticle.AutoSize = true;
            this.label_prixArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prixArticle.Location = new System.Drawing.Point(74, 606);
            this.label_prixArticle.Name = "label_prixArticle";
            this.label_prixArticle.Size = new System.Drawing.Size(41, 18);
            this.label_prixArticle.TabIndex = 7;
            this.label_prixArticle.Text = "Prix :";
            // 
            // textBox_nomArticle
            // 
            this.textBox_nomArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nomArticle.Location = new System.Drawing.Point(243, 63);
            this.textBox_nomArticle.Name = "textBox_nomArticle";
            this.textBox_nomArticle.Size = new System.Drawing.Size(204, 24);
            this.textBox_nomArticle.TabIndex = 8;
            this.textBox_nomArticle.TextChanged += new System.EventHandler(this.textBox_nomArticle_TextChanged);
            // 
            // textBox_domaineArticle
            // 
            this.textBox_domaineArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_domaineArticle.Location = new System.Drawing.Point(243, 277);
            this.textBox_domaineArticle.Name = "textBox_domaineArticle";
            this.textBox_domaineArticle.Size = new System.Drawing.Size(204, 24);
            this.textBox_domaineArticle.TabIndex = 9;
            this.textBox_domaineArticle.TextChanged += new System.EventHandler(this.textBox_domaineArticle_TextChanged);
            // 
            // textBox_descriptionArticle
            // 
            this.textBox_descriptionArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_descriptionArticle.Location = new System.Drawing.Point(243, 357);
            this.textBox_descriptionArticle.Name = "textBox_descriptionArticle";
            this.textBox_descriptionArticle.Size = new System.Drawing.Size(204, 24);
            this.textBox_descriptionArticle.TabIndex = 10;
            this.textBox_descriptionArticle.TextChanged += new System.EventHandler(this.textBox_descriptionArticle_TextChanged);
            // 
            // textBox_urlImgArticle
            // 
            this.textBox_urlImgArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_urlImgArticle.Location = new System.Drawing.Point(243, 441);
            this.textBox_urlImgArticle.Name = "textBox_urlImgArticle";
            this.textBox_urlImgArticle.Size = new System.Drawing.Size(204, 24);
            this.textBox_urlImgArticle.TabIndex = 11;
            this.textBox_urlImgArticle.TextChanged += new System.EventHandler(this.textBox_urlImgArticle_TextChanged);
            // 
            // textBox_volumeArticle
            // 
            this.textBox_volumeArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_volumeArticle.Location = new System.Drawing.Point(243, 530);
            this.textBox_volumeArticle.Name = "textBox_volumeArticle";
            this.textBox_volumeArticle.Size = new System.Drawing.Size(204, 24);
            this.textBox_volumeArticle.TabIndex = 12;
            this.textBox_volumeArticle.TextChanged += new System.EventHandler(this.textBox_volumeArticle_TextChanged);
            // 
            // textBox_prixArticle
            // 
            this.textBox_prixArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_prixArticle.Location = new System.Drawing.Point(243, 603);
            this.textBox_prixArticle.Name = "textBox_prixArticle";
            this.textBox_prixArticle.Size = new System.Drawing.Size(204, 24);
            this.textBox_prixArticle.TabIndex = 13;
            this.textBox_prixArticle.TextChanged += new System.EventHandler(this.textBox_prixArticle_TextChanged);
            // 
            // comboBox_fournisseurArticle
            // 
            this.comboBox_fournisseurArticle.FormattingEnabled = true;
            this.comboBox_fournisseurArticle.Location = new System.Drawing.Point(243, 125);
            this.comboBox_fournisseurArticle.Name = "comboBox_fournisseurArticle";
            this.comboBox_fournisseurArticle.Size = new System.Drawing.Size(204, 21);
            this.comboBox_fournisseurArticle.TabIndex = 14;
            this.comboBox_fournisseurArticle.SelectedIndexChanged += new System.EventHandler(this.comboBox_fournisseurArticle_SelectedIndexChanged);
            // 
            // comboBox_categorieArticle
            // 
            this.comboBox_categorieArticle.FormattingEnabled = true;
            this.comboBox_categorieArticle.Location = new System.Drawing.Point(243, 201);
            this.comboBox_categorieArticle.Name = "comboBox_categorieArticle";
            this.comboBox_categorieArticle.Size = new System.Drawing.Size(204, 21);
            this.comboBox_categorieArticle.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(658, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(602, 423);
            this.dataGridView1.TabIndex = 16;
            // 
            // btn_AjoutArticle
            // 
            this.btn_AjoutArticle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_AjoutArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AjoutArticle.Location = new System.Drawing.Point(875, 603);
            this.btn_AjoutArticle.Name = "btn_AjoutArticle";
            this.btn_AjoutArticle.Size = new System.Drawing.Size(228, 67);
            this.btn_AjoutArticle.TabIndex = 17;
            this.btn_AjoutArticle.Text = "Ajouter produit";
            this.btn_AjoutArticle.UseVisualStyleBackColor = false;
            this.btn_AjoutArticle.Click += new System.EventHandler(this.btn_AjoutArticle_Click);
            // 
            // AjoutArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 709);
            this.Controls.Add(this.btn_AjoutArticle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox_categorieArticle);
            this.Controls.Add(this.comboBox_fournisseurArticle);
            this.Controls.Add(this.textBox_prixArticle);
            this.Controls.Add(this.textBox_volumeArticle);
            this.Controls.Add(this.textBox_urlImgArticle);
            this.Controls.Add(this.textBox_descriptionArticle);
            this.Controls.Add(this.textBox_domaineArticle);
            this.Controls.Add(this.textBox_nomArticle);
            this.Controls.Add(this.label_prixArticle);
            this.Controls.Add(this.label_volumeArticle);
            this.Controls.Add(this.label_urlImgArticle);
            this.Controls.Add(this.label_descriptionArticle);
            this.Controls.Add(this.label_domaineArticle);
            this.Controls.Add(this.label_categorieArticle);
            this.Controls.Add(this.label_fournisseurArticle);
            this.Controls.Add(this.label1_nomArticle);
            this.Name = "AjoutArticle";
            this.Text = "AjoutArticle";
            this.Load += new System.EventHandler(this.AjoutProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_nomArticle;
        private System.Windows.Forms.Label label_fournisseurArticle;
        private System.Windows.Forms.Label label_categorieArticle;
        private System.Windows.Forms.Label label_domaineArticle;
        private System.Windows.Forms.Label label_descriptionArticle;
        private System.Windows.Forms.Label label_urlImgArticle;
        private System.Windows.Forms.Label label_volumeArticle;
        private System.Windows.Forms.Label label_prixArticle;
        private System.Windows.Forms.TextBox textBox_nomArticle;
        private System.Windows.Forms.TextBox textBox_domaineArticle;
        private System.Windows.Forms.TextBox textBox_descriptionArticle;
        private System.Windows.Forms.TextBox textBox_urlImgArticle;
        private System.Windows.Forms.TextBox textBox_volumeArticle;
        private System.Windows.Forms.TextBox textBox_prixArticle;
        private System.Windows.Forms.ComboBox comboBox_fournisseurArticle;
        private System.Windows.Forms.ComboBox comboBox_categorieArticle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_AjoutArticle;
    }
}