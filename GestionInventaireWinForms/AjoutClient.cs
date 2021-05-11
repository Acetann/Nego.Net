using Newtonsoft.Json;
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
    public partial class AjoutClient : Form
    {
        private string firstNameClient;
        private string lastNameClient;
        private string emailClient;
        private string adresseClient;
        private string telClient;

        private HttpWebRequest webRequest;
        public AjoutClient()
        {
            InitializeComponent();
        }

        private void AjoutClient_Load(object sender, EventArgs e)
        {
            firstNameClient = TxtBox_Nom_Client.Text;
            lastNameClient = TxtBox_Nom_Client.Text;
            emailClient = TxtBox_Mail_Client.Text;
            adresseClient = TxtBox_Adresse_Client.Text;
            telClient = TxtBox_Tel_Client.Text;
        }

        private void btn_Ajout_Client_Click(object sender, EventArgs e)
        {
           string url = "https://localhost:44319/api/Users";

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

            textBox_PrenomClient.Text = null;
            TxtBox_Nom_Client.Text = null;
            TxtBox_Mail_Client.Text = null;
            TxtBox_Adresse_Client.Text = null;
            TxtBox_Tel_Client.Text = null;

            this.Close();
        }

        public string JsonTester()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();

            var jsonData = new ClientDTO()
            {
                FirstName = firstNameClient,
                LastName = lastNameClient,
                Email = emailClient,
                Address = adresseClient,
                PhoneNumber = telClient,
                isActive = true,
            };

            var result = ser.Serialize(jsonData);
            return result;
        }

        private void TxtBox_Nom_Client_TextChanged(object sender, EventArgs e)
        {
            lastNameClient = TxtBox_Nom_Client.Text;
        }

        private void TxtBox_Mail_Client_TextChanged(object sender, EventArgs e)
        {
            emailClient = TxtBox_Mail_Client.Text;
        }

        private void TxtBox_Adresse_Client_TextChanged(object sender, EventArgs e)
        {
            adresseClient = TxtBox_Adresse_Client.Text;
        }

        private void TxtBox_Tel_Client_TextChanged(object sender, EventArgs e)
        {
            telClient = TxtBox_Tel_Client.Text;
        }

        private void Titre_Client_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_PrenomClient_TextChanged(object sender, EventArgs e)
        {
            firstNameClient = textBox_PrenomClient.Text;
        }
    }
}
