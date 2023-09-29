using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;
using static pogoda.Form1;

namespace pogoda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private async void button1_Click(object sender, EventArgs e)
        {
            PogodaJson pogodaJson = new PogodaJson();
            string latitude = textBox1.Text;
            string longtitude = textBox2.Text;
            string urlWhatNeeded = $"https://api.openweathermap.org/data/2.5/weather?lat={latitude}&lon={longtitude}&units=metric&appid=6c249bb0a53a073c7839c3a8b77bd19a";
            HttpWebRequest request = WebRequest.Create(urlWhatNeeded) as HttpWebRequest;
            HttpWebResponse Httpresponse = (HttpWebResponse)request.GetResponse();
            string response;
            using (StreamReader stream = new StreamReader(Httpresponse.GetResponseStream()))
            {
                response =  stream.ReadToEnd();
            }

            pogodaJson = JsonConvert.DeserializeObject<PogodaJson>(response);
            tempLabel.Text = pogodaJson.Main.Temp;
            CityNameLabel.Text = pogodaJson.Name;
            WindSpeedLabeJson.Text = pogodaJson.Wind.Speed;
            label7.Text = pogodaJson.Clouds.All + "%";
            if (pogodaJson.Clouds.All <= 10)
            {
                using (FileStream stream = File.Open("C:\\Users\\user\\source\\repos\\pogoda\\PogodaImage\\солнышко.PNG", FileMode.Open))
                {
                    Image image = System.Drawing.Image.FromStream(stream);
                    pictureBox1.Image = image;
                }
            }
            if (pogodaJson.Clouds.All <= 30)
            {
                using (FileStream stream = File.Open("C:\\Users\\user\\source\\repos\\pogoda\\PogodaImage\\проста€ тучка.PNG", FileMode.Open))
                {
                    Image image = System.Drawing.Image.FromStream(stream);
                    pictureBox1.Image = image;
                }
            }
            if (pogodaJson.Clouds.All <= 50)
            {
                using (FileStream stream = File.Open("C:\\Users\\user\\source\\repos\\pogoda\\PogodaImage\\наполовину €сно на половину нет.PNG", FileMode.Open))
                {
                    Image image = System.Drawing.Image.FromStream(stream);
                    pictureBox1.Image = image;
                }

            }
            if (pogodaJson.Clouds.All <= 50)
            {
                using (FileStream stream = File.Open("C:\\Users\\user\\source\\repos\\pogoda\\PogodaImage\\просто серые тучи.PNG", FileMode.Open))
                {
                    Image image = System.Drawing.Image.FromStream(stream);
                    pictureBox1.Image = image;
                }
            }
        }

        public class PogodaJson
        {
            public TemperatureInfo Main { get; set; }
            public string Name { get; set; }
            public CloudsInfo Clouds { get; set; }
            public TemperatureInfo Wind { get; set; }
        }

        public class TemperatureInfo
        {
            public string Temp { get; set; }
            public string Speed { get; set; }


        }
        public class CloudsInfo
        {
            public int All { get; set; }
        }




        private void linkLabel1_MouseEnter(object sender, EventArgs e)
        {
            linkLabel1.LinkColor = Color.Gray;
        }

        private void linkLabel1_MouseLeave(object sender, EventArgs e)
        {
            linkLabel1.LinkColor = Color.Black;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            string url = "https://time-in.ru/coordinates";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {

                var message = MessageBox.Show("ќшибка при открытии URL: " + ex.Message);
                message = (DialogResult)MessageBoxIcon.Error;

            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            tempLabel.Text = "";
            CityNameLabel.Text = "";
            WindSpeedLabeJson.Text = "";
            label7.Text =  "";
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}