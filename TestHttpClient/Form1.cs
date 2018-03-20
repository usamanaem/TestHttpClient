using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml;

namespace TestHttpClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Task.Run(async () => { await GetCountryList(); }

                ).Wait();


            BindProviderType();
        }

        private void BindProviderType()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Value", typeof(string));

            dt.Rows.Add("Hospitals", "HOSPITALS");
            dt.Rows.Add("Doctors and Health Practitioners", "PRACTITIONERS");
            ddlProviderType.DisplayMember = "Title";
            ddlProviderType.ValueMember = "Value";
            ddlProviderType.DataSource = dt;

        }

        private void btnGetProviders_Click(object sender, EventArgs e)
        {
            GetProvidersList();

        }

        private void GetProvidersList()
        {
            string urlValue = ddlCountry.SelectedValue.ToString();
            string Country = ddlCountry.Text;
            string cityValue = ddlCity.SelectedValue.ToString();
            string ProvidrTypeValue = ddlProviderType.SelectedValue.ToString();
            string URLVal = "https://apps.allianzworldwidecare.com/poi/hospital-doctor-and-health-practitioner-finder?TRANS=Hospitals%2C+Doctors+and+Health+Practitioners+in+" + cityValue + "%2C" + Country + "&CON=World&COUNTRY=" + Country + "&CITY=" + cityValue + "&PROVTYPE=" + ProvidrTypeValue;

            // string url = "https://apps.allianzworldwidecare.com/poi/" + HttpUtility.HtmlDecode(urlValue) + "&City=" + cityValue + "&PROVTYPE=" + ProvidrTypeValue;


            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(URLVal);




            HtmlAgilityPack.HtmlNodeCollection ProviderListNodes = doc.DocumentNode.SelectNodes("//table[@class='table']");
            lstValues.Items.Clear();

            foreach (var node in ProviderListNodes)
            {
                lstValues.Items.Add(HttpUtility.HtmlDecode(node.ChildNodes[1].InnerText.Trim()));
            }
        }

        private async Task GetCountryList()
        {
            string url = "https://apps.allianzworldwidecare.com/poi/hospital-doctor-and-health-practitioner-finder?TRANS=Hospitals%2C+Doctors+and+Health+Practitioners+in+Qatar";

            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);
            HtmlAgilityPack.HtmlNodeCollection countriesNode = doc.DocumentNode.SelectNodes("//a[@class='blocking-ui btn-link zero_left_margin']");

            ddlCountry.Items.Clear();
            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Url", typeof(string));
            foreach (var country in countriesNode)
            {
                dt.Rows.Add(country.InnerText, country.Attributes["href"].Value);
            }

            ddlCountry.ValueMember = "Url";
            ddlCountry.DisplayMember = "Name";
            ddlCountry.DataSource = dt;

        }
        private async Task GetCity(string urlValue)
        {
            string url = "https://apps.allianzworldwidecare.com/poi/" + HttpUtility.HtmlDecode(urlValue);


            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);




            HtmlAgilityPack.HtmlNode cityNode = doc.DocumentNode.SelectSingleNode("//select[@id='city']");
            var CityList = cityNode.ChildNodes.Where(e => e.Name == "option");

            DataTable dt = new DataTable();
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Value", typeof(string));

            foreach (var city in CityList)
            {

                dt.Rows.Add(city.InnerText, city.InnerText);
            }
            ddlCity.DisplayMember = "Title";
            ddlCity.ValueMember = "Value";
            ddlCity.DataSource = dt;
            ddlCity.SelectedIndex = 0;

        }

        private async void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            var url = ddlCountry.SelectedValue;
            await GetCity(url.ToString());


        }

    }
}
