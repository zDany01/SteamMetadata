using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamMetadata
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
            findBtn.Click += FindGame;
            browseBtn.Click += ChooseDirectory;
            dwnBtn.Click += DownloadMetadata;
        }

        private void FindGame(object sender, EventArgs e) => throw new NotImplementedException();

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
