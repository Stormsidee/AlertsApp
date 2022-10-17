using System;
using System.Linq;
using Xamarin.Essentials;

using HtmlAgilityPack;
using AlertsApp.Data;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AlertsApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlertsPage : ContentPage
    {
        public AlertsList al = new AlertsList();
        public Label helloText = new Label();

        public AlertsPage()
        {
            InitializeComponent();
            Hello();
            BackgroundImageSource = "background.jpg";

        }


        private void Parser()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(al.url);
            HtmlNodeCollection _vb = doc.DocumentNode.SelectNodes("//div[@class='mission-entry']//div[@class='mission-icon']//div[@class='mission-reward-item ']");
            HtmlNodeCollection _power = doc.DocumentNode.SelectNodes("//div[@class='special-overview']//div[@class='mission-pl']");
            HtmlNodeCollection _mission = doc.DocumentNode.SelectNodes("//div[@class='mission-details']//div[@class='mission-overview']//div[@class='mission-zone']");

            if (_vb == null) { }
            else
            {
                foreach (var itemVb in _vb)
                {
                    al.vbucks.Add(itemVb.InnerText.Trim());
                }
                foreach (var itemPwr in _power)
                {
                    al.power.Add(itemPwr.InnerText.Trim());
                }
                foreach (var itemMisson in _mission)
                {
                    al.mission.Add(itemMisson.InnerText.Trim());
                }
            }


        }
        private void Hello()
        {
            DateTime timeNow = DateTime.Now;
            DateTime timeNight = new DateTime(timeNow.Year, timeNow.Month, timeNow.Day, 0, 00, 00);
            DateTime timeMorning = new DateTime(timeNow.Year, timeNow.Month, timeNow.Day, 6, 00, 00);
            DateTime timeAfternoon = new DateTime(timeNow.Year, timeNow.Month, timeNow.Day, 12, 00, 00);
            DateTime timeEvening = new DateTime(timeNow.Year, timeNow.Month, timeNow.Day, 18, 00, 00);

            helloText.HorizontalOptions = LayoutOptions.Center;
            helloText.VerticalOptions = LayoutOptions.CenterAndExpand;
            helloText.FontSize = 25;
            helloText.Margin = 40;
            helloText.FontAttributes = FontAttributes.Bold;

            if (timeNow >= timeNight && timeNow < timeMorning)
            {
                helloText.Text = "Доброй ночи, Игорь!";

            }
            else if (timeNow >= timeMorning && timeNow < timeAfternoon)
            {
                helloText.Text = "Доброе утро, Игорь!";
            }
            else if (timeNow >= timeAfternoon && timeNow < timeEvening)
            {
                helloText.Text = "Добрый день, Игорь!";
            }
            else if (timeNow >= timeEvening)
            {
                helloText.Text = "Добрый вечер, Игорь!";
            }
            this.Content = new StackLayout { Children = { helloText, updateBtn } };
        }

 

        private void updateBtn_Clicked(object sender, EventArgs e)
        {
            var internetCheck = Connectivity.ConnectionProfiles;

            if (internetCheck.Contains(ConnectionProfile.WiFi) || internetCheck.Contains(ConnectionProfile.Cellular))
            {
                Parser();
                if(al.GetVb == null)
                {
                    al.GetList();
                }
                if (al.vbucks == null)
                {
                    DisplayAlert("Уведомление", "Алерты отсутствуют", "Ок");
                }
                else
                {


                    DisplayAlert("Алерты", $"{al.GetVb}", "Ок");


                }
            }
            else
            {
                DisplayAlert("Уведомление", "Отсутствует подключение к интернету!", "Ок");
            }

        }
    }
}
        
    
