using System.Windows.Forms;

namespace Accountruiner
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        [System.Obsolete]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.esclbl = new System.Windows.Forms.Label();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.titlelbl = new MetroFramework.Controls.MetroLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.whuseragent = new MetroFramework.Controls.MetroTextBox();
            this.btndelwh = new MetroFramework.Controls.MetroButton();
            this.whfooter = new MetroFramework.Controls.MetroTextBox();
            this.whauthor = new MetroFramework.Controls.MetroTextBox();
            this.wbtitle = new MetroFramework.Controls.MetroTextBox();
            this.whdesc = new MetroFramework.Controls.MetroTextBox();
            this.ewhsendbtn = new MetroFramework.Controls.MetroButton();
            this.whavatar = new MetroFramework.Controls.MetroTextBox();
            this.whslider = new MetroFramework.Controls.MetroTrackBar();
            this.whname = new MetroFramework.Controls.MetroTextBox();
            this.whinput = new MetroFramework.Controls.MetroTextBox();
            this.whamountlbl = new MetroFramework.Controls.MetroLabel();
            this.whsliderlbl = new MetroFramework.Controls.MetroLabel();
            this.whmessage = new MetroFramework.Controls.MetroTextBox();
            this.whlbl1 = new MetroFramework.Controls.MetroLabel();
            this.nwhsendbtn = new MetroFramework.Controls.MetroButton();
            this.whlbl2 = new MetroFramework.Controls.MetroLabel();
            this.whauthorlink = new MetroFramework.Controls.MetroTextBox();
            this.whlbl3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // esclbl
            // 
            this.esclbl.BackColor = System.Drawing.Color.Transparent;
            this.esclbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.esclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esclbl.ForeColor = System.Drawing.Color.White;
            this.esclbl.Location = new System.Drawing.Point(973, 29);
            this.esclbl.Name = "esclbl";
            this.esclbl.Size = new System.Drawing.Size(20, 20);
            this.esclbl.TabIndex = 1;
            this.esclbl.Text = "X";
            this.esclbl.Click += new System.EventHandler(this.label1_Click);
            this.esclbl.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.esclbl.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // titlelbl
            // 
            this.titlelbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titlelbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.titlelbl.ForeColor = System.Drawing.Color.Transparent;
            this.titlelbl.Location = new System.Drawing.Point(16, 18);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(180, 31);
            this.titlelbl.Style = MetroFramework.MetroColorStyle.Black;
            this.titlelbl.TabIndex = 2;
            this.titlelbl.Text = "epic webhook tools";
            this.titlelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titlelbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // whuseragent
            // 
            // 
            // 
            // 
            this.whuseragent.CustomButton.Image = null;
            this.whuseragent.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.whuseragent.CustomButton.Name = "";
            this.whuseragent.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.whuseragent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.whuseragent.CustomButton.TabIndex = 1;
            this.whuseragent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.whuseragent.CustomButton.UseSelectable = true;
            this.whuseragent.CustomButton.Visible = false;
            this.whuseragent.Lines = new string[0];
            this.whuseragent.Location = new System.Drawing.Point(635, 110);
            this.whuseragent.MaxLength = 32767;
            this.whuseragent.Name = "whuseragent";
            this.whuseragent.PasswordChar = '\0';
            this.whuseragent.PromptText = "user-agent";
            this.whuseragent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.whuseragent.SelectedText = "";
            this.whuseragent.SelectionLength = 0;
            this.whuseragent.SelectionStart = 0;
            this.whuseragent.ShortcutsEnabled = true;
            this.whuseragent.Size = new System.Drawing.Size(287, 23);
            this.whuseragent.Style = MetroFramework.MetroColorStyle.Black;
            this.whuseragent.TabIndex = 95;
            this.whuseragent.Tag = "";
            this.whuseragent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.whuseragent.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.whuseragent.UseSelectable = true;
            this.whuseragent.WaterMark = "user-agent";
            this.whuseragent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.whuseragent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btndelwh
            // 
            this.btndelwh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.btndelwh.Highlight = true;
            this.btndelwh.Location = new System.Drawing.Point(635, 139);
            this.btndelwh.Name = "btndelwh";
            this.btndelwh.Size = new System.Drawing.Size(287, 23);
            this.btndelwh.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btndelwh.TabIndex = 94;
            this.btndelwh.Text = "delete webhook";
            this.btndelwh.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btndelwh.UseMnemonic = false;
            this.btndelwh.UseSelectable = true;
            this.btndelwh.Click += new System.EventHandler(this.btndelwh_Click);
            // 
            // whfooter
            // 
            // 
            // 
            // 
            this.whfooter.CustomButton.Image = null;
            this.whfooter.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.whfooter.CustomButton.Name = "";
            this.whfooter.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.whfooter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.whfooter.CustomButton.TabIndex = 1;
            this.whfooter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.whfooter.CustomButton.UseSelectable = true;
            this.whfooter.CustomButton.Visible = false;
            this.whfooter.Lines = new string[0];
            this.whfooter.Location = new System.Drawing.Point(329, 340);
            this.whfooter.MaxLength = 32767;
            this.whfooter.Name = "whfooter";
            this.whfooter.PasswordChar = '\0';
            this.whfooter.PromptText = "footer text";
            this.whfooter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.whfooter.SelectedText = "";
            this.whfooter.SelectionLength = 0;
            this.whfooter.SelectionStart = 0;
            this.whfooter.ShortcutsEnabled = true;
            this.whfooter.Size = new System.Drawing.Size(300, 23);
            this.whfooter.Style = MetroFramework.MetroColorStyle.Black;
            this.whfooter.TabIndex = 93;
            this.whfooter.Tag = "";
            this.whfooter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.whfooter.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.whfooter.UseSelectable = true;
            this.whfooter.WaterMark = "footer text";
            this.whfooter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.whfooter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // whauthor
            // 
            // 
            // 
            // 
            this.whauthor.CustomButton.Image = null;
            this.whauthor.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.whauthor.CustomButton.Name = "";
            this.whauthor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.whauthor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.whauthor.CustomButton.TabIndex = 1;
            this.whauthor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.whauthor.CustomButton.UseSelectable = true;
            this.whauthor.CustomButton.Visible = false;
            this.whauthor.Lines = new string[0];
            this.whauthor.Location = new System.Drawing.Point(329, 282);
            this.whauthor.MaxLength = 32767;
            this.whauthor.Name = "whauthor";
            this.whauthor.PasswordChar = '\0';
            this.whauthor.PromptText = "author text";
            this.whauthor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.whauthor.SelectedText = "";
            this.whauthor.SelectionLength = 0;
            this.whauthor.SelectionStart = 0;
            this.whauthor.ShortcutsEnabled = true;
            this.whauthor.Size = new System.Drawing.Size(300, 23);
            this.whauthor.Style = MetroFramework.MetroColorStyle.Black;
            this.whauthor.TabIndex = 92;
            this.whauthor.Tag = "";
            this.whauthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.whauthor.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.whauthor.UseSelectable = true;
            this.whauthor.WaterMark = "author text";
            this.whauthor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.whauthor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // wbtitle
            // 
            // 
            // 
            // 
            this.wbtitle.CustomButton.Image = null;
            this.wbtitle.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.wbtitle.CustomButton.Name = "";
            this.wbtitle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.wbtitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.wbtitle.CustomButton.TabIndex = 1;
            this.wbtitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.wbtitle.CustomButton.UseSelectable = true;
            this.wbtitle.CustomButton.Visible = false;
            this.wbtitle.Lines = new string[0];
            this.wbtitle.Location = new System.Drawing.Point(329, 110);
            this.wbtitle.MaxLength = 32767;
            this.wbtitle.Name = "wbtitle";
            this.wbtitle.PasswordChar = '\0';
            this.wbtitle.PromptText = "title";
            this.wbtitle.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.wbtitle.SelectedText = "";
            this.wbtitle.SelectionLength = 0;
            this.wbtitle.SelectionStart = 0;
            this.wbtitle.ShortcutsEnabled = true;
            this.wbtitle.Size = new System.Drawing.Size(300, 23);
            this.wbtitle.Style = MetroFramework.MetroColorStyle.Black;
            this.wbtitle.TabIndex = 91;
            this.wbtitle.Tag = "";
            this.wbtitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.wbtitle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.wbtitle.UseSelectable = true;
            this.wbtitle.WaterMark = "title";
            this.wbtitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.wbtitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // whdesc
            // 
            // 
            // 
            // 
            this.whdesc.CustomButton.Image = null;
            this.whdesc.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.whdesc.CustomButton.Name = "";
            this.whdesc.CustomButton.Size = new System.Drawing.Size(135, 135);
            this.whdesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.whdesc.CustomButton.TabIndex = 1;
            this.whdesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.whdesc.CustomButton.UseSelectable = true;
            this.whdesc.CustomButton.Visible = false;
            this.whdesc.Lines = new string[0];
            this.whdesc.Location = new System.Drawing.Point(329, 139);
            this.whdesc.MaxLength = 32767;
            this.whdesc.Multiline = true;
            this.whdesc.Name = "whdesc";
            this.whdesc.PasswordChar = '\0';
            this.whdesc.PromptText = "desc";
            this.whdesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.whdesc.SelectedText = "";
            this.whdesc.SelectionLength = 0;
            this.whdesc.SelectionStart = 0;
            this.whdesc.ShortcutsEnabled = true;
            this.whdesc.Size = new System.Drawing.Size(300, 137);
            this.whdesc.Style = MetroFramework.MetroColorStyle.Black;
            this.whdesc.TabIndex = 90;
            this.whdesc.Tag = "";
            this.whdesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.whdesc.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.whdesc.UseSelectable = true;
            this.whdesc.WaterMark = "desc";
            this.whdesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.whdesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ewhsendbtn
            // 
            this.ewhsendbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.ewhsendbtn.Highlight = true;
            this.ewhsendbtn.Location = new System.Drawing.Point(329, 369);
            this.ewhsendbtn.Name = "ewhsendbtn";
            this.ewhsendbtn.Size = new System.Drawing.Size(300, 23);
            this.ewhsendbtn.Style = MetroFramework.MetroColorStyle.Pink;
            this.ewhsendbtn.TabIndex = 89;
            this.ewhsendbtn.Text = "send embed";
            this.ewhsendbtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ewhsendbtn.UseMnemonic = false;
            this.ewhsendbtn.UseSelectable = true;
            this.ewhsendbtn.Click += new System.EventHandler(this.ewhsendbtn_Click);
            // 
            // whavatar
            // 
            // 
            // 
            // 
            this.whavatar.CustomButton.Image = null;
            this.whavatar.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.whavatar.CustomButton.Name = "";
            this.whavatar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.whavatar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.whavatar.CustomButton.TabIndex = 1;
            this.whavatar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.whavatar.CustomButton.UseSelectable = true;
            this.whavatar.CustomButton.Visible = false;
            this.whavatar.Lines = new string[] {
        "https://doggo.ninja/rFGB14.png"};
            this.whavatar.Location = new System.Drawing.Point(23, 168);
            this.whavatar.MaxLength = 32767;
            this.whavatar.Name = "whavatar";
            this.whavatar.PasswordChar = '\0';
            this.whavatar.PromptText = "avatar url";
            this.whavatar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.whavatar.SelectedText = "";
            this.whavatar.SelectionLength = 0;
            this.whavatar.SelectionStart = 0;
            this.whavatar.ShortcutsEnabled = true;
            this.whavatar.Size = new System.Drawing.Size(300, 23);
            this.whavatar.Style = MetroFramework.MetroColorStyle.Black;
            this.whavatar.TabIndex = 88;
            this.whavatar.Tag = "";
            this.whavatar.Text = "https://doggo.ninja/rFGB14.png";
            this.whavatar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.whavatar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.whavatar.UseSelectable = true;
            this.whavatar.WaterMark = "avatar url";
            this.whavatar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.whavatar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // whslider
            // 
            this.whslider.BackColor = System.Drawing.Color.Transparent;
            this.whslider.ForeColor = System.Drawing.Color.Yellow;
            this.whslider.Location = new System.Drawing.Point(23, 385);
            this.whslider.Minimum = 1;
            this.whslider.Name = "whslider";
            this.whslider.Size = new System.Drawing.Size(300, 23);
            this.whslider.Style = MetroFramework.MetroColorStyle.Pink;
            this.whslider.TabIndex = 87;
            this.whslider.Text = "metroTrackBar1";
            this.whslider.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.whslider.UseCustomBackColor = true;
            this.whslider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.whslider_Scroll);
            // 
            // whname
            // 
            // 
            // 
            // 
            this.whname.CustomButton.Image = null;
            this.whname.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.whname.CustomButton.Name = "";
            this.whname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.whname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.whname.CustomButton.TabIndex = 1;
            this.whname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.whname.CustomButton.UseSelectable = true;
            this.whname.CustomButton.Visible = false;
            this.whname.Lines = new string[0];
            this.whname.Location = new System.Drawing.Point(23, 139);
            this.whname.MaxLength = 32767;
            this.whname.Name = "whname";
            this.whname.PasswordChar = '\0';
            this.whname.PromptText = "username";
            this.whname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.whname.SelectedText = "";
            this.whname.SelectionLength = 0;
            this.whname.SelectionStart = 0;
            this.whname.ShortcutsEnabled = true;
            this.whname.Size = new System.Drawing.Size(300, 23);
            this.whname.Style = MetroFramework.MetroColorStyle.Black;
            this.whname.TabIndex = 86;
            this.whname.Tag = "";
            this.whname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.whname.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.whname.UseSelectable = true;
            this.whname.WaterMark = "username";
            this.whname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.whname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // whinput
            // 
            // 
            // 
            // 
            this.whinput.CustomButton.Image = null;
            this.whinput.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.whinput.CustomButton.Name = "";
            this.whinput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.whinput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.whinput.CustomButton.TabIndex = 1;
            this.whinput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.whinput.CustomButton.UseSelectable = true;
            this.whinput.CustomButton.Visible = false;
            this.whinput.Lines = new string[0];
            this.whinput.Location = new System.Drawing.Point(23, 110);
            this.whinput.MaxLength = 32767;
            this.whinput.Name = "whinput";
            this.whinput.PasswordChar = '\0';
            this.whinput.PromptText = "webhook";
            this.whinput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.whinput.SelectedText = "";
            this.whinput.SelectionLength = 0;
            this.whinput.SelectionStart = 0;
            this.whinput.ShortcutsEnabled = true;
            this.whinput.Size = new System.Drawing.Size(300, 23);
            this.whinput.Style = MetroFramework.MetroColorStyle.Black;
            this.whinput.TabIndex = 85;
            this.whinput.Tag = "";
            this.whinput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.whinput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.whinput.UseSelectable = true;
            this.whinput.WaterMark = "webhook";
            this.whinput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.whinput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // whamountlbl
            // 
            this.whamountlbl.BackColor = System.Drawing.Color.Transparent;
            this.whamountlbl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.whamountlbl.ForeColor = System.Drawing.Color.White;
            this.whamountlbl.Location = new System.Drawing.Point(23, 337);
            this.whamountlbl.Name = "whamountlbl";
            this.whamountlbl.Size = new System.Drawing.Size(300, 45);
            this.whamountlbl.Style = MetroFramework.MetroColorStyle.Pink;
            this.whamountlbl.TabIndex = 84;
            this.whamountlbl.Text = "amount of messages";
            this.whamountlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.whamountlbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.whamountlbl.UseCustomBackColor = true;
            this.whamountlbl.UseStyleColors = true;
            // 
            // whsliderlbl
            // 
            this.whsliderlbl.BackColor = System.Drawing.Color.Transparent;
            this.whsliderlbl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.whsliderlbl.ForeColor = System.Drawing.Color.White;
            this.whsliderlbl.Location = new System.Drawing.Point(23, 411);
            this.whsliderlbl.Name = "whsliderlbl";
            this.whsliderlbl.Size = new System.Drawing.Size(300, 26);
            this.whsliderlbl.Style = MetroFramework.MetroColorStyle.Pink;
            this.whsliderlbl.TabIndex = 83;
            this.whsliderlbl.Text = "50";
            this.whsliderlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.whsliderlbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.whsliderlbl.UseCustomBackColor = true;
            this.whsliderlbl.UseStyleColors = true;
            // 
            // whmessage
            // 
            // 
            // 
            // 
            this.whmessage.CustomButton.Image = null;
            this.whmessage.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.whmessage.CustomButton.Name = "";
            this.whmessage.CustomButton.Size = new System.Drawing.Size(135, 135);
            this.whmessage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.whmessage.CustomButton.TabIndex = 1;
            this.whmessage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.whmessage.CustomButton.UseSelectable = true;
            this.whmessage.CustomButton.Visible = false;
            this.whmessage.Lines = new string[0];
            this.whmessage.Location = new System.Drawing.Point(23, 197);
            this.whmessage.MaxLength = 32767;
            this.whmessage.Multiline = true;
            this.whmessage.Name = "whmessage";
            this.whmessage.PasswordChar = '\0';
            this.whmessage.PromptText = "message";
            this.whmessage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.whmessage.SelectedText = "";
            this.whmessage.SelectionLength = 0;
            this.whmessage.SelectionStart = 0;
            this.whmessage.ShortcutsEnabled = true;
            this.whmessage.Size = new System.Drawing.Size(300, 137);
            this.whmessage.Style = MetroFramework.MetroColorStyle.Black;
            this.whmessage.TabIndex = 82;
            this.whmessage.Tag = "";
            this.whmessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.whmessage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.whmessage.UseSelectable = true;
            this.whmessage.WaterMark = "message";
            this.whmessage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.whmessage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // whlbl1
            // 
            this.whlbl1.BackColor = System.Drawing.Color.Transparent;
            this.whlbl1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.whlbl1.ForeColor = System.Drawing.Color.White;
            this.whlbl1.Location = new System.Drawing.Point(23, 60);
            this.whlbl1.Name = "whlbl1";
            this.whlbl1.Size = new System.Drawing.Size(300, 47);
            this.whlbl1.Style = MetroFramework.MetroColorStyle.Pink;
            this.whlbl1.TabIndex = 81;
            this.whlbl1.Text = "-------------- webhook tools --------------";
            this.whlbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.whlbl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.whlbl1.UseCustomBackColor = true;
            this.whlbl1.UseStyleColors = true;
            // 
            // nwhsendbtn
            // 
            this.nwhsendbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.nwhsendbtn.Highlight = true;
            this.nwhsendbtn.Location = new System.Drawing.Point(23, 440);
            this.nwhsendbtn.Name = "nwhsendbtn";
            this.nwhsendbtn.Size = new System.Drawing.Size(300, 23);
            this.nwhsendbtn.Style = MetroFramework.MetroColorStyle.Pink;
            this.nwhsendbtn.TabIndex = 80;
            this.nwhsendbtn.Text = "send";
            this.nwhsendbtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.nwhsendbtn.UseMnemonic = false;
            this.nwhsendbtn.UseSelectable = true;
            this.nwhsendbtn.Click += new System.EventHandler(this.nwhsendbtn_Click);
            // 
            // whlbl2
            // 
            this.whlbl2.BackColor = System.Drawing.Color.Transparent;
            this.whlbl2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.whlbl2.ForeColor = System.Drawing.Color.White;
            this.whlbl2.Location = new System.Drawing.Point(329, 60);
            this.whlbl2.Name = "whlbl2";
            this.whlbl2.Size = new System.Drawing.Size(300, 47);
            this.whlbl2.Style = MetroFramework.MetroColorStyle.Pink;
            this.whlbl2.TabIndex = 96;
            this.whlbl2.Text = "-------------- embed stuff --------------";
            this.whlbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.whlbl2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.whlbl2.UseCustomBackColor = true;
            this.whlbl2.UseStyleColors = true;
            // 
            // whauthorlink
            // 
            // 
            // 
            // 
            this.whauthorlink.CustomButton.Image = null;
            this.whauthorlink.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.whauthorlink.CustomButton.Name = "";
            this.whauthorlink.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.whauthorlink.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.whauthorlink.CustomButton.TabIndex = 1;
            this.whauthorlink.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.whauthorlink.CustomButton.UseSelectable = true;
            this.whauthorlink.CustomButton.Visible = false;
            this.whauthorlink.Lines = new string[0];
            this.whauthorlink.Location = new System.Drawing.Point(329, 311);
            this.whauthorlink.MaxLength = 32767;
            this.whauthorlink.Name = "whauthorlink";
            this.whauthorlink.PasswordChar = '\0';
            this.whauthorlink.PromptText = "author link";
            this.whauthorlink.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.whauthorlink.SelectedText = "";
            this.whauthorlink.SelectionLength = 0;
            this.whauthorlink.SelectionStart = 0;
            this.whauthorlink.ShortcutsEnabled = true;
            this.whauthorlink.Size = new System.Drawing.Size(300, 23);
            this.whauthorlink.Style = MetroFramework.MetroColorStyle.Black;
            this.whauthorlink.TabIndex = 97;
            this.whauthorlink.Tag = "";
            this.whauthorlink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.whauthorlink.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.whauthorlink.UseSelectable = true;
            this.whauthorlink.WaterMark = "author link";
            this.whauthorlink.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.whauthorlink.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // whlbl3
            // 
            this.whlbl3.BackColor = System.Drawing.Color.Transparent;
            this.whlbl3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.whlbl3.ForeColor = System.Drawing.Color.White;
            this.whlbl3.Location = new System.Drawing.Point(635, 60);
            this.whlbl3.Name = "whlbl3";
            this.whlbl3.Size = new System.Drawing.Size(287, 47);
            this.whlbl3.Style = MetroFramework.MetroColorStyle.Pink;
            this.whlbl3.TabIndex = 98;
            this.whlbl3.Text = "-------------- delete the webhook --------------";
            this.whlbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.whlbl3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.whlbl3.UseCustomBackColor = true;
            this.whlbl3.UseStyleColors = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 582);
            this.ControlBox = false;
            this.Controls.Add(this.whlbl3);
            this.Controls.Add(this.whauthorlink);
            this.Controls.Add(this.whlbl2);
            this.Controls.Add(this.whuseragent);
            this.Controls.Add(this.btndelwh);
            this.Controls.Add(this.whfooter);
            this.Controls.Add(this.whauthor);
            this.Controls.Add(this.wbtitle);
            this.Controls.Add(this.whdesc);
            this.Controls.Add(this.ewhsendbtn);
            this.Controls.Add(this.whavatar);
            this.Controls.Add(this.whslider);
            this.Controls.Add(this.whname);
            this.Controls.Add(this.whinput);
            this.Controls.Add(this.whamountlbl);
            this.Controls.Add(this.whsliderlbl);
            this.Controls.Add(this.whmessage);
            this.Controls.Add(this.whlbl1);
            this.Controls.Add(this.nwhsendbtn);
            this.Controls.Add(this.titlelbl);
            this.Controls.Add(this.esclbl);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label esclbl;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel titlelbl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroTextBox whuseragent;
        private MetroFramework.Controls.MetroButton btndelwh;
        private MetroFramework.Controls.MetroTextBox whfooter;
        private MetroFramework.Controls.MetroTextBox whauthor;
        private MetroFramework.Controls.MetroTextBox wbtitle;
        private MetroFramework.Controls.MetroTextBox whdesc;
        private MetroFramework.Controls.MetroButton ewhsendbtn;
        private MetroFramework.Controls.MetroTextBox whavatar;
        private MetroFramework.Controls.MetroTrackBar whslider;
        private MetroFramework.Controls.MetroTextBox whname;
        private MetroFramework.Controls.MetroTextBox whinput;
        private MetroFramework.Controls.MetroLabel whamountlbl;
        private MetroFramework.Controls.MetroLabel whsliderlbl;
        private MetroFramework.Controls.MetroTextBox whmessage;
        private MetroFramework.Controls.MetroLabel whlbl1;
        private MetroFramework.Controls.MetroButton nwhsendbtn;
        private MetroFramework.Controls.MetroLabel whlbl2;
        private MetroFramework.Controls.MetroTextBox whauthorlink;
        private MetroFramework.Controls.MetroLabel whlbl3;
    }
}

