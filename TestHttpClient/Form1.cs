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
            GetCountryList();

        }

        private void btnGetProviders_Click(object sender, EventArgs e)
        {


        }
        private void GetCountryList()
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
        private void GetCity(string urlValue)
        {
            string url = "https://apps.allianzworldwidecare.com/poi/" +HttpUtility.HtmlDecode( urlValue);

           
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);

            ddlCity.Items.Clear();


            HtmlAgilityPack.HtmlNode cityNode = doc.DocumentNode.SelectSingleNode("//select[@id='city']");
            var CityList = cityNode.ChildNodes.Where(e => e.Name == "option");

            foreach (var city in CityList)
            {

                ddlCity.Items.Add(city.InnerText);
            }
            ddlCity.SelectedIndex = 0;

        }

        private void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            var url = ddlCountry.SelectedValue;
            GetCity(url.ToString());


        }
    }
}
