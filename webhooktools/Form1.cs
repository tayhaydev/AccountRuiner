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

        private void whslider_Scroll(object sender, ScrollEventArgs e)
        {
            whsliderlbl.Text = whslider.Value.ToString();
        }
        
        private void nwhsendbtn_Click(object sender, EventArgs e)
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
        private void ewhsendbtn_Click(object sender, EventArgs e)
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
                            color = "000000",

                            author = new {
                                name = whauthor.Text,
                                url = whauthorlink.Text,
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

        #region delwebhook
        private void btndelwh_Click(object sender, EventArgs e)
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
