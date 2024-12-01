using Newtonsoft.Json;
using SteamMetadata.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SteamMetadata
{
    internal class GameData
    {
        private const string STEAM_ENDPOINT = "https://cdn.cloudflare.steamstatic.com/steam/apps/";
        /*
         * Hero: https://cdn.cloudflare.steamstatic.com/steam/apps/<appid>/library_hero_2x.jpg || https://cdn.cloudflare.steamstatic.com/steam/apps/<appid>/library_hero.jpg
         * Logo https://cdn.cloudflare.steamstatic.com/steam/apps/<appid>/logo_2x.png || https://cdn.cloudflare.steamstatic.com/steam/apps/<appid>/logo.png
         * Capsule: https://cdn.cloudflare.steamstatic.com/steam/apps/<appid>/library_600x900_2x.jpg || https://cdn.cloudflare.steamstatic.com/steam/apps/<appid>/library_600x900.jpg
         */
        [JsonProperty("name")]
        public string Name { get; }
        [JsonProperty("appid")]
        public int AppID { get; }

        public HttpClient Downloader { private get; set; }

        public GameData(string name, int appID)
        {
            this.Name = name;
            this.AppID = appID;
        }

        public Image GetCapsule() => throw new NotImplementedException();
        private Image _header = null;
        public Image GetHeader
        {
            get
            {
                if(_header != null) return _header;
                HttpResponseMessage result = Downloader.SendAsync(new HttpRequestMessage(HttpMethod.Get, $"{STEAM_ENDPOINT}{AppID}/header.jpg")).Result;
                if (!result.IsSuccessStatusCode) return Resources.NotFound;
                using (Stream imageData = result.Content.ReadAsStreamAsync().Result) _header = new Bitmap(imageData);
                return _header;
                
            }
        }
        public Image GetHero() => throw new NotImplementedException();
        public Image GetLogo() => throw new NotImplementedException();
    }
}
