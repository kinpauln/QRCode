namespace 二维码生成
{
    using Microsoft.Win32;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.IO;
    using System.Management;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security.Cryptography;
    using System.Text;
    using System.Windows.Forms;
    using ThoughtWorks.QRCode.Codec;
    using ThoughtWorks.QRCode.Codec.Data;
    using 二维码生成.Properties;

    public class Form1 : Form
    {
        private Button button1;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button2;
        private Button button20;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private ComboBox cboCorrectionLevel;
        private ComboBox cboEncoding;
        private ComboBox cboVersion;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private IContainer components = null;
        private GroupBox groupBox1;
        public const int idHook = 13;
        private HookProc KeyboardHookProcedure;
        private Label label1;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label2;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label3;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label label35;
        private Label label36;
        private Label label37;
        private Label label38;
        private Label label39;
        private Label label4;
        private Label label40;
        private Label label41;
        private Label label42;
        private Label label43;
        private Label label44;
        private Label label45;
        private Label label46;
        private Label label47;
        private Label label48;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private IntPtr pKeyboardHook = IntPtr.Zero;
        private bool reg_YN = false;
        private int regsum = 0;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox6;
        private StatusStrip statusStrip1;
        private TabControl tabControl1;
        private TabControl tabControl2;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private TabPage tabPage9;
        private TextBox textBox1;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox textBox15;
        private TextBox textBox16;
        private TextBox textBox17;
        private TextBox textBox18;
        private TextBox textBox19;
        private TextBox textBox2;
        private TextBox textBox20;
        private TextBox textBox21;
        private TextBox textBox22;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TextBox txtSize;
        private int use_sum = 0;
        private int use_zsum = 0;

        public Form1()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label44.Visible = true;
            this.richTextBox1.Text = "";
            if (this.tabControl2.SelectedIndex == 0)
            {
                this.richTextBox1.Text = this.richTextBox3.Text;
            }
            else if (this.tabControl2.SelectedIndex == 1)
            {
                this.richTextBox1.Text = "BEGIN:VCARD\nVERSION:3.0\n";
                if (this.textBox10.Text.Trim() != "")
                {
                    this.richTextBox1.Text = this.richTextBox1.Text + "N:" + this.textBox10.Text.Trim() + "\n";
                }
                if (this.textBox11.Text.Trim() != "")
                {
                    this.richTextBox1.Text = this.richTextBox1.Text + "TEL:" + this.textBox11.Text.Trim() + "\n";
                }
                if (this.textBox12.Text.Trim() != "")
                {
                    this.richTextBox1.Text = this.richTextBox1.Text + "TEL:" + this.textBox12.Text.Trim() + "\n";
                }
                if (this.textBox13.Text.Trim() != "")
                {
                    this.richTextBox1.Text = this.richTextBox1.Text + "EMAIL:" + this.textBox13.Text.Trim() + "\n";
                }
                if (this.textBox14.Text.Trim() != "")
                {
                    this.richTextBox1.Text = this.richTextBox1.Text + "TITLE:" + this.textBox14.Text.Trim() + "\n";
                }
                if (this.textBox15.Text.Trim() != "")
                {
                    this.richTextBox1.Text = this.richTextBox1.Text + "ADR:" + this.textBox15.Text.Trim() + "\n";
                }
                if (this.textBox16.Text.Trim() != "")
                {
                    this.richTextBox1.Text = this.richTextBox1.Text + "ORG:" + this.textBox16.Text.Trim() + "\n";
                }
                if ((this.textBox17.Text.Trim() != "") && (this.textBox17.Text.Trim() != "http://"))
                {
                    this.richTextBox1.Text = this.richTextBox1.Text + "URL:" + this.textBox17.Text.Trim() + "\n";
                }
                this.richTextBox1.Text = this.richTextBox1.Text + "END:VCARD";
            }
            else if (this.tabControl2.SelectedIndex == 2)
            {
                if ((this.textBox22.Text.Trim() != "") && (this.textBox22.Text.Trim() != "http://"))
                {
                    this.richTextBox1.Text = this.textBox22.Text;
                }
            }
            else if (this.tabControl2.SelectedIndex == 3)
            {
                this.richTextBox1.Text = "TEL:" + this.textBox20.Text.Trim();
            }
            else if (this.tabControl2.SelectedIndex == 4)
            {
                this.richTextBox1.Text = "SMSTO:" + this.textBox21.Text.Trim() + ":" + this.richTextBox6.Text.Trim();
            }
            else if (this.tabControl2.SelectedIndex == 5)
            {
                if (this.comboBox3.SelectedIndex == 0)
                {
                    this.richTextBox1.Text = "WIFI:T:WPA;S:" + this.textBox18.Text.Trim() + ";P:" + this.textBox19.Text.Trim() + ";";
                }
                else if (this.comboBox3.SelectedIndex == 1)
                {
                    this.richTextBox1.Text = "WIFI:T:WEP;S:" + this.textBox18.Text.Trim() + ";P:" + this.textBox19.Text.Trim() + ";";
                }
                else if (this.comboBox3.SelectedIndex == 2)
                {
                    this.richTextBox1.Text = "WIFI:S:" + this.textBox18.Text.Trim() + ";";
                }
            }
            try
            {
                Image image;
                Graphics graphics;
                if (this.checkBox1.Checked)
                {
                    if (this.textBox3.Text.Trim() == "")
                    {
                        OpenFileDialog dialog = new OpenFileDialog {
                            Filter = "PNG Image|*.png|JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif",
                            Title = "打开二维码中间放置的图片",
                            FileName = string.Empty
                        };
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            if (this.reg_YN)
                            {
                                this.pictureBox1.Image = this.CombinImage(this.GCode(this.richTextBox1.Text), dialog.FileName);
                                this.label44.Visible = false;
                            }
                            else
                            {
                                this.pictureBox1.Image = this.CombinImage(this.GCode(this.richTextBox1.Text), dialog.FileName);
                                this.label44.Visible = false;
                                image = this.pictureBox1.Image;
                                graphics = Graphics.FromImage(image);
                                graphics.DrawString("试用版", new Font("宋体", (float) (5 * int.Parse(this.txtSize.Text)), FontStyle.Bold), new SolidBrush(System.Drawing.Color.Black), (float) ((3 * int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2)), (float) ((8 * int.Parse(this.txtSize.Text)) - (int.Parse(this.txtSize.Text) / 3)));
                                graphics.DrawString("试用版", new Font("宋体", (float) (5 * int.Parse(this.txtSize.Text)), FontStyle.Bold), new SolidBrush(System.Drawing.Color.Red), (float) (3 * int.Parse(this.txtSize.Text)), (float) (8 * int.Parse(this.txtSize.Text)));
                                this.pictureBox1.Image = image;
                                graphics.Dispose();
                            }
                            this.textBox3.Text = dialog.FileName;
                        }
                        else
                        {
                            MessageBox.Show("请先选择叠加的图片！");
                        }
                    }
                    else if (this.reg_YN)
                    {
                        this.pictureBox1.Image = this.CombinImage(this.GCode(this.richTextBox1.Text), this.textBox3.Text.Trim());
                        this.label44.Visible = false;
                    }
                    else
                    {
                        this.pictureBox1.Image = this.CombinImage(this.GCode(this.richTextBox1.Text), this.textBox3.Text.Trim());
                        this.label44.Visible = false;
                        image = this.pictureBox1.Image;
                        graphics = Graphics.FromImage(image);
                        graphics.DrawString("试用版", new Font("宋体", (float) (5 * int.Parse(this.txtSize.Text)), FontStyle.Bold), new SolidBrush(System.Drawing.Color.Black), (float) ((3 * int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2)), (float) ((8 * int.Parse(this.txtSize.Text)) - (int.Parse(this.txtSize.Text) / 3)));
                        graphics.DrawString("试用版", new Font("宋体", (float) (5 * int.Parse(this.txtSize.Text)), FontStyle.Bold), new SolidBrush(System.Drawing.Color.Red), (float) (3 * int.Parse(this.txtSize.Text)), (float) (8 * int.Parse(this.txtSize.Text)));
                        this.pictureBox1.Image = image;
                        this.label44.Visible = false;
                        graphics.Dispose();
                    }
                }
                else if (this.reg_YN)
                {
                    this.pictureBox1.Image = this.GCode(this.richTextBox1.Text);
                    this.label44.Visible = false;
                }
                else
                {
                    this.pictureBox1.Image = this.GCode(this.richTextBox1.Text);
                    this.label44.Visible = false;
                    image = this.pictureBox1.Image;
                    graphics = Graphics.FromImage(image);
                    graphics.DrawString("试用版", new Font("宋体", (float) (5 * int.Parse(this.txtSize.Text)), FontStyle.Bold), new SolidBrush(System.Drawing.Color.Black), (float) ((3 * int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2)), (float) ((8 * int.Parse(this.txtSize.Text)) - (int.Parse(this.txtSize.Text) / 3)));
                    graphics.DrawString("试用版", new Font("宋体", (float) (5 * int.Parse(this.txtSize.Text)), FontStyle.Bold), new SolidBrush(System.Drawing.Color.Red), (float) (3 * int.Parse(this.txtSize.Text)), (float) (8 * int.Parse(this.txtSize.Text)));
                    this.pictureBox1.Image = image;
                    graphics.Dispose();
                }
                this.label8.Text = "(" + this.pictureBox1.Image.Width.ToString() + "," + this.pictureBox1.Image.Height.ToString() + ")";
            }
            catch
            {
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.checkBox3.Checked = true;
            if (this.checkBox3.Checked)
            {
                ColorDialog dialog = new ColorDialog();
                ColorConverter converter = new ColorConverter();
                dialog.Color = System.Drawing.Color.Black;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.button10.BackColor = dialog.Color;
                    this.creat_image();
                    this.Refresh();
                }
            }
            else
            {
                MessageBox.Show("请先选择渐变色");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.checkBox3.Checked = true;
            if (this.checkBox3.Checked)
            {
                ColorDialog dialog = new ColorDialog();
                ColorConverter converter = new ColorConverter();
                dialog.Color = System.Drawing.Color.Black;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.button11.BackColor = dialog.Color;
                    this.creat_image();
                    this.Refresh();
                }
            }
            else
            {
                MessageBox.Show("请先选择渐变色");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                QRCodeDecoder decoder = new QRCodeDecoder();
                string str = "";
                if (this.comboBox4.SelectedIndex == 0)
                {
                    str = decoder.decode(new QRCodeBitmapImage(new Bitmap(this.pictureBox1.Image)), Encoding.GetEncoding("gb2312"));
                }
                if (this.comboBox4.SelectedIndex == 1)
                {
                    str = decoder.decode(new QRCodeBitmapImage(new Bitmap(this.pictureBox1.Image)), Encoding.UTF8);
                }
                if (this.comboBox4.SelectedIndex == 2)
                {
                    str = decoder.decode(new QRCodeBitmapImage(new Bitmap(this.pictureBox1.Image)), Encoding.Unicode);
                }
                MessageBox.Show(str.Trim(), "信息");
            }
            catch
            {
                MessageBox.Show("无法识别，建议采用手机扫描识别！");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            ColorConverter converter = new ColorConverter();
            dialog.Color = System.Drawing.Color.Black;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.button14.BackColor = dialog.Color;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.textBox7.Text = this.GetCpuInfo() + this.GetDiskInfo() + random.Next(0, 100).ToString();
            QRCodeEncoder encoder = new QRCodeEncoder {
                QRCodeBackgroundColor = System.Drawing.Color.White
            };
            string text = this.cboEncoding.Text;
            encoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            encoder.QRCodeScale = 0x10;
            encoder.QRCodeVersion = 4;
            encoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q;
            if (this.comboBox4.SelectedIndex == 0)
            {
                this.pictureBox5.Image = encoder.Encode(this.textBox7.Text, Encoding.GetEncoding("gb2312"));
            }
            if (this.comboBox4.SelectedIndex == 1)
            {
                this.pictureBox5.Image = encoder.Encode(this.textBox7.Text, Encoding.UTF8);
            }
            if (this.comboBox4.SelectedIndex == 2)
            {
                this.pictureBox5.Image = encoder.Encode(this.textBox7.Text, Encoding.Unicode);
            }
            this.button15.Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog {
                Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png",
                Title = "打开背景图片",
                FileName = string.Empty
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.textBox6.Text = dialog.FileName;
                this.pictureBox1.Image = Image.FromFile(dialog.FileName);
            }
            else
            {
                MessageBox.Show("请先选择背景的图片！");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                int.Parse(this.textBox9.Text.Trim());
            }
            catch
            {
                MessageBox.Show("使用次数不是整数", "出错");
                return;
            }
            if (this.textBox8.Text.Trim() == this.password(this.textBox7.Text, int.Parse(this.textBox9.Text.Trim())))
            {
                this.reg_YN = true;
                this.use_sum = 0;
                this.use_zsum = int.Parse(this.textBox9.Text);
                this.pictureBox4.Image = Resources.button_ok;
                RegistryKey key2 = Registry.CurrentUser.CreateSubKey("Sysqrcode");
                key2.SetValue("syzs", this.textBox9.Text.Trim());
                key2.SetValue("regtxt", this.textBox8.Text.Trim());
                key2.SetValue("dqcs", GetMd5Str(this.use_sum.ToString().Trim()));
                key2.SetValue("jqmhc", this.textBox7.Text.Trim());
                this.textBox8.Enabled = false;
                this.textBox9.Enabled = false;
                this.button17.Enabled = false;
                this.toolStripStatusLabel1.Text = "您现在已经使用了0次，总次数" + this.textBox9.Text;
                MessageBox.Show("注册成功", "提示");
                StreamWriter writer = File.CreateText(Directory.GetCurrentDirectory() + @"\reg.ini");
                writer.WriteLine(this.textBox9.Text.Trim());
                writer.WriteLine(this.textBox8.Text.Trim());
                writer.WriteLine(this.textBox7.Text.Trim());
                writer.Flush();
                writer.Close();
                this.Refresh();
            }
            else
            {
                this.pictureBox4.Image = Resources.button_cancel;
                this.regsum++;
                if (this.regsum > 3)
                {
                    MessageBox.Show("注册码输入错误次数超过三次", "出错");
                    Application.Exit();
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.checkBox3.Checked = true;
            if (this.checkBox3.Checked)
            {
                ColorDialog dialog = new ColorDialog();
                ColorConverter converter = new ColorConverter();
                dialog.Color = System.Drawing.Color.White;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.button18.BackColor = dialog.Color;
                    this.creat_image();
                    this.Refresh();
                }
            }
            else
            {
                MessageBox.Show("请先选择渐变色");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.checkBox3.Checked = true;
            if (this.checkBox3.Checked)
            {
                ColorDialog dialog = new ColorDialog();
                ColorConverter converter = new ColorConverter();
                dialog.Color = System.Drawing.Color.White;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.button19.BackColor = dialog.Color;
                    this.creat_image();
                    this.Refresh();
                }
            }
            else
            {
                MessageBox.Show("请先选择渐变色");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog {
                    Filter = "PNG Image|*.png|JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif",
                    Title = "--Save--",
                    FileName = string.Empty
                };
                if ((dialog.ShowDialog() == DialogResult.OK) && (dialog.FileName != null))
                {
                    if (this.reg_str_yn("Sysqrcode"))
                    {
                        if (this.reg_YN)
                        {
                            if (this.use_sum < this.use_zsum)
                            {
                                this.pictureBox1.Image.Save(dialog.FileName);
                                this.use_sum++;
                                this.toolStripStatusLabel1.Text = "您现在已经使用了" + this.use_sum.ToString() + "次，总次数" + this.use_zsum.ToString();
                                this.pictureBox4.Image = Resources.button_ok;
                                RegistryKey key2 = Registry.CurrentUser.CreateSubKey("Sysqrcode");
                                key2.SetValue("syzs", this.textBox9.Text.Trim());
                                key2.SetValue("regtxt", this.textBox8.Text.Trim());
                                key2.SetValue("dqcs", GetMd5Str(this.use_sum.ToString().Trim()));
                                key2.SetValue("jqmhc", this.textBox7.Text.Trim());
                                this.textBox8.Enabled = false;
                                this.textBox9.Enabled = false;
                                this.button17.Enabled = false;
                                this.button15.Enabled = false;
                            }
                            else
                            {
                                this.reg_YN = false;
                                this.textBox8.Enabled = true;
                                this.textBox9.Enabled = true;
                                this.button17.Enabled = true;
                                this.button15.Enabled = true;
                                this.textBox8.Text = "";
                                this.textBox9.Text = "";
                                this.textBox7.Text = "点击获取获得注册码";
                                this.pictureBox4.Image = Resources.button_cancel;
                                MessageBox.Show("软件注册的次数已经使用完，不能保存，请联系作者重新注册1！", "出错");
                            }
                        }
                        else
                        {
                            this.reg_YN = false;
                            this.textBox8.Enabled = true;
                            this.textBox9.Enabled = true;
                            this.button17.Enabled = true;
                            this.button15.Enabled = true;
                            this.textBox8.Text = "";
                            this.textBox9.Text = "";
                            this.textBox7.Text = "点击获取获得注册码";
                            this.pictureBox4.Image = Resources.button_cancel;
                            MessageBox.Show("软件注册的次数已经使用完，不能保存，请联系作者重新注册2！", "出错");
                        }
                    }
                    else
                    {
                        this.reg_YN = false;
                        MessageBox.Show("软件还未注册，不能使用保存功能！", "出错");
                    }
                }
            }
            catch
            {
                MessageBox.Show("保存时发生异常，请检查要保存的文件是否处于打开状态");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.creat_image();
            this.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox2.Image = Image.FromFile(dialog.FileName.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                QRCodeDecoder decoder = new QRCodeDecoder();
                string str = "";
                if (this.comboBox5.SelectedIndex == 0)
                {
                    str = decoder.decode(new QRCodeBitmapImage(new Bitmap(this.pictureBox2.Image)), Encoding.GetEncoding("gb2312"));
                }
                if (this.comboBox5.SelectedIndex == 1)
                {
                    str = decoder.decode(new QRCodeBitmapImage(new Bitmap(this.pictureBox2.Image)), Encoding.UTF8);
                }
                if (this.comboBox5.SelectedIndex == 2)
                {
                    str = decoder.decode(new QRCodeBitmapImage(new Bitmap(this.pictureBox2.Image)), Encoding.Unicode);
                }
                this.richTextBox2.Text = str;
            }
            catch
            {
                MessageBox.Show("无法识别，建议采用手机扫描识别！");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string url = Directory.GetCurrentDirectory() + @"\help.chm";
            Help.ShowHelp(this, url);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            ColorConverter converter = new ColorConverter();
            dialog.Color = System.Drawing.Color.White;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.button6.BackColor = dialog.Color;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.checkBox2.Checked = true;
            if (this.checkBox2.Checked)
            {
                ColorDialog dialog = new ColorDialog();
                ColorConverter converter = new ColorConverter();
                dialog.Color = System.Drawing.Color.Black;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.button7.BackColor = dialog.Color;
                    Bitmap image = new Bitmap(0x1388, 0x1388);
                    Graphics graphics = Graphics.FromImage(image);
                    graphics.FillRectangle(new SolidBrush(dialog.Color), 0, 0, 0x1388, 0x1388);
                    graphics.Dispose();
                    this.pictureBox3.Image = image;
                }
            }
            else
            {
                MessageBox.Show("还未选择单色的选项！");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            ColorConverter converter = new ColorConverter();
            dialog.Color = System.Drawing.Color.White;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.button8.BackColor = dialog.Color;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.checkBox2.Checked = false;
            this.checkBox3.Checked = false;
            try
            {
                if (!this.checkBox2.Checked && !this.checkBox3.Checked)
                {
                    OpenFileDialog dialog = new OpenFileDialog {
                        Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png",
                        Title = "--Open--",
                        FileName = string.Empty
                    };
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        this.pictureBox3.Image = Image.FromFile(dialog.FileName);
                    }
                    else
                    {
                        MessageBox.Show("请先选择前景的图片！");
                    }
                }
                else
                {
                    MessageBox.Show("请不要选择单色和渐变色！");
                }
            }
            catch
            {
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.textBox1.Visible = true;
                this.textBox2.Visible = true;
                this.label10.Visible = true;
                this.label11.Visible = true;
                this.label12.Visible = true;
                this.label13.Visible = true;
                this.label14.Visible = true;
                this.button12.Visible = true;
                this.textBox4.Visible = true;
                this.textBox5.Visible = true;
                this.numericUpDown1.Visible = true;
            }
            else
            {
                this.textBox1.Visible = false;
                this.textBox2.Visible = false;
                this.label10.Visible = false;
                this.label11.Visible = false;
                this.label12.Visible = false;
                this.label13.Visible = false;
                this.label14.Visible = false;
                this.button12.Visible = false;
                this.textBox3.Text = "";
                this.textBox4.Visible = false;
                this.textBox5.Visible = false;
                this.numericUpDown1.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.checkBox3.Checked = false;
                Bitmap image = new Bitmap(0x1388, 0x1388);
                Graphics graphics = Graphics.FromImage(image);
                graphics.FillRectangle(new SolidBrush(this.button7.BackColor), 0, 0, 0x1388, 0x1388);
                graphics.Dispose();
                this.pictureBox3.Image = image;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked)
            {
                this.checkBox2.Checked = false;
                this.creat_image();
                this.Refresh();
            }
        }

        private Image CombinImage(Image imgBack, string destImg)
        {
            int newW = 0;
            int newH = 0;
            try
            {
                newW = int.Parse(this.textBox1.Text.Trim());
                newH = int.Parse(this.textBox2.Text.Trim());
            }
            catch
            {
                MessageBox.Show("嵌入的图片宽和高不是整数！");
                return null;
            }
            Image bmp = Image.FromFile(destImg);
            bmp = this.KiResizeImage(bmp, newW, newH, 0);
            bmp = this.Rotate(bmp, (int) this.numericUpDown1.Value);
            Graphics graphics = Graphics.FromImage(imgBack);
            graphics.DrawImage(imgBack, 0, 0, imgBack.Width, imgBack.Height);
            graphics.DrawImage(bmp, ((imgBack.Width / 2) - (bmp.Width / 2)) + int.Parse(this.textBox5.Text), ((imgBack.Height / 2) - (bmp.Height / 2)) + int.Parse(this.textBox4.Text), bmp.Width, bmp.Height);
            GC.Collect();
            return imgBack;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked)
            {
                this.creat_image();
                this.Refresh();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox2.SelectedIndex == 7)
            {
                this.button6.BackColor = System.Drawing.Color.Transparent;
                this.button8.BackColor = System.Drawing.Color.Transparent;
            }
            else
            {
                this.button6.BackColor = System.Drawing.Color.White;
                this.button8.BackColor = System.Drawing.Color.White;
            }
            if (this.comboBox2.SelectedIndex == 6)
            {
                this.button16.Visible = true;
                this.label16.Visible = true;
            }
            else
            {
                this.button16.Visible = false;
                this.label16.Visible = false;
            }
            if (this.comboBox2.SelectedIndex == 5)
            {
                this.button14.Visible = true;
                this.label15.Visible = true;
                this.numericUpDown4.Visible = true;
                this.label27.Visible = true;
            }
            else
            {
                this.button14.Visible = false;
                this.label15.Visible = false;
                this.numericUpDown4.Visible = false;
                this.label27.Visible = false;
            }
        }

        private void creat_image()
        {
            Point point;
            int num;
            GraphicsPath path;
            PathGradientBrush brush;
            System.Drawing.Color[] colorArray;
            Bitmap image = new Bitmap(0x1388, 0x1388);
            Graphics graphics = Graphics.FromImage(image);
            if (this.comboBox1.SelectedIndex == 4)
            {
                this.button18.Visible = false;
                this.button19.Visible = false;
                this.button20.Visible = false;
                this.label23.Visible = false;
                this.numericUpDown5.Visible = false;
                point = new Point(0x9c4, 0x9c4);
                num = (int) (2500.0 / Math.Cos(45.0));
                path = new GraphicsPath();
                path.AddEllipse((int) (point.X - num), (int) (point.Y - num), (int) (2 * num), (int) (2 * num));
                brush = new PathGradientBrush(path) {
                    CenterPoint = (PointF) point,
                    CenterColor = this.button11.BackColor
                };
                colorArray = new System.Drawing.Color[] { this.button10.BackColor };
                brush.SurroundColors = colorArray;
                brush.SetSigmaBellShape((float) this.numericUpDown2.Value);
                graphics.FillEllipse(brush, (int) (point.X - num), (int) (point.Y - num), (int) (2 * num), (int) (2 * num));
                brush.Dispose();
                graphics.Dispose();
                this.pictureBox3.Image = image;
            }
            else
            {
                Rectangle rectangle;
                LinearGradientBrush brush2;
                Point point2;
                int num2;
                GraphicsPath path2;
                PathGradientBrush brush3;
                if (this.comboBox1.SelectedIndex == 5)
                {
                    this.button18.Visible = true;
                    this.button19.Visible = true;
                    this.button20.Visible = true;
                    this.label23.Visible = true;
                    this.numericUpDown5.Visible = true;
                    rectangle = new Rectangle {
                        Width = 0x1388,
                        Height = 0x1388
                    };
                    brush2 = null;
                    brush2 = new LinearGradientBrush(rectangle, this.button10.BackColor, this.button19.BackColor, LinearGradientMode.Vertical);
                    brush2.SetSigmaBellShape((float) this.numericUpDown2.Value);
                    graphics.FillRectangle(brush2, 0, 0, 0x1388, 0x1388);
                    brush2.Dispose();
                    point2 = new Point(0x9c4, 0x9c4);
                    num2 = (int) (1000M * this.numericUpDown5.Value);
                    path2 = new GraphicsPath();
                    path2.AddEllipse((int) (point2.X - num2), (int) (point2.Y - num2), (int) (2 * num2), (int) (2 * num2));
                    brush3 = new PathGradientBrush(path2) {
                        CenterPoint = (PointF) point2,
                        CenterColor = this.button18.BackColor
                    };
                    colorArray = new System.Drawing.Color[] { this.button11.BackColor };
                    brush3.SurroundColors = colorArray;
                    graphics.FillEllipse(brush3, (int) (point2.X - num2), (int) (point2.Y - num2), (int) (2 * num2), (int) (2 * num2));
                    brush3.Dispose();
                    graphics.Dispose();
                    this.pictureBox3.Image = image;
                }
                else if (this.comboBox1.SelectedIndex == 6)
                {
                    this.button18.Visible = true;
                    this.button19.Visible = true;
                    this.button20.Visible = true;
                    this.label23.Visible = true;
                    this.numericUpDown5.Visible = true;
                    rectangle = new Rectangle {
                        Width = 0x1388,
                        Height = 0x1388
                    };
                    brush2 = null;
                    brush2 = new LinearGradientBrush(rectangle, this.button10.BackColor, this.button19.BackColor, LinearGradientMode.Horizontal);
                    brush2.SetSigmaBellShape((float) this.numericUpDown2.Value);
                    graphics.FillRectangle(brush2, 0, 0, 0x1388, 0x1388);
                    brush2.Dispose();
                    point2 = new Point(0x9c4, 0x9c4);
                    num2 = (int) (1000M * this.numericUpDown5.Value);
                    path2 = new GraphicsPath();
                    path2.AddEllipse((int) (point2.X - num2), (int) (point2.Y - num2), (int) (2 * num2), (int) (2 * num2));
                    brush3 = new PathGradientBrush(path2) {
                        CenterPoint = (PointF) point2,
                        CenterColor = this.button18.BackColor
                    };
                    colorArray = new System.Drawing.Color[] { this.button11.BackColor };
                    brush3.SurroundColors = colorArray;
                    graphics.FillEllipse(brush3, (int) (point2.X - num2), (int) (point2.Y - num2), (int) (2 * num2), (int) (2 * num2));
                    brush3.Dispose();
                    graphics.Dispose();
                    this.pictureBox3.Image = image;
                }
                else if (this.comboBox1.SelectedIndex == 7)
                {
                    this.button18.Visible = true;
                    this.button19.Visible = true;
                    this.button20.Visible = true;
                    this.label23.Visible = true;
                    this.numericUpDown5.Visible = true;
                    rectangle = new Rectangle {
                        Width = 0x1388,
                        Height = 0x1388
                    };
                    brush2 = null;
                    brush2 = new LinearGradientBrush(rectangle, this.button10.BackColor, this.button19.BackColor, LinearGradientMode.BackwardDiagonal);
                    brush2.SetSigmaBellShape((float) this.numericUpDown2.Value);
                    graphics.FillRectangle(brush2, 0, 0, 0x1388, 0x1388);
                    brush2.Dispose();
                    point2 = new Point(0x9c4, 0x9c4);
                    num2 = (int) (1000M * this.numericUpDown5.Value);
                    path2 = new GraphicsPath();
                    path2.AddEllipse((int) (point2.X - num2), (int) (point2.Y - num2), (int) (2 * num2), (int) (2 * num2));
                    brush3 = new PathGradientBrush(path2) {
                        CenterPoint = (PointF) point2,
                        CenterColor = this.button18.BackColor
                    };
                    colorArray = new System.Drawing.Color[] { this.button11.BackColor };
                    brush3.SurroundColors = colorArray;
                    graphics.FillEllipse(brush3, (int) (point2.X - num2), (int) (point2.Y - num2), (int) (2 * num2), (int) (2 * num2));
                    brush3.Dispose();
                    graphics.Dispose();
                    this.pictureBox3.Image = image;
                }
                else if (this.comboBox1.SelectedIndex == 8)
                {
                    this.button18.Visible = true;
                    this.button19.Visible = true;
                    this.button20.Visible = true;
                    this.label23.Visible = true;
                    this.numericUpDown5.Visible = true;
                    rectangle = new Rectangle {
                        Width = 0x1388,
                        Height = 0x1388
                    };
                    brush2 = null;
                    brush2 = new LinearGradientBrush(rectangle, this.button10.BackColor, this.button19.BackColor, LinearGradientMode.ForwardDiagonal);
                    brush2.SetSigmaBellShape((float) this.numericUpDown2.Value);
                    graphics.FillRectangle(brush2, 0, 0, 0x1388, 0x1388);
                    brush2.Dispose();
                    point2 = new Point(0x9c4, 0x9c4);
                    num2 = (int) (1000M * this.numericUpDown5.Value);
                    path2 = new GraphicsPath();
                    path2.AddEllipse((int) (point2.X - num2), (int) (point2.Y - num2), (int) (2 * num2), (int) (2 * num2));
                    brush3 = new PathGradientBrush(path2) {
                        CenterPoint = (PointF) point2,
                        CenterColor = this.button18.BackColor
                    };
                    colorArray = new System.Drawing.Color[] { this.button11.BackColor };
                    brush3.SurroundColors = colorArray;
                    graphics.FillEllipse(brush3, (int) (point2.X - num2), (int) (point2.Y - num2), (int) (2 * num2), (int) (2 * num2));
                    brush3.Dispose();
                    graphics.Dispose();
                    this.pictureBox3.Image = image;
                }
                else if (this.comboBox1.SelectedIndex == 9)
                {
                    graphics.FillRectangle(new SolidBrush(this.button10.BackColor), 0, 0, 0x1388, 0x1388);
                    this.button18.Visible = true;
                    this.button19.Visible = true;
                    this.button20.Visible = true;
                    this.label23.Visible = true;
                    this.numericUpDown5.Visible = true;
                    point = new Point(0x9c4, 0x9c4);
                    num = (int) (1800M * this.numericUpDown5.Value);
                    path = new GraphicsPath();
                    path.AddEllipse((int) (point.X - num), (int) (point.Y - num), (int) (2 * num), (int) (2 * num));
                    brush = new PathGradientBrush(path) {
                        CenterPoint = (PointF) point,
                        CenterColor = this.button19.BackColor
                    };
                    colorArray = new System.Drawing.Color[] { this.button10.BackColor };
                    brush.SurroundColors = colorArray;
                    brush.SetSigmaBellShape((float) this.numericUpDown2.Value);
                    graphics.FillEllipse(brush, (int) (point.X - num), (int) (point.Y - num), (int) (2 * num), (int) (2 * num));
                    brush.Dispose();
                    point2 = new Point(0x9c4, 0x9c4);
                    num2 = (int) (1000M * this.numericUpDown5.Value);
                    path2 = new GraphicsPath();
                    path2.AddEllipse((int) (point2.X - num2), (int) (point2.Y - num2), (int) (2 * num2), (int) (2 * num2));
                    brush3 = new PathGradientBrush(path2) {
                        CenterPoint = (PointF) point2,
                        CenterColor = this.button18.BackColor
                    };
                    colorArray = new System.Drawing.Color[] { this.button11.BackColor };
                    brush3.SurroundColors = colorArray;
                    graphics.FillEllipse(brush3, (int) (point2.X - num2), (int) (point2.Y - num2), (int) (2 * num2), (int) (2 * num2));
                    brush3.Dispose();
                    graphics.Dispose();
                    this.pictureBox3.Image = image;
                }
                else
                {
                    this.button18.Visible = false;
                    this.button19.Visible = false;
                    this.button20.Visible = false;
                    this.label23.Visible = false;
                    this.numericUpDown5.Visible = false;
                    rectangle = new Rectangle {
                        Width = 0x1388,
                        Height = 0x1388
                    };
                    brush2 = null;
                    if (this.comboBox1.SelectedIndex == 0)
                    {
                        brush2 = new LinearGradientBrush(rectangle, this.button10.BackColor, this.button11.BackColor, LinearGradientMode.Vertical);
                    }
                    else if (this.comboBox1.SelectedIndex == 1)
                    {
                        brush2 = new LinearGradientBrush(rectangle, this.button10.BackColor, this.button11.BackColor, LinearGradientMode.Horizontal);
                    }
                    else if (this.comboBox1.SelectedIndex == 2)
                    {
                        brush2 = new LinearGradientBrush(rectangle, this.button10.BackColor, this.button11.BackColor, LinearGradientMode.BackwardDiagonal);
                    }
                    else if (this.comboBox1.SelectedIndex == 3)
                    {
                        brush2 = new LinearGradientBrush(rectangle, this.button10.BackColor, this.button11.BackColor, LinearGradientMode.ForwardDiagonal);
                    }
                    else
                    {
                        brush2 = new LinearGradientBrush(rectangle, this.button10.BackColor, this.button11.BackColor, LinearGradientMode.Vertical);
                    }
                    brush2.SetSigmaBellShape((float) this.numericUpDown2.Value);
                    graphics.FillRectangle(brush2, 0, 0, 0x1388, 0x1388);
                    brush2.Dispose();
                    graphics.Dispose();
                    this.pictureBox3.Image = image;
                }
            }
            this.Refresh();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private Bitmap fore_color(Bitmap image, System.Drawing.Color mycolor, System.Drawing.Color mycolor_qg)
        {
            Bitmap bitmap = new Bitmap(this.pictureBox3.Image, image.Width, image.Height);
            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    if (this.comboBox2.SelectedIndex == 5)
                    {
                        if (image.GetPixel(i, j) == mycolor)
                        {
                            bitmap.SetPixel(i, j, this.button8.BackColor);
                        }
                        else if (image.GetPixel(i, j) != mycolor_qg)
                        {
                            bitmap.SetPixel(i, j, this.button14.BackColor);
                        }
                    }
                    else if (image.GetPixel(i, j) == mycolor)
                    {
                        bitmap.SetPixel(i, j, this.button8.BackColor);
                    }
                }
            }
            return bitmap;
        }

        private Bitmap fore_color2(Bitmap image, System.Drawing.Color mycolor, System.Drawing.Color mycolor_qg, Bitmap image2)
        {
            Bitmap bitmap = new Bitmap(image.Width, image.Height);
            TextureBrush brush = new TextureBrush(image2) {
                WrapMode = WrapMode.Tile
            };
            Graphics.FromImage(bitmap).FillRectangle(brush, new Rectangle(0, 0, image.Width - 1, image.Height - 1));
            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    if (image.GetPixel(i, j) == mycolor)
                    {
                        bitmap.SetPixel(i, j, this.button8.BackColor);
                    }
                    else if (image.GetPixel(i, j) != mycolor_qg)
                    {
                        bitmap.SetPixel(i, j, this.button14.BackColor);
                    }
                }
            }
            return bitmap;
        }

        private Bitmap fore_riubd(Bitmap image)
        {
            System.Drawing.Color pixel = image.GetPixel(0, 0);
            System.Drawing.Color backColor = this.button8.BackColor;
            Bitmap bitmap = new Bitmap(image.Width, image.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.FillRectangle(new SolidBrush(backColor), 0, 0, image.Width, image.Height);
            graphics.Dispose();
            Graphics graphics2 = Graphics.FromImage(bitmap);
            for (int i = 0; i < image.Height; i += int.Parse(this.txtSize.Text))
            {
                for (int j = 0; j < image.Width; j += int.Parse(this.txtSize.Text))
                {
                    if (image.GetPixel(i, j) == pixel)
                    {
                        graphics2.FillEllipse(new SolidBrush(pixel), i, j, int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                    }
                }
            }
            graphics2.Dispose();
            return bitmap;
        }

        private Bitmap fore_yj(Bitmap image)
        {
            System.Drawing.Color pixel = image.GetPixel(0, 0);
            System.Drawing.Color backColor = this.button8.BackColor;
            Bitmap bitmap = new Bitmap(image.Width, image.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.FillRectangle(new SolidBrush(backColor), 0, 0, image.Width, image.Height);
            graphics.Dispose();
            Graphics graphics2 = Graphics.FromImage(bitmap);
            for (int i = 0; i < (image.Height - 1); i += int.Parse(this.txtSize.Text))
            {
                for (int j = 0; j < (image.Width - 1); j += int.Parse(this.txtSize.Text))
                {
                    if (image.GetPixel(j + (int.Parse(this.txtSize.Text) / 2), i + (int.Parse(this.txtSize.Text) / 2)) == pixel)
                    {
                        if ((i == 0) || (image.GetPixel(j + (int.Parse(this.txtSize.Text) / 2), i - (int.Parse(this.txtSize.Text) / 2)) != pixel))
                        {
                            if ((((i + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2)) > image.Height) || (image.GetPixel(j + (int.Parse(this.txtSize.Text) / 2), (i + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2)) != pixel))
                            {
                                if ((j == 0) || (image.GetPixel(j - (int.Parse(this.txtSize.Text) / 2), i + (int.Parse(this.txtSize.Text) / 2)) != pixel))
                                {
                                    if ((((j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2)) > image.Width) || (image.GetPixel((j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), i + (int.Parse(this.txtSize.Text) / 2)) != pixel))
                                    {
                                        graphics2.FillEllipse(new SolidBrush(pixel), j, i, int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                                    }
                                    else
                                    {
                                        graphics2.FillEllipse(new SolidBrush(pixel), j, i, int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                                        graphics2.FillRectangle(new SolidBrush(pixel), j + (int.Parse(this.txtSize.Text) / 2), i, int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text));
                                    }
                                }
                                else if ((((j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2)) > image.Width) || (image.GetPixel((j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), i + (int.Parse(this.txtSize.Text) / 2)) != pixel))
                                {
                                    graphics2.FillEllipse(new SolidBrush(pixel), j, i, int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                                    graphics2.FillRectangle(new SolidBrush(pixel), j, i, int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text));
                                }
                                else
                                {
                                    graphics2.FillRectangle(new SolidBrush(pixel), j, i, int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                                }
                            }
                            else if ((j == 0) || (image.GetPixel(j - (int.Parse(this.txtSize.Text) / 2), i + (int.Parse(this.txtSize.Text) / 2)) != pixel))
                            {
                                if ((((j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2)) > image.Width) || (image.GetPixel((j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), i + (int.Parse(this.txtSize.Text) / 2)) != pixel))
                                {
                                    graphics2.FillEllipse(new SolidBrush(pixel), j, i, int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                                    graphics2.FillRectangle(new SolidBrush(pixel), j, i + (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2));
                                }
                                else
                                {
                                    graphics2.FillPie(new SolidBrush(pixel), j, i, int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), 180, 90);
                                    graphics2.FillRectangle(new SolidBrush(pixel), j + (int.Parse(this.txtSize.Text) / 2), i, int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text));
                                    graphics2.FillRectangle(new SolidBrush(pixel), j, i + (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2));
                                    if (image.GetPixel((j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), (i + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2)) != pixel)
                                    {
                                        graphics2.FillRectangle(new SolidBrush(pixel), j + int.Parse(this.txtSize.Text), i + int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                                        graphics2.FillPie(new SolidBrush(backColor), j + int.Parse(this.txtSize.Text), i + int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), 180, 90);
                                        graphics2.FillRectangle(new SolidBrush(backColor), (j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), i + int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text));
                                        graphics2.FillRectangle(new SolidBrush(backColor), j + int.Parse(this.txtSize.Text), (i + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2));
                                    }
                                }
                            }
                            else if ((((j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2)) > image.Width) || (image.GetPixel((j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), i + (int.Parse(this.txtSize.Text) / 2)) != pixel))
                            {
                                graphics2.FillPie(new SolidBrush(pixel), j, i, int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), 0, -90);
                                graphics2.FillRectangle(new SolidBrush(pixel), j, i, int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text));
                                graphics2.FillRectangle(new SolidBrush(pixel), j, i + (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2));
                                if (image.GetPixel(j - (int.Parse(this.txtSize.Text) / 2), (i + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2)) != pixel)
                                {
                                    graphics2.FillRectangle(new SolidBrush(pixel), j - int.Parse(this.txtSize.Text), i + int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                                    graphics2.FillPie(new SolidBrush(backColor), j - int.Parse(this.txtSize.Text), i + int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), 0, -90);
                                    graphics2.FillRectangle(new SolidBrush(backColor), j - int.Parse(this.txtSize.Text), i + int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text));
                                    graphics2.FillRectangle(new SolidBrush(backColor), j - int.Parse(this.txtSize.Text), (i + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2));
                                }
                            }
                            else
                            {
                                graphics2.FillRectangle(new SolidBrush(pixel), j, i, int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                                if (image.GetPixel(j - (int.Parse(this.txtSize.Text) / 2), (i + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2)) != pixel)
                                {
                                    graphics2.FillRectangle(new SolidBrush(pixel), j - int.Parse(this.txtSize.Text), i + int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                                    graphics2.FillPie(new SolidBrush(backColor), j - int.Parse(this.txtSize.Text), i + int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), 0, -90);
                                    graphics2.FillRectangle(new SolidBrush(backColor), j - int.Parse(this.txtSize.Text), i + int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text));
                                    graphics2.FillRectangle(new SolidBrush(backColor), j - int.Parse(this.txtSize.Text), (i + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2));
                                }
                                if (image.GetPixel((j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), (i + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2)) != pixel)
                                {
                                    graphics2.FillRectangle(new SolidBrush(pixel), j + int.Parse(this.txtSize.Text), i + int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                                    graphics2.FillPie(new SolidBrush(backColor), j + int.Parse(this.txtSize.Text), i + int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), 180, 90);
                                    graphics2.FillRectangle(new SolidBrush(backColor), (j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), i + int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text));
                                    graphics2.FillRectangle(new SolidBrush(backColor), j + int.Parse(this.txtSize.Text), (i + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2));
                                }
                            }
                        }
                        else if ((((i + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2)) > image.Height) || (image.GetPixel(j + (int.Parse(this.txtSize.Text) / 2), (i + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2)) != pixel))
                        {
                            if ((j == 0) || (image.GetPixel(j - (int.Parse(this.txtSize.Text) / 2), i + (int.Parse(this.txtSize.Text) / 2)) != pixel))
                            {
                                if ((((j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2)) > image.Width) || (image.GetPixel((j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), i + (int.Parse(this.txtSize.Text) / 2)) != pixel))
                                {
                                    graphics2.FillEllipse(new SolidBrush(pixel), j, i, int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                                    graphics2.FillRectangle(new SolidBrush(pixel), j, i, int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2));
                                }
                                else
                                {
                                    graphics2.FillPie(new SolidBrush(pixel), j, i, int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), 90, 90);
                                    graphics2.FillRectangle(new SolidBrush(pixel), j, i, int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2));
                                    graphics2.FillRectangle(new SolidBrush(pixel), j + (int.Parse(this.txtSize.Text) / 2), i, int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text));
                                    if (image.GetPixel((j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), i - (int.Parse(this.txtSize.Text) / 2)) != pixel)
                                    {
                                        graphics2.FillRectangle(new SolidBrush(pixel), j + int.Parse(this.txtSize.Text), i - int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                                        graphics2.FillPie(new SolidBrush(backColor), j + int.Parse(this.txtSize.Text), i - int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), 90, 90);
                                        graphics2.FillRectangle(new SolidBrush(backColor), j + int.Parse(this.txtSize.Text), i - int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2));
                                        graphics2.FillRectangle(new SolidBrush(backColor), (j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), i - int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text));
                                    }
                                }
                            }
                            else if ((((j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2)) > image.Width) || (image.GetPixel((j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), i + (int.Parse(this.txtSize.Text) / 2)) != pixel))
                            {
                                graphics2.FillEllipse(new SolidBrush(pixel), j, i, int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                                graphics2.FillRectangle(new SolidBrush(pixel), j, i, int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2));
                                graphics2.FillRectangle(new SolidBrush(pixel), j, i, int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text));
                                if (image.GetPixel(j - (int.Parse(this.txtSize.Text) / 2), i - (int.Parse(this.txtSize.Text) / 2)) != pixel)
                                {
                                    graphics2.FillRectangle(new SolidBrush(pixel), j - int.Parse(this.txtSize.Text), i - int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                                    graphics2.FillPie(new SolidBrush(backColor), j - int.Parse(this.txtSize.Text), i - int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), 0, 90);
                                    graphics2.FillRectangle(new SolidBrush(backColor), j - int.Parse(this.txtSize.Text), i - int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2));
                                    graphics2.FillRectangle(new SolidBrush(backColor), j - int.Parse(this.txtSize.Text), i - int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text));
                                }
                            }
                            else
                            {
                                graphics2.FillRectangle(new SolidBrush(pixel), j, i, int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                                if (image.GetPixel(j - (int.Parse(this.txtSize.Text) / 2), i - (int.Parse(this.txtSize.Text) / 2)) != pixel)
                                {
                                    graphics2.FillRectangle(new SolidBrush(pixel), j - int.Parse(this.txtSize.Text), i - int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                                    graphics2.FillPie(new SolidBrush(backColor), j - int.Parse(this.txtSize.Text), i - int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), 0, 90);
                                    graphics2.FillRectangle(new SolidBrush(backColor), j - int.Parse(this.txtSize.Text), i - int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2));
                                    graphics2.FillRectangle(new SolidBrush(backColor), j - int.Parse(this.txtSize.Text), i - int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text));
                                }
                                if (image.GetPixel((j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), i - (int.Parse(this.txtSize.Text) / 2)) != pixel)
                                {
                                    graphics2.FillRectangle(new SolidBrush(pixel), j + int.Parse(this.txtSize.Text), i - int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                                    graphics2.FillPie(new SolidBrush(backColor), j + int.Parse(this.txtSize.Text), i - int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), 90, 90);
                                    graphics2.FillRectangle(new SolidBrush(backColor), j + int.Parse(this.txtSize.Text), i - int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2));
                                    graphics2.FillRectangle(new SolidBrush(backColor), (j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), i - int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text));
                                }
                            }
                        }
                        else if ((j == 0) || (image.GetPixel(j - (int.Parse(this.txtSize.Text) / 2), i + (int.Parse(this.txtSize.Text) / 2)) != pixel))
                        {
                            if ((((j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2)) > image.Width) || (image.GetPixel((j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), i + (int.Parse(this.txtSize.Text) / 2)) != pixel))
                            {
                                graphics2.FillRectangle(new SolidBrush(pixel), j, i, int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                            }
                            else
                            {
                                graphics2.FillRectangle(new SolidBrush(pixel), j, i, int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                                if (image.GetPixel((j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), i - (int.Parse(this.txtSize.Text) / 2)) != pixel)
                                {
                                    graphics2.FillRectangle(new SolidBrush(pixel), j + int.Parse(this.txtSize.Text), i - int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                                    graphics2.FillPie(new SolidBrush(backColor), j + int.Parse(this.txtSize.Text), i - int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), 90, 90);
                                    graphics2.FillRectangle(new SolidBrush(backColor), j + int.Parse(this.txtSize.Text), i - int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2));
                                    graphics2.FillRectangle(new SolidBrush(backColor), (j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), i - int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text));
                                }
                                if (image.GetPixel((j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), (i + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2)) != pixel)
                                {
                                    graphics2.FillRectangle(new SolidBrush(pixel), j + int.Parse(this.txtSize.Text), i + int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                                    graphics2.FillPie(new SolidBrush(backColor), j + int.Parse(this.txtSize.Text), i + int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), 180, 90);
                                    graphics2.FillRectangle(new SolidBrush(backColor), (j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), i + int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text));
                                    graphics2.FillRectangle(new SolidBrush(backColor), j + int.Parse(this.txtSize.Text), (i + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2));
                                }
                            }
                        }
                        else if ((((j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2)) > image.Width) || (image.GetPixel((j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), i + (int.Parse(this.txtSize.Text) / 2)) != pixel))
                        {
                            graphics2.FillRectangle(new SolidBrush(pixel), j, i, int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                            if (image.GetPixel(j - (int.Parse(this.txtSize.Text) / 2), i - (int.Parse(this.txtSize.Text) / 2)) != pixel)
                            {
                                graphics2.FillRectangle(new SolidBrush(pixel), j - int.Parse(this.txtSize.Text), i - int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                                graphics2.FillPie(new SolidBrush(backColor), j - int.Parse(this.txtSize.Text), i - int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), 0, 90);
                                graphics2.FillRectangle(new SolidBrush(backColor), j - int.Parse(this.txtSize.Text), i - int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2));
                                graphics2.FillRectangle(new SolidBrush(backColor), j - int.Parse(this.txtSize.Text), i - int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text));
                            }
                            if (image.GetPixel(j - (int.Parse(this.txtSize.Text) / 2), (i + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2)) != pixel)
                            {
                                graphics2.FillRectangle(new SolidBrush(pixel), j - int.Parse(this.txtSize.Text), i + int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                                graphics2.FillPie(new SolidBrush(backColor), j - int.Parse(this.txtSize.Text), i + int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), 0, -90);
                                graphics2.FillRectangle(new SolidBrush(backColor), j - int.Parse(this.txtSize.Text), i + int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text));
                                graphics2.FillRectangle(new SolidBrush(backColor), j - int.Parse(this.txtSize.Text), (i + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2));
                            }
                        }
                        else
                        {
                            graphics2.FillRectangle(new SolidBrush(pixel), j, i, int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                            if (image.GetPixel(j - (int.Parse(this.txtSize.Text) / 2), i - (int.Parse(this.txtSize.Text) / 2)) != pixel)
                            {
                                graphics2.FillRectangle(new SolidBrush(pixel), j - int.Parse(this.txtSize.Text), i - int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                                graphics2.FillPie(new SolidBrush(backColor), j - int.Parse(this.txtSize.Text), i - int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), 0, 90);
                                graphics2.FillRectangle(new SolidBrush(backColor), j - int.Parse(this.txtSize.Text), i - int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2));
                                graphics2.FillRectangle(new SolidBrush(backColor), j - int.Parse(this.txtSize.Text), i - int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text));
                            }
                            if (image.GetPixel(j - (int.Parse(this.txtSize.Text) / 2), (i + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2)) != pixel)
                            {
                                graphics2.FillRectangle(new SolidBrush(pixel), j - int.Parse(this.txtSize.Text), i + int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                                graphics2.FillPie(new SolidBrush(backColor), j - int.Parse(this.txtSize.Text), i + int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), 0, -90);
                                graphics2.FillRectangle(new SolidBrush(backColor), j - int.Parse(this.txtSize.Text), i + int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text));
                                graphics2.FillRectangle(new SolidBrush(backColor), j - int.Parse(this.txtSize.Text), (i + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2));
                            }
                            if (image.GetPixel((j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), i - (int.Parse(this.txtSize.Text) / 2)) != pixel)
                            {
                                graphics2.FillRectangle(new SolidBrush(pixel), j + int.Parse(this.txtSize.Text), i - int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                                graphics2.FillPie(new SolidBrush(backColor), j + int.Parse(this.txtSize.Text), i - int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), 90, 90);
                                graphics2.FillRectangle(new SolidBrush(backColor), j + int.Parse(this.txtSize.Text), i - int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2));
                                graphics2.FillRectangle(new SolidBrush(backColor), (j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), i - int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text));
                            }
                            if (image.GetPixel((j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), (i + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2)) != pixel)
                            {
                                graphics2.FillRectangle(new SolidBrush(pixel), j + int.Parse(this.txtSize.Text), i + int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                                graphics2.FillPie(new SolidBrush(backColor), j + int.Parse(this.txtSize.Text), i + int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text), 180, 90);
                                graphics2.FillRectangle(new SolidBrush(backColor), (j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), i + int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text));
                                graphics2.FillRectangle(new SolidBrush(backColor), j + int.Parse(this.txtSize.Text), (i + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text) - (int.Parse(this.txtSize.Text) / 2));
                            }
                        }
                    }
                }
            }
            graphics2.Dispose();
            return bitmap;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.pictureBox6.Visible = false;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            this.pictureBox6.Visible = true;
            this.pictureBox1.Controls.Add(this.pictureBox6);
            this.pictureBox6.SetBounds(0, 0, 220, 220);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.UnInsertHook();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.InsertHook();
            this.cboEncoding.SelectedIndex = 0;
            this.cboVersion.SelectedIndex = 2;
            this.cboCorrectionLevel.SelectedIndex = 3;
            this.comboBox1.SelectedIndex = 3;
            this.comboBox2.SelectedIndex = 0;
            this.comboBox3.SelectedIndex = 0;
            this.comboBox4.SelectedIndex = 1;
            this.comboBox5.SelectedIndex = 1;
            this.checkBox3.Checked = true;
            if (this.reg_str_yn("Sysqrcode"))
            {
                this.reg_YN = false;
                this.toolStripStatusLabel1.Text = "您现在使用的是试用版，部分功能不能使用，请尽快注册";
                MessageBox.Show("软件为试用版，部分功能不能使用！", "请尽快注册");
                this.Refresh();
            }
            else
            {
                this.reg_YN = true;
                string str = this.GetCpuInfo() + this.GetDiskInfo();
                string s = "";
                string str3 = "";
                string str4 = "";
                string passw = "";
                RegistryKey key2 = Registry.CurrentUser.OpenSubKey("Sysqrcode");
                s = key2.GetValue("syzs").ToString();
                str3 = key2.GetValue("regtxt").ToString();
                passw = key2.GetValue("jqmhc").ToString();
                int num = 0;
                while (num <= 0x2710)
                {
                    if (key2.GetValue("dqcs").ToString().Trim() == GetMd5Str(num.ToString()))
                    {
                        str4 = num.ToString();
                        break;
                    }
                    num++;
                }
                foreach (string str6 in key2.GetSubKeyNames())
                {
                    if (str6.Trim() == "syzs")
                    {
                        s = key2.OpenSubKey("str").GetValue("syzs").ToString();
                    }
                    if (str6.Trim() == "regtxt")
                    {
                        str3 = key2.OpenSubKey("str").GetValue("regtxt").ToString();
                    }
                    if (str6.Trim() == "dqcs")
                    {
                        for (num = 0; num <= 0x2710; num++)
                        {
                            if (key2.OpenSubKey("str").GetValue("dqcs").ToString().Trim() == GetMd5Str(num.ToString()))
                            {
                                str4 = num.ToString();
                                break;
                            }
                        }
                    }
                    if (str6.Trim() == "jqmhc")
                    {
                        passw = key2.OpenSubKey("str").GetValue("jqmhc").ToString();
                    }
                }
                if ((((s == "") || (str3 == "")) || (str4 == "")) || (passw == ""))
                {
                    this.reg_YN = false;
                    this.Refresh();
                    MessageBox.Show("软件注册文件损坏！", "出错");
                }
                else if ((this.password(passw, int.Parse(s)).Trim() == str3.Trim()) && (passw.IndexOf(str) == 0))
                {
                    this.use_sum = int.Parse(str4);
                    this.use_zsum = int.Parse(s);
                    if (int.Parse(str4) >= int.Parse(s))
                    {
                        this.reg_YN = false;
                        this.Refresh();
                        MessageBox.Show("软件注册次数已经使用完，请联系作者并重新注册！", "次数使用完毕");
                    }
                    else
                    {
                        this.textBox7.Text = passw;
                        this.textBox9.Text = s;
                        this.textBox8.Text = str3;
                        this.textBox7.Enabled = false;
                        this.textBox9.Enabled = false;
                        this.textBox8.Enabled = false;
                        this.button17.Enabled = false;
                        this.button15.Enabled = false;
                        this.reg_YN = true;
                        this.pictureBox4.Image = Resources.button_ok;
                        QRCodeEncoder encoder = new QRCodeEncoder {
                            QRCodeBackgroundColor = System.Drawing.Color.White
                        };
                        string text = this.cboEncoding.Text;
                        encoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
                        encoder.QRCodeScale = 0x10;
                        encoder.QRCodeVersion = 4;
                        encoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q;
                        if (this.comboBox4.SelectedIndex == 0)
                        {
                            this.pictureBox5.Image = encoder.Encode(this.textBox7.Text, Encoding.GetEncoding("gb2312"));
                        }
                        if (this.comboBox4.SelectedIndex == 1)
                        {
                            this.pictureBox5.Image = encoder.Encode(this.textBox7.Text, Encoding.UTF8);
                        }
                        if (this.comboBox4.SelectedIndex == 2)
                        {
                            this.pictureBox5.Image = encoder.Encode(this.textBox7.Text, Encoding.Unicode);
                        }
                        this.toolStripStatusLabel1.Text = "您现在已经使用了" + str4 + "次，总次数" + s;
                    }
                }
                else
                {
                    this.reg_YN = false;
                    this.Refresh();
                    MessageBox.Show("软件注册文件损坏,或者使用次数到期！", "出错");
                }
            }
        }

        public Image GCode(string data)
        {
            if (this.richTextBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("输入的数据为空，请检测！");
                return null;
            }
            QRCodeEncoder encoder = new QRCodeEncoder {
                QRCodeBackgroundColor = this.button8.BackColor
            };
            switch (this.cboEncoding.Text)
            {
                case "文字":
                    encoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
                    break;

                case "数字":
                    encoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.NUMERIC;
                    break;
            }
            try
            {
                int num = Convert.ToInt16(this.txtSize.Text);
                encoder.QRCodeScale = num;
            }
            catch
            {
                MessageBox.Show("尺寸输入错误");
                return null;
            }
            try
            {
                int num2 = Convert.ToInt16(this.cboVersion.Text);
                encoder.QRCodeVersion = num2;
            }
            catch
            {
                MessageBox.Show("版本信息错误!");
            }
            string text = this.cboCorrectionLevel.Text;
            if (text == "低")
            {
                encoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
            }
            else if (text == "中")
            {
                encoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
            }
            else if (text == "高")
            {
                encoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q;
            }
            else if (text == "最高")
            {
                encoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H;
            }
            try
            {
                bool flag;
                Bitmap image = null;
                int num3 = 1;
                if (this.checkBox4.Checked)
                {
                    num3 = 1 + (this.len(data) / 30);
                    encoder.QRCodeVersion = num3;
                }
                goto Label_0272;
            Label_01BB:;
                try
                {
                    if (this.comboBox4.SelectedIndex == 0)
                    {
                        image = encoder.Encode(data, Encoding.GetEncoding("gb2312"));
                    }
                    if (this.comboBox4.SelectedIndex == 1)
                    {
                        image = encoder.Encode(data, Encoding.UTF8);
                    }
                    if (this.comboBox4.SelectedIndex == 2)
                    {
                        image = encoder.Encode(data, Encoding.Unicode);
                    }
                    goto Label_027A;
                }
                catch
                {
                    if (num3 < this.cboVersion.Items.Count)
                    {
                        num3++;
                    }
                    else
                    {
                        goto Label_027A;
                    }
                    encoder.QRCodeVersion = num3;
                }
                this.Refresh();
            Label_0272:
                flag = true;
                goto Label_01BB;
            Label_027A:
                this.cboVersion.SelectedIndex = num3 - 1;
                System.Drawing.Color mycolor = this.get_color_bg(image);
                System.Drawing.Color color2 = this.get_color_qg(image);
                if (this.comboBox2.SelectedIndex == 1)
                {
                    image = this.fore_riubd(image);
                }
                if (this.comboBox2.SelectedIndex == 2)
                {
                    image = this.fore_yj(image);
                }
                if (this.comboBox2.SelectedIndex == 3)
                {
                    image = this.round1(image);
                }
                if (this.comboBox2.SelectedIndex == 4)
                {
                    image = this.fore_yj(image);
                    image = this.round1(image);
                }
                if (this.comboBox2.SelectedIndex == 5)
                {
                    image = this.line_add(image);
                }
                if (this.comboBox2.SelectedIndex == 6)
                {
                    if (this.textBox6.Text.Trim() != "")
                    {
                        return this.KiResizeImage(Image.FromFile(this.textBox6.Text), int.Parse(this.txtSize.Text) * 0x2a, int.Parse(this.txtSize.Text) * 0x2a, 0);
                    }
                    MessageBox.Show("请先选择背景图！");
                    return null;
                }
                if (this.comboBox2.SelectedIndex == 8)
                {
                    Bitmap bitmap2 = new Bitmap(this.pictureBox3.Image, int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                    image = this.fore_color2(image, mycolor, color2, bitmap2);
                }
                else
                {
                    image = this.fore_color(image, mycolor, color2);
                }
                int x = (int) this.numericUpDown3.Value;
                int num5 = x * 2;
                Bitmap bitmap3 = new Bitmap(image.Width + num5, image.Height + num5);
                Graphics graphics = Graphics.FromImage(bitmap3);
                graphics.FillRectangle(new SolidBrush(this.button6.BackColor), 0, 0, image.Width + num5, image.Height + num5);
                graphics.DrawImage(image, x, x);
                graphics.Dispose();
                return bitmap3;
            }
            catch
            {
                MessageBox.Show("字符数量太多");
                return null;
            }
        }

        private System.Drawing.Color get_color_bg(Bitmap image)
        {
            System.Drawing.Color pixel = image.GetPixel(int.Parse(this.txtSize.Text) / 2, int.Parse(this.txtSize.Text) / 2);
            System.Drawing.Color white = System.Drawing.Color.White;
            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    if (image.GetPixel(i, j) != image.GetPixel(0, 0))
                    {
                        white = image.GetPixel(i, j);
                        break;
                    }
                }
            }
            return white;
        }

        private System.Drawing.Color get_color_qg(Bitmap image)
        {
            return image.GetPixel(int.Parse(this.txtSize.Text) / 2, int.Parse(this.txtSize.Text) / 2);
        }

        public string GetCpuInfo()
        {
            string str = " ";
            using (ManagementClass class2 = new ManagementClass("Win32_Processor"))
            {
                ManagementObjectCollection instances = class2.GetInstances();
                foreach (ManagementObject obj2 in instances)
                {
                    str = obj2.Properties["ProcessorId"].Value.ToString();
                    obj2.Dispose();
                }
            }
            return str.ToString();
        }

        public string GetDiskInfo()
        {
            ManagementClass class2 = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObject obj2 = new ManagementObject("Win32_logicaldisk.deviceid=\"c:\"");
            obj2.Get();
            return obj2.GetPropertyValue("VolumeSerialNumber").ToString();
        }

        public static string GetMd5Str(string ConvertString)
        {
            MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider();
            string str = BitConverter.ToString(provider.ComputeHash(Encoding.Default.GetBytes(ConvertString)), 4, 8).Replace("-", "");
            return (str.Substring(0, 4) + "-" + str.Substring(4, 4) + "-" + str.Substring(8, 4) + "-" + str.Substring(12, 4));
        }

        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new TabControl();
            this.tabPage1 = new TabPage();
            this.label44 = new Label();
            this.label45 = new Label();
            this.comboBox4 = new ComboBox();
            this.checkBox4 = new CheckBox();
            this.tabControl2 = new TabControl();
            this.tabPage4 = new TabPage();
            this.richTextBox3 = new RichTextBox();
            this.tabPage5 = new TabPage();
            this.textBox17 = new TextBox();
            this.textBox16 = new TextBox();
            this.textBox15 = new TextBox();
            this.textBox14 = new TextBox();
            this.textBox13 = new TextBox();
            this.textBox12 = new TextBox();
            this.textBox11 = new TextBox();
            this.label36 = new Label();
            this.textBox10 = new TextBox();
            this.label35 = new Label();
            this.label34 = new Label();
            this.label33 = new Label();
            this.label32 = new Label();
            this.label31 = new Label();
            this.label30 = new Label();
            this.label29 = new Label();
            this.label28 = new Label();
            this.tabPage6 = new TabPage();
            this.textBox22 = new TextBox();
            this.label43 = new Label();
            this.tabPage7 = new TabPage();
            this.textBox20 = new TextBox();
            this.label40 = new Label();
            this.tabPage8 = new TabPage();
            this.textBox21 = new TextBox();
            this.label42 = new Label();
            this.label41 = new Label();
            this.richTextBox6 = new RichTextBox();
            this.tabPage9 = new TabPage();
            this.textBox19 = new TextBox();
            this.textBox18 = new TextBox();
            this.label39 = new Label();
            this.label38 = new Label();
            this.label37 = new Label();
            this.comboBox3 = new ComboBox();
            this.button5 = new Button();
            this.label27 = new Label();
            this.label26 = new Label();
            this.pictureBox6 = new PictureBox();
            this.label25 = new Label();
            this.textBox6 = new TextBox();
            this.button16 = new Button();
            this.label16 = new Label();
            this.numericUpDown4 = new NumericUpDown();
            this.button14 = new Button();
            this.comboBox2 = new ComboBox();
            this.label15 = new Label();
            this.numericUpDown3 = new NumericUpDown();
            this.label13 = new Label();
            this.label14 = new Label();
            this.textBox4 = new TextBox();
            this.textBox5 = new TextBox();
            this.numericUpDown1 = new NumericUpDown();
            this.label12 = new Label();
            this.label8 = new Label();
            this.button13 = new Button();
            this.textBox3 = new TextBox();
            this.button12 = new Button();
            this.groupBox1 = new GroupBox();
            this.button20 = new Button();
            this.label24 = new Label();
            this.button19 = new Button();
            this.numericUpDown5 = new NumericUpDown();
            this.label23 = new Label();
            this.button18 = new Button();
            this.comboBox1 = new ComboBox();
            this.numericUpDown2 = new NumericUpDown();
            this.checkBox3 = new CheckBox();
            this.checkBox2 = new CheckBox();
            this.button11 = new Button();
            this.button10 = new Button();
            this.button9 = new Button();
            this.pictureBox3 = new PictureBox();
            this.button7 = new Button();
            this.label11 = new Label();
            this.label10 = new Label();
            this.textBox2 = new TextBox();
            this.textBox1 = new TextBox();
            this.button8 = new Button();
            this.button6 = new Button();
            this.label9 = new Label();
            this.label7 = new Label();
            this.checkBox1 = new CheckBox();
            this.label5 = new Label();
            this.txtSize = new TextBox();
            this.label4 = new Label();
            this.cboVersion = new ComboBox();
            this.label3 = new Label();
            this.cboCorrectionLevel = new ComboBox();
            this.label2 = new Label();
            this.cboEncoding = new ComboBox();
            this.pictureBox1 = new PictureBox();
            this.richTextBox1 = new RichTextBox();
            this.label1 = new Label();
            this.button2 = new Button();
            this.button1 = new Button();
            this.tabPage2 = new TabPage();
            this.label47 = new Label();
            this.label46 = new Label();
            this.comboBox5 = new ComboBox();
            this.richTextBox2 = new RichTextBox();
            this.label6 = new Label();
            this.button4 = new Button();
            this.button3 = new Button();
            this.pictureBox2 = new PictureBox();
            this.tabPage3 = new TabPage();
            this.label22 = new Label();
            this.label21 = new Label();
            this.label20 = new Label();
            this.label19 = new Label();
            this.textBox9 = new TextBox();
            this.textBox8 = new TextBox();
            this.label18 = new Label();
            this.button17 = new Button();
            this.button15 = new Button();
            this.textBox7 = new TextBox();
            this.label17 = new Label();
            this.pictureBox5 = new PictureBox();
            this.pictureBox4 = new PictureBox();
            this.statusStrip1 = new StatusStrip();
            this.toolStripStatusLabel1 = new ToolStripStatusLabel();
            this.label48 = new Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            ((ISupportInitialize) this.pictureBox6).BeginInit();
            this.numericUpDown4.BeginInit();
            this.numericUpDown3.BeginInit();
            this.numericUpDown1.BeginInit();
            this.groupBox1.SuspendLayout();
            this.numericUpDown5.BeginInit();
            this.numericUpDown2.BeginInit();
            ((ISupportInitialize) this.pictureBox3).BeginInit();
            ((ISupportInitialize) this.pictureBox1).BeginInit();
            this.tabPage2.SuspendLayout();
            ((ISupportInitialize) this.pictureBox2).BeginInit();
            this.tabPage3.SuspendLayout();
            ((ISupportInitialize) this.pictureBox5).BeginInit();
            ((ISupportInitialize) this.pictureBox4).BeginInit();
            this.statusStrip1.SuspendLayout();
            base.SuspendLayout();
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            //this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = DockStyle.Fill;
            this.tabControl1.Location = new Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new Size(0x21e, 0x1a9);
            this.tabControl1.TabIndex = 6;
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label44);
            this.tabPage1.Controls.Add(this.label45);
            this.tabPage1.Controls.Add(this.comboBox4);
            this.tabPage1.Controls.Add(this.checkBox4);
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.pictureBox6);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.button16);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.numericUpDown4);
            this.tabPage1.Controls.Add(this.button14);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.numericUpDown3);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.button13);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.button12);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtSize);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cboVersion);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cboCorrectionLevel);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cboEncoding);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new Point(4, 0x16);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new Padding(3);
            this.tabPage1.Size = new Size(0x216, 0x18f);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "二维码生成";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.LightCoral;
            this.label44.Font = new Font("宋体", 15f, FontStyle.Italic | FontStyle.Bold, GraphicsUnit.Point, 0x86);
            this.label44.Location = new Point(0xa4, 0xaf);
            this.label44.Name = "label44";
            this.label44.Size = new Size(0x111, 20);
            this.label44.TabIndex = 0;
            this.label44.Text = "正在生成二维码，请稍后...";
            this.label44.Visible = false;
            this.label45.AutoSize = true;
            this.label45.Location = new Point(0x1ab, 10);
            this.label45.Name = "label45";
            this.label45.Size = new Size(0x1d, 12);
            this.label45.TabIndex = 0x48;
            this.label45.Text = "编码";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] { "GB2312", "UTF8", "Unicode" });
            this.comboBox4.Location = new Point(460, 7);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new Size(0x42, 20);
            this.comboBox4.TabIndex = 0x47;
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = CheckState.Checked;
            this.checkBox4.Location = new Point(0x19f, 0x3b);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new Size(0x54, 0x10);
            this.checkBox4.TabIndex = 0x45;
            this.checkBox4.Text = "最适合级别";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Controls.Add(this.tabPage9);
            this.tabControl2.Location = new Point(12, 0xf6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new Size(0xe7, 0x84);
            this.tabControl2.TabIndex = 0x44;
            this.tabPage4.Controls.Add(this.richTextBox3);
            this.tabPage4.Location = new Point(4, 0x16);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new Padding(3);
            this.tabPage4.Size = new Size(0xdf, 0x6a);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "文字";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.richTextBox3.Location = new Point(5, 5);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new Size(0xc5, 0x5d);
            this.richTextBox3.TabIndex = 0;
            this.richTextBox3.Text = "";
            this.tabPage5.AutoScroll = true;
            this.tabPage5.Controls.Add(this.textBox17);
            this.tabPage5.Controls.Add(this.textBox16);
            this.tabPage5.Controls.Add(this.textBox15);
            this.tabPage5.Controls.Add(this.textBox14);
            this.tabPage5.Controls.Add(this.textBox13);
            this.tabPage5.Controls.Add(this.textBox12);
            this.tabPage5.Controls.Add(this.textBox11);
            this.tabPage5.Controls.Add(this.label36);
            this.tabPage5.Controls.Add(this.textBox10);
            this.tabPage5.Controls.Add(this.label35);
            this.tabPage5.Controls.Add(this.label34);
            this.tabPage5.Controls.Add(this.label33);
            this.tabPage5.Controls.Add(this.label32);
            this.tabPage5.Controls.Add(this.label31);
            this.tabPage5.Controls.Add(this.label30);
            this.tabPage5.Controls.Add(this.label29);
            this.tabPage5.Controls.Add(this.label28);
            this.tabPage5.Location = new Point(4, 0x16);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new Padding(3);
            this.tabPage5.Size = new Size(0xdf, 0x6a);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "名片";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.textBox17.Location = new Point(0x3f, 0xb1);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new Size(0x8a, 0x15);
            this.textBox17.TabIndex = 0x10;
            this.textBox17.Text = "http://";
            this.textBox17.TextChanged += new EventHandler(this.textBox17_TextChanged);
            this.textBox16.Location = new Point(0x3f, 0x99);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new Size(0x8a, 0x15);
            this.textBox16.TabIndex = 15;
            this.textBox15.Location = new Point(0x3f, 130);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new Size(0x8a, 0x15);
            this.textBox15.TabIndex = 14;
            this.textBox14.Location = new Point(0x3f, 0x69);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new Size(100, 0x15);
            this.textBox14.TabIndex = 13;
            this.textBox13.Location = new Point(0x3f, 0x51);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new Size(0x8a, 0x15);
            this.textBox13.TabIndex = 12;
            this.textBox12.Location = new Point(0x3f, 0x39);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new Size(100, 0x15);
            this.textBox12.TabIndex = 11;
            this.textBox12.KeyPress += new KeyPressEventHandler(this.textBox11_KeyPress);
            this.textBox11.Location = new Point(0x3f, 0x21);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new Size(100, 0x15);
            this.textBox11.TabIndex = 10;
            this.textBox11.KeyPress += new KeyPressEventHandler(this.textBox11_KeyPress);
            this.label36.AutoSize = true;
            this.label36.Location = new Point(10, 0xcc);
            this.label36.Name = "label36";
            this.label36.Size = new Size(0, 12);
            this.label36.TabIndex = 9;
            this.textBox10.Location = new Point(0x3f, 9);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Size(100, 0x15);
            this.textBox10.TabIndex = 8;
            this.label35.AutoSize = true;
            this.label35.Location = new Point(10, 0xb6);
            this.label35.Name = "label35";
            this.label35.Size = new Size(0x29, 12);
            this.label35.TabIndex = 7;
            this.label35.Text = "网址：";
            this.label34.AutoSize = true;
            this.label34.Location = new Point(10, 110);
            this.label34.Name = "label34";
            this.label34.Size = new Size(0x29, 12);
            this.label34.TabIndex = 6;
            this.label34.Text = "职务：";
            this.label33.AutoSize = true;
            this.label33.Location = new Point(10, 0x56);
            this.label33.Name = "label33";
            this.label33.Size = new Size(0x29, 12);
            this.label33.TabIndex = 5;
            this.label33.Text = "EMIL：";
            this.label32.AutoSize = true;
            this.label32.Location = new Point(10, 0x9e);
            this.label32.Name = "label32";
            this.label32.Size = new Size(0x29, 12);
            this.label32.TabIndex = 4;
            this.label32.Text = "公司：";
            this.label31.AutoSize = true;
            this.label31.Location = new Point(10, 0x86);
            this.label31.Name = "label31";
            this.label31.Size = new Size(0x29, 12);
            this.label31.TabIndex = 3;
            this.label31.Text = "地址：";
            this.label30.AutoSize = true;
            this.label30.Location = new Point(10, 0x3e);
            this.label30.Name = "label30";
            this.label30.Size = new Size(0x2f, 12);
            this.label30.TabIndex = 2;
            this.label30.Text = "电话2：";
            this.label29.AutoSize = true;
            this.label29.Location = new Point(10, 0x26);
            this.label29.Name = "label29";
            this.label29.Size = new Size(0x2f, 12);
            this.label29.TabIndex = 1;
            this.label29.Text = "电话1：";
            this.label28.AutoSize = true;
            this.label28.Location = new Point(10, 14);
            this.label28.Name = "label28";
            this.label28.Size = new Size(0x29, 12);
            this.label28.TabIndex = 0;
            this.label28.Text = "姓名：";
            this.tabPage6.Controls.Add(this.textBox22);
            this.tabPage6.Controls.Add(this.label43);
            this.tabPage6.Location = new Point(4, 0x16);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new Size(0xdf, 0x6a);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "网址";
            this.tabPage6.UseVisualStyleBackColor = true;
            this.textBox22.Location = new Point(8, 0x25);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new Size(0xcf, 0x15);
            this.textBox22.TabIndex = 3;
            this.textBox22.Text = "http://";
            this.textBox22.TextChanged += new EventHandler(this.textBox22_TextChanged);
            this.label43.AutoSize = true;
            this.label43.Location = new Point(6, 20);
            this.label43.Name = "label43";
            this.label43.Size = new Size(0x23, 12);
            this.label43.TabIndex = 2;
            this.label43.Text = "网址:";
            this.tabPage7.Controls.Add(this.textBox20);
            this.tabPage7.Controls.Add(this.label40);
            this.tabPage7.Location = new Point(4, 0x16);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new Size(0xdf, 0x6a);
            this.tabPage7.TabIndex = 3;
            this.tabPage7.Text = "电话";
            this.tabPage7.UseVisualStyleBackColor = true;
            this.textBox20.Location = new Point(0x44, 0x2a);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new Size(0x80, 0x15);
            this.textBox20.TabIndex = 1;
            this.textBox20.KeyPress += new KeyPressEventHandler(this.textBox20_KeyPress);
            this.label40.AutoSize = true;
            this.label40.Location = new Point(0x1d, 0x2e);
            this.label40.Name = "label40";
            this.label40.Size = new Size(0x23, 12);
            this.label40.TabIndex = 0;
            this.label40.Text = "电话:";
            this.tabPage8.Controls.Add(this.textBox21);
            this.tabPage8.Controls.Add(this.label42);
            this.tabPage8.Controls.Add(this.label41);
            this.tabPage8.Controls.Add(this.richTextBox6);
            this.tabPage8.Location = new Point(4, 0x16);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new Size(0xdf, 0x6a);
            this.tabPage8.TabIndex = 4;
            this.tabPage8.Text = "短信";
            this.tabPage8.UseVisualStyleBackColor = true;
            this.textBox21.Location = new Point(0x31, 10);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new Size(100, 0x15);
            this.textBox21.TabIndex = 4;
            this.textBox21.KeyPress += new KeyPressEventHandler(this.textBox21_KeyPress);
            this.label42.AutoSize = true;
            this.label42.Location = new Point(8, 0x24);
            this.label42.Name = "label42";
            this.label42.Size = new Size(0x23, 12);
            this.label42.TabIndex = 3;
            this.label42.Text = "内容:";
            this.label41.AutoSize = true;
            this.label41.Location = new Point(8, 14);
            this.label41.Name = "label41";
            this.label41.Size = new Size(0x23, 12);
            this.label41.TabIndex = 2;
            this.label41.Text = "电话:";
            this.richTextBox6.Location = new Point(0x31, 0x23);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new Size(0x9e, 0x3f);
            this.richTextBox6.TabIndex = 1;
            this.richTextBox6.Text = "";
            this.tabPage9.Controls.Add(this.textBox19);
            this.tabPage9.Controls.Add(this.textBox18);
            this.tabPage9.Controls.Add(this.label39);
            this.tabPage9.Controls.Add(this.label38);
            this.tabPage9.Controls.Add(this.label37);
            this.tabPage9.Controls.Add(this.comboBox3);
            this.tabPage9.Location = new Point(4, 0x16);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new Size(0xdf, 0x6a);
            this.tabPage9.TabIndex = 5;
            this.tabPage9.Text = "WIFI";
            this.tabPage9.UseVisualStyleBackColor = true;
            this.textBox19.Location = new Point(0x62, 0x3e);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new Size(100, 0x15);
            this.textBox19.TabIndex = 5;
            this.textBox18.Location = new Point(0x62, 0x23);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new Size(100, 0x15);
            this.textBox18.TabIndex = 4;
            this.label39.AutoSize = true;
            this.label39.Location = new Point(11, 0x42);
            this.label39.Name = "label39";
            this.label39.Size = new Size(0x4d, 12);
            this.label39.TabIndex = 3;
            this.label39.Text = "无线WIFI密码";
            this.label38.AutoSize = true;
            this.label38.Location = new Point(11, 0x27);
            this.label38.Name = "label38";
            this.label38.Size = new Size(0x53, 12);
            this.label38.TabIndex = 2;
            this.label38.Text = "SSID/无线帐号";
            this.label37.AutoSize = true;
            this.label37.Location = new Point(11, 14);
            this.label37.Name = "label37";
            this.label37.Size = new Size(0x35, 12);
            this.label37.TabIndex = 1;
            this.label37.Text = "加密类型";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] { "WPA/WPA2", "WEB", "无加密" });
            this.comboBox3.Location = new Point(0x62, 9);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new Size(100, 20);
            this.comboBox3.TabIndex = 0;
            this.button5.Location = new Point(0x1e7, 0x157);
            this.button5.Name = "button5";
            this.button5.Size = new Size(0x2d, 30);
            this.button5.TabIndex = 0x43;
            this.button5.Text = "帮助";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new EventHandler(this.button5_Click);
            this.label27.AutoSize = true;
            this.label27.Location = new Point(400, 0xc4);
            this.label27.Name = "label27";
            this.label27.Size = new Size(0x1d, 12);
            this.label27.TabIndex = 0x42;
            this.label27.Text = "线宽";
            this.label26.AutoSize = true;
            this.label26.Location = new Point(0x18f, 0xab);
            this.label26.Name = "label26";
            this.label26.Size = new Size(0x29, 12);
            this.label26.TabIndex = 0x41;
            this.label26.Text = "边框宽";
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = Resources.蒙板;
            this.pictureBox6.InitialImage = (Image) manager.GetObject("pictureBox6.InitialImage");
            this.pictureBox6.Location = new Point(0x11, 9);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new Size(0xd6, 0xd6);
            this.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 0x40;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            this.label25.AutoSize = true;
            this.label25.Location = new Point(0xf3, 0x160);
            this.label25.Name = "label25";
            this.label25.Size = new Size(0x3b, 12);
            this.label25.TabIndex = 0x2e;
            this.label25.Text = "选择样式:";
            this.textBox6.Location = new Point(0x203, 80);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Size(11, 0x15);
            this.textBox6.TabIndex = 0x2d;
            this.textBox6.Visible = false;
            this.button16.BackColor = System.Drawing.Color.Transparent;
            this.button16.Location = new Point(0x12a, 190);
            this.button16.Name = "button16";
            this.button16.Size = new Size(0x19, 0x17);
            this.button16.TabIndex = 0x2c;
            this.button16.Text = "...";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Visible = false;
            this.button16.Click += new EventHandler(this.button16_Click);
            this.label16.AutoSize = true;
            this.label16.Location = new Point(0x100, 0xc3);
            this.label16.Name = "label16";
            this.label16.Size = new Size(0x29, 12);
            this.label16.TabIndex = 0x2b;
            this.label16.Text = "背景图";
            this.label16.Visible = false;
            this.numericUpDown4.Location = new Point(0x1bb, 0xc1);
            int[] bits = new int[4];
            bits[0] = 60;
            this.numericUpDown4.Maximum = new decimal(bits);
            bits = new int[4];
            bits[0] = 1;
            this.numericUpDown4.Minimum = new decimal(bits);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new Size(0x2c, 0x15);
            this.numericUpDown4.TabIndex = 0x29;
            bits = new int[4];
            bits[0] = 1;
            this.numericUpDown4.Value = new decimal(bits);
            this.numericUpDown4.Visible = false;
            this.button14.BackColor = System.Drawing.Color.Gray;
            this.button14.Location = new Point(0x173, 0xbf);
            this.button14.Name = "button14";
            this.button14.Size = new Size(0x19, 0x17);
            this.button14.TabIndex = 40;
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Visible = false;
            this.button14.Click += new EventHandler(this.button14_Click);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] { "普通", "围棋样式", "圆角样式", "内圆普通", "内圆圆滑", "内线条", "背景图片", "透明二维码", "图片像素" });
            this.comboBox2.Location = new Point(0x12e, 0x15d);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new Size(0x54, 20);
            this.comboBox2.TabIndex = 0x3f;
            this.comboBox2.SelectedIndexChanged += new EventHandler(this.comboBox2_SelectedIndexChanged);
            this.label15.AutoSize = true;
            this.label15.Location = new Point(0x14b, 0xc4);
            this.label15.Name = "label15";
            this.label15.Size = new Size(0x29, 12);
            this.label15.TabIndex = 0x27;
            this.label15.Text = "线条色";
            this.label15.Visible = false;
            bits = new int[4];
            bits[0] = 2;
            this.numericUpDown3.Increment = new decimal(bits);
            this.numericUpDown3.Location = new Point(0x1bb, 0xa7);
            bits = new int[4];
            bits[0] = 400;
            this.numericUpDown3.Maximum = new decimal(bits);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new Size(0x2c, 0x15);
            this.numericUpDown3.TabIndex = 0x26;
            bits = new int[4];
            bits[0] = 50;
            this.numericUpDown3.Value = new decimal(bits);
            this.label13.AutoSize = true;
            this.label13.Location = new Point(0x192, 0x8f);
            this.label13.Name = "label13";
            this.label13.Size = new Size(0x11, 12);
            this.label13.TabIndex = 0x25;
            this.label13.Text = "下";
            this.label13.Visible = false;
            this.label14.AutoSize = true;
            this.label14.Location = new Point(0x155, 0x8f);
            this.label14.Name = "label14";
            this.label14.Size = new Size(0x11, 12);
            this.label14.TabIndex = 0x24;
            this.label14.Text = "右";
            this.label14.Visible = false;
            this.textBox4.Location = new Point(420, 140);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Size(40, 0x15);
            this.textBox4.TabIndex = 0x23;
            this.textBox4.Text = "0";
            this.textBox4.Visible = false;
            this.textBox4.KeyPress += new KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox5.Location = new Point(0x166, 0x8b);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Size(40, 0x15);
            this.textBox5.TabIndex = 0x22;
            this.textBox5.Text = "0";
            this.textBox5.Visible = false;
            this.textBox5.KeyPress += new KeyPressEventHandler(this.textBox1_KeyPress);
            this.numericUpDown1.Location = new Point(0x129, 0x8b);
            bits = new int[4];
            bits[0] = 360;
            this.numericUpDown1.Maximum = new decimal(bits);
            bits = new int[4];
            bits[0] = 360;
            bits[3] = -2147483648;
            this.numericUpDown1.Minimum = new decimal(bits);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new Size(40, 0x15);
            this.numericUpDown1.TabIndex = 0x21;
            this.numericUpDown1.Visible = false;
            this.label12.AutoSize = true;
            this.label12.Location = new Point(0x107, 0x8e);
            this.label12.Name = "label12";
            this.label12.Size = new Size(0x1d, 12);
            this.label12.TabIndex = 0x20;
            this.label12.Text = "角度";
            this.label12.Visible = false;
            this.label8.AutoSize = true;
            this.label8.Location = new Point(0x70, 0xe7);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0, 12);
            this.label8.TabIndex = 0x1f;
            this.button13.Location = new Point(0xbf, 0xe3);
            this.button13.Name = "button13";
            this.button13.Size = new Size(0x2b, 20);
            this.button13.TabIndex = 30;
            this.button13.Text = "识别";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new EventHandler(this.button13_Click);
            this.textBox3.Location = new Point(0x1f2, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Size(11, 0x15);
            this.textBox3.TabIndex = 0x1d;
            this.textBox3.Visible = false;
            this.button12.Location = new Point(0x1cf, 0x8b);
            this.button12.Name = "button12";
            this.button12.Size = new Size(0x27, 0x17);
            this.button12.TabIndex = 0x1c;
            this.button12.Text = "重置";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Visible = false;
            this.button12.Click += new EventHandler(this.button12_Click);
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button20);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.button19);
            this.groupBox1.Controls.Add(this.numericUpDown5);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.button18);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Location = new Point(0xf4, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x11a, 0x75);
            this.groupBox1.TabIndex = 0x1b;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "二维码前景";
            this.button20.Location = new Point(0xed, 0x54);
            this.button20.Name = "button20";
            this.button20.Size = new Size(0x25, 0x17);
            this.button20.TabIndex = 0x43;
            this.button20.Text = "刷新";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new EventHandler(this.button20_Click);
            this.label24.AutoSize = true;
            this.label24.Location = new Point(0x5e, 0x41);
            this.label24.Name = "label24";
            this.label24.Size = new Size(0x1d, 12);
            this.label24.TabIndex = 0x2e;
            this.label24.Text = "比例";
            this.button19.BackColor = System.Drawing.Color.LightGray;
            this.button19.Location = new Point(0xc7, 0x54);
            this.button19.Name = "button19";
            this.button19.Size = new Size(0x19, 0x17);
            this.button19.TabIndex = 0x42;
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Visible = false;
            this.button19.Click += new EventHandler(this.button19_Click);
            this.numericUpDown5.DecimalPlaces = 1;
            bits = new int[4];
            bits[0] = 1;
            bits[3] = 0x10000;
            this.numericUpDown5.Increment = new decimal(bits);
            this.numericUpDown5.Location = new Point(0xed, 0x3d);
            bits = new int[4];
            bits[0] = 50;
            bits[3] = 0x10000;
            this.numericUpDown5.Maximum = new decimal(bits);
            bits = new int[4];
            bits[0] = 1;
            bits[3] = 0x10000;
            this.numericUpDown5.Minimum = new decimal(bits);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new Size(0x25, 0x15);
            this.numericUpDown5.TabIndex = 0x41;
            bits = new int[4];
            bits[0] = 10;
            bits[3] = 0x10000;
            this.numericUpDown5.Value = new decimal(bits);
            this.numericUpDown5.Visible = false;
            this.numericUpDown5.ValueChanged += new EventHandler(this.numericUpDown5_ValueChanged);
            this.label23.AutoSize = true;
            this.label23.Location = new Point(0xe2, 0x40);
            this.label23.Name = "label23";
            this.label23.Size = new Size(11, 12);
            this.label23.TabIndex = 0x2e;
            this.label23.Text = "R";
            this.label23.Visible = false;
            this.button18.BackColor = System.Drawing.Color.White;
            this.button18.Location = new Point(0xc7, 60);
            this.button18.Name = "button18";
            this.button18.Size = new Size(0x19, 0x17);
            this.button18.TabIndex = 0x40;
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Visible = false;
            this.button18.Click += new EventHandler(this.button18_Click);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] { "水平渐变", "垂直渐变", "左斜渐变", "右斜渐变", "球形渐变", "内球水平", "内球垂直", "内球左斜", "内球右斜", "内球球形" });
            this.comboBox1.Location = new Point(0x5f, 0x57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(0x49, 20);
            this.comboBox1.TabIndex = 0x3e;
            this.comboBox1.SelectedIndexChanged += new EventHandler(this.comboBox1_SelectedIndexChanged);
            this.numericUpDown2.DecimalPlaces = 1;
            bits = new int[4];
            bits[0] = 1;
            bits[3] = 0x10000;
            this.numericUpDown2.Increment = new decimal(bits);
            this.numericUpDown2.Location = new Point(0x7f, 0x3e);
            bits = new int[4];
            bits[0] = 1;
            this.numericUpDown2.Maximum = new decimal(bits);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new Size(0x2b, 0x15);
            this.numericUpDown2.TabIndex = 0x3d;
            bits = new int[4];
            bits[0] = 5;
            bits[3] = 0x10000;
            this.numericUpDown2.Value = new decimal(bits);
            this.numericUpDown2.ValueChanged += new EventHandler(this.numericUpDown2_ValueChanged);
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new Point(0x61, 0x2b);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new Size(60, 0x10);
            this.checkBox3.TabIndex = 0x21;
            this.checkBox3.Text = "渐变色";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new EventHandler(this.checkBox3_CheckedChanged);
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new Point(0x61, 0x13);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new Size(0x30, 0x10);
            this.checkBox2.TabIndex = 0x20;
            this.checkBox2.Text = "单色";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new EventHandler(this.checkBox2_CheckedChanged);
            this.button11.BackColor = System.Drawing.Color.Red;
            this.button11.Location = new Point(0xad, 60);
            this.button11.Name = "button11";
            this.button11.Size = new Size(0x19, 0x17);
            this.button11.TabIndex = 0x1f;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new EventHandler(this.button11_Click);
            this.button10.BackColor = System.Drawing.Color.Black;
            this.button10.Location = new Point(0xad, 0x54);
            this.button10.Name = "button10";
            this.button10.Size = new Size(0x19, 0x17);
            this.button10.TabIndex = 30;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new EventHandler(this.button10_Click);
            this.button9.Location = new Point(0xbb, 0x10);
            this.button9.Name = "button9";
            this.button9.Size = new Size(0x4b, 0x17);
            this.button9.TabIndex = 0x1a;
            this.button9.Text = "设置贴图";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new EventHandler(this.button9_Click);
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new Point(5, 0x1a);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new Size(0x55, 0x55);
            this.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0x19;
            this.pictureBox3.TabStop = false;
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.Location = new Point(0x93, 0x10);
            this.button7.Name = "button7";
            this.button7.Size = new Size(0x19, 0x17);
            this.button7.TabIndex = 0x13;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new EventHandler(this.button7_Click);
            this.label11.AutoSize = true;
            this.label11.Location = new Point(0x191, 0x72);
            this.label11.Name = "label11";
            this.label11.Size = new Size(0x11, 12);
            this.label11.TabIndex = 0x18;
            this.label11.Text = "高";
            this.label11.Visible = false;
            this.label10.AutoSize = true;
            this.label10.Location = new Point(340, 0x72);
            this.label10.Name = "label10";
            this.label10.Size = new Size(0x11, 12);
            this.label10.TabIndex = 0x17;
            this.label10.Text = "宽";
            this.label10.Visible = false;
            this.textBox2.Location = new Point(420, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(40, 0x15);
            this.textBox2.TabIndex = 0x16;
            this.textBox2.Text = "200";
            this.textBox2.Visible = false;
            this.textBox2.KeyPress += new KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Location = new Point(0x166, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(40, 0x15);
            this.textBox1.TabIndex = 0x15;
            this.textBox1.Text = "200";
            this.textBox1.Visible = false;
            this.textBox1.KeyPress += new KeyPressEventHandler(this.textBox1_KeyPress);
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Location = new Point(0x12a, 0xa6);
            this.button8.Name = "button8";
            this.button8.Size = new Size(0x19, 0x17);
            this.button8.TabIndex = 20;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new EventHandler(this.button8_Click);
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Location = new Point(370, 0xa6);
            this.button6.Name = "button6";
            this.button6.Size = new Size(0x19, 0x17);
            this.button6.TabIndex = 0x12;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new EventHandler(this.button6_Click);
            this.label9.AutoSize = true;
            this.label9.Location = new Point(0x100, 0xab);
            this.label9.Name = "label9";
            this.label9.Size = new Size(0x29, 12);
            this.label9.TabIndex = 0x11;
            this.label9.Text = "背景色";
            this.label7.AutoSize = true;
            this.label7.Location = new Point(330, 0xab);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x29, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "边框色";
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new Point(0xfe, 0x71);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new Size(0x48, 0x10);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "中心图片";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new EventHandler(this.checkBox1_CheckedChanged);
            this.label5.AutoSize = true;
            this.label5.Location = new Point(0xfe, 0x57);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x35, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "尺寸级别";
            this.txtSize.Location = new Point(0x14b, 0x52);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new Size(0x24, 0x15);
            this.txtSize.TabIndex = 12;
            this.txtSize.Text = "16";
            this.txtSize.KeyPress += new KeyPressEventHandler(this.txtSize_KeyPress);
            this.label4.AutoSize = true;
            this.label4.Location = new Point(0xfe, 0x3e);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x4d, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "字符数量级别";
            this.cboVersion.FormattingEnabled = true;
            this.cboVersion.Items.AddRange(new object[] { 
                "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", 
                "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", 
                "33", "34", "35", "36", "37", "38", "39", "40"
             });
            this.cboVersion.Location = new Point(0x14b, 0x39);
            this.cboVersion.Name = "cboVersion";
            this.cboVersion.Size = new Size(0x4f, 20);
            this.cboVersion.TabIndex = 10;
            this.label3.AutoSize = true;
            this.label3.Location = new Point(0xfe, 0x24);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x35, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "容错级别";
            this.cboCorrectionLevel.FormattingEnabled = true;
            this.cboCorrectionLevel.Items.AddRange(new object[] { "低", "中", "高", "最高" });
            this.cboCorrectionLevel.Location = new Point(0x14b, 0x20);
            this.cboCorrectionLevel.Name = "cboCorrectionLevel";
            this.cboCorrectionLevel.Size = new Size(0x4f, 20);
            this.cboCorrectionLevel.TabIndex = 8;
            this.label2.AutoSize = true;
            this.label2.Location = new Point(0xfe, 10);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x35, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "文字类型";
            this.cboEncoding.FormattingEnabled = true;
            this.cboEncoding.Items.AddRange(new object[] { "文字", "数字" });
            this.cboEncoding.Location = new Point(0x14b, 7);
            this.cboEncoding.Name = "cboEncoding";
            this.cboEncoding.Size = new Size(0x4f, 20);
            this.cboEncoding.TabIndex = 6;
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            this.pictureBox1.Image = Resources.my;
            this.pictureBox1.Location = new Point(14, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(220, 220);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.richTextBox1.Location = new Point(0x1cf, 0x51);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new Size(0x1d, 0x11);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            this.label1.AutoSize = true;
            this.label1.Location = new Point(13, 0xe7);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x59, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "选择转换的类型";
            this.button2.Location = new Point(0x1b7, 0x157);
            this.button2.Name = "button2";
            this.button2.Size = new Size(0x2d, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "保存";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button1.Location = new Point(0x187, 0x157);
            this.button1.Name = "button1";
            this.button1.Size = new Size(0x2d, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "预览";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.label47);
            this.tabPage2.Controls.Add(this.label46);
            this.tabPage2.Controls.Add(this.comboBox5);
            this.tabPage2.Controls.Add(this.richTextBox2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new Point(4, 0x16);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new Padding(3);
            this.tabPage2.Size = new Size(0x216, 0x18f);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "二维解码";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.label47.AutoSize = true;
            this.label47.Location = new Point(0x10f, 0xe9);
            this.label47.Name = "label47";
            this.label47.Size = new Size(0xf5, 12);
            this.label47.TabIndex = 0x4b;
            this.label47.Text = "如果解码出现乱码，可转换编码模式重新解码";
            this.label46.AutoSize = true;
            this.label46.Location = new Point(0x13f, 0xc5);
            this.label46.Name = "label46";
            this.label46.Size = new Size(0x1d, 12);
            this.label46.TabIndex = 0x4a;
            this.label46.Text = "编码";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] { "GB2312", "UTF8", "Unicode" });
            this.comboBox5.Location = new Point(0x160, 0xc2);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new Size(0x42, 20);
            this.comboBox5.TabIndex = 0x49;
            this.richTextBox2.Location = new Point(0x111, 0x44);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new Size(0xee, 120);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            this.label6.AutoSize = true;
            this.label6.Location = new Point(0x112, 0x30);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x41, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "转换后信息";
            this.button4.Location = new Point(0x193, 0x106);
            this.button4.Name = "button4";
            this.button4.Size = new Size(0x4b, 0x17);
            this.button4.TabIndex = 3;
            this.button4.Text = "解码";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new EventHandler(this.button4_Click);
            this.button3.Location = new Point(0x142, 0x106);
            this.button3.Name = "button3";
            this.button3.Size = new Size(0x4b, 0x17);
            this.button3.TabIndex = 2;
            this.button3.Text = "打开二维码";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new EventHandler(this.button3_Click);
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            this.pictureBox2.Image = Resources.aa;
            this.pictureBox2.Location = new Point(6, 0x31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new Size(0xff, 0xff);
            this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.label48);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.textBox9);
            this.tabPage3.Controls.Add(this.textBox8);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.button17);
            this.tabPage3.Controls.Add(this.button15);
            this.tabPage3.Controls.Add(this.textBox7);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.pictureBox5);
            this.tabPage3.Controls.Add(this.pictureBox4);
            this.tabPage3.Location = new Point(4, 0x16);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new Size(0x216, 0x18f);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "注册";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new Point(0x68, 310);
            this.label22.Name = "label22";
            this.label22.Size = new Size(0x131, 12);
            this.label22.TabIndex = 13;
            this.label22.Text = "如需注册请联系 QQ:51553874  TEL: 18502001405(杨生)";
            this.label21.AutoSize = true;
            this.label21.Location = new Point(0xe9, 0x52);
            this.label21.Name = "label21";
            this.label21.Size = new Size(0x53, 12);
            this.label21.TabIndex = 12;
            this.label21.Text = "(最大值10000)";
            this.label20.AutoSize = true;
            this.label20.Location = new Point(0x65, 0x81);
            this.label20.Name = "label20";
            this.label20.Size = new Size(0x59, 12);
            this.label20.TabIndex = 10;
            this.label20.Text = "机器码的二维码";
            this.label19.AutoSize = true;
            this.label19.Location = new Point(0x65, 0x51);
            this.label19.Name = "label19";
            this.label19.Size = new Size(0x35, 12);
            this.label19.TabIndex = 9;
            this.label19.Text = "使用次数";
            this.textBox9.Location = new Point(0x9e, 0x4d);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Size(0x40, 0x15);
            this.textBox9.TabIndex = 8;
            this.textBox8.Location = new Point(0x9d, 0x66);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Size(0xd8, 0x15);
            this.textBox8.TabIndex = 6;
            this.label18.AutoSize = true;
            this.label18.Location = new Point(0x65, 0x69);
            this.label18.Name = "label18";
            this.label18.Size = new Size(0x29, 12);
            this.label18.TabIndex = 5;
            this.label18.Text = "注册码";
            this.button17.Location = new Point(0xe1, 0x109);
            this.button17.Name = "button17";
            this.button17.Size = new Size(0x4b, 0x17);
            this.button17.TabIndex = 4;
            this.button17.Text = "注册";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new EventHandler(this.button17_Click);
            this.button15.Location = new Point(0x177, 0x33);
            this.button15.Name = "button15";
            this.button15.Size = new Size(0x30, 0x17);
            this.button15.TabIndex = 2;
            this.button15.Text = "获取";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new EventHandler(this.button15_Click);
            this.textBox7.Location = new Point(0x9e, 0x34);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new Size(0xd7, 0x15);
            this.textBox7.TabIndex = 1;
            this.textBox7.Text = "点击获取获得注册码";
            this.label17.AutoSize = true;
            this.label17.Location = new Point(0x65, 0x38);
            this.label17.Name = "label17";
            this.label17.Size = new Size(0x29, 12);
            this.label17.TabIndex = 0;
            this.label17.Text = "机器码";
            this.pictureBox5.Location = new Point(0xca, 0x81);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new Size(130, 130);
            this.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            this.pictureBox4.Image = Resources.button_cancel;
            this.pictureBox4.Location = new Point(0x17b, 0x66);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new Size(20, 20);
            this.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.statusStrip1.Items.AddRange(new ToolStripItem[] { this.toolStripStatusLabel1 });
            this.statusStrip1.Location = new Point(0, 0x193);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new Size(0x21e, 0x16);
            this.statusStrip1.TabIndex = 0x2f;
            this.statusStrip1.Text = "statusStrip1";
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new Size(0xbc, 0x11);
            this.toolStripStatusLabel1.Text = "您现在使用的试用版，请尽快注册";
            this.label48.AutoSize = true;
            this.label48.Location = new Point(0x6a, 0x14e);
            this.label48.Name = "label48";
            this.label48.Size = new Size(0xfb, 12);
            this.label48.TabIndex = 14;
            this.label48.Text = "官方网站：http://www.xkwork.com  点击访问";
            this.label48.Click += new EventHandler(this.label48_Click);
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            base.ClientSize = new Size(0x21e, 0x1a9);
            base.Controls.Add(this.statusStrip1);
            base.Controls.Add(this.tabControl1);
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.Name = "Form1";
            this.Text = "炫酷二维码生成器";
            base.Deactivate += new EventHandler(this.Form1_Deactivate);
            base.Load += new EventHandler(this.Form1_Load);
            base.Activated += new EventHandler(this.Form1_Activated);
            base.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            ((ISupportInitialize) this.pictureBox6).EndInit();
            this.numericUpDown4.EndInit();
            this.numericUpDown3.EndInit();
            this.numericUpDown1.EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.numericUpDown5.EndInit();
            this.numericUpDown2.EndInit();
            ((ISupportInitialize) this.pictureBox3).EndInit();
            ((ISupportInitialize) this.pictureBox1).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((ISupportInitialize) this.pictureBox2).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((ISupportInitialize) this.pictureBox5).EndInit();
            ((ISupportInitialize) this.pictureBox4).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        public bool InsertHook()
        {
            IntPtr pInstance = (IntPtr) 0x400000;
            if (this.pKeyboardHook == IntPtr.Zero)
            {
                this.KeyboardHookProcedure = new HookProc(this.KeyboardHookProc);
                this.pKeyboardHook = SetWindowsHookEx(13, this.KeyboardHookProcedure, pInstance, 0);
                if (this.pKeyboardHook == IntPtr.Zero)
                {
                    this.UnInsertHook();
                    return false;
                }
            }
            return true;
        }

        private int KeyboardHookProc(int nCode, int wParam, IntPtr lParam)
        {
            KeyMSG ymsg = (KeyMSG) Marshal.PtrToStructure(lParam, typeof(KeyMSG));
            if (this.pKeyboardHook != IntPtr.Zero)
            {
                switch (((Keys) ymsg.vkCode))
                {
                    case Keys.Print:
                    case Keys.Snapshot:
                    case Keys.Alt:
                        return 1;
                }
            }
            return 0;
        }

        private Image KiResizeImage(Image bmp, int newW, int newH, int Mode)
        {
            try
            {
                Image image = new Bitmap(newW, newH);
                Graphics graphics = Graphics.FromImage(image);
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(bmp, new Rectangle(0, 0, newW, newH), new Rectangle(0, 0, bmp.Width, bmp.Height), GraphicsUnit.Pixel);
                graphics.Dispose();
                return image;
            }
            catch
            {
                return null;
            }
        }

        private void label48_Click(object sender, EventArgs e)
        {
            Process.Start("iexplore.exe", "www.xkwork.com");
        }

        private int len(string str)
        {
            byte[] bytes = new ASCIIEncoding().GetBytes(str);
            int num = 0;
            for (int i = 0; i <= (bytes.Length - 1); i++)
            {
                if (bytes[i] == 0x3f)
                {
                    num++;
                }
                num++;
            }
            return num;
        }

        private Bitmap line_add(Bitmap image)
        {
            System.Drawing.Color pixel = image.GetPixel(int.Parse(this.txtSize.Text) / 2, int.Parse(this.txtSize.Text) / 2);
            System.Drawing.Color backColor = this.button8.BackColor;
            Bitmap bitmap = new Bitmap(image.Width, image.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.FillRectangle(new SolidBrush(backColor), 0, 0, image.Width, image.Height);
            graphics.Dispose();
            Graphics graphics2 = Graphics.FromImage(bitmap);
            for (int i = 0; i < (image.Height - 1); i += int.Parse(this.txtSize.Text))
            {
                for (int j = 0; j < (image.Width - 1); j += int.Parse(this.txtSize.Text))
                {
                    if ((image.GetPixel(j + (int.Parse(this.txtSize.Text) / 2), i + (int.Parse(this.txtSize.Text) / 2)) == pixel) && (image.GetPixel(j + (int.Parse(this.txtSize.Text) / 2), i + (int.Parse(this.txtSize.Text) / 2)) == pixel))
                    {
                        graphics2.FillRectangle(new SolidBrush(pixel), j, i, int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                        graphics2.DrawRectangle(new Pen(this.button14.BackColor, (float) this.numericUpDown4.Value), j, i, int.Parse(this.txtSize.Text), int.Parse(this.txtSize.Text));
                    }
                }
            }
            graphics2.Dispose();
            return bitmap;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked)
            {
                this.creat_image();
                this.Refresh();
            }
            else
            {
                MessageBox.Show("请先选择渐变色");
            }
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
        }

        private string password(string passw, int apply_sum)
        {
            string str = "";
            int length = 4;
            for (int i = 0; i <= (passw.Length - length); i++)
            {
                str = str + Math.Abs(passw.Substring(i, length).GetHashCode()).ToString();
            }
            return GetMd5Str(str + apply_sum);
        }

        public bool reg_str_yn(string regtxt)
        {
            RegistryKey currentUser = Registry.CurrentUser;
            foreach (string str in currentUser.GetSubKeyNames())
            {
                if (str.Trim() == regtxt.Trim())
                {
                    return true;
                }
            }
            return false;
        }

        public Bitmap Rotate(Image b, int angle)
        {
            angle = angle % 360;
            double d = (angle * 3.1415926535897931) / 180.0;
            double num2 = Math.Cos(d);
            double num3 = Math.Sin(d);
            int width = b.Width;
            int height = b.Height;
            int num6 = (int) Math.Max(Math.Abs((double) ((width * num2) - (height * num3))), Math.Abs((double) ((width * num2) + (height * num3))));
            int num7 = (int) Math.Max(Math.Abs((double) ((width * num3) - (height * num2))), Math.Abs((double) ((width * num3) + (height * num2))));
            Bitmap image = new Bitmap(num6, num7);
            Graphics graphics = Graphics.FromImage(image);
            graphics.InterpolationMode = InterpolationMode.Bilinear;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            Point point = new Point((num6 - width) / 2, (num7 - height) / 2);
            Rectangle rect = new Rectangle(point.X, point.Y, width, height);
            Point point2 = new Point(rect.X + (rect.Width / 2), rect.Y + (rect.Height / 2));
            graphics.TranslateTransform((float) point2.X, (float) point2.Y);
            graphics.RotateTransform((float) (360 - angle));
            graphics.TranslateTransform((float) -point2.X, (float) -point2.Y);
            graphics.DrawImage(b, rect);
            graphics.ResetTransform();
            graphics.Save();
            graphics.Dispose();
            return image;
        }

        private Bitmap round1(Bitmap image)
        {
            System.Drawing.Color pixel = image.GetPixel(int.Parse(this.txtSize.Text) / 2, int.Parse(this.txtSize.Text) / 2);
            System.Drawing.Color backColor = this.button8.BackColor;
            Graphics graphics = Graphics.FromImage(image);
            for (int i = 0; i < (image.Height - 1); i += int.Parse(this.txtSize.Text))
            {
                for (int j = 0; j < (image.Width - 1); j += int.Parse(this.txtSize.Text))
                {
                    if ((((((i >= 0) && (i <= (6 * int.Parse(this.txtSize.Text)))) && ((j >= 0) && (j <= (6 * int.Parse(this.txtSize.Text))))) || (((i >= 0) && (i <= (6 * int.Parse(this.txtSize.Text)))) && ((j >= (image.Width - (7 * int.Parse(this.txtSize.Text)))) && (j < (image.Width - (4 * int.Parse(this.txtSize.Text))))))) || ((((i >= (image.Height - (7 * int.Parse(this.txtSize.Text)))) && (i <= (image.Height - (4 * int.Parse(this.txtSize.Text))))) && (j >= 0)) && (j <= (6 * int.Parse(this.txtSize.Text))))) && (((((image.GetPixel(j + (int.Parse(this.txtSize.Text) / 2), i + (int.Parse(this.txtSize.Text) / 2)) == pixel) && (image.GetPixel((j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), i + (int.Parse(this.txtSize.Text) / 2)) == pixel)) && ((image.GetPixel((j + (2 * int.Parse(this.txtSize.Text))) + (int.Parse(this.txtSize.Text) / 2), i + (int.Parse(this.txtSize.Text) / 2)) == pixel) && (image.GetPixel(j + (int.Parse(this.txtSize.Text) / 2), (i + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2)) == pixel))) && (((image.GetPixel(j + (int.Parse(this.txtSize.Text) / 2), (i + (2 * int.Parse(this.txtSize.Text))) + (int.Parse(this.txtSize.Text) / 2)) == pixel) && (image.GetPixel((j + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2), (i + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2)) == pixel)) && (image.GetPixel((j + (2 * int.Parse(this.txtSize.Text))) + (int.Parse(this.txtSize.Text) / 2), (i + int.Parse(this.txtSize.Text)) + (int.Parse(this.txtSize.Text) / 2)) == pixel))) && (image.GetPixel((j + (2 * int.Parse(this.txtSize.Text))) + (int.Parse(this.txtSize.Text) / 2), (i + (2 * int.Parse(this.txtSize.Text))) + (int.Parse(this.txtSize.Text) / 2)) == pixel)))
                    {
                        graphics.FillRectangle(new SolidBrush(backColor), j, i, 3 * int.Parse(this.txtSize.Text), 3 * int.Parse(this.txtSize.Text));
                        graphics.FillEllipse(new SolidBrush(System.Drawing.Color.Red), j, i, 3 * int.Parse(this.txtSize.Text), 3 * int.Parse(this.txtSize.Text));
                    }
                }
            }
            graphics.Dispose();
            return image;
        }

        [DllImport("user32.dll", CallingConvention=CallingConvention.StdCall)]
        public static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr pInstance, int threadId);
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar) && (e.KeyChar != '\r')) && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar) && (e.KeyChar != '\r')) && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox17.Text.Trim() == "")
            {
                this.textBox17.Text = "http://";
            }
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar) && (e.KeyChar != '\r')) && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }

        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar) && (e.KeyChar != '\r')) && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox22.Text.Trim() == "")
            {
                this.textBox22.Text = "http://";
            }
        }

        private void txtSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar) && (e.KeyChar != '\r')) && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }

        [DllImport("user32.dll", CallingConvention=CallingConvention.StdCall)]
        public static extern bool UnhookWindowsHookEx(IntPtr pHookHandle);
        public bool UnInsertHook()
        {
            bool flag = true;
            if (this.pKeyboardHook != IntPtr.Zero)
            {
                flag = UnhookWindowsHookEx(this.pKeyboardHook) && flag;
                this.pKeyboardHook = IntPtr.Zero;
            }
            return flag;
        }

        public delegate int HookProc(int nCode, int wParam, IntPtr lParam);

        [StructLayout(LayoutKind.Sequential)]
        public struct KeyMSG
        {
            public int vkCode;
            public int scanCode;
            public int flags;
            public int time;
            public int dwExtraInfo;
        }
    }
}

