using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;
using ThoughtWorks.QRCode.Codec.Data;
using ThoughtWorks.QRCode.Codec.Util;
using System.IO;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Diagnostics;

namespace DemoQRCodeGenerator
{
    public partial class QRCodeGenerator : MaterialForm
    {
        public QRCodeGenerator()
        {
            InitializeComponent();
            string[] cbversion = new string[41];
            for (int i = 0; i <= 10; i++)
            {
                cbversion[i] = i.ToString();
            }
            cbVersion.DataSource = cbversion;
            cbVersion.Text = "7";
            cbEncoding.Text = "Byte";
            cbCorrectionLevel.Text = "M";
            txtScale.Text = "6";
        }

        private void btnQRCodeForegroundColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                btnQRCodeForegroundColor.BackColor = cd.Color;
            }
        }

        private void btnQRCodeBackgroundColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                btnQRCodeBackgroundColor.BackColor = cd.Color;
            }
        }

        private void btnChooseLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image|*.jpg;*.bmp;*.gif;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtLogo.Text = ofd.FileName;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            try
            {
                lblData.Text = "Text";
                string encoding = cbEncoding.Text;
                string correctionLever = cbCorrectionLevel.Text;
                int version = Convert.ToInt32(cbVersion.Text);
                int scale;
                if (!int.TryParse(txtScale.Text.Trim(), out scale))
                {
                    MessageBox.Show("Not entered rate!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string data = txtData.Text.Trim();
                if (data == string.Empty)
                {
                    MessageBox.Show("No text entered!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
                switch (encoding)
                {
                    case "Byte":
                        qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
                        break;

                    case "AlphaNumeric":
                        qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.ALPHA_NUMERIC;
                        break;

                    case "Numeric":
                        qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.NUMERIC;
                        break;
                }
                qrCodeEncoder.QRCodeScale = scale;
                qrCodeEncoder.QRCodeVersion = version;
                if (correctionLever == "L")
                {
                    qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
                }
                else if (correctionLever == "M")
                {
                    qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
                }
                else if (correctionLever == "Q")
                {
                    qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q;
                }
                else if (correctionLever == "H")
                {
                    qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H;
                }
                qrCodeEncoder.QRCodeForegroundColor = btnQRCodeForegroundColor.BackColor;
                qrCodeEncoder.QRCodeBackgroundColor = btnQRCodeBackgroundColor.BackColor;
                Image image = qrCodeEncoder.Encode(data, Encoding.UTF8);
                if (txtLogo.Text.Trim() != string.Empty)
                {
                    Bitmap btm = new Bitmap(txtLogo.Text);
                    Bitmap copyImage = new Bitmap(btm, image.Width / 4, image.Height / 4);
                    Graphics g = Graphics.FromImage(image);
                    int x = image.Width / 2 - copyImage.Width / 2;
                    int y = image.Height / 2 - copyImage.Height / 2;
                    g.DrawImage(copyImage, x, y);
                }
                picEncode.Image = image;
            }
            catch
            {
                DialogResult dlr = MessageBox.Show("Characters do not support! / Wrong path!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dlr == DialogResult.OK)
                {
                    txtData.Text = "";
                }
            }
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG Image|*.jpg|PNG Image|*.png|GIF Image|*.gif|Bitmap Image|*.bmp";
            sfd.FileName = "QR Code";
            if (picEncode.Image != null)
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = (FileStream)sfd.OpenFile())
                    {
                        switch (sfd.FilterIndex)
                        {
                            case 1:
                                picEncode.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                                break;
                            case 2:
                                picEncode.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                                break;
                            case 3:
                                picEncode.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                                break;
                            case 4:
                                picEncode.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                                break;
                        }
                    }
                    MessageBox.Show("Saved!", "Notification", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("No QR codes created yet!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            lblData.Text = "Text";
            txtData.Text = "";
            txtData.Focus();
            picEncode.Image = null;
            if (chkbD.Checked == true)
            {

            }
            else
            {
                txtLogo.Text = "";
            }
        }

        private void QRCode_Load(object sender, EventArgs e)
        {
            txtData.Focus();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtData.Text.Length > 0)
            {
                btnC.Enabled = true;
            }
            else
            {
                btnC.Enabled = false;
            }
            if (txtData.Text.Length > 0 && picEncode.Image != null)
            {
                btnD.Enabled = true;
                btnS.Enabled = true;
            }
            else
            {
                btnD.Enabled = false;
                btnS.Enabled = false;
            }
        }

        private void btnFB_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/quochung27092k");
        }

        private void btnIG_Click(object sender, EventArgs e)
        {
            Process.Start("https://instagram.com/quochung2792k"); 
        }
    }
}
