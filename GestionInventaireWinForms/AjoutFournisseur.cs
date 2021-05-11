using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace GestionInventaireWinForms
{
    public partial class AjoutFournisseur : Form
    {
        private string nameFournisseur;
        private string emailFournisseur;
        private string adresseFournisseur;
        private string nameCity;
        private string telFournisseur;

        private HttpWebRequest webRequest;
        public AjoutFournisseur()
        {
            InitializeComponent();
        }

        public string JsonTester()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();

            var jsonData = new ProviderDTO()
            {
                Email = emailFournisseur,
                Name = nameFournisseur,
                Address = adresseFournisseur,
                PhoneNumber = telFournisseur,
                isActive = true,
            };

            var result = ser.Serialize(jsonData);
            return result;
        }

        private void AjoutFournisseur_Load(object sender, EventArgs e)
        {
            nameFournisseur = textBox_nomFournisseur.Text;
            emailFournisseur = textBox_mailFournisseur.Text;
            adresseFournisseur = textBox_adresseFournisseur.Text;
            nameCity = textBox_villeFournisseur.Text;
            telFournisseur = textBox_telFournisseur.Text;
        }

       

        private void btn_ajoutFournisseur_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:44319/api/Providers";

            string requestParams = JsonTester();

            webRequest = (HttpWebRequest)WebRequest.Create(url);

            webRequest.Method = "POST";
            webRequest.ContentType = "application/json";

            byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
            webRequest.ContentLength = byteArray.Length;
            using (Stream requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(byteArray, 0, byteArray.Length);
            }

            textBox_nomFournisseur.Text = null;
            textBox_mailFournisseur.Text = null;
            textBox_adresseFournisseur.Text = null;
            textBox_villeFournisseur.Text = null;
            textBox_telFournisseur.Text = null;

            this.Close();
        }

        private void textBox_mailFournisseur_TextChanged(object sender, EventArgs e)
        {
            emailFournisseur = textBox_mailFournisseur.Text;
        }

        private void textBox_adresseFournisseur_TextChanged(object sender, EventArgs e)
        {
            adresseFournisseur = textBox_adresseFournisseur.Text;
        }

        private void textBox_villeFournisseur_TextChanged(object sender, EventArgs e)
        {
            nameCity = textBox_villeFournisseur.Text;
        }
        private void textBox_nomFournisseur_TextChanged(object sender, EventArgs e)
        {
            nameFournisseur = textBox_nomFournisseur.Text;
        }

        private void textBox_telFournisseur_TextChanged(object sender, EventArgs e)
        {
            telFournisseur = textBox_telFournisseur.Text;
        }

        private void label_nomFournisseur_Click(object sender, EventArgs e)
        {

        }
    }

}

