using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.UI;
using Newtonsoft.Json.Linq;


namespace UsodeApi
{
    public partial class _Default : System.Web.UI.Page
    {
        
        protected async void BotonBrom(object sender, EventArgs e)
        {
            string broma = await ObtenerBroma();
            Bromalb.Text = broma;
        }
        static async Task<string> ObtenerBroma()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://v2.jokeapi.dev/joke/Programming,Spooky,Christmas?lang=es&blacklistFlags=nsfw,religious,political,racist,sexist,explicit\r\n");

                if (response.IsSuccessStatusCode)
                {
                    string jsonResult = await response.Content.ReadAsStringAsync();
                    JObject json = JObject.Parse(jsonResult);

                    if ((string)json["type"] == "single")
                    {
                        return json["joke"].ToString();
                    }
                    else if ((string)json["type"] == "twopart")
                    {
                        return $"{json["setup"]} - {json["delivery"]}";
                    }

                }
                return "No hay más bromaaas! Intenta de nuevo.";
            }
        }
    }
}