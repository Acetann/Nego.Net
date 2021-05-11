using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Web.Script.Serialization;
using System.Linq;

namespace GestionInventaireWinForms
{
    public partial class negoges : Form
    {

        AjoutClient AjoutClient = new AjoutClient();
        AjoutArticle AjoutArticle = new AjoutArticle();
        AjoutCategorie AjoutCategorie = new AjoutCategorie();
        AjoutFournisseur AjoutFournisseur = new AjoutFournisseur();
        AjoutCommande AjoutCommande = new AjoutCommande();

        private HttpWebRequest webRequest;

        string id;
        string Name;
        string IsActive, commandeAuto;
        string idCategorie;
        string nameArticle, descriptionArticle, domaineArticle, imgUrlArticle, volumeArticle;
        string prixArticle, prixFournisseurArticle, prixArticleV;
        string oldStatus;
        string idCommandeFournisseur, prixTotalCommande, dateCommandeEdit, statutCommande;
        private string idClient, firstNameClient, lastNameClient, EmailClient, AdresseClient, TelClient;
        string idFournisseur, nomFournisseur, adresseFournisseur, telFournisseur, mailFournisseur;
        string idStock, quantiteStockCommande, quantiteStock, idArticleStock;


        private void comboBox_fournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public string CelluleProduitValue { get; private set; }
        public negoges()
        {
            InitializeComponent();
            appel_Api("https://localhost:44319/api/Providers");
            this.dataGridView_Fournisseur.Columns["IsActive"].Visible = false;
            appel_Api("https://localhost:44319/api/Articles");
            this.dataGridView_Article.Columns["IsActive"].Visible = false;
            appel_Api("https://localhost:44319/api/Users");
            this.dataGridView_Client.Columns["IsActive"].Visible = false;
            appel_Api("https://localhost:44319/api/Categories");
            this.dataGridView_Categorie.Columns["IsActive"].Visible = false;
            appel_Api("https://localhost:44319/api/Orders");
            appel_Api("https://localhost:44319/api/Stocks");
            this.dataGridView_Commande.Columns["IsActive"].Visible = false;
            apiComboBox("https://localhost:44319/api/Categories");
            apiComboBox("https://localhost:44319/api/Providers");
        }

        private void apiComboBox(string url)
        {
            if (url == "https://localhost:44319/api/Categories")
            {
                var webRequest = (HttpWebRequest)WebRequest.Create(url);
                var webResponse = (HttpWebResponse)webRequest.GetResponse();

                if ((webResponse.StatusCode == HttpStatusCode.OK))
                {
                    var reader = new StreamReader(webResponse.GetResponseStream());
                    string s = reader.ReadToEnd();
                    var arr = JsonConvert.DeserializeObject<List<CategorieDTO>>(s);
                    var list = new BindingList<CategorieDTO>(arr);
                    var data = new BindingSource(list, null);
                    comboBox_categorie.DataSource = data.DataSource;
                    comboBox_categorie.DisplayMember = "Name";
                    comboBox_categorie.ValueMember = "Name";

                }
                else
                {
                    MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
                }
            }
            else if (url == "https://localhost:44319/api/Providers")
            {
                var webRequest = (HttpWebRequest)WebRequest.Create(url);
                var webResponse = (HttpWebResponse)webRequest.GetResponse();

                if ((webResponse.StatusCode == HttpStatusCode.OK))
                {
                    var reader = new StreamReader(webResponse.GetResponseStream());
                    string s = reader.ReadToEnd();
                    var arr = JsonConvert.DeserializeObject<List<ProviderDTO>>(s);
                    var list = new BindingList<ProviderDTO>(arr);
                    var data = new BindingSource(list, null);
                    comboBox_fournisseur.DataSource = data.DataSource;
                    comboBox_fournisseur.DisplayMember = "Name";
                    comboBox_fournisseur.ValueMember = "Name";

                }
                else
                {
                    MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
                }
            }
        }
        private void appel_Api(string url)
        {
            ClientDTO clientDto = new ClientDTO();

            if (url == "https://localhost:44319/api/Users")
            {
                
                var webRequest = (HttpWebRequest)WebRequest.Create(url);
                var webResponse = (HttpWebResponse)webRequest.GetResponse();

                if ((webResponse.StatusCode == HttpStatusCode.OK))
                {
                    var reader = new StreamReader(webResponse.GetResponseStream());
                    string s = reader.ReadToEnd();
                    var arr = JsonConvert.DeserializeObject<List<ClientDTO>>(s);
                    var list = new BindingList<ClientDTO>(arr);
                    var data = new BindingSource(list, null);

                    dataGridView_Client.DataSource = data;
                    

                }
                else
                {
                    MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
                }
            }
            else if (url == "https://localhost:44319/api/Articles")
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
                    dataGridView_Article.DataSource = data;

                }
                else
                {
                    MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
                }

            }
            else if (url == "https://localhost:44319/api/Categories")
            {
                var webRequest = (HttpWebRequest)WebRequest.Create(url);
                var webResponse = (HttpWebResponse)webRequest.GetResponse();

                if ((webResponse.StatusCode == HttpStatusCode.OK))
                {
                    var reader = new StreamReader(webResponse.GetResponseStream());
                    string s = reader.ReadToEnd();
                    var arr = JsonConvert.DeserializeObject<List<CategorieDTO>>(s);
                    var list = new BindingList<CategorieDTO>(arr);
                    var data = new BindingSource(list, null);
                    dataGridView_Categorie.DataSource = data;

                }
                else
                {
                    MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
                }
            }
            else if (url == "https://localhost:44319/api/Providers")
            {
                var webRequest = (HttpWebRequest)WebRequest.Create(url);
                var webResponse = (HttpWebResponse)webRequest.GetResponse();

                if ((webResponse.StatusCode == HttpStatusCode.OK))
                {
                    var reader = new StreamReader(webResponse.GetResponseStream());
                    string s = reader.ReadToEnd();
                    var arr = JsonConvert.DeserializeObject<List<ProviderDTO>>(s);
                    var list = new BindingList<ProviderDTO>(arr);
                    var data = new BindingSource(list, null);
                    dataGridView_Fournisseur.DataSource = data;

                }
                else
                {
                    MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
                }
            }
            else if (url == "https://localhost:44319/api/Orders")
            {
                var webRequest = (HttpWebRequest)WebRequest.Create(url);
                var webResponse = (HttpWebResponse)webRequest.GetResponse();

                if ((webResponse.StatusCode == HttpStatusCode.OK))
                {
                    var reader = new StreamReader(webResponse.GetResponseStream());
                    string s = reader.ReadToEnd();
                    var arr = JsonConvert.DeserializeObject<List<CommandeInterneDTO>>(s);
                    var list = new BindingList<CommandeInterneDTO>(arr);
                    var data = new BindingSource(list, null);
                    dataGridView_Commande.DataSource = data;

                }
                else
                {
                    MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
                }

            }
            else if (url == "https://localhost:44319/api/Stocks")
            {
                var webRequest = (HttpWebRequest)WebRequest.Create(url);
                var webResponse = (HttpWebResponse)webRequest.GetResponse();

                if ((webResponse.StatusCode == HttpStatusCode.OK))
                {
                    var reader = new StreamReader(webResponse.GetResponseStream());
                    string s = reader.ReadToEnd();
                    var arr = JsonConvert.DeserializeObject<List<StockDTO>>(s);
                    var list = new BindingList<StockDTO>(arr);
                    var data = new BindingSource(list, null);
                    dataGridView_Stock.DataSource = data;

                }
                else
                {
                    MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
                }
            }
        }
        //Boutons ajout
        private void btn_addClient_Click(object sender, EventArgs e)
        {
            this.AjoutClient.Show();
        }

        private void btn_addCommande_Click(object sender, EventArgs e)
        {
            this.AjoutCommande.Show();
        }

        private void btn_addCategorie_Click(object sender, EventArgs e)
        {
            this.AjoutCategorie.Show();
        }

        //Bouton reload
        private void button_LoadArticle_Click(object sender, EventArgs e)
        {
            appel_Api("https://localhost:44319/api/Articles");
            this.dataGridView_Article.Columns["IsActive"].Visible = false;
        }

        private void btn_LoadFournisseur_Click(object sender, EventArgs e)
        {
            this.appel_Api("https://localhost:44319/api/Providers");
        }

        private void btn_addFournisseur_Click(object sender, EventArgs e)
        {
            this.AjoutFournisseur.Show();
        }

        private void btn_LoadCommandeInterne_Click(object sender, EventArgs e)
        {
            appel_Api("https://localhost:44319/api/Orders");
        }

        private void button_AddArticle_Click(object sender, EventArgs e)
        {
            this.AjoutArticle.Show();
        }

        private void textBox_nameArticle_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_LoadCategorie_Click(object sender, EventArgs e)
        {
            appel_Api("https://localhost:44319/api/Categories");
        }
        private void btn_LoadStock_Click(object sender, EventArgs e)
        {
            appel_Api("https://localhost:44319/api/Stocks");
        }
        private void button10_Click(object sender, EventArgs e)
        {
            appel_Api("https://localhost:44319/api/Users");
        }

        //Bouton Delete
        private void btn_DeleteClient_Click(object sender, EventArgs e)
        {
            if (dataGridView_Client.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_Client.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView_Client.Rows[selectedrowindex];

                idClient = Convert.ToString(selectedRow.Cells["Id"].Value);
                firstNameClient = Convert.ToString(selectedRow.Cells["FirstName"].Value);
                lastNameClient = Convert.ToString(selectedRow.Cells["LastName"].Value);
                EmailClient = Convert.ToString(selectedRow.Cells["Email"].Value);
                AdresseClient = Convert.ToString(selectedRow.Cells["Address"].Value);
                TelClient = Convert.ToString(selectedRow.Cells["PhoneNumber"].Value);
                IsActive = Convert.ToString(selectedRow.Cells["isActive"].Value);


            }

            string url = "https://localhost:44319/api/Users/" + idClient;
            string requestParams = JsonClientSuppr();

            webRequest = (HttpWebRequest)WebRequest.Create(url);

            webRequest.Method = "PUT";
            webRequest.ContentType = "application/json";

            byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
            webRequest.ContentLength = byteArray.Length;
            using (Stream requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(byteArray, 0, byteArray.Length);
            }
            MessageBox.Show("Vous avez suppprimé " + lastNameClient);
            appel_Api("https://localhost:44319/api/Users");
        }

        private void btn_DeleteFournisseur_Click(object sender, EventArgs e)
        {
            if (dataGridView_Fournisseur.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_Fournisseur.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView_Fournisseur.Rows[selectedrowindex];

                idFournisseur = Convert.ToString(selectedRow.Cells["Id"].Value);
                nomFournisseur = Convert.ToString(selectedRow.Cells["Name"].Value);
                adresseFournisseur = Convert.ToString(selectedRow.Cells["Address"].Value);
                mailFournisseur = Convert.ToString(selectedRow.Cells["Email"].Value);
                telFournisseur = Convert.ToString(selectedRow.Cells["PhoneNumber"].Value);
                IsActive = Convert.ToString(selectedRow.Cells["IsActive"].Value);
            }

            string url = "https://localhost:44319/api/Providers/" + idFournisseur;
            string requestParams = JsonFournisseurSuppr();

            webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Method = "PUT";
            webRequest.ContentType = "application/json";

            byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
            webRequest.ContentLength = byteArray.Length;
            using (Stream requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(byteArray, 0, byteArray.Length);
            }
            MessageBox.Show("Vous avez suppprimé " + nomFournisseur);
            appel_Api("https://localhost:44319/api/Providers");
        }

        private void button_DeleteArticle_Click(object sender, EventArgs e)
        {
            if (dataGridView_Article.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_Article.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView_Article.Rows[selectedrowindex];

                id = Convert.ToString(selectedRow.Cells["Id"].Value);
                idCategorie = Convert.ToString(selectedRow.Cells["idCatégorie"].Value);
                nameArticle = Convert.ToString(selectedRow.Cells["Nom"].Value);
                prixArticle = Convert.ToString(selectedRow.Cells["Prix"].Value);
                prixFournisseurArticle = Convert.ToString(selectedRow.Cells["Prix fournisseur"].Value);
                descriptionArticle = Convert.ToString(selectedRow.Cells["Description"].Value);
                domaineArticle = Convert.ToString(selectedRow.Cells["Domaine"].Value);
                imgUrlArticle = Convert.ToString(selectedRow.Cells["ImgUrl"].Value);
                volumeArticle = Convert.ToString(selectedRow.Cells["Volume"].Value);
                IsActive = Convert.ToString(selectedRow.Cells["IsActive"].Value);
                commandeAuto = Convert.ToString(selectedRow.Cells["commandeAuto"].Value);
            }

            string url = "https://localhost:44319/api/Articles/" + id;

            string requestParams = JsonArticleSuppr();

            webRequest = (HttpWebRequest)WebRequest.Create(url);

            webRequest.Method = "PUT";
            webRequest.ContentType = "application/json";

            byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
            webRequest.ContentLength = byteArray.Length;
            using (Stream requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(byteArray, 0, byteArray.Length);
            }

            MessageBox.Show("Vous avez suppprimé " + nameArticle);
            appel_Api("https://localhost:44319/api/Articles");
        }

        //Bouton Edit
        private void button_Modif_Client_Click(object sender, EventArgs e)
        {
            if (dataGridView_Client.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_Client.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView_Client.Rows[selectedrowindex];

                idClient = Convert.ToString(selectedRow.Cells["Id"].Value);
                firstNameClient = Convert.ToString(selectedRow.Cells["Prénom"].Value);
                lastNameClient = Convert.ToString(selectedRow.Cells["Nom"].Value);
                EmailClient = Convert.ToString(selectedRow.Cells["Mail"].Value);
                AdresseClient = Convert.ToString(selectedRow.Cells["Adresse"].Value);
                TelClient = Convert.ToString(selectedRow.Cells["Tel"].Value);
                IsActive = Convert.ToString(selectedRow.Cells["IsActive"].Value);


            }

            string url = "https://localhost:44319/api/Users/" + idClient;
            string requestParams = JsonClientEdit();

            webRequest = (HttpWebRequest)WebRequest.Create(url);

            webRequest.Method = "PUT";
            webRequest.ContentType = "application/json";

            byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
            webRequest.ContentLength = byteArray.Length;
            using (Stream requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(byteArray, 0, byteArray.Length);
            }
        }

        private void btn_EditStock_Click(object sender, EventArgs e)
        {
            if (dataGridView_Stock.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_Stock.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView_Stock.Rows[selectedrowindex];

                idStock = Convert.ToString(selectedRow.Cells["id"].Value);
                idArticleStock = Convert.ToString(selectedRow.Cells["idArticle"].Value);
                quantiteStock = Convert.ToString(selectedRow.Cells["Quantité"].Value);
                quantiteStockCommande = Convert.ToString(selectedRow.Cells["Quantite Commande"].Value);

            }

            string url = "https://localhost:44319/api/Stocks/" + idStock;
            string requestParams = JsonStockEdit();

            webRequest = (HttpWebRequest)WebRequest.Create(url);

            webRequest.Method = "PUT";
            webRequest.ContentType = "application/json";

            byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
            webRequest.ContentLength = byteArray.Length;
            using (Stream requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(byteArray, 0, byteArray.Length);
            }
        }

        private void btn_EditFournisseur_Click(object sender, EventArgs e)
        {
            if (dataGridView_Fournisseur.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_Fournisseur.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView_Fournisseur.Rows[selectedrowindex];

                idFournisseur = Convert.ToString(selectedRow.Cells["Id"].Value);
                nomFournisseur = Convert.ToString(selectedRow.Cells["Name"].Value);
                adresseFournisseur = Convert.ToString(selectedRow.Cells["Address"].Value);
                mailFournisseur = Convert.ToString(selectedRow.Cells["Email"].Value);
                telFournisseur = Convert.ToString(selectedRow.Cells["PhoneNumber"].Value);
                IsActive = Convert.ToString(selectedRow.Cells["IsActive"].Value);
            }

            string url = "https://localhost:44319/api/Providers/" + idFournisseur;
            string requestParams = JsonFournisseurEdit();

            webRequest = (HttpWebRequest)WebRequest.Create(url);

            webRequest.Method = "PUT";
            webRequest.ContentType = "application/json";

            byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
            webRequest.ContentLength = byteArray.Length;
            using (Stream requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(byteArray, 0, byteArray.Length);
            }
        }

        private void btn_EditCategorie_Click(object sender, EventArgs e)
        {
            if (dataGridView_Categorie.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_Categorie.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView_Categorie.Rows[selectedrowindex];

                id = Convert.ToString(selectedRow.Cells["Id"].Value);
                Name = Convert.ToString(selectedRow.Cells["Name"].Value);
                IsActive = Convert.ToString(selectedRow.Cells["IsActive"].Value);

            }

            string url = "https://localhost:44319/api/Categories/" + id;
            string requestParams = JsonCategorieEdit();

            webRequest = (HttpWebRequest)WebRequest.Create(url);

            webRequest.Method = "PUT";
            webRequest.ContentType = "application/json";

            byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
            webRequest.ContentLength = byteArray.Length;
            using (Stream requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(byteArray, 0, byteArray.Length);
            }
        }

        private void btn_EditCommandeFournisseur_Click(object sender, EventArgs e)
        {
            if (dataGridView_Commande.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_Commande.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView_Commande.Rows[selectedrowindex];

                idCommandeFournisseur = Convert.ToString(selectedRow.Cells["id"].Value);
                prixTotalCommande = Convert.ToString(selectedRow.Cells["Prix Total"].Value);
                dateCommandeEdit = Convert.ToString(selectedRow.Cells["Date Commande"].Value);
                statutCommande = Convert.ToString(selectedRow.Cells["Statut"].Value);
            }

            string url = "https://localhost:44319/api/Orders/" + idCommandeFournisseur;
            webRequest = (HttpWebRequest)WebRequest.Create(url);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();

            if ((webResponse.StatusCode == HttpStatusCode.OK))
            {
                var reader = new StreamReader(webResponse.GetResponseStream());
                string s = reader.ReadToEnd();
                var arrStock = JsonConvert.DeserializeObject<CommandeInterneDTO>(s);
                oldStatus = arrStock.statut;
            }

            url = "https://localhost:44319/api/Orders/" + idCommandeFournisseur;
            string requestParams = JsonCommandeEdit();

            webRequest = (HttpWebRequest)WebRequest.Create(url);

            webRequest.Method = "PUT";
            webRequest.ContentType = "application/json";

            byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
            webRequest.ContentLength = byteArray.Length;
            using (Stream requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(byteArray, 0, byteArray.Length);
            }

            if (statutCommande == "Livré" && oldStatus != "Livré")
            {
                // on rucupère la liste des produits et leurs stocks
                url = "https://localhost:44319/api/Stocks";
                webRequest = (HttpWebRequest)WebRequest.Create(url);
                webResponse = (HttpWebResponse)webRequest.GetResponse();

                if ((webResponse.StatusCode == HttpStatusCode.OK))
                {
                    var reader = new StreamReader(webResponse.GetResponseStream());
                    string s = reader.ReadToEnd();
                    var arrStock = JsonConvert.DeserializeObject<List<StockDTO>>(s);

                    var allStockId = from r in arrStock
                                     orderby r.Id
                                     select r;
                    url = "https://localhost:44319/api/OrdersProduit/";
                    webRequest = (HttpWebRequest)WebRequest.Create(url);
                    webResponse = (HttpWebResponse)webRequest.GetResponse();

                    if ((webResponse.StatusCode == HttpStatusCode.OK))
                    {
                        reader = new StreamReader(webResponse.GetResponseStream());
                        s = reader.ReadToEnd();
                        var arrProduitCommande = JsonConvert.DeserializeObject<List<CommandeInterneArticleDTO>>(s);

                        var allCommandeInterneProduitsId = from r in arrProduitCommande
                                                           orderby r.idCommandeInterne
                                                           select r;

                        // Mise a jours du stock commandé sur le produit
                        foreach (var stdStock in allStockId)
                        {
                            foreach (var stdCommande in allCommandeInterneProduitsId)
                            {
                                if (stdStock.IdArticle == stdCommande.idCommandeInterne && stdCommande.idCommandeInterne.ToString() == idCommandeFournisseur)
                                {
                                    var idStock = stdStock.Id;
                                    url = "https://localhost:44319/api/Stocks/" + idStock.ToString();
                                    JavaScriptSerializer ser = new JavaScriptSerializer();
                                    var jsonData = new StockDTO()
                                    {
                                        Id = idStock,
                                        IdArticle = (int)stdCommande.idArticle,
                                        Quantity = stdStock.Quantity + stdCommande.Quantity,
                                        QuantityCommande = stdStock.QuantityCommande - stdCommande.Quantity,

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
                }
            }
        }
        private void btn_EditArticle_Click(object sender, EventArgs e)
        {
            if (dataGridView_Article.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_Article.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView_Article.Rows[selectedrowindex];

                id = Convert.ToString(selectedRow.Cells["Id"].Value);
                idCategorie = Convert.ToString(selectedRow.Cells["idFamille"].Value);
                nameArticle = Convert.ToString(selectedRow.Cells["Nom"].Value);
                prixArticle = Convert.ToString(selectedRow.Cells["Prix"].Value);
                prixFournisseurArticle = Convert.ToString(selectedRow.Cells["Prix Fournisseur"].Value);
                descriptionArticle = Convert.ToString(selectedRow.Cells["Description"].Value);
                domaineArticle = Convert.ToString(selectedRow.Cells["Domaine"].Value);
                imgUrlArticle = Convert.ToString(selectedRow.Cells["ImgUrl"].Value);
                volumeArticle = Convert.ToString(selectedRow.Cells["Volume"].Value);
                IsActive = Convert.ToString(selectedRow.Cells["IsActive"].Value);
                commandeAuto = Convert.ToString(selectedRow.Cells["commandeAuto"].Value);
            }

            string url = "https://localhost:44319/api/Articles/" + id;
            string requestParams = JsonArticleEdit();

            webRequest = (HttpWebRequest)WebRequest.Create(url);

            webRequest.Method = "PUT";
            webRequest.ContentType = "application/json";

            byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
            webRequest.ContentLength = byteArray.Length;
            using (Stream requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(byteArray, 0, byteArray.Length);
            }
        }

        //Json Delete
        public string JsonClientSuppr()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();

            var jsonData = new ClientDTO()
            {
                Id = (int)Convert.ToInt64(idClient),
                FirstName = firstNameClient,
                LastName = lastNameClient,
                Email = EmailClient,
                Address = AdresseClient,
                PhoneNumber = TelClient,
                isActive = bool.Parse("false"),
            };

            var result = ser.Serialize(jsonData);
            return result;
        }

        public string JsonArticleSuppr()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();

            var jsonData = new ArticleDTO()
            {
                Id = (int)Convert.ToInt64(id),
                IdCategorie = (int)Convert.ToInt64(idCategorie),
                Name = nameArticle,
                Description = descriptionArticle,
                Domaine = domaineArticle,
                ImgUrl = imgUrlArticle,
                Volume = volumeArticle,
                isActive = bool.Parse(IsActive),
                commandeAuto = bool.Parse(commandeAuto),

            };

            var result = ser.Serialize(jsonData);
            return result;
        }

        public string JsonCategorieSuppr()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();

            var jsonData = new CategorieDTO()
            {
                Id = (int)Convert.ToInt64(id),
                Name = Name,
                isActive = bool.Parse("false"),

            };

            var result = ser.Serialize(jsonData);
            return result;
        }

        public string JsonFournisseurSuppr()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();
            var jsonData = new ProviderDTO()
            {
                Id = (int)Convert.ToInt64(idFournisseur),
                Name = nomFournisseur,
                Email = mailFournisseur,
                Address = adresseFournisseur,
                PhoneNumber = telFournisseur,
                isActive = bool.Parse("false"),
            };

            var result = ser.Serialize(jsonData);
            return result;
        }

        //Json Edit
        public string JsonFournisseurEdit()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();

            var jsonData = new ProviderDTO()
            {
                Id = (int)Convert.ToInt64(idFournisseur),
                Name = nomFournisseur,
                Email = mailFournisseur,
                Address = adresseFournisseur,
                PhoneNumber = telFournisseur,
                isActive = bool.Parse(IsActive),
            };

            var result = ser.Serialize(jsonData);
            return result;
        }
        public string JsonClientEdit()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();

            var jsonData = new ClientDTO()
            {
                Id = (int)Convert.ToInt64(idClient),
                FirstName = firstNameClient,
                LastName = lastNameClient,
                Email = EmailClient,
                Address = AdresseClient,
                PhoneNumber = TelClient,
                isActive = bool.Parse(IsActive),
            };

            var result = ser.Serialize(jsonData);
            return result;
        }
        public string JsonArticleEdit()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();

            var jsonData = new ArticleDTO()
            {
                Id = (int)Convert.ToInt64(id),
                IdCategorie = (int)Convert.ToInt64(idCategorie),
                Name = nameArticle,
                Description = descriptionArticle,
                Domaine = domaineArticle,
                ImgUrl = imgUrlArticle,
                Volume = volumeArticle,

                isActive = bool.Parse(IsActive),
                commandeAuto = bool.Parse(commandeAuto),

            };

            var result = ser.Serialize(jsonData);
            return result;
        }
        public string JsonCategorieEdit()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();

            var jsonData = new CategorieDTO()
            {
                Id = (int)Convert.ToInt64(id),
                Name = Name,
                isActive = bool.Parse(IsActive),

            };

            var result = ser.Serialize(jsonData);
            return result;
        }
        public string JsonStockEdit()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();

            var jsonData = new StockDTO()
            {
                Id = (int)Convert.ToInt64(idStock),
                IdArticle = (int)Convert.ToInt64(idArticleStock),
                Quantity = Convert.ToInt32(quantiteStock),
                QuantityCommande = Convert.ToInt32(quantiteStockCommande),

            };

            var result = ser.Serialize(jsonData);
            return result;
        }
        public string JsonCommandeEdit()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();

            var jsonData = new CommandeInterneDTO()
            {
                id = Convert.ToInt64(idCommandeFournisseur),
                prixTotal = Convert.ToInt32(prixTotalCommande),
                dateCommande = dateCommandeEdit,
                statut = statutCommande,
                isActive = true
            };

            var result = ser.Serialize(jsonData);
            return result;
        }
    }
}
