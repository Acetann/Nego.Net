
namespace GestionInventaireWinForms
{
    partial class AjoutClient
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
            this.Titre_Client = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBox_Nom_Client = new System.Windows.Forms.TextBox();
            this.TxtBox_Mail_Client = new System.Windows.Forms.TextBox();
            this.TxtBox_Adresse_Client = new System.Windows.Forms.TextBox();
            this.TxtBox_Tel_Client = new System.Windows.Forms.TextBox();
            this.btn_Ajout_Client = new System.Windows.Forms.Button();
            this.label_prenomClient = new System.Windows.Forms.Label();
            this.textBox_PrenomClient = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Titre_Client
            // 
            this.Titre_Client.AutoSize = true;
            this.Titre_Client.BackColor = System.Drawing.SystemColors.Desktop;
            this.Titre_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre_Client.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Titre_Client.Location = new System.Drawing.Point(184, 9);
            this.Titre_Client.Name = "Titre_Client";
            this.Titre_Client.Size = new System.Drawing.Size(84, 31);
            this.Titre_Client.TabIndex = 0;
            this.Titre_Client.Text = "Client";
            this.Titre_Client.Click += new System.EventHandler(this.Titre_Client_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adresse :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Télephone :";
            // 
            // TxtBox_Nom_Client
            // 
            this.TxtBox_Nom_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Nom_Client.Location = new System.Drawing.Point(190, 110);
            this.TxtBox_Nom_Client.Name = "TxtBox_Nom_Client";
            this.TxtBox_Nom_Client.Size = new System.Drawing.Size(175, 22);
            this.TxtBox_Nom_Client.TabIndex = 5;
            this.TxtBox_Nom_Client.TextChanged += new System.EventHandler(this.TxtBox_Nom_Client_TextChanged);
            // 
            // TxtBox_Mail_Client
            // 
            this.TxtBox_Mail_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Mail_Client.Location = new System.Drawing.Point(190, 261);
            this.TxtBox_Mail_Client.Name = "TxtBox_Mail_Client";
            this.TxtBox_Mail_Client.Size = new System.Drawing.Size(175, 22);
            this.TxtBox_Mail_Client.TabIndex = 6;
            this.TxtBox_Mail_Client.TextChanged += new System.EventHandler(this.TxtBox_Mail_Client_TextChanged);
            // 
            // TxtBox_Adresse_Client
            // 
            this.TxtBox_Adresse_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Adresse_Client.Location = new System.Drawing.Point(190, 337);
            this.TxtBox_Adresse_Client.Name = "TxtBox_Adresse_Client";
            this.TxtBox_Adresse_Client.Size = new System.Drawing.Size(175, 22);
            this.TxtBox_Adresse_Client.TabIndex = 7;
            this.TxtBox_Adresse_Client.TextChanged += new System.EventHandler(this.TxtBox_Adresse_Client_TextChanged);
            // 
            // TxtBox_Tel_Client
            // 
            this.TxtBox_Tel_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Tel_Client.Location = new System.Drawing.Point(190, 426);
            this.TxtBox_Tel_Client.Name = "TxtBox_Tel_Client";
            this.TxtBox_Tel_Client.Size = new System.Drawing.Size(175, 22);
            this.TxtBox_Tel_Client.TabIndex = 8;
            this.TxtBox_Tel_Client.TextChanged += new System.EventHandler(this.TxtBox_Tel_Client_TextChanged);
            // 
            // btn_Ajout_Client
            // 
            this.btn_Ajout_Client.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Ajout_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ajout_Client.Location = new System.Drawing.Point(190, 553);
            this.btn_Ajout_Client.Name = "btn_Ajout_Client";
            this.btn_Ajout_Client.Size = new System.Drawing.Size(175, 43);
            this.btn_Ajout_Client.TabIndex = 9;
            this.btn_Ajout_Client.Text = "Ajouter le Client";
            this.btn_Ajout_Client.UseVisualStyleBackColor = false;
            this.btn_Ajout_Client.Click += new System.EventHandler(this.btn_Ajout_Client_Click);
            // 
            // label_prenomClient
            // 
            this.label_prenomClient.AutoSize = true;
            this.label_prenomClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prenomClient.Location = new System.Drawing.Point(53, 179);
            this.label_prenomClient.Name = "label_prenomClient";
            this.label_prenomClient.Size = new System.Drawing.Size(69, 18);
            this.label_prenomClient.TabIndex = 10;
            this.label_prenomClient.Text = "Prenom :";
            // 
            // textBox_PrenomClient
            // 
            this.textBox_PrenomClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PrenomClient.Location = new System.Drawing.Point(190, 175);
            this.textBox_PrenomClient.Name = "textBox_PrenomClient";
            this.textBox_PrenomClient.Size = new System.Drawing.Size(175, 22);
            this.textBox_PrenomClient.TabIndex = 11;
            this.textBox_PrenomClient.TextChanged += new System.EventHandler(this.textBox_PrenomClient_TextChanged);
            // 
            // AjoutClient
            // 
            this.ClientSize = new System.Drawing.Size(448, 639);
            this.Controls.Add(this.textBox_PrenomClient);
            this.Controls.Add(this.label_prenomClient);
            this.Controls.Add(this.btn_Ajout_Client);
            this.Controls.Add(this.TxtBox_Tel_Client);
            this.Controls.Add(this.TxtBox_Adresse_Client);
            this.Controls.Add(this.TxtBox_Mail_Client);
            this.Controls.Add(this.TxtBox_Nom_Client);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titre_Client);
            this.Name = "AjoutClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_Client;
        private System.Windows.Forms.Label Titre_Client;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBox_Nom_Client;
        private System.Windows.Forms.TextBox TxtBox_Mail_Client;
        private System.Windows.Forms.TextBox TxtBox_Adresse_Client;
        private System.Windows.Forms.TextBox TxtBox_Tel_Client;
        private System.Windows.Forms.Button btn_Ajout_Client;
        private System.Windows.Forms.Label label_prenomClient;
        private System.Windows.Forms.TextBox textBox_PrenomClient;
    }
}