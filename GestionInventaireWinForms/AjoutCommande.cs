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
    public partial class AjoutCommande : Form
    {

        string selectArticle;
        int quantite;
        int prix, prixTotal, prixtotaux;
        long idSelect, idSelectFournisseur, maxId, i;

        Dictionary<string, int> listSelect = new Dictionary<string, int>();
        Dictionary<long, int> listSelectCmd = new Dictionary<long, int>();

        private HttpWebRequest webRequest;

        private void AjoutCommande_Load(object sender, EventArgs e)
        {
            apiComboBox("https://localhost:44319/api/Articles");

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44319/api/Articles");
            var webResponse = (HttpWebResponse)webRequest.GetResponse();

            if ((webResponse.StatusCode == HttpStatusCode.OK))
            {
                var reader = new StreamReader(webResponse.GetResponseStream());
                string s = reader.ReadToEnd();
                var arr = JsonConvert.DeserializeObject<List<ArticleDTO>>(s);

                selectArticle = comboBox_ArticlesCommande.GetItemText(comboBox_ArticlesCommande.SelectedItem);

                if (selectArticle != "")
                {
                    idSelect = arr.FirstOrDefault(x => x.Name == selectArticle).Id;
                    prix = arr.FirstOrDefault(x => x.Name == selectArticle).BuyPrice;
                    quantite = (int)numericUpDown1.Value;
                    prixTotal = (int)(prix * quantite);
                    textBox_PrixTotal.Text = prixTotal.ToString() + " €";
                }
            }
            else
            {
                MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
            }
        }

        public AjoutCommande()
        {
            InitializeComponent();
        }
        private void apiComboBox(string url)
        {
            if (url == "https://localhost:44319/api/Articles")
            {
                var webRequest = (HttpWebRequest)WebRequest.Create(url);
                var webResponse = (HttpWebResponse)webRequest.GetResponse();

                if ((webResponse.StatusCode == HttpStatusCode.OK))
                {
                    var reader = new StreamReader(webResponse.GetResponseStream());
                    string s = reader.ReadToEnd();
                    var arr = JsonConvert.DeserializeObject<List<ArticleDTO>>(s);
                    var list = new BindingList<ArticleDTO>(arr);
                    var data = new BindingSource(list, null);
                    comboBox_ArticlesCommande.DataSource = data.DataSource;
                    comboBox_ArticlesCommande.DisplayMember = "Name";
                    comboBox_ArticlesCommande.ValueMember = "Name";
                }
                else
                {
                    MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
                }
            }

        }

        private void comboBox_ArticlesCommande_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_AjoutCommande_Click(object sender, EventArgs e)
        {
            listSelect.Add(selectArticle.ToString() + " x" + quantite.ToString(), prixTotal);
            listSelectCmd.Add(idSelect, quantite);

            dataGridView1.DataSource = (from d in listSelect orderby d.Value select new { d.Key, d.Value }).ToList();
        }

        private void button_FinCommande_Click(object sender, EventArgs e)
        {
            // On créé une commande
            string url = "https://localhost:44319/api/Orders";

            prixtotaux = 0;
            foreach (KeyValuePair<string, int> entry in listSelect)
            {
                var prixLoop = entry.Value;
                prixtotaux += prixLoop;
            }

            string requestParams = JsonTCommandeInterne();

            webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Method = "POST";
            webRequest.ContentType = "application/json";

            byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
            webRequest.ContentLength = byteArray.Length;
            using (Stream requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(byteArray, 0, byteArray.Length);
            }

            AppelApiId();
            // on récupère la liste des produits et leur stock
            url = "https://localhost:44319/api/Stocks";
            webRequest = (HttpWebRequest)WebRequest.Create(url);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();

            if ((webResponse.StatusCode == HttpStatusCode.OK))
            {
                var reader = new StreamReader(webResponse.GetResponseStream());
                string s = reader.ReadToEnd();
                var arr = JsonConvert.DeserializeObject<List<StockDTO>>(s);

                // Pour chaque Article dans la commande
                foreach (KeyValuePair<long, int> entry in listSelectCmd)
                {
                    url = "https://localhost:44319/api/OrderArticles";
                    var idSelectLoop = entry.Key;
                    var quantiteLoop = entry.Value;
                    var allStockId = from r in arr
                                     orderby r.Id
                                     select r;

                    
                    // Mise a jour du stock commandé sur le produit
                    foreach (var std in allStockId)
                    {
                        if (std.IdArticle == idSelectLoop)
                        {
                            var idStock = std.Id;
                            url = "https://localhost:44319/api/Stocks/" + idStock.ToString();
                            JavaScriptSerializer ser = new JavaScriptSerializer();
                            var jsonData = new StockDTO()
                            {
                                Id = idStock,
                                IdArticle = (int)idSelectLoop,
                                Quantity = std.Quantity

                            };
                            requestParams = ser.Serialize(jsonData);

                            webRequest = (HttpWebRequest)WebRequest.Create(url);
                            webRequest.Method = "PUT";
                            webRequest.ContentType = "application/json";

                            byte[] byteArray2 = Encoding.UTF8.GetBytes(requestParams);
                            webRequest.ContentLength = byteArray2.Length;
                            using (Stream requestStream = webRequest.GetRequestStream())
                            {
                                requestStream.Write(byteArray2, 0, byteArray2.Length);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
            }
            // On ferme le formulaire de commande
            this.Close();
        }
        public string JsonTCommandeInterne()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();

            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-ddTHH:mm:ss.fff");

            var jsonData = new CommandeInterneDTO()
            {
                id = 0,
                prixTotal = prixtotaux,
                dateCommande = sqlFormattedDate,
                isActive = true,
                statut = "En cours",

            };

            var result = ser.Serialize(jsonData);
            return result;
        }
        public string JsonTCommandeInterneProduit(long idSelect, int quantite)
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();

            var jsonData = new CommandeInterneArticleDTO()
            {

                idCommandeInterne = i,
                idArticle = idSelect,
                Quantity = quantite,

            };
            var result = ser.Serialize(jsonData);
            return result;
        }
        public void AppelApiId()
        {
            string url = "https://localhost:44319/api/Orders";

            var webRequest = (HttpWebRequest)WebRequest.Create(url);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();

            if ((webResponse.StatusCode == HttpStatusCode.OK))
            {

                var reader = new StreamReader(webResponse.GetResponseStream());
                string s = reader.ReadToEnd();
                var arr = JsonConvert.DeserializeObject<List<CommandeInterneDTO>>(s);

                var maxId = from r in arr
                            orderby r.id
                            select r;
                i = 1;

                foreach (var std in maxId)
                {
                    i++;

                }
            }
            else
            {
                MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
            }
        }


    }
}

