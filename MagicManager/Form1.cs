using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace MagicManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CardDB cards = JsonConvert.DeserializeObject<CardDB>(File.ReadAllText(@"C:\AllCards.json"));

            Console.WriteLine();
        }

        private void setListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cardListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
