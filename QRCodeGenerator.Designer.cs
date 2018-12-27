namespace DemoQRCodeGenerator
{
    partial class QRCodeGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRCodeGenerator));
            this.simpleTransperentLabel1 = new Simpleblue_Theme.SimpleTransperentLabel();
            this.simpleTransperentLabel2 = new Simpleblue_Theme.SimpleTransperentLabel();
            this.simpleTransperentLabel3 = new Simpleblue_Theme.SimpleTransperentLabel();
            this.simpleTransperentLabel4 = new Simpleblue_Theme.SimpleTransperentLabel();
            this.cbEncoding = new Redemption_theme.RedemptionComboBox();
            this.cbCorrectionLevel = new Redemption_theme.RedemptionComboBox();
            this.cbVersion = new Redemption_theme.RedemptionComboBox();
            this.btnChooseLogo = new Redemption_theme.RedemptionButton();
            this.txtData = new Redemption_theme.RedemptionTextBox();
            this.btnC = new Redemption_theme.RedemptionButton();
            this.btnS = new Redemption_theme.RedemptionButton();
            this.simpleTransperentLabel7 = new Simpleblue_Theme.SimpleTransperentLabel();
            this.btnD = new Redemption_theme.RedemptionButton();
            this.simpleTransperentLabel5 = new Simpleblue_Theme.SimpleTransperentLabel();
            this.simpleTransperentLabel6 = new Simpleblue_Theme.SimpleTransperentLabel();
            this.lblData = new Simpleblue_Theme.SimpleTransperentLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picEncode = new System.Windows.Forms.PictureBox();
            this.txtLogo = new Redemption_theme.RedemptionTextBox();
            this.txtScale = new Redemption_theme.RedemptionTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblLink = new System.Windows.Forms.Label();
            this.btnQRCodeForegroundColor = new System.Windows.Forms.Button();
            this.btnQRCodeBackgroundColor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFB = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnIG = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEncode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIG)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleTransperentLabel1
            // 
            this.simpleTransperentLabel1.AutoSize = true;
            this.simpleTransperentLabel1.BackColor = System.Drawing.Color.Transparent;
            this.simpleTransperentLabel1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.simpleTransperentLabel1.Location = new System.Drawing.Point(21, 174);
            this.simpleTransperentLabel1.Name = "simpleTransperentLabel1";
            this.simpleTransperentLabel1.Size = new System.Drawing.Size(65, 17);
            this.simpleTransperentLabel1.TabIndex = 7;
            this.simpleTransperentLabel1.Text = "Encoding";
            // 
            // simpleTransperentLabel2
            // 
            this.simpleTransperentLabel2.AutoSize = true;
            this.simpleTransperentLabel2.BackColor = System.Drawing.Color.Transparent;
            this.simpleTransperentLabel2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.simpleTransperentLabel2.Location = new System.Drawing.Point(300, 174);
            this.simpleTransperentLabel2.Name = "simpleTransperentLabel2";
            this.simpleTransperentLabel2.Size = new System.Drawing.Size(31, 17);
            this.simpleTransperentLabel2.TabIndex = 8;
            this.simpleTransperentLabel2.Text = "Size";
            // 
            // simpleTransperentLabel3
            // 
            this.simpleTransperentLabel3.AutoSize = true;
            this.simpleTransperentLabel3.BackColor = System.Drawing.Color.Transparent;
            this.simpleTransperentLabel3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.simpleTransperentLabel3.Location = new System.Drawing.Point(296, 220);
            this.simpleTransperentLabel3.Name = "simpleTransperentLabel3";
            this.simpleTransperentLabel3.Size = new System.Drawing.Size(39, 17);
            this.simpleTransperentLabel3.TabIndex = 10;
            this.simpleTransperentLabel3.Text = "Scale";
            // 
            // simpleTransperentLabel4
            // 
            this.simpleTransperentLabel4.AutoSize = true;
            this.simpleTransperentLabel4.BackColor = System.Drawing.Color.Transparent;
            this.simpleTransperentLabel4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.simpleTransperentLabel4.Location = new System.Drawing.Point(21, 220);
            this.simpleTransperentLabel4.Name = "simpleTransperentLabel4";
            this.simpleTransperentLabel4.Size = new System.Drawing.Size(39, 17);
            this.simpleTransperentLabel4.TabIndex = 9;
            this.simpleTransperentLabel4.Text = "Level";
            // 
            // cbEncoding
            // 
            this.cbEncoding.BackColor = System.Drawing.Color.Transparent;
            this.cbEncoding.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEncoding.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbEncoding.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbEncoding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(179)))), ((int)(((byte)(171)))));
            this.cbEncoding.FormattingEnabled = true;
            this.cbEncoding.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbEncoding.ItemHeight = 18;
            this.cbEncoding.Items.AddRange(new object[] {
            "Byte",
            "AlphaNumeric",
            "Numeric"});
            this.cbEncoding.Location = new System.Drawing.Point(144, 170);
            this.cbEncoding.Name = "cbEncoding";
            this.cbEncoding.Size = new System.Drawing.Size(145, 24);
            this.cbEncoding.TabIndex = 13;
            // 
            // cbCorrectionLevel
            // 
            this.cbCorrectionLevel.BackColor = System.Drawing.Color.Transparent;
            this.cbCorrectionLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCorrectionLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCorrectionLevel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbCorrectionLevel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbCorrectionLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(179)))), ((int)(((byte)(171)))));
            this.cbCorrectionLevel.FormattingEnabled = true;
            this.cbCorrectionLevel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbCorrectionLevel.ItemHeight = 18;
            this.cbCorrectionLevel.Items.AddRange(new object[] {
            "L",
            "M",
            "Q",
            "H"});
            this.cbCorrectionLevel.Location = new System.Drawing.Point(344, 170);
            this.cbCorrectionLevel.Name = "cbCorrectionLevel";
            this.cbCorrectionLevel.Size = new System.Drawing.Size(150, 24);
            this.cbCorrectionLevel.TabIndex = 14;
            // 
            // cbVersion
            // 
            this.cbVersion.BackColor = System.Drawing.Color.Transparent;
            this.cbVersion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVersion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbVersion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(179)))), ((int)(((byte)(171)))));
            this.cbVersion.FormattingEnabled = true;
            this.cbVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbVersion.ItemHeight = 18;
            this.cbVersion.Items.AddRange(new object[] {
            "sdfs",
            "sfsdfsd",
            "fsdfsdf",
            "sdfsdf"});
            this.cbVersion.Location = new System.Drawing.Point(144, 216);
            this.cbVersion.Name = "cbVersion";
            this.cbVersion.Size = new System.Drawing.Size(145, 24);
            this.cbVersion.TabIndex = 15;
            // 
            // btnChooseLogo
            // 
            this.btnChooseLogo.BackColor = System.Drawing.Color.Transparent;
            this.btnChooseLogo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnChooseLogo.Location = new System.Drawing.Point(460, 125);
            this.btnChooseLogo.Name = "btnChooseLogo";
            this.btnChooseLogo.Size = new System.Drawing.Size(37, 23);
            this.btnChooseLogo.TabIndex = 19;
            this.btnChooseLogo.Text = "Bro...";
            this.btnChooseLogo.TextAlign = Redemption_theme.RedemptionButton.HorizontalAlignment.Center;
            this.btnChooseLogo.Click += new System.EventHandler(this.btnChooseLogo_Click);
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.Transparent;
            this.txtData.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.ForeColor = System.Drawing.Color.White;
            this.txtData.Location = new System.Drawing.Point(144, 79);
            this.txtData.MaxLength = 32767;
            this.txtData.MultiLine = false;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(353, 24);
            this.txtData.TabIndex = 21;
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtData.UseSystemPasswordChar = false;
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.Black;
            this.btnC.Enabled = false;
            this.btnC.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnC.ForeColor = System.Drawing.Color.Black;
            this.btnC.Location = new System.Drawing.Point(17, 308);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 23);
            this.btnC.TabIndex = 22;
            this.btnC.Text = "Encode";
            this.btnC.TextAlign = Redemption_theme.RedemptionButton.HorizontalAlignment.Center;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.Color.Black;
            this.btnS.Enabled = false;
            this.btnS.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnS.ForeColor = System.Drawing.Color.Black;
            this.btnS.Location = new System.Drawing.Point(422, 308);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(75, 23);
            this.btnS.TabIndex = 24;
            this.btnS.Text = "Save";
            this.btnS.TextAlign = Redemption_theme.RedemptionButton.HorizontalAlignment.Center;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // simpleTransperentLabel7
            // 
            this.simpleTransperentLabel7.AutoSize = true;
            this.simpleTransperentLabel7.BackColor = System.Drawing.Color.Transparent;
            this.simpleTransperentLabel7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.simpleTransperentLabel7.Location = new System.Drawing.Point(21, 128);
            this.simpleTransperentLabel7.Name = "simpleTransperentLabel7";
            this.simpleTransperentLabel7.Size = new System.Drawing.Size(39, 17);
            this.simpleTransperentLabel7.TabIndex = 26;
            this.simpleTransperentLabel7.Text = "Logo";
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.Black;
            this.btnD.Enabled = false;
            this.btnD.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnD.ForeColor = System.Drawing.Color.Black;
            this.btnD.Location = new System.Drawing.Point(221, 308);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(75, 23);
            this.btnD.TabIndex = 28;
            this.btnD.Text = "Clear";
            this.btnD.TextAlign = Redemption_theme.RedemptionButton.HorizontalAlignment.Center;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // simpleTransperentLabel5
            // 
            this.simpleTransperentLabel5.AutoSize = true;
            this.simpleTransperentLabel5.BackColor = System.Drawing.Color.Transparent;
            this.simpleTransperentLabel5.Enabled = false;
            this.simpleTransperentLabel5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.simpleTransperentLabel5.Location = new System.Drawing.Point(12, 367);
            this.simpleTransperentLabel5.Name = "simpleTransperentLabel5";
            this.simpleTransperentLabel5.Size = new System.Drawing.Size(128, 17);
            this.simpleTransperentLabel5.TabIndex = 30;
            this.simpleTransperentLabel5.Text = "BackColor QR Code";
            // 
            // simpleTransperentLabel6
            // 
            this.simpleTransperentLabel6.AutoSize = true;
            this.simpleTransperentLabel6.BackColor = System.Drawing.Color.Transparent;
            this.simpleTransperentLabel6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.simpleTransperentLabel6.Location = new System.Drawing.Point(21, 265);
            this.simpleTransperentLabel6.Name = "simpleTransperentLabel6";
            this.simpleTransperentLabel6.Size = new System.Drawing.Size(126, 17);
            this.simpleTransperentLabel6.TabIndex = 29;
            this.simpleTransperentLabel6.Text = "ForeColor QR Code";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblData.Location = new System.Drawing.Point(21, 83);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(36, 17);
            this.lblData.TabIndex = 31;
            this.lblData.Text = "Text";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picEncode);
            this.panel1.Location = new System.Drawing.Point(503, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 250);
            this.panel1.TabIndex = 27;
            // 
            // picEncode
            // 
            this.picEncode.BackColor = System.Drawing.Color.White;
            this.picEncode.Location = new System.Drawing.Point(3, 3);
            this.picEncode.Name = "picEncode";
            this.picEncode.Size = new System.Drawing.Size(244, 244);
            this.picEncode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEncode.TabIndex = 20;
            this.picEncode.TabStop = false;
            // 
            // txtLogo
            // 
            this.txtLogo.BackColor = System.Drawing.Color.Transparent;
            this.txtLogo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtLogo.ForeColor = System.Drawing.Color.White;
            this.txtLogo.Location = new System.Drawing.Point(144, 124);
            this.txtLogo.MaxLength = 32767;
            this.txtLogo.MultiLine = false;
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.Size = new System.Drawing.Size(310, 24);
            this.txtLogo.TabIndex = 32;
            this.txtLogo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLogo.UseSystemPasswordChar = false;
            // 
            // txtScale
            // 
            this.txtScale.BackColor = System.Drawing.Color.Transparent;
            this.txtScale.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtScale.ForeColor = System.Drawing.Color.White;
            this.txtScale.Location = new System.Drawing.Point(344, 216);
            this.txtScale.MaxLength = 32767;
            this.txtScale.MultiLine = false;
            this.txtScale.Name = "txtScale";
            this.txtScale.Size = new System.Drawing.Size(150, 24);
            this.txtScale.TabIndex = 33;
            this.txtScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtScale.UseSystemPasswordChar = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblLink
            // 
            this.lblLink.BackColor = System.Drawing.Color.Transparent;
            this.lblLink.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblLink.ForeColor = System.Drawing.Color.White;
            this.lblLink.Location = new System.Drawing.Point(48, 6);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(184, 13);
            this.lblLink.TabIndex = 34;
            this.lblLink.Text = "Design && Coded by quochung27092k";
            // 
            // btnQRCodeForegroundColor
            // 
            this.btnQRCodeForegroundColor.BackColor = System.Drawing.Color.Black;
            this.btnQRCodeForegroundColor.ForeColor = System.Drawing.Color.White;
            this.btnQRCodeForegroundColor.Location = new System.Drawing.Point(144, 262);
            this.btnQRCodeForegroundColor.Name = "btnQRCodeForegroundColor";
            this.btnQRCodeForegroundColor.Size = new System.Drawing.Size(350, 23);
            this.btnQRCodeForegroundColor.TabIndex = 35;
            this.btnQRCodeForegroundColor.Text = "Choose color";
            this.btnQRCodeForegroundColor.UseVisualStyleBackColor = false;
            this.btnQRCodeForegroundColor.Click += new System.EventHandler(this.btnQRCodeForegroundColor_Click);
            // 
            // btnQRCodeBackgroundColor
            // 
            this.btnQRCodeBackgroundColor.BackColor = System.Drawing.Color.White;
            this.btnQRCodeBackgroundColor.Enabled = false;
            this.btnQRCodeBackgroundColor.Location = new System.Drawing.Point(143, 364);
            this.btnQRCodeBackgroundColor.Name = "btnQRCodeBackgroundColor";
            this.btnQRCodeBackgroundColor.Size = new System.Drawing.Size(340, 23);
            this.btnQRCodeBackgroundColor.TabIndex = 36;
            this.btnQRCodeBackgroundColor.Text = "Choose color";
            this.btnQRCodeBackgroundColor.UseVisualStyleBackColor = false;
            this.btnQRCodeBackgroundColor.Click += new System.EventHandler(this.btnQRCodeBackgroundColor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(15, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 135);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recommendations";
            // 
            // btnFB
            // 
            this.btnFB.BackColor = System.Drawing.Color.Transparent;
            this.btnFB.Cursor = System.Windows.Forms.Cursors.No;
            this.btnFB.Image = ((System.Drawing.Image)(resources.GetObject("btnFB.Image")));
            this.btnFB.ImageActive = null;
            this.btnFB.Location = new System.Drawing.Point(0, 0);
            this.btnFB.Name = "btnFB";
            this.btnFB.Size = new System.Drawing.Size(24, 24);
            this.btnFB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFB.TabIndex = 38;
            this.btnFB.TabStop = false;
            this.btnFB.Zoom = 10;
            this.btnFB.Click += new System.EventHandler(this.btnFB_Click);
            // 
            // btnIG
            // 
            this.btnIG.BackColor = System.Drawing.Color.Transparent;
            this.btnIG.Cursor = System.Windows.Forms.Cursors.No;
            this.btnIG.Image = ((System.Drawing.Image)(resources.GetObject("btnIG.Image")));
            this.btnIG.ImageActive = null;
            this.btnIG.Location = new System.Drawing.Point(23, 0);
            this.btnIG.Name = "btnIG";
            this.btnIG.Size = new System.Drawing.Size(24, 24);
            this.btnIG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnIG.TabIndex = 39;
            this.btnIG.TabStop = false;
            this.btnIG.Zoom = 10;
            this.btnIG.Click += new System.EventHandler(this.btnIG_Click);
            // 
            // QRCodeGenerator
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(768, 346);
            this.Controls.Add(this.btnIG);
            this.Controls.Add(this.btnFB);
            this.Controls.Add(this.btnQRCodeBackgroundColor);
            this.Controls.Add(this.btnQRCodeForegroundColor);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.txtScale);
            this.Controls.Add(this.txtLogo);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.simpleTransperentLabel5);
            this.Controls.Add(this.simpleTransperentLabel6);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.simpleTransperentLabel7);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnChooseLogo);
            this.Controls.Add(this.cbVersion);
            this.Controls.Add(this.cbCorrectionLevel);
            this.Controls.Add(this.cbEncoding);
            this.Controls.Add(this.simpleTransperentLabel3);
            this.Controls.Add(this.simpleTransperentLabel4);
            this.Controls.Add(this.simpleTransperentLabel2);
            this.Controls.Add(this.simpleTransperentLabel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "QRCodeGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[DEMO] QR Code Generator with Logo";
            this.Load += new System.EventHandler(this.QRCode_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picEncode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Simpleblue_Theme.SimpleTransperentLabel simpleTransperentLabel1;
        private Simpleblue_Theme.SimpleTransperentLabel simpleTransperentLabel2;
        private Simpleblue_Theme.SimpleTransperentLabel simpleTransperentLabel3;
        private Simpleblue_Theme.SimpleTransperentLabel simpleTransperentLabel4;
        private Redemption_theme.RedemptionComboBox cbEncoding;
        private Redemption_theme.RedemptionComboBox cbCorrectionLevel;
        private Redemption_theme.RedemptionComboBox cbVersion;
        private Redemption_theme.RedemptionButton btnChooseLogo;
        private Redemption_theme.RedemptionTextBox txtData;
        private Redemption_theme.RedemptionButton btnC;
        private Redemption_theme.RedemptionButton btnS;
        private Simpleblue_Theme.SimpleTransperentLabel simpleTransperentLabel7;
        private Redemption_theme.RedemptionButton btnD;
        private Simpleblue_Theme.SimpleTransperentLabel simpleTransperentLabel5;
        private Simpleblue_Theme.SimpleTransperentLabel simpleTransperentLabel6;
        private Simpleblue_Theme.SimpleTransperentLabel lblData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picEncode;
        private Redemption_theme.RedemptionTextBox txtLogo;
        private Redemption_theme.RedemptionTextBox txtScale;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.Button btnQRCodeForegroundColor;
        private System.Windows.Forms.Button btnQRCodeBackgroundColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuImageButton btnFB;
        private Bunifu.Framework.UI.BunifuImageButton btnIG;
    }
}