using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text.Json;
using System.Net;
using System.Net.Http;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace SteamMetadata
{
    public partial class GUI : Form
    {
        private const string STEAM_DB_URL = "https://api.steampowered.com/ISteamApps/GetAppList/v0002/";
        private GameData[] gameDatabase;

        public GUI()
        {
            InitializeComponent();
            this.Load += GUI_Load;
            this.searchTbx.TextChanged += UpdateList;
            findBtn.Click += SelectGame;
            browseBtn.Click += ChooseDirectory;
            dwnBtn.Click += DownloadMetadata;
        }

        public HttpClient Downloader { get; private set; }

        private void GUI_Load(object sender, EventArgs e)
        {
            Downloader = new HttpClient();
            HttpResponseMessage response = Downloader.SendAsync(new HttpRequestMessage(HttpMethod.Get, STEAM_DB_URL)).Result;
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Unable to get data from Steam servers", Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            gameDatabase = JsonConvert.DeserializeObject<GameData[]>(JsonDocument.Parse(response.Content.ReadAsStringAsync().Result).RootElement.GetProperty("applist").GetProperty("apps").ToString());
            foreach (GameData game in gameDatabase) game.Downloader = this.Downloader;
        }
        private void UpdateList(object sender, EventArgs e)
        {
            string match = searchTbx.Text.ToLower();
            gameList.Items.Clear();
            if (string.IsNullOrWhiteSpace(match)) return;
            GameData[] foundGames = gameDatabase.Where(x => x.Name.ToLower().StartsWith(match)).Union(gameDatabase.Where(x => x.Name.ToLower().Contains(match))).Take(5).ToArray();
            ImageList currentImages = new ImageList
            {
                ImageSize = new Size(106, 50)
            };
            gameList.SmallImageList = currentImages;
            for (int i = 0; i < foundGames.Length; i++)
            {
                currentImages.Images.Add(foundGames[i].GetHeader);
                string[] items = { "", foundGames[i].Name };
                gameList.Items.Add(new ListViewItem(items, i));
            }
        }
        private void SelectGame(object sender, EventArgs e)
        {

        }
        private void ChooseDirectory(object sender, EventArgs e)
        {
            if (outputFolderDialog.ShowDialog() == DialogResult.OK)
            {
                pathTbx.Text = outputFolderDialog.SelectedPath;
            }
        }
        private void DownloadMetadata(object sender, EventArgs e) => throw new NotImplementedException();
    }
}
