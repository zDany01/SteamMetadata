using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamMetadata
{
    internal class GameData
    {
        [JsonProperty("name")]
        public string Name { get; }
        [JsonProperty("appid")]
        public int AppID { get; }

        public GameData(string name, int appID)
        {
            this.Name = name;
            this.AppID = appID;
        }

        public Image GetCapsule() => throw new NotImplementedException();
        public Image GetHero() => throw new NotImplementedException();
        public Image GetLogo() => throw new NotImplementedException();
    }
}
