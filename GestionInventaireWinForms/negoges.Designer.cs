
namespace GestionInventaireWinForms
{
    partial class negoges
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_DeleteArticle = new System.Windows.Forms.Button();
            this.button_searchArticle = new System.Windows.Forms.Button();
            this.btn_EditArticle = new System.Windows.Forms.Button();
            this.button_LoadArticle = new System.Windows.Forms.Button();
            this.button_AddArticle = new System.Windows.Forms.Button();
            this.comboBox_categorie = new System.Windows.Forms.ComboBox();
            this.comboBox_fournisseur = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_nameArticle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Article = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_DeleteFournisseur = new System.Windows.Forms.Button();
            this.btn_EditFournisseur = new System.Windows.Forms.Button();
            this.btn_addFournisseur = new System.Windows.Forms.Button();
            this.btn_LoadFournisseur = new System.Windows.Forms.Button();
            this.dataGridView_Fournisseur = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_addClient = new System.Windows.Forms.Button();
            this.btn_DeleteClient = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView_Client = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_EditCommandeFournisseur = new System.Windows.Forms.Button();
            this.btn_LoadCommandeInterne = new System.Windows.Forms.Button();
            this.btn_addCommande = new System.Windows.Forms.Button();
            this.dataGridView_Commande = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button20 = new System.Windows.Forms.Button();
            this.btn_EditCategorie = new System.Windows.Forms.Button();
            this.btn_LoadCategorie = new System.Windows.Forms.Button();
            this.btn_addCategorie = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView_Categorie = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_EditStock = new System.Windows.Forms.Button();
            this.btn_LoadStock = new System.Windows.Forms.Button();
            this.dataGridView_Stock = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Article)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Fournisseur)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Client)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Commande)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Categorie)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Stock)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1390, 713);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.button_DeleteArticle);
            this.tabPage1.Controls.Add(this.button_searchArticle);
            this.tabPage1.Controls.Add(this.btn_EditArticle);
            this.tabPage1.Controls.Add(this.button_LoadArticle);
            this.tabPage1.Controls.Add(this.button_AddArticle);
            this.tabPage1.Controls.Add(this.comboBox_categorie);
            this.tabPage1.Controls.Add(this.comboBox_fournisseur);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox_nameArticle);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView_Article);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1382, 687);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // button_DeleteArticle
            // 
            this.button_DeleteArticle.BackColor = System.Drawing.Color.White;
            this.button_DeleteArticle.BackgroundImage = global::GestionInventaireWinForms.Properties.Resources.delete;
            this.button_DeleteArticle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_DeleteArticle.Location = new System.Drawing.Point(1078, 49);
            this.button_DeleteArticle.Name = "button_DeleteArticle";
            this.button_DeleteArticle.Size = new System.Drawing.Size(62, 61);
            this.button_DeleteArticle.TabIndex = 11;
            this.button_DeleteArticle.UseVisualStyleBackColor = false;
            this.button_DeleteArticle.Click += new System.EventHandler(this.button_DeleteArticle_Click);
            // 
            // button_searchArticle
            // 
            this.button_searchArticle.BackColor = System.Drawing.Color.White;
            this.button_searchArticle.BackgroundImage = global::GestionInventaireWinForms.Properties.Resources.search;
            this.button_searchArticle.Location = new System.Drawing.Point(752, 50);
            this.button_searchArticle.Name = "button_searchArticle";
            this.button_searchArticle.Size = new System.Drawing.Size(62, 61);
            this.button_searchArticle.TabIndex = 10;
            this.button_searchArticle.UseVisualStyleBackColor = false;
            // 
            // btn_EditArticle
            // 
            this.btn_EditArticle.BackColor = System.Drawing.Color.White;
            this.btn_EditArticle.BackgroundImage = global::GestionInventaireWinForms.Properties.Resources.edit;
            this.btn_EditArticle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_EditArticle.Location = new System.Drawing.Point(999, 49);
            this.btn_EditArticle.Name = "btn_EditArticle";
            this.btn_EditArticle.Size = new System.Drawing.Size(62, 61);
            this.btn_EditArticle.TabIndex = 9;
            this.btn_EditArticle.UseVisualStyleBackColor = false;
            this.btn_EditArticle.Click += new System.EventHandler(this.btn_EditArticle_Click);
            // 
            // button_LoadArticle
            // 
            this.button_LoadArticle.BackColor = System.Drawing.Color.White;
            this.button_LoadArticle.BackgroundImage = global::GestionInventaireWinForms.Properties.Resources.reset;
            this.button_LoadArticle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_LoadArticle.Location = new System.Drawing.Point(834, 50);
            this.button_LoadArticle.Name = "button_LoadArticle";
            this.button_LoadArticle.Size = new System.Drawing.Size(62, 61);
            this.button_LoadArticle.TabIndex = 8;
            this.button_LoadArticle.UseVisualStyleBackColor = false;
            this.button_LoadArticle.Click += new System.EventHandler(this.button_LoadArticle_Click);
            // 
            // button_AddArticle
            // 
            this.button_AddArticle.BackColor = System.Drawing.Color.White;
            this.button_AddArticle.BackgroundImage = global::GestionInventaireWinForms.Properties.Resources.add;
            this.button_AddArticle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_AddArticle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_AddArticle.Location = new System.Drawing.Point(918, 50);
            this.button_AddArticle.Name = "button_AddArticle";
            this.button_AddArticle.Size = new System.Drawing.Size(62, 61);
            this.button_AddArticle.TabIndex = 7;
            this.button_AddArticle.UseVisualStyleBackColor = false;
            this.button_AddArticle.Click += new System.EventHandler(this.button_AddArticle_Click);
            // 
            // comboBox_categorie
            // 
            this.comboBox_categorie.FormattingEnabled = true;
            this.comboBox_categorie.Location = new System.Drawing.Point(523, 70);
            this.comboBox_categorie.Name = "comboBox_categorie";
            this.comboBox_categorie.Size = new System.Drawing.Size(160, 21);
            this.comboBox_categorie.TabIndex = 6;
            // 
            // comboBox_fournisseur
            // 
            this.comboBox_fournisseur.FormattingEnabled = true;
            this.comboBox_fournisseur.Location = new System.Drawing.Point(278, 70);
            this.comboBox_fournisseur.Name = "comboBox_fournisseur";
            this.comboBox_fournisseur.Size = new System.Drawing.Size(160, 21);
            this.comboBox_fournisseur.TabIndex = 5;
            this.comboBox_fournisseur.SelectedIndexChanged += new System.EventHandler(this.comboBox_fournisseur_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(520, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Catégorie :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fournisseur:";
            // 
            // textBox_nameArticle
            // 
            this.textBox_nameArticle.Location = new System.Drawing.Point(35, 71);
            this.textBox_nameArticle.Name = "textBox_nameArticle";
            this.textBox_nameArticle.Size = new System.Drawing.Size(152, 20);
            this.textBox_nameArticle.TabIndex = 2;
            this.textBox_nameArticle.TextChanged += new System.EventHandler(this.textBox_nameArticle_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Articles";
            // 
            // dataGridView_Article
            // 
            this.dataGridView_Article.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView_Article.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Article.Location = new System.Drawing.Point(3, 141);
            this.dataGridView_Article.Name = "dataGridView_Article";
            this.dataGridView_Article.Size = new System.Drawing.Size(1379, 543);
            this.dataGridView_Article.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_DeleteFournisseur);
            this.tabPage2.Controls.Add(this.btn_EditFournisseur);
            this.tabPage2.Controls.Add(this.btn_addFournisseur);
            this.tabPage2.Controls.Add(this.btn_LoadFournisseur);
            this.tabPage2.Controls.Add(this.dataGridView_Fournisseur);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1382, 687);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteFournisseur
            // 
            this.btn_DeleteFournisseur.BackColor = System.Drawing.Color.White;
            this.btn_DeleteFournisseur.BackgroundImage = global::GestionInventaireWinForms.Properties.Resources.delete;
            this.btn_DeleteFournisseur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_DeleteFournisseur.Location = new System.Drawing.Point(1041, 258);
            this.btn_DeleteFournisseur.Name = "btn_DeleteFournisseur";
            this.btn_DeleteFournisseur.Size = new System.Drawing.Size(62, 61);
            this.btn_DeleteFournisseur.TabIndex = 12;
            this.btn_DeleteFournisseur.UseVisualStyleBackColor = false;
            this.btn_DeleteFournisseur.Click += new System.EventHandler(this.btn_DeleteFournisseur_Click);
            // 
            // btn_EditFournisseur
            // 
            this.btn_EditFournisseur.BackColor = System.Drawing.Color.White;
            this.btn_EditFournisseur.BackgroundImage = global::GestionInventaireWinForms.Properties.Resources.edit;
            this.btn_EditFournisseur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_EditFournisseur.Location = new System.Drawing.Point(1041, 191);
            this.btn_EditFournisseur.Name = "btn_EditFournisseur";
            this.btn_EditFournisseur.Size = new System.Drawing.Size(62, 61);
            this.btn_EditFournisseur.TabIndex = 11;
            this.btn_EditFournisseur.UseVisualStyleBackColor = false;
            this.btn_EditFournisseur.Click += new System.EventHandler(this.btn_EditFournisseur_Click);
            // 
            // btn_addFournisseur
            // 
            this.btn_addFournisseur.BackColor = System.Drawing.Color.White;
            this.btn_addFournisseur.BackgroundImage = global::GestionInventaireWinForms.Properties.Resources.add;
            this.btn_addFournisseur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_addFournisseur.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_addFournisseur.Location = new System.Drawing.Point(1041, 124);
            this.btn_addFournisseur.Name = "btn_addFournisseur";
            this.btn_addFournisseur.Size = new System.Drawing.Size(62, 61);
            this.btn_addFournisseur.TabIndex = 10;
            this.btn_addFournisseur.UseVisualStyleBackColor = false;
            this.btn_addFournisseur.Click += new System.EventHandler(this.btn_addFournisseur_Click);
            // 
            // btn_LoadFournisseur
            // 
            this.btn_LoadFournisseur.BackColor = System.Drawing.Color.White;
            this.btn_LoadFournisseur.BackgroundImage = global::GestionInventaireWinForms.Properties.Resources.reset;
            this.btn_LoadFournisseur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_LoadFournisseur.Location = new System.Drawing.Point(1041, 57);
            this.btn_LoadFournisseur.Name = "btn_LoadFournisseur";
            this.btn_LoadFournisseur.Size = new System.Drawing.Size(62, 61);
            this.btn_LoadFournisseur.TabIndex = 9;
            this.btn_LoadFournisseur.UseVisualStyleBackColor = false;
            this.btn_LoadFournisseur.Click += new System.EventHandler(this.btn_LoadFournisseur_Click);
            // 
            // dataGridView_Fournisseur
            // 
            this.dataGridView_Fournisseur.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView_Fournisseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Fournisseur.Location = new System.Drawing.Point(6, 57);
            this.dataGridView_Fournisseur.Name = "dataGridView_Fournisseur";
            this.dataGridView_Fournisseur.Size = new System.Drawing.Size(1029, 623);
            this.dataGridView_Fournisseur.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fournisseurs";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_addClient);
            this.tabPage3.Controls.Add(this.btn_DeleteClient);
            this.tabPage3.Controls.Add(this.button11);
            this.tabPage3.Controls.Add(this.button10);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.dataGridView_Client);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1382, 687);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_addClient
            // 
            this.btn_addClient.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_addClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_addClient.Location = new System.Drawing.Point(66, 91);
            this.btn_addClient.Name = "btn_addClient";
            this.btn_addClient.Size = new System.Drawing.Size(125, 38);
            this.btn_addClient.TabIndex = 14;
            this.btn_addClient.Text = "Ajouter Client";
            this.btn_addClient.UseVisualStyleBackColor = false;
            this.btn_addClient.Click += new System.EventHandler(this.btn_addClient_Click);
            // 
            // btn_DeleteClient
            // 
            this.btn_DeleteClient.BackColor = System.Drawing.Color.White;
            this.btn_DeleteClient.BackgroundImage = global::GestionInventaireWinForms.Properties.Resources.delete;
            this.btn_DeleteClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_DeleteClient.Location = new System.Drawing.Point(426, 81);
            this.btn_DeleteClient.Name = "btn_DeleteClient";
            this.btn_DeleteClient.Size = new System.Drawing.Size(62, 61);
            this.btn_DeleteClient.TabIndex = 13;
            this.btn_DeleteClient.UseVisualStyleBackColor = false;
            this.btn_DeleteClient.Click += new System.EventHandler(this.btn_DeleteClient_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.BackgroundImage = global::GestionInventaireWinForms.Properties.Resources.edit;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button11.Location = new System.Drawing.Point(358, 81);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(62, 61);
            this.button11.TabIndex = 12;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.BackgroundImage = global::GestionInventaireWinForms.Properties.Resources.reset;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button10.Location = new System.Drawing.Point(290, 81);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(62, 61);
            this.button10.TabIndex = 10;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Clients";
            // 
            // dataGridView_Client
            // 
            this.dataGridView_Client.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView_Client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Client.Location = new System.Drawing.Point(6, 148);
            this.dataGridView_Client.Name = "dataGridView_Client";
            this.dataGridView_Client.Size = new System.Drawing.Size(619, 532);
            this.dataGridView_Client.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_EditCommandeFournisseur);
            this.tabPage4.Controls.Add(this.btn_LoadCommandeInterne);
            this.tabPage4.Controls.Add(this.btn_addCommande);
            this.tabPage4.Controls.Add(this.dataGridView_Commande);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1382, 687);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_EditCommandeFournisseur
            // 
            this.btn_EditCommandeFournisseur.BackColor = System.Drawing.Color.White;
            this.btn_EditCommandeFournisseur.BackgroundImage = global::GestionInventaireWinForms.Properties.Resources.edit;
            this.btn_EditCommandeFournisseur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_EditCommandeFournisseur.Location = new System.Drawing.Point(455, 85);
            this.btn_EditCommandeFournisseur.Name = "btn_EditCommandeFournisseur";
            this.btn_EditCommandeFournisseur.Size = new System.Drawing.Size(62, 61);
            this.btn_EditCommandeFournisseur.TabIndex = 17;
            this.btn_EditCommandeFournisseur.UseVisualStyleBackColor = false;
            this.btn_EditCommandeFournisseur.Click += new System.EventHandler(this.btn_EditCommandeFournisseur_Click);
            // 
            // btn_LoadCommandeInterne
            // 
            this.btn_LoadCommandeInterne.BackColor = System.Drawing.Color.White;
            this.btn_LoadCommandeInterne.BackgroundImage = global::GestionInventaireWinForms.Properties.Resources.reset;
            this.btn_LoadCommandeInterne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_LoadCommandeInterne.Location = new System.Drawing.Point(387, 85);
            this.btn_LoadCommandeInterne.Name = "btn_LoadCommandeInterne";
            this.btn_LoadCommandeInterne.Size = new System.Drawing.Size(62, 61);
            this.btn_LoadCommandeInterne.TabIndex = 16;
            this.btn_LoadCommandeInterne.UseVisualStyleBackColor = false;
            this.btn_LoadCommandeInterne.Click += new System.EventHandler(this.btn_LoadCommandeInterne_Click);
            // 
            // btn_addCommande
            // 
            this.btn_addCommande.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_addCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addCommande.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_addCommande.Location = new System.Drawing.Point(57, 108);
            this.btn_addCommande.Name = "btn_addCommande";
            this.btn_addCommande.Size = new System.Drawing.Size(167, 38);
            this.btn_addCommande.TabIndex = 15;
            this.btn_addCommande.Text = "Ajouter Commande";
            this.btn_addCommande.UseVisualStyleBackColor = false;
            this.btn_addCommande.Click += new System.EventHandler(this.btn_addCommande_Click);
            // 
            // dataGridView_Commande
            // 
            this.dataGridView_Commande.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView_Commande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Commande.Location = new System.Drawing.Point(6, 152);
            this.dataGridView_Commande.Name = "dataGridView_Commande";
            this.dataGridView_Commande.Size = new System.Drawing.Size(741, 532);
            this.dataGridView_Commande.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Commandes";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button20);
            this.tabPage5.Controls.Add(this.btn_EditCategorie);
            this.tabPage5.Controls.Add(this.btn_LoadCategorie);
            this.tabPage5.Controls.Add(this.btn_addCategorie);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.dataGridView_Categorie);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1382, 687);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.White;
            this.button20.BackgroundImage = global::GestionInventaireWinForms.Properties.Resources.delete;
            this.button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button20.Location = new System.Drawing.Point(404, 85);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(62, 61);
            this.button20.TabIndex = 19;
            this.button20.UseVisualStyleBackColor = false;
            // 
            // btn_EditCategorie
            // 
            this.btn_EditCategorie.BackColor = System.Drawing.Color.White;
            this.btn_EditCategorie.BackgroundImage = global::GestionInventaireWinForms.Properties.Resources.edit;
            this.btn_EditCategorie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_EditCategorie.Location = new System.Drawing.Point(336, 85);
            this.btn_EditCategorie.Name = "btn_EditCategorie";
            this.btn_EditCategorie.Size = new System.Drawing.Size(62, 61);
            this.btn_EditCategorie.TabIndex = 18;
            this.btn_EditCategorie.UseVisualStyleBackColor = false;
            this.btn_EditCategorie.Click += new System.EventHandler(this.btn_EditCategorie_Click);
            // 
            // btn_LoadCategorie
            // 
            this.btn_LoadCategorie.BackColor = System.Drawing.Color.White;
            this.btn_LoadCategorie.BackgroundImage = global::GestionInventaireWinForms.Properties.Resources.reset;
            this.btn_LoadCategorie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_LoadCategorie.Location = new System.Drawing.Point(268, 85);
            this.btn_LoadCategorie.Name = "btn_LoadCategorie";
            this.btn_LoadCategorie.Size = new System.Drawing.Size(62, 61);
            this.btn_LoadCategorie.TabIndex = 17;
            this.btn_LoadCategorie.UseVisualStyleBackColor = false;
            this.btn_LoadCategorie.Click += new System.EventHandler(this.btn_LoadCategorie_Click);
            // 
            // btn_addCategorie
            // 
            this.btn_addCategorie.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_addCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addCategorie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_addCategorie.Location = new System.Drawing.Point(23, 108);
            this.btn_addCategorie.Name = "btn_addCategorie";
            this.btn_addCategorie.Size = new System.Drawing.Size(167, 38);
            this.btn_addCategorie.TabIndex = 16;
            this.btn_addCategorie.Text = "Ajouter Catégorie";
            this.btn_addCategorie.UseVisualStyleBackColor = false;
            this.btn_addCategorie.Click += new System.EventHandler(this.btn_addCategorie_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Catégories";
            // 
            // dataGridView_Categorie
            // 
            this.dataGridView_Categorie.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView_Categorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Categorie.Location = new System.Drawing.Point(3, 152);
            this.dataGridView_Categorie.Name = "dataGridView_Categorie";
            this.dataGridView_Categorie.Size = new System.Drawing.Size(493, 528);
            this.dataGridView_Categorie.TabIndex = 6;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label8);
            this.tabPage6.Controls.Add(this.btn_EditStock);
            this.tabPage6.Controls.Add(this.btn_LoadStock);
            this.tabPage6.Controls.Add(this.dataGridView_Stock);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1382, 687);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "Stock";
            // 
            // btn_EditStock
            // 
            this.btn_EditStock.BackColor = System.Drawing.Color.White;
            this.btn_EditStock.BackgroundImage = global::GestionInventaireWinForms.Properties.Resources.edit;
            this.btn_EditStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_EditStock.Location = new System.Drawing.Point(504, 161);
            this.btn_EditStock.Name = "btn_EditStock";
            this.btn_EditStock.Size = new System.Drawing.Size(62, 61);
            this.btn_EditStock.TabIndex = 19;
            this.btn_EditStock.UseVisualStyleBackColor = false;
            this.btn_EditStock.Click += new System.EventHandler(this.btn_EditStock_Click);
            // 
            // btn_LoadStock
            // 
            this.btn_LoadStock.BackColor = System.Drawing.Color.White;
            this.btn_LoadStock.BackgroundImage = global::GestionInventaireWinForms.Properties.Resources.reset;
            this.btn_LoadStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_LoadStock.Location = new System.Drawing.Point(436, 161);
            this.btn_LoadStock.Name = "btn_LoadStock";
            this.btn_LoadStock.Size = new System.Drawing.Size(62, 61);
            this.btn_LoadStock.TabIndex = 18;
            this.btn_LoadStock.UseVisualStyleBackColor = false;
            this.btn_LoadStock.Click += new System.EventHandler(this.btn_LoadStock_Click);
            // 
            // dataGridView_Stock
            // 
            this.dataGridView_Stock.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView_Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Stock.Location = new System.Drawing.Point(6, 228);
            this.dataGridView_Stock.Name = "dataGridView_Stock";
            this.dataGridView_Stock.Size = new System.Drawing.Size(617, 236);
            this.dataGridView_Stock.TabIndex = 7;
            // 
            // negoges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 715);
            this.Controls.Add(this.tabControl1);
            this.Name = "negoges";
            this.Text = "negoges";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Article)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Fournisseur)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Client)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Commande)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Categorie)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Stock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView_Article;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_DeleteArticle;
        private System.Windows.Forms.Button button_searchArticle;
        private System.Windows.Forms.Button btn_EditArticle;
        private System.Windows.Forms.Button button_LoadArticle;
        private System.Windows.Forms.Button button_AddArticle;
        private System.Windows.Forms.ComboBox comboBox_categorie;
        private System.Windows.Forms.ComboBox comboBox_fournisseur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nameArticle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btn_DeleteFournisseur;
        private System.Windows.Forms.Button btn_EditFournisseur;
        private System.Windows.Forms.Button btn_addFournisseur;
        private System.Windows.Forms.Button btn_LoadFournisseur;
        private System.Windows.Forms.DataGridView dataGridView_Fournisseur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_addClient;
        private System.Windows.Forms.Button btn_DeleteClient;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView_Client;
        private System.Windows.Forms.DataGridView dataGridView_Commande;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_addCommande;
        private System.Windows.Forms.Button btn_EditCommandeFournisseur;
        private System.Windows.Forms.Button btn_LoadCommandeInterne;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button btn_EditCategorie;
        private System.Windows.Forms.Button btn_LoadCategorie;
        private System.Windows.Forms.Button btn_addCategorie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView_Categorie;
        private System.Windows.Forms.Button btn_EditStock;
        private System.Windows.Forms.Button btn_LoadStock;
        private System.Windows.Forms.DataGridView dataGridView_Stock;
        private System.Windows.Forms.Label label8;
    }
}