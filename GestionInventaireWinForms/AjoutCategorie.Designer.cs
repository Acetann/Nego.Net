
namespace GestionInventaireWinForms
{
    partial class AjoutCategorie
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
            this.btn_AjoutCategorie = new System.Windows.Forms.Button();
            this.label_nomCategorie = new System.Windows.Forms.Label();
            this.txtBox_NomCategorie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_AjoutCategorie
            // 
            this.btn_AjoutCategorie.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_AjoutCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AjoutCategorie.Location = new System.Drawing.Point(157, 339);
            this.btn_AjoutCategorie.Name = "btn_AjoutCategorie";
            this.btn_AjoutCategorie.Size = new System.Drawing.Size(129, 44);
            this.btn_AjoutCategorie.TabIndex = 0;
            this.btn_AjoutCategorie.Text = "Ajouter";
            this.btn_AjoutCategorie.UseVisualStyleBackColor = false;
            this.btn_AjoutCategorie.Click += new System.EventHandler(this.btn_AjoutCategorie_Click);
            // 
            // label_nomCategorie
            // 
            this.label_nomCategorie.AutoSize = true;
            this.label_nomCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nomCategorie.Location = new System.Drawing.Point(29, 136);
            this.label_nomCategorie.Name = "label_nomCategorie";
            this.label_nomCategorie.Size = new System.Drawing.Size(49, 18);
            this.label_nomCategorie.TabIndex = 1;
            this.label_nomCategorie.Text = "Nom :";
            this.label_nomCategorie.Click += new System.EventHandler(this.label_nomCategorie_Click);
            // 
            // txtBox_NomCategorie
            // 
            this.txtBox_NomCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_NomCategorie.Location = new System.Drawing.Point(170, 137);
            this.txtBox_NomCategorie.Name = "txtBox_NomCategorie";
            this.txtBox_NomCategorie.Size = new System.Drawing.Size(100, 22);
            this.txtBox_NomCategorie.TabIndex = 2;
            this.txtBox_NomCategorie.TextChanged += new System.EventHandler(this.txtBox_NomCategorie_TextChanged);
            // 
            // AjoutCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 485);
            this.Controls.Add(this.txtBox_NomCategorie);
            this.Controls.Add(this.label_nomCategorie);
            this.Controls.Add(this.btn_AjoutCategorie);
            this.Name = "AjoutCategorie";
            this.Text = "AjoutCategorie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AjoutCategorie;
        private System.Windows.Forms.Label label_nomCategorie;
        private System.Windows.Forms.TextBox txtBox_NomCategorie;
    }
}