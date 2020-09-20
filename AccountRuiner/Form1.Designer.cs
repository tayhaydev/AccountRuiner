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
            this.tabpage1 = new MetroFramework.Controls.MetroTabPage();
            this.uremovefriendsbtn = new MetroFramework.Controls.MetroButton();
            this.umsgalllbl = new MetroFramework.Controls.MetroLabel();
            this.utokenlbl = new MetroFramework.Controls.MetroLabel();
            this.upfplbl = new MetroFramework.Controls.MetroLabel();
            this.ustatuslbl = new MetroFramework.Controls.MetroLabel();
            this.ulanglbl = new MetroFramework.Controls.MetroLabel();
            this.unukelbl = new MetroFramework.Controls.MetroLabel();
            this.uguildlbl = new MetroFramework.Controls.MetroLabel();
            this.ulangbtn = new MetroFramework.Controls.MetroButton();
            this.upfpchangebtn = new MetroFramework.Controls.MetroButton();
            this.uimgbtn = new MetroFramework.Controls.MetroButton();
            this.ustatuschagebtn = new MetroFramework.Controls.MetroButton();
            this.ustatus = new MetroFramework.Controls.MetroTextBox();
            this.umsgallbtn = new MetroFramework.Controls.MetroButton();
            this.umsg = new MetroFramework.Controls.MetroTextBox();
            this.uguildiconbtn = new MetroFramework.Controls.MetroButton();
            this.uguildname = new MetroFramework.Controls.MetroTextBox();
            this.uguildsliderlbl = new MetroFramework.Controls.MetroLabel();
            this.aguildamountlbl = new MetroFramework.Controls.MetroLabel();
            this.uguildslider = new MetroFramework.Controls.MetroTrackBar();
            this.uguildcreatebtn = new MetroFramework.Controls.MetroButton();
            this.uclosedmsbtn = new MetroFramework.Controls.MetroButton();
            this.uremoveguildsbtn = new MetroFramework.Controls.MetroButton();
            this.utoken = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabpage2 = new MetroFramework.Controls.MetroTabPage();
            this.tabpage3 = new MetroFramework.Controls.MetroTabPage();
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
            this.wblbl = new MetroFramework.Controls.MetroLabel();
            this.nwhsendbtn = new MetroFramework.Controls.MetroButton();
            this.btndelwh = new MetroFramework.Controls.MetroButton();
            this.whuseragent = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.tabpage1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.tabpage3.SuspendLayout();
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
            this.titlelbl.Size = new System.Drawing.Size(122, 31);
            this.titlelbl.Style = MetroFramework.MetroColorStyle.Black;
            this.titlelbl.TabIndex = 2;
            this.titlelbl.Text = "epic ruiner";
            this.titlelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titlelbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tabpage1
            // 
            this.tabpage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.tabpage1.Controls.Add(this.uremovefriendsbtn);
            this.tabpage1.Controls.Add(this.umsgalllbl);
            this.tabpage1.Controls.Add(this.utokenlbl);
            this.tabpage1.Controls.Add(this.upfplbl);
            this.tabpage1.Controls.Add(this.ustatuslbl);
            this.tabpage1.Controls.Add(this.ulanglbl);
            this.tabpage1.Controls.Add(this.unukelbl);
            this.tabpage1.Controls.Add(this.uguildlbl);
            this.tabpage1.Controls.Add(this.ulangbtn);
            this.tabpage1.Controls.Add(this.upfpchangebtn);
            this.tabpage1.Controls.Add(this.uimgbtn);
            this.tabpage1.Controls.Add(this.ustatuschagebtn);
            this.tabpage1.Controls.Add(this.ustatus);
            this.tabpage1.Controls.Add(this.umsgallbtn);
            this.tabpage1.Controls.Add(this.umsg);
            this.tabpage1.Controls.Add(this.uguildiconbtn);
            this.tabpage1.Controls.Add(this.uguildname);
            this.tabpage1.Controls.Add(this.uguildsliderlbl);
            this.tabpage1.Controls.Add(this.aguildamountlbl);
            this.tabpage1.Controls.Add(this.uguildslider);
            this.tabpage1.Controls.Add(this.uguildcreatebtn);
            this.tabpage1.Controls.Add(this.uclosedmsbtn);
            this.tabpage1.Controls.Add(this.uremoveguildsbtn);
            this.tabpage1.Controls.Add(this.utoken);
            this.tabpage1.HorizontalScrollbarBarColor = true;
            this.tabpage1.HorizontalScrollbarHighlightOnWheel = false;
            this.tabpage1.HorizontalScrollbarSize = 10;
            this.tabpage1.Location = new System.Drawing.Point(4, 41);
            this.tabpage1.Name = "tabpage1";
            this.tabpage1.Size = new System.Drawing.Size(969, 462);
            this.tabpage1.Style = MetroFramework.MetroColorStyle.Pink;
            this.tabpage1.TabIndex = 5;
            this.tabpage1.Text = "user";
            this.tabpage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabpage1.UseCustomBackColor = true;
            this.tabpage1.UseCustomForeColor = true;
            this.tabpage1.VerticalScrollbarBarColor = true;
            this.tabpage1.VerticalScrollbarHighlightOnWheel = false;
            this.tabpage1.VerticalScrollbarSize = 10;
            // 
            // uremovefriendsbtn
            // 
            this.uremovefriendsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.uremovefriendsbtn.Highlight = true;
            this.uremovefriendsbtn.Location = new System.Drawing.Point(557, 85);
            this.uremovefriendsbtn.Name = "uremovefriendsbtn";
            this.uremovefriendsbtn.Size = new System.Drawing.Size(323, 23);
            this.uremovefriendsbtn.Style = MetroFramework.MetroColorStyle.Pink;
            this.uremovefriendsbtn.TabIndex = 50;
            this.uremovefriendsbtn.Text = "remove friends";
            this.uremovefriendsbtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.uremovefriendsbtn.UseMnemonic = false;
            this.uremovefriendsbtn.UseSelectable = true;
            this.uremovefriendsbtn.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // umsgalllbl
            // 
            this.umsgalllbl.BackColor = System.Drawing.Color.Transparent;
            this.umsgalllbl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.umsgalllbl.ForeColor = System.Drawing.Color.White;
            this.umsgalllbl.Location = new System.Drawing.Point(557, 349);
            this.umsgalllbl.Name = "umsgalllbl";
            this.umsgalllbl.Size = new System.Drawing.Size(323, 45);
            this.umsgalllbl.Style = MetroFramework.MetroColorStyle.Pink;
            this.umsgalllbl.TabIndex = 49;
            this.umsgalllbl.Text = "-------------- message all of their contacts --------------";
            this.umsgalllbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.umsgalllbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.umsgalllbl.UseCustomBackColor = true;
            this.umsgalllbl.UseStyleColors = true;
            // 
            // utokenlbl
            // 
            this.utokenlbl.BackColor = System.Drawing.Color.Transparent;
            this.utokenlbl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.utokenlbl.ForeColor = System.Drawing.Color.White;
            this.utokenlbl.Location = new System.Drawing.Point(96, 8);
            this.utokenlbl.Name = "utokenlbl";
            this.utokenlbl.Size = new System.Drawing.Size(323, 45);
            this.utokenlbl.Style = MetroFramework.MetroColorStyle.Pink;
            this.utokenlbl.TabIndex = 48;
            this.utokenlbl.Text = "-------------- the magic starts here --------------";
            this.utokenlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.utokenlbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.utokenlbl.UseCustomBackColor = true;
            this.utokenlbl.UseStyleColors = true;
            // 
            // upfplbl
            // 
            this.upfplbl.BackColor = System.Drawing.Color.Transparent;
            this.upfplbl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.upfplbl.ForeColor = System.Drawing.Color.White;
            this.upfplbl.Location = new System.Drawing.Point(557, 243);
            this.upfplbl.Name = "upfplbl";
            this.upfplbl.Size = new System.Drawing.Size(323, 45);
            this.upfplbl.Style = MetroFramework.MetroColorStyle.Pink;
            this.upfplbl.TabIndex = 47;
            this.upfplbl.Text = "-------------- profile picture changer --------------";
            this.upfplbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.upfplbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.upfplbl.UseCustomBackColor = true;
            this.upfplbl.UseStyleColors = true;
            // 
            // ustatuslbl
            // 
            this.ustatuslbl.BackColor = System.Drawing.Color.Transparent;
            this.ustatuslbl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.ustatuslbl.ForeColor = System.Drawing.Color.White;
            this.ustatuslbl.Location = new System.Drawing.Point(557, 140);
            this.ustatuslbl.Name = "ustatuslbl";
            this.ustatuslbl.Size = new System.Drawing.Size(323, 45);
            this.ustatuslbl.Style = MetroFramework.MetroColorStyle.Pink;
            this.ustatuslbl.TabIndex = 46;
            this.ustatuslbl.Text = "-------------- status --------------";
            this.ustatuslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ustatuslbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ustatuslbl.UseCustomBackColor = true;
            this.ustatuslbl.UseStyleColors = true;
            // 
            // ulanglbl
            // 
            this.ulanglbl.BackColor = System.Drawing.Color.Transparent;
            this.ulanglbl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.ulanglbl.ForeColor = System.Drawing.Color.White;
            this.ulanglbl.Location = new System.Drawing.Point(96, 82);
            this.ulanglbl.Name = "ulanglbl";
            this.ulanglbl.Size = new System.Drawing.Size(323, 45);
            this.ulanglbl.Style = MetroFramework.MetroColorStyle.Pink;
            this.ulanglbl.TabIndex = 45;
            this.ulanglbl.Text = "-------------- language --------------";
            this.ulanglbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ulanglbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ulanglbl.UseCustomBackColor = true;
            this.ulanglbl.UseStyleColors = true;
            // 
            // unukelbl
            // 
            this.unukelbl.BackColor = System.Drawing.Color.Transparent;
            this.unukelbl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.unukelbl.ForeColor = System.Drawing.Color.White;
            this.unukelbl.Location = new System.Drawing.Point(557, 8);
            this.unukelbl.Name = "unukelbl";
            this.unukelbl.Size = new System.Drawing.Size(323, 45);
            this.unukelbl.Style = MetroFramework.MetroColorStyle.Pink;
            this.unukelbl.TabIndex = 44;
            this.unukelbl.Text = "-------------- average nuker features --------------";
            this.unukelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.unukelbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.unukelbl.UseCustomBackColor = true;
            this.unukelbl.UseStyleColors = true;
            // 
            // uguildlbl
            // 
            this.uguildlbl.BackColor = System.Drawing.Color.Transparent;
            this.uguildlbl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.uguildlbl.ForeColor = System.Drawing.Color.White;
            this.uguildlbl.Location = new System.Drawing.Point(99, 156);
            this.uguildlbl.Name = "uguildlbl";
            this.uguildlbl.Size = new System.Drawing.Size(326, 45);
            this.uguildlbl.Style = MetroFramework.MetroColorStyle.Pink;
            this.uguildlbl.TabIndex = 43;
            this.uguildlbl.Text = "-------------- guild mass creator --------------";
            this.uguildlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uguildlbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.uguildlbl.UseCustomBackColor = true;
            this.uguildlbl.UseStyleColors = true;
            // 
            // ulangbtn
            // 
            this.ulangbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.ulangbtn.Highlight = true;
            this.ulangbtn.Location = new System.Drawing.Point(99, 130);
            this.ulangbtn.Name = "ulangbtn";
            this.ulangbtn.Size = new System.Drawing.Size(323, 23);
            this.ulangbtn.Style = MetroFramework.MetroColorStyle.Yellow;
            this.ulangbtn.TabIndex = 42;
            this.ulangbtn.Text = "change language to russian";
            this.ulangbtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ulangbtn.UseMnemonic = false;
            this.ulangbtn.UseSelectable = true;
            this.ulangbtn.Click += new System.EventHandler(this.metroButton18_Click);
            // 
            // upfpchangebtn
            // 
            this.upfpchangebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.upfpchangebtn.Highlight = true;
            this.upfpchangebtn.Location = new System.Drawing.Point(557, 320);
            this.upfpchangebtn.Name = "upfpchangebtn";
            this.upfpchangebtn.Size = new System.Drawing.Size(323, 23);
            this.upfpchangebtn.Style = MetroFramework.MetroColorStyle.Pink;
            this.upfpchangebtn.TabIndex = 41;
            this.upfpchangebtn.Text = "change pfp";
            this.upfpchangebtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.upfpchangebtn.UseMnemonic = false;
            this.upfpchangebtn.UseSelectable = true;
            this.upfpchangebtn.Click += new System.EventHandler(this.metroButton17_Click);
            // 
            // uimgbtn
            // 
            this.uimgbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.uimgbtn.Highlight = true;
            this.uimgbtn.Location = new System.Drawing.Point(557, 291);
            this.uimgbtn.Name = "uimgbtn";
            this.uimgbtn.Size = new System.Drawing.Size(323, 23);
            this.uimgbtn.Style = MetroFramework.MetroColorStyle.Yellow;
            this.uimgbtn.TabIndex = 40;
            this.uimgbtn.Text = "select image";
            this.uimgbtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.uimgbtn.UseMnemonic = false;
            this.uimgbtn.UseSelectable = true;
            this.uimgbtn.Click += new System.EventHandler(this.metroButton15_Click);
            // 
            // ustatuschagebtn
            // 
            this.ustatuschagebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.ustatuschagebtn.Highlight = true;
            this.ustatuschagebtn.Location = new System.Drawing.Point(557, 217);
            this.ustatuschagebtn.Name = "ustatuschagebtn";
            this.ustatuschagebtn.Size = new System.Drawing.Size(323, 23);
            this.ustatuschagebtn.Style = MetroFramework.MetroColorStyle.Yellow;
            this.ustatuschagebtn.TabIndex = 39;
            this.ustatuschagebtn.Text = "change status";
            this.ustatuschagebtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ustatuschagebtn.UseMnemonic = false;
            this.ustatuschagebtn.UseSelectable = true;
            this.ustatuschagebtn.Click += new System.EventHandler(this.metroButton16_Click);
            // 
            // ustatus
            // 
            // 
            // 
            // 
            this.ustatus.CustomButton.Image = null;
            this.ustatus.CustomButton.Location = new System.Drawing.Point(301, 1);
            this.ustatus.CustomButton.Name = "";
            this.ustatus.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ustatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ustatus.CustomButton.TabIndex = 1;
            this.ustatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ustatus.CustomButton.UseSelectable = true;
            this.ustatus.CustomButton.Visible = false;
            this.ustatus.Lines = new string[0];
            this.ustatus.Location = new System.Drawing.Point(557, 188);
            this.ustatus.MaxLength = 32767;
            this.ustatus.Name = "ustatus";
            this.ustatus.PasswordChar = '\0';
            this.ustatus.PromptText = "change status";
            this.ustatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ustatus.SelectedText = "";
            this.ustatus.SelectionLength = 0;
            this.ustatus.SelectionStart = 0;
            this.ustatus.ShortcutsEnabled = true;
            this.ustatus.Size = new System.Drawing.Size(323, 23);
            this.ustatus.Style = MetroFramework.MetroColorStyle.Black;
            this.ustatus.TabIndex = 38;
            this.ustatus.Tag = "";
            this.ustatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ustatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ustatus.UseSelectable = true;
            this.ustatus.WaterMark = "change status";
            this.ustatus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ustatus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // umsgallbtn
            // 
            this.umsgallbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.umsgallbtn.Highlight = true;
            this.umsgallbtn.Location = new System.Drawing.Point(557, 426);
            this.umsgallbtn.Name = "umsgallbtn";
            this.umsgallbtn.Size = new System.Drawing.Size(323, 23);
            this.umsgallbtn.Style = MetroFramework.MetroColorStyle.Pink;
            this.umsgallbtn.TabIndex = 27;
            this.umsgallbtn.Text = "send to all dms";
            this.umsgallbtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.umsgallbtn.UseMnemonic = false;
            this.umsgallbtn.UseSelectable = true;
            this.umsgallbtn.Click += new System.EventHandler(this.metroButton12_Click);
            // 
            // umsg
            // 
            // 
            // 
            // 
            this.umsg.CustomButton.Image = null;
            this.umsg.CustomButton.Location = new System.Drawing.Point(301, 1);
            this.umsg.CustomButton.Name = "";
            this.umsg.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.umsg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.umsg.CustomButton.TabIndex = 1;
            this.umsg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.umsg.CustomButton.UseSelectable = true;
            this.umsg.CustomButton.Visible = false;
            this.umsg.Lines = new string[0];
            this.umsg.Location = new System.Drawing.Point(557, 397);
            this.umsg.MaxLength = 32767;
            this.umsg.Name = "umsg";
            this.umsg.PasswordChar = '\0';
            this.umsg.PromptText = "message";
            this.umsg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.umsg.SelectedText = "";
            this.umsg.SelectionLength = 0;
            this.umsg.SelectionStart = 0;
            this.umsg.ShortcutsEnabled = true;
            this.umsg.Size = new System.Drawing.Size(323, 23);
            this.umsg.Style = MetroFramework.MetroColorStyle.Black;
            this.umsg.TabIndex = 30;
            this.umsg.Tag = "";
            this.umsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.umsg.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.umsg.UseSelectable = true;
            this.umsg.WaterMark = "message";
            this.umsg.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.umsg.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // uguildiconbtn
            // 
            this.uguildiconbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.uguildiconbtn.Highlight = true;
            this.uguildiconbtn.Location = new System.Drawing.Point(96, 320);
            this.uguildiconbtn.Name = "uguildiconbtn";
            this.uguildiconbtn.Size = new System.Drawing.Size(323, 23);
            this.uguildiconbtn.Style = MetroFramework.MetroColorStyle.Yellow;
            this.uguildiconbtn.TabIndex = 35;
            this.uguildiconbtn.Text = "select icon";
            this.uguildiconbtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.uguildiconbtn.UseMnemonic = false;
            this.uguildiconbtn.UseSelectable = true;
            this.uguildiconbtn.Click += new System.EventHandler(this.metroButton14_Click);
            // 
            // uguildname
            // 
            // 
            // 
            // 
            this.uguildname.CustomButton.Image = null;
            this.uguildname.CustomButton.Location = new System.Drawing.Point(301, 1);
            this.uguildname.CustomButton.Name = "";
            this.uguildname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.uguildname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uguildname.CustomButton.TabIndex = 1;
            this.uguildname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uguildname.CustomButton.UseSelectable = true;
            this.uguildname.CustomButton.Visible = false;
            this.uguildname.Lines = new string[0];
            this.uguildname.Location = new System.Drawing.Point(96, 291);
            this.uguildname.MaxLength = 32767;
            this.uguildname.Name = "uguildname";
            this.uguildname.PasswordChar = '\0';
            this.uguildname.PromptText = "guild name";
            this.uguildname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uguildname.SelectedText = "";
            this.uguildname.SelectionLength = 0;
            this.uguildname.SelectionStart = 0;
            this.uguildname.ShortcutsEnabled = true;
            this.uguildname.Size = new System.Drawing.Size(323, 23);
            this.uguildname.Style = MetroFramework.MetroColorStyle.Black;
            this.uguildname.TabIndex = 34;
            this.uguildname.Tag = "";
            this.uguildname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uguildname.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.uguildname.UseSelectable = true;
            this.uguildname.WaterMark = "guild name";
            this.uguildname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uguildname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // uguildsliderlbl
            // 
            this.uguildsliderlbl.BackColor = System.Drawing.Color.Transparent;
            this.uguildsliderlbl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.uguildsliderlbl.ForeColor = System.Drawing.Color.White;
            this.uguildsliderlbl.Location = new System.Drawing.Point(96, 264);
            this.uguildsliderlbl.Name = "uguildsliderlbl";
            this.uguildsliderlbl.Size = new System.Drawing.Size(323, 24);
            this.uguildsliderlbl.Style = MetroFramework.MetroColorStyle.Pink;
            this.uguildsliderlbl.TabIndex = 33;
            this.uguildsliderlbl.Text = "50";
            this.uguildsliderlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uguildsliderlbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.uguildsliderlbl.UseCustomBackColor = true;
            this.uguildsliderlbl.UseStyleColors = true;
            // 
            // aguildamountlbl
            // 
            this.aguildamountlbl.BackColor = System.Drawing.Color.Transparent;
            this.aguildamountlbl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.aguildamountlbl.ForeColor = System.Drawing.Color.White;
            this.aguildamountlbl.Location = new System.Drawing.Point(99, 201);
            this.aguildamountlbl.Name = "aguildamountlbl";
            this.aguildamountlbl.Size = new System.Drawing.Size(326, 34);
            this.aguildamountlbl.Style = MetroFramework.MetroColorStyle.Pink;
            this.aguildamountlbl.TabIndex = 32;
            this.aguildamountlbl.Text = "amount of guilds";
            this.aguildamountlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aguildamountlbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.aguildamountlbl.UseCustomBackColor = true;
            this.aguildamountlbl.UseStyleColors = true;
            // 
            // uguildslider
            // 
            this.uguildslider.BackColor = System.Drawing.Color.Transparent;
            this.uguildslider.ForeColor = System.Drawing.Color.Yellow;
            this.uguildslider.Location = new System.Drawing.Point(99, 238);
            this.uguildslider.Minimum = 1;
            this.uguildslider.Name = "uguildslider";
            this.uguildslider.Size = new System.Drawing.Size(320, 23);
            this.uguildslider.Style = MetroFramework.MetroColorStyle.Pink;
            this.uguildslider.TabIndex = 31;
            this.uguildslider.Text = "metroTrackBar2";
            this.uguildslider.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.uguildslider.UseCustomBackColor = true;
            this.uguildslider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBar2_Scroll);
            // 
            // uguildcreatebtn
            // 
            this.uguildcreatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.uguildcreatebtn.Highlight = true;
            this.uguildcreatebtn.Location = new System.Drawing.Point(96, 349);
            this.uguildcreatebtn.Name = "uguildcreatebtn";
            this.uguildcreatebtn.Size = new System.Drawing.Size(323, 23);
            this.uguildcreatebtn.Style = MetroFramework.MetroColorStyle.Pink;
            this.uguildcreatebtn.TabIndex = 30;
            this.uguildcreatebtn.Text = "create guilds";
            this.uguildcreatebtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.uguildcreatebtn.UseMnemonic = false;
            this.uguildcreatebtn.UseSelectable = true;
            this.uguildcreatebtn.Click += new System.EventHandler(this.metroButton11_Click);
            // 
            // uclosedmsbtn
            // 
            this.uclosedmsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.uclosedmsbtn.Highlight = true;
            this.uclosedmsbtn.Location = new System.Drawing.Point(557, 56);
            this.uclosedmsbtn.Name = "uclosedmsbtn";
            this.uclosedmsbtn.Size = new System.Drawing.Size(323, 23);
            this.uclosedmsbtn.Style = MetroFramework.MetroColorStyle.Pink;
            this.uclosedmsbtn.TabIndex = 27;
            this.uclosedmsbtn.Text = "close dms";
            this.uclosedmsbtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.uclosedmsbtn.UseMnemonic = false;
            this.uclosedmsbtn.UseSelectable = true;
            this.uclosedmsbtn.Click += new System.EventHandler(this.metroButton13_Click);
            // 
            // uremoveguildsbtn
            // 
            this.uremoveguildsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.uremoveguildsbtn.Highlight = true;
            this.uremoveguildsbtn.Location = new System.Drawing.Point(557, 114);
            this.uremoveguildsbtn.Name = "uremoveguildsbtn";
            this.uremoveguildsbtn.Size = new System.Drawing.Size(323, 23);
            this.uremoveguildsbtn.Style = MetroFramework.MetroColorStyle.Pink;
            this.uremoveguildsbtn.TabIndex = 22;
            this.uremoveguildsbtn.Text = "remove servers";
            this.uremoveguildsbtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.uremoveguildsbtn.UseMnemonic = false;
            this.uremoveguildsbtn.UseSelectable = true;
            this.uremoveguildsbtn.Click += new System.EventHandler(this.metroButton9_Click);
            // 
            // utoken
            // 
            // 
            // 
            // 
            this.utoken.CustomButton.Image = null;
            this.utoken.CustomButton.Location = new System.Drawing.Point(304, 1);
            this.utoken.CustomButton.Name = "";
            this.utoken.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.utoken.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.utoken.CustomButton.TabIndex = 1;
            this.utoken.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.utoken.CustomButton.UseSelectable = true;
            this.utoken.CustomButton.Visible = false;
            this.utoken.Lines = new string[0];
            this.utoken.Location = new System.Drawing.Point(96, 56);
            this.utoken.MaxLength = 32767;
            this.utoken.Name = "utoken";
            this.utoken.PasswordChar = '\0';
            this.utoken.PromptText = "token";
            this.utoken.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.utoken.SelectedText = "";
            this.utoken.SelectionLength = 0;
            this.utoken.SelectionStart = 0;
            this.utoken.ShortcutsEnabled = true;
            this.utoken.Size = new System.Drawing.Size(326, 23);
            this.utoken.Style = MetroFramework.MetroColorStyle.Black;
            this.utoken.TabIndex = 16;
            this.utoken.Tag = "";
            this.utoken.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.utoken.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.utoken.UseSelectable = true;
            this.utoken.WaterMark = "token";
            this.utoken.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.utoken.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.tabpage1);
            this.metroTabControl1.Controls.Add(this.tabpage3);
            this.metroTabControl1.Controls.Add(this.tabpage2);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 52);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(977, 507);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabpage2
            // 
            this.tabpage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.tabpage2.HorizontalScrollbarBarColor = true;
            this.tabpage2.HorizontalScrollbarHighlightOnWheel = false;
            this.tabpage2.HorizontalScrollbarSize = 10;
            this.tabpage2.Location = new System.Drawing.Point(4, 41);
            this.tabpage2.Name = "tabpage2";
            this.tabpage2.Size = new System.Drawing.Size(969, 462);
            this.tabpage2.Style = MetroFramework.MetroColorStyle.Pink;
            this.tabpage2.TabIndex = 6;
            this.tabpage2.Text = "server";
            this.tabpage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabpage2.UseCustomBackColor = true;
            this.tabpage2.UseCustomForeColor = true;
            this.tabpage2.VerticalScrollbarBarColor = true;
            this.tabpage2.VerticalScrollbarHighlightOnWheel = false;
            this.tabpage2.VerticalScrollbarSize = 10;
            // 
            // tabpage3
            // 
            this.tabpage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.tabpage3.Controls.Add(this.whuseragent);
            this.tabpage3.Controls.Add(this.btndelwh);
            this.tabpage3.Controls.Add(this.whfooter);
            this.tabpage3.Controls.Add(this.whauthor);
            this.tabpage3.Controls.Add(this.wbtitle);
            this.tabpage3.Controls.Add(this.whdesc);
            this.tabpage3.Controls.Add(this.ewhsendbtn);
            this.tabpage3.Controls.Add(this.whavatar);
            this.tabpage3.Controls.Add(this.whslider);
            this.tabpage3.Controls.Add(this.whname);
            this.tabpage3.Controls.Add(this.whinput);
            this.tabpage3.Controls.Add(this.whamountlbl);
            this.tabpage3.Controls.Add(this.whsliderlbl);
            this.tabpage3.Controls.Add(this.whmessage);
            this.tabpage3.Controls.Add(this.wblbl);
            this.tabpage3.Controls.Add(this.nwhsendbtn);
            this.tabpage3.HorizontalScrollbarBarColor = true;
            this.tabpage3.HorizontalScrollbarHighlightOnWheel = false;
            this.tabpage3.HorizontalScrollbarSize = 10;
            this.tabpage3.Location = new System.Drawing.Point(4, 41);
            this.tabpage3.Name = "tabpage3";
            this.tabpage3.Size = new System.Drawing.Size(969, 462);
            this.tabpage3.Style = MetroFramework.MetroColorStyle.Pink;
            this.tabpage3.TabIndex = 7;
            this.tabpage3.Text = "other";
            this.tabpage3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabpage3.UseCustomBackColor = true;
            this.tabpage3.UseCustomForeColor = true;
            this.tabpage3.VerticalScrollbarBarColor = true;
            this.tabpage3.VerticalScrollbarHighlightOnWheel = false;
            this.tabpage3.VerticalScrollbarSize = 10;
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
            this.whfooter.Lines = new string[] {
        "sent by https://github.com/xvap/AccountRuiner"};
            this.whfooter.Location = new System.Drawing.Point(492, 263);
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
            this.whfooter.TabIndex = 77;
            this.whfooter.Tag = "";
            this.whfooter.Text = "sent by https://github.com/xvap/AccountRuiner";
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
            this.whauthor.Lines = new string[] {
        "Tayhay"};
            this.whauthor.Location = new System.Drawing.Point(492, 234);
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
            this.whauthor.TabIndex = 76;
            this.whauthor.Tag = "";
            this.whauthor.Text = "Tayhay";
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
            this.wbtitle.Location = new System.Drawing.Point(492, 179);
            this.wbtitle.MaxLength = 32767;
            this.wbtitle.Name = "wbtitle";
            this.wbtitle.PasswordChar = '\0';
            this.wbtitle.PromptText = "title";
            this.wbtitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.wbtitle.SelectedText = "";
            this.wbtitle.SelectionLength = 0;
            this.wbtitle.SelectionStart = 0;
            this.wbtitle.ShortcutsEnabled = true;
            this.wbtitle.Size = new System.Drawing.Size(300, 23);
            this.wbtitle.Style = MetroFramework.MetroColorStyle.Black;
            this.wbtitle.TabIndex = 75;
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
            this.whdesc.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.whdesc.CustomButton.Name = "";
            this.whdesc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.whdesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.whdesc.CustomButton.TabIndex = 1;
            this.whdesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.whdesc.CustomButton.UseSelectable = true;
            this.whdesc.CustomButton.Visible = false;
            this.whdesc.Lines = new string[0];
            this.whdesc.Location = new System.Drawing.Point(492, 205);
            this.whdesc.MaxLength = 32767;
            this.whdesc.Name = "whdesc";
            this.whdesc.PasswordChar = '\0';
            this.whdesc.PromptText = "desc";
            this.whdesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.whdesc.SelectedText = "";
            this.whdesc.SelectionLength = 0;
            this.whdesc.SelectionStart = 0;
            this.whdesc.ShortcutsEnabled = true;
            this.whdesc.Size = new System.Drawing.Size(300, 23);
            this.whdesc.Style = MetroFramework.MetroColorStyle.Black;
            this.whdesc.TabIndex = 74;
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
            this.ewhsendbtn.Location = new System.Drawing.Point(492, 308);
            this.ewhsendbtn.Name = "ewhsendbtn";
            this.ewhsendbtn.Size = new System.Drawing.Size(300, 23);
            this.ewhsendbtn.Style = MetroFramework.MetroColorStyle.Pink;
            this.ewhsendbtn.TabIndex = 73;
            this.ewhsendbtn.Text = "send embed";
            this.ewhsendbtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ewhsendbtn.UseMnemonic = false;
            this.ewhsendbtn.UseSelectable = true;
            this.ewhsendbtn.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // whavatar
            // 
            // 
            // 
            // 
            this.whavatar.CustomButton.Image = null;
            this.whavatar.CustomButton.Location = new System.Drawing.Point(317, 1);
            this.whavatar.CustomButton.Name = "";
            this.whavatar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.whavatar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.whavatar.CustomButton.TabIndex = 1;
            this.whavatar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.whavatar.CustomButton.UseSelectable = true;
            this.whavatar.CustomButton.Visible = false;
            this.whavatar.Lines = new string[] {
        "https://doggo.ninja/BxqWae.png"};
            this.whavatar.Location = new System.Drawing.Point(314, 126);
            this.whavatar.MaxLength = 32767;
            this.whavatar.Name = "whavatar";
            this.whavatar.PasswordChar = '\0';
            this.whavatar.PromptText = "avatar url";
            this.whavatar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.whavatar.SelectedText = "";
            this.whavatar.SelectionLength = 0;
            this.whavatar.SelectionStart = 0;
            this.whavatar.ShortcutsEnabled = true;
            this.whavatar.Size = new System.Drawing.Size(339, 23);
            this.whavatar.Style = MetroFramework.MetroColorStyle.Black;
            this.whavatar.TabIndex = 72;
            this.whavatar.Tag = "";
            this.whavatar.Text = "https://doggo.ninja/BxqWae.png";
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
            this.whslider.Location = new System.Drawing.Point(186, 253);
            this.whslider.Minimum = 1;
            this.whslider.Name = "whslider";
            this.whslider.Size = new System.Drawing.Size(300, 23);
            this.whslider.Style = MetroFramework.MetroColorStyle.Pink;
            this.whslider.TabIndex = 71;
            this.whslider.Text = "metroTrackBar1";
            this.whslider.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.whslider.UseCustomBackColor = true;
            this.whslider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBar1_Scroll);
            // 
            // whname
            // 
            // 
            // 
            // 
            this.whname.CustomButton.Image = null;
            this.whname.CustomButton.Location = new System.Drawing.Point(317, 1);
            this.whname.CustomButton.Name = "";
            this.whname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.whname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.whname.CustomButton.TabIndex = 1;
            this.whname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.whname.CustomButton.UseSelectable = true;
            this.whname.CustomButton.Visible = false;
            this.whname.Lines = new string[] {
        "antiskid"};
            this.whname.Location = new System.Drawing.Point(314, 97);
            this.whname.MaxLength = 32767;
            this.whname.Name = "whname";
            this.whname.PasswordChar = '\0';
            this.whname.PromptText = "username";
            this.whname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.whname.SelectedText = "";
            this.whname.SelectionLength = 0;
            this.whname.SelectionStart = 0;
            this.whname.ShortcutsEnabled = true;
            this.whname.Size = new System.Drawing.Size(339, 23);
            this.whname.Style = MetroFramework.MetroColorStyle.Black;
            this.whname.TabIndex = 70;
            this.whname.Tag = "";
            this.whname.Text = "antiskid";
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
            this.whinput.CustomButton.Location = new System.Drawing.Point(317, 1);
            this.whinput.CustomButton.Name = "";
            this.whinput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.whinput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.whinput.CustomButton.TabIndex = 1;
            this.whinput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.whinput.CustomButton.UseSelectable = true;
            this.whinput.CustomButton.Visible = false;
            this.whinput.Lines = new string[0];
            this.whinput.Location = new System.Drawing.Point(314, 68);
            this.whinput.MaxLength = 32767;
            this.whinput.Name = "whinput";
            this.whinput.PasswordChar = '\0';
            this.whinput.PromptText = "webhook";
            this.whinput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.whinput.SelectedText = "";
            this.whinput.SelectionLength = 0;
            this.whinput.SelectionStart = 0;
            this.whinput.ShortcutsEnabled = true;
            this.whinput.Size = new System.Drawing.Size(339, 23);
            this.whinput.Style = MetroFramework.MetroColorStyle.Black;
            this.whinput.TabIndex = 69;
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
            this.whamountlbl.Location = new System.Drawing.Point(186, 205);
            this.whamountlbl.Name = "whamountlbl";
            this.whamountlbl.Size = new System.Drawing.Size(300, 45);
            this.whamountlbl.Style = MetroFramework.MetroColorStyle.Pink;
            this.whamountlbl.TabIndex = 68;
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
            this.whsliderlbl.Location = new System.Drawing.Point(186, 279);
            this.whsliderlbl.Name = "whsliderlbl";
            this.whsliderlbl.Size = new System.Drawing.Size(300, 26);
            this.whsliderlbl.Style = MetroFramework.MetroColorStyle.Pink;
            this.whsliderlbl.TabIndex = 67;
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
            this.whmessage.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.whmessage.CustomButton.Name = "";
            this.whmessage.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.whmessage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.whmessage.CustomButton.TabIndex = 1;
            this.whmessage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.whmessage.CustomButton.UseSelectable = true;
            this.whmessage.CustomButton.Visible = false;
            this.whmessage.Lines = new string[0];
            this.whmessage.Location = new System.Drawing.Point(186, 179);
            this.whmessage.MaxLength = 32767;
            this.whmessage.Name = "whmessage";
            this.whmessage.PasswordChar = '\0';
            this.whmessage.PromptText = "message";
            this.whmessage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.whmessage.SelectedText = "";
            this.whmessage.SelectionLength = 0;
            this.whmessage.SelectionStart = 0;
            this.whmessage.ShortcutsEnabled = true;
            this.whmessage.Size = new System.Drawing.Size(300, 23);
            this.whmessage.Style = MetroFramework.MetroColorStyle.Black;
            this.whmessage.TabIndex = 66;
            this.whmessage.Tag = "";
            this.whmessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.whmessage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.whmessage.UseSelectable = true;
            this.whmessage.WaterMark = "message";
            this.whmessage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.whmessage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // wblbl
            // 
            this.wblbl.BackColor = System.Drawing.Color.Transparent;
            this.wblbl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.wblbl.ForeColor = System.Drawing.Color.White;
            this.wblbl.Location = new System.Drawing.Point(3, 20);
            this.wblbl.Name = "wblbl";
            this.wblbl.Size = new System.Drawing.Size(963, 45);
            this.wblbl.Style = MetroFramework.MetroColorStyle.Pink;
            this.wblbl.TabIndex = 65;
            this.wblbl.Text = "-------------- webhook bot --------------";
            this.wblbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wblbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.wblbl.UseCustomBackColor = true;
            this.wblbl.UseStyleColors = true;
            // 
            // nwhsendbtn
            // 
            this.nwhsendbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.nwhsendbtn.Highlight = true;
            this.nwhsendbtn.Location = new System.Drawing.Point(186, 308);
            this.nwhsendbtn.Name = "nwhsendbtn";
            this.nwhsendbtn.Size = new System.Drawing.Size(300, 23);
            this.nwhsendbtn.Style = MetroFramework.MetroColorStyle.Pink;
            this.nwhsendbtn.TabIndex = 64;
            this.nwhsendbtn.Text = "send";
            this.nwhsendbtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.nwhsendbtn.UseMnemonic = false;
            this.nwhsendbtn.UseSelectable = true;
            this.nwhsendbtn.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btndelwh
            // 
            this.btndelwh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.btndelwh.Highlight = true;
            this.btndelwh.Location = new System.Drawing.Point(314, 366);
            this.btndelwh.Name = "btndelwh";
            this.btndelwh.Size = new System.Drawing.Size(339, 23);
            this.btndelwh.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btndelwh.TabIndex = 78;
            this.btndelwh.Text = "delete webhook";
            this.btndelwh.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btndelwh.UseMnemonic = false;
            this.btndelwh.UseSelectable = true;
            this.btndelwh.Click += new System.EventHandler(this.metroButton2_Click_1);
            // 
            // whuseragent
            // 
            // 
            // 
            // 
            this.whuseragent.CustomButton.Image = null;
            this.whuseragent.CustomButton.Location = new System.Drawing.Point(317, 1);
            this.whuseragent.CustomButton.Name = "";
            this.whuseragent.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.whuseragent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.whuseragent.CustomButton.TabIndex = 1;
            this.whuseragent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.whuseragent.CustomButton.UseSelectable = true;
            this.whuseragent.CustomButton.Visible = false;
            this.whuseragent.Lines = new string[0];
            this.whuseragent.Location = new System.Drawing.Point(314, 337);
            this.whuseragent.MaxLength = 32767;
            this.whuseragent.Name = "whuseragent";
            this.whuseragent.PasswordChar = '\0';
            this.whuseragent.PromptText = "user-agent";
            this.whuseragent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.whuseragent.SelectedText = "";
            this.whuseragent.SelectionLength = 0;
            this.whuseragent.SelectionStart = 0;
            this.whuseragent.ShortcutsEnabled = true;
            this.whuseragent.Size = new System.Drawing.Size(339, 23);
            this.whuseragent.Style = MetroFramework.MetroColorStyle.Black;
            this.whuseragent.TabIndex = 79;
            this.whuseragent.Tag = "";
            this.whuseragent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.whuseragent.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.whuseragent.UseSelectable = true;
            this.whuseragent.WaterMark = "user-agent";
            this.whuseragent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.whuseragent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 582);
            this.ControlBox = false;
            this.Controls.Add(this.titlelbl);
            this.Controls.Add(this.esclbl);
            this.Controls.Add(this.metroTabControl1);
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
            this.tabpage1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.tabpage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label esclbl;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel titlelbl;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabpage1;
        private MetroFramework.Controls.MetroButton ulangbtn;
        private MetroFramework.Controls.MetroButton upfpchangebtn;
        private MetroFramework.Controls.MetroButton uimgbtn;
        private MetroFramework.Controls.MetroButton ustatuschagebtn;
        private MetroFramework.Controls.MetroTextBox ustatus;
        private MetroFramework.Controls.MetroButton umsgallbtn;
        private MetroFramework.Controls.MetroTextBox umsg;
        private MetroFramework.Controls.MetroButton uguildiconbtn;
        private MetroFramework.Controls.MetroTextBox uguildname;
        private MetroFramework.Controls.MetroLabel uguildsliderlbl;
        private MetroFramework.Controls.MetroLabel aguildamountlbl;
        private MetroFramework.Controls.MetroTrackBar uguildslider;
        private MetroFramework.Controls.MetroButton uguildcreatebtn;
        private MetroFramework.Controls.MetroButton uclosedmsbtn;
        private MetroFramework.Controls.MetroButton uremoveguildsbtn;
        private MetroFramework.Controls.MetroTextBox utoken;
        private MetroFramework.Controls.MetroLabel unukelbl;
        private MetroFramework.Controls.MetroLabel uguildlbl;
        private MetroFramework.Controls.MetroLabel umsgalllbl;
        private MetroFramework.Controls.MetroLabel utokenlbl;
        private MetroFramework.Controls.MetroLabel upfplbl;
        private MetroFramework.Controls.MetroLabel ustatuslbl;
        private MetroFramework.Controls.MetroLabel ulanglbl;
        private MetroFramework.Controls.MetroTabPage tabpage2;
        private MetroFramework.Controls.MetroTabPage tabpage3;
        private MetroFramework.Controls.MetroTrackBar whslider;
        private MetroFramework.Controls.MetroTextBox whname;
        private MetroFramework.Controls.MetroTextBox whinput;
        private MetroFramework.Controls.MetroLabel whamountlbl;
        private MetroFramework.Controls.MetroLabel whsliderlbl;
        private MetroFramework.Controls.MetroTextBox whmessage;
        private MetroFramework.Controls.MetroLabel wblbl;
        private MetroFramework.Controls.MetroButton nwhsendbtn;
        private MetroFramework.Controls.MetroButton uremovefriendsbtn;
        private MetroFramework.Controls.MetroTextBox whavatar;
        private MetroFramework.Controls.MetroTextBox whdesc;
        private MetroFramework.Controls.MetroButton ewhsendbtn;
        private MetroFramework.Controls.MetroTextBox wbtitle;
        private MetroFramework.Controls.MetroTextBox whfooter;
        private MetroFramework.Controls.MetroTextBox whauthor;
        private MetroFramework.Controls.MetroButton btndelwh;
        private MetroFramework.Controls.MetroTextBox whuseragent;
    }
}

