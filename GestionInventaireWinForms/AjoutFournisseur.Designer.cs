
namespace GestionInventaireWinForms
{
    partial class AjoutFournisseur
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
            this.btn_ajoutFournisseur = new System.Windows.Forms.Button();
            this.label_nomFournisseur = new System.Windows.Forms.Label();
            this.label_mailFournisseur = new System.Windows.Forms.Label();
            this.label_adresseFournisseur = new System.Windows.Forms.Label();
            this.label_villeFournisseur = new System.Windows.Forms.Label();
            this.label_telFournisseur = new System.Windows.Forms.Label();
            this.textBox_nomFournisseur = new System.Windows.Forms.TextBox();
            this.textBox_mailFournisseur = new System.Windows.Forms.TextBox();
            this.textBox_adresseFournisseur = new System.Windows.Forms.TextBox();
            this.textBox_villeFournisseur = new System.Windows.Forms.TextBox();
            this.textBox_telFournisseur = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_ajoutFournisseur
            // 
            this.btn_ajoutFournisseur.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ajoutFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajoutFournisseur.Location = new System.Drawing.Point(375, 411);
            this.btn_ajoutFournisseur.Name = "btn_ajoutFournisseur";
            this.btn_ajoutFournisseur.Size = new System.Drawing.Size(266, 48);
            this.btn_ajoutFournisseur.TabIndex = 0;
            this.btn_ajoutFournisseur.Text = "Ajouter le fournisseur";
            this.btn_ajoutFournisseur.UseVisualStyleBackColor = false;
            this.btn_ajoutFournisseur.Click += new System.EventHandler(this.btn_ajoutFournisseur_Click);
            // 
            // label_nomFournisseur
            // 
            this.label_nomFournisseur.AutoSize = true;
            this.label_nomFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nomFournisseur.Location = new System.Drawing.Point(88, 79);
            this.label_nomFournisseur.Name = "label_nomFournisseur";
            this.label_nomFournisseur.Size = new System.Drawing.Size(49, 18);
            this.label_nomFournisseur.TabIndex = 1;
            this.label_nomFournisseur.Text = "Nom :";
            this.label_nomFournisseur.Click += new System.EventHandler(this.label_nomFournisseur_Click);
            // 
            // label_mailFournisseur
            // 
            this.label_mailFournisseur.AutoSize = true;
            this.label_mailFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mailFournisseur.Location = new System.Drawing.Point(88, 190);
            this.label_mailFournisseur.Name = "label_mailFournisseur";
            this.label_mailFournisseur.Size = new System.Drawing.Size(53, 18);
            this.label_mailFournisseur.TabIndex = 2;
            this.label_mailFournisseur.Text = "Email :";
            // 
            // label_adresseFournisseur
            // 
            this.label_adresseFournisseur.AutoSize = true;
            this.label_adresseFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adresseFournisseur.Location = new System.Drawing.Point(88, 292);
            this.label_adresseFournisseur.Name = "label_adresseFournisseur";
            this.label_adresseFournisseur.Size = new System.Drawing.Size(74, 18);
            this.label_adresseFournisseur.TabIndex = 3;
            this.label_adresseFournisseur.Text = "Adresse : ";
            // 
            // label_villeFournisseur
            // 
            this.label_villeFournisseur.AutoSize = true;
            this.label_villeFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_villeFournisseur.Location = new System.Drawing.Point(616, 79);
            this.label_villeFournisseur.Name = "label_villeFournisseur";
            this.label_villeFournisseur.Size = new System.Drawing.Size(42, 18);
            this.label_villeFournisseur.TabIndex = 4;
            this.label_villeFournisseur.Text = "Ville :";
            // 
            // label_telFournisseur
            // 
            this.label_telFournisseur.AutoSize = true;
            this.label_telFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_telFournisseur.Location = new System.Drawing.Point(601, 190);
            this.label_telFournisseur.Name = "label_telFournisseur";
            this.label_telFournisseur.Size = new System.Drawing.Size(85, 18);
            this.label_telFournisseur.TabIndex = 5;
            this.label_telFournisseur.Text = "Telephone :";
            // 
            // textBox_nomFournisseur
            // 
            this.textBox_nomFournisseur.Location = new System.Drawing.Point(216, 79);
            this.textBox_nomFournisseur.Name = "textBox_nomFournisseur";
            this.textBox_nomFournisseur.Size = new System.Drawing.Size(164, 20);
            this.textBox_nomFournisseur.TabIndex = 6;
            this.textBox_nomFournisseur.TextChanged += new System.EventHandler(this.textBox_nomFournisseur_TextChanged);
            // 
            // textBox_mailFournisseur
            // 
            this.textBox_mailFournisseur.Location = new System.Drawing.Point(216, 185);
            this.textBox_mailFournisseur.Name = "textBox_mailFournisseur";
            this.textBox_mailFournisseur.Size = new System.Drawing.Size(164, 20);
            this.textBox_mailFournisseur.TabIndex = 7;
            this.textBox_mailFournisseur.TextChanged += new System.EventHandler(this.textBox_mailFournisseur_TextChanged);
            // 
            // textBox_adresseFournisseur
            // 
            this.textBox_adresseFournisseur.Location = new System.Drawing.Point(216, 293);
            this.textBox_adresseFournisseur.Name = "textBox_adresseFournisseur";
            this.textBox_adresseFournisseur.Size = new System.Drawing.Size(164, 20);
            this.textBox_adresseFournisseur.TabIndex = 8;
            this.textBox_adresseFournisseur.TextChanged += new System.EventHandler(this.textBox_adresseFournisseur_TextChanged);
            // 
            // textBox_villeFournisseur
            // 
            this.textBox_villeFournisseur.Location = new System.Drawing.Point(722, 77);
            this.textBox_villeFournisseur.Name = "textBox_villeFournisseur";
            this.textBox_villeFournisseur.Size = new System.Drawing.Size(187, 20);
            this.textBox_villeFournisseur.TabIndex = 9;
            this.textBox_villeFournisseur.TextChanged += new System.EventHandler(this.textBox_villeFournisseur_TextChanged);
            // 
            // textBox_telFournisseur
            // 
            this.textBox_telFournisseur.Location = new System.Drawing.Point(722, 191);
            this.textBox_telFournisseur.Name = "textBox_telFournisseur";
            this.textBox_telFournisseur.Size = new System.Drawing.Size(187, 20);
            this.textBox_telFournisseur.TabIndex = 10;
            this.textBox_telFournisseur.TextChanged += new System.EventHandler(this.textBox_telFournisseur_TextChanged);
            // 
            // AjoutFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 488);
            this.Controls.Add(this.textBox_telFournisseur);
            this.Controls.Add(this.textBox_villeFournisseur);
            this.Controls.Add(this.textBox_adresseFournisseur);
            this.Controls.Add(this.textBox_mailFournisseur);
            this.Controls.Add(this.textBox_nomFournisseur);
            this.Controls.Add(this.label_telFournisseur);
            this.Controls.Add(this.label_villeFournisseur);
            this.Controls.Add(this.label_adresseFournisseur);
            this.Controls.Add(this.label_mailFournisseur);
            this.Controls.Add(this.label_nomFournisseur);
            this.Controls.Add(this.btn_ajoutFournisseur);
            this.Name = "AjoutFournisseur";
            this.Text = "AjoutFournisseur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ajoutFournisseur;
        private System.Windows.Forms.Label label_nomFournisseur;
        private System.Windows.Forms.Label label_mailFournisseur;
        private System.Windows.Forms.Label label_adresseFournisseur;
        private System.Windows.Forms.Label label_villeFournisseur;
        private System.Windows.Forms.Label label_telFournisseur;
        private System.Windows.Forms.TextBox textBox_nomFournisseur;
        private System.Windows.Forms.TextBox textBox_mailFournisseur;
        private System.Windows.Forms.TextBox textBox_adresseFournisseur;
        private System.Windows.Forms.TextBox textBox_villeFournisseur;
        private System.Windows.Forms.TextBox textBox_telFournisseur;
    }
}