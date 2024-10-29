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
    public partial class _Contact : System.Web.UI.Page
    {
        
        protected async void Perritos(object sender, EventArgs e)
        {
            string imageUr1 = await Imagenaleatoria();
            IDperritosapiimg.ImageUrl = imageUr1;
        }

        private async Task<string> Imagenaleatoria()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://dog.ceo/api/breeds/image/random");

                if (response.IsSuccessStatusCode)
                {
                    string jsonResult = await response.Content.ReadAsStringAsync();
                    JObject json = JObject.Parse(jsonResult);
                    return json["message"].ToString();
                }
                else
                {
                    return "Error al obtener la imagen.";
                }
            }
        }

    }
}