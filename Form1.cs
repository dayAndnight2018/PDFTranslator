﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Web;
using eBdb.EpubReader;

namespace WindowsFormsApplication2
{
    public enum Type {
        PDF = 0,
        EPUB = 1
    }

    public partial class Form1 : Form
    {

        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static public extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

        MouseHook mouseHook = new MouseHook();

        bool isDown = false;
        bool isMove = false;

        Epub epub;      

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            content.Parent = panel1;
        }

        public Form1(String path, Type type)
        {
            InitializeComponent();
            if (type == Type.PDF)
            {
                axAcroPDF.src = path;
                this.WindowState = FormWindowState.Maximized;
                this.label2.Text = Path.GetFileName(path);
                this.webBrowser.Visible = false;
                this.axAcroPDF.Visible = true;
            }
            else if (type == Type.EPUB)
            {
                epub = new Epub(path);
                this.WindowState = FormWindowState.Maximized;
                this.label2.Text = Path.GetFileName(path);
                string htmlText = epub.GetContentAsHtml();
                webBrowser.DocumentText = htmlText;
                webBrowser.Show();
                this.webBrowser.Visible = true;
                this.axAcroPDF.Visible = false;
            }
            content.Parent = panel1;
        }

        private void hide_btn_Click_1(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = true;
        }        
           

        void mouseHook_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //鼠标左键点下 则开始绘制
                isDown = true;
            }
        }


        void mouseHook_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown && ucSwitch1.Checked)
            {
                isMove = true;
            }
        }

        void mouseHook_MouseUp(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                Thread t = new Thread(() =>
                {
                    if (isDown && isMove)
                    {
                        SendKeys.SendWait("^c");
                        SendKeys.Flush();
                        IDataObject iData = Clipboard.GetDataObject();
                        if (null != iData)
                        {
                            if (iData.GetDataPresent(DataFormats.Text)) //检查是否存在文本
                            {
                                    Thread.Sleep(500);
                                    string res = (String)iData.GetData(DataFormats.Text);
                                    if (!string.IsNullOrWhiteSpace(res))
                                    {
                                        if (splitContainer1.Panel2Collapsed)
                                        {
                                            splitContainer1.Panel2Collapsed = false;
                                        }
                                        word.Text = res;
                                    }
                            }
                        }
                        Translate2(word.Text);
                    }
                    isDown = false;
                    isMove = false;
                });
                Control.CheckForIllegalCrossThreadCalls = false;
                t.SetApartmentState(ApartmentState.STA);
                t.Start();

            }

        }

        void Translate(string input)
        {

            try
            {
                HttpWebRequest request = WebRequest.Create("http://ws.webxml.com.cn//WebServices/TranslatorWebService.asmx/getEnCnTwoWayTranslator?Word=" + input.Trim()) as HttpWebRequest;
                request.Method = "GET";
                request.Timeout = 2000;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                StreamReader sr = new StreamReader(response.GetResponseStream());
                string result = sr.ReadToEnd();
                var matches = Regex.Matches(result, @"(?<=\<string\>)[\s\S]*?(?=\</string\>)");
                if (matches != null)
                {
                    translation.Text = null;
                }

                for (int i = 1; i < matches.Count; i++)
                {
                    string temp = matches[i].ToString();
                    string[] splits = temp.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var item in splits)
                    {
                        translation.Text += item.Trim();
                        translation.Text += Environment.NewLine;
                    }
                }
            }
            catch (Exception ex)
            {
                translation.Text = null;
            }
        }

        public static string UnicodeToGB(string text)
        {
            System.Text.RegularExpressions.MatchCollection mc = System.Text.RegularExpressions.Regex.Matches(text, "\\\\u([\\w]{4})");
            if (mc != null && mc.Count > 0)
            {
                foreach (System.Text.RegularExpressions.Match m2 in mc)
                {
                    string v = m2.Value;
                    string word = v.Substring(2);
                    byte[] codes = new byte[2];
                    int code = Convert.ToInt32(word.Substring(0, 2), 16);
                    int code2 = Convert.ToInt32(word.Substring(2), 16);
                    codes[0] = (byte)code2;
                    codes[1] = (byte)code;
                    text = text.Replace(v, Encoding.Unicode.GetString(codes));
                }
            }
            else
            {

            }
            return text;
        }

        void Translate2(string input)
        {
            bool flag = input.Trim(' ').Contains(" ");
            input = input.Replace("\r\n", " ").Replace("（", "(").Replace("）", ")").Replace(" [ ", "[").Replace(" ] ", "]");
            input = Regex.Replace(input, @"\([^\(]*\)", "");
            input = Regex.Replace(input, @"\[[^\[]*\]", "");
            input = HttpUtility.HtmlEncode(input);

            try
            {
                HttpWebRequest request = WebRequest.Create("http://fy.iciba.com/ajax.php?a=fy&f=auto&t=auto&w=" + input) as HttpWebRequest;
                request.Method = "GET";
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                StreamReader sr = new StreamReader(response.GetResponseStream());
                string result = sr.ReadToEnd();
                if (!string.IsNullOrWhiteSpace(result))
                {
                    translation.Text = String.Empty;
                }
                if (flag)
                {
                    var matches = Regex.Match(result, @"(?<=out"":"")[\s\S]*?(?="")").ToString();

                    translation.Text = UnicodeToGB(matches);
                }
                else
                {
                    var matches = Regex.Match(result, @"(?<=word_mean"":\[)[\s\S]*?(?=\])").ToString();
                    matches = UnicodeToGB(matches);
                    var splitResult = matches.Split(new char[]{','});
                    foreach (var item in splitResult)
                    {
                        translation.Text += item.Trim('"');
                        translation.Text += Environment.NewLine;
                    }
                   
                }
               

            }
            catch (Exception ex)
            {
                translation.Text = null;
            }


        }

        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C:\\";
            ofd.Filter = "PDF文件|*.pdf|EPUB文件|*.epub";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (ofd.FileName.ToLower().EndsWith(".pdf"))
                {
                    axAcroPDF.src = ofd.FileName;
                    this.label2.Text = Path.GetFileName(ofd.FileName);
                    this.webBrowser.Visible = false;
                    this.axAcroPDF.Visible = true;
                }
                else if (ofd.FileName.ToLower().EndsWith(".epub"))
                {
                    epub = new Epub(ofd.FileName);
                    this.label2.Text = Path.GetFileName(ofd.FileName);
                    this.webBrowser.Visible = true;
                    this.axAcroPDF.Visible = false;
                    string htmlText = epub.GetContentAsHtml();
                    webBrowser.DocumentText = htmlText;
                    webBrowser.Show();
                   
                }


                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = true;
        }

        private void ucSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if(ucSwitch1.Checked)
            {
                mouseHook.MouseMove += new MouseEventHandler(mouseHook_MouseMove);
                mouseHook.MouseDown += new MouseEventHandler(mouseHook_MouseDown);
                mouseHook.MouseUp += new MouseEventHandler(mouseHook_MouseUp);
                mouseHook.Start();
            }
            else
            {
                mouseHook.MouseMove -= new MouseEventHandler(mouseHook_MouseMove);
                mouseHook.MouseDown -= new MouseEventHandler(mouseHook_MouseDown);
                mouseHook.MouseUp -= new MouseEventHandler(mouseHook_MouseUp);
                mouseHook.Stop();
            }
        }

        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            mouseHook.MouseMove -= new MouseEventHandler(mouseHook_MouseMove);
            mouseHook.MouseDown -= new MouseEventHandler(mouseHook_MouseDown);
            mouseHook.MouseUp -= new MouseEventHandler(mouseHook_MouseUp);
            mouseHook.Stop();
            this.Close();
        }

        private void openFile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C:\\";
            ofd.Filter = "PDF文件|*.pdf|EPUB文件|*.epub";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (ofd.FileName.ToLower().EndsWith(".pdf"))
                {
                    axAcroPDF.src = ofd.FileName;
                    this.label2.Text = Path.GetFileName(ofd.FileName);
                    this.webBrowser.Visible = false;
                    this.axAcroPDF.Visible = true;
                }
                else if (ofd.FileName.ToLower().EndsWith(".epub"))
                {
                    epub = new Epub(ofd.FileName);
                    this.label2.Text = Path.GetFileName(ofd.FileName);
                    this.webBrowser.Visible = true;
                    this.axAcroPDF.Visible = false;
                    string htmlText = epub.GetContentAsHtml();
                    webBrowser.DocumentText = htmlText;
                    webBrowser.Show();

                }



            }
        }

        private void min_BtnClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
