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
    public partial class AjoutCategorie : Form
    {
        private HttpWebRequest webRequest;
        public string lblCategorie;
        public AjoutCategorie()
        {
            InitializeComponent();
        }

        private void txtBox_NomCategorie_TextChanged(object sender, EventArgs e)
        {
            lblCategorie = txtBox_NomCategorie.Text;
        }

        private void btn_AjoutCategorie_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:44319/api/Categories";

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


            this.Close();


        }

        public string JsonTester()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();

            var jsonData = new CategorieDTO()
            {

                Name = lblCategorie,
                isActive = true,

            };


            var result = ser.Serialize(jsonData);
            return result;
        }

        private void label_nomCategorie_Click(object sender, EventArgs e)
        {

        }
    }
}
