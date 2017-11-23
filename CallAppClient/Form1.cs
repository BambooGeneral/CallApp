using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CallAppClient
{
    public partial class Form1 : Form
    {
        //文字コード
        private Encoding enc = Encoding.GetEncoding("shift_jis");
        private string ParentPath = @"%userprofile%";
        private string callFileName;
        private string calledFileName;
        private string emgFileName;
        private string wakeFileName;
        private string AppConfigFileName;

        public Form1()
        {
            InitializeComponent();
            this.Hide();
            labelCall.Text = "";
            // 実行ファイルのディレクトリを取得する
            string stBaseDir = System.AppDomain.CurrentDomain.BaseDirectory;

            // カレントディレクトリを表示する
            Debug.WriteLine(stBaseDir);

            //設定ファイルを読み込む
            AppConfigFileName = stBaseDir + @"\CallAppClient.cfg";
            Debug.WriteLine(AppConfigFileName);
            if (File.Exists(AppConfigFileName))
            {
                Debug.WriteLine("'" + AppConfigFileName + "'は存在します。");

                //テキストファイルの中身をすべて読み込む
                string str = Environment.ExpandEnvironmentVariables(File.ReadAllText(AppConfigFileName, enc));
                Debug.WriteLine(str);
                if (Directory.Exists(str))
                {
                    ParentPath = str;
                }
                else
                {
                    MessageBox.Show("設定ファイルの内容が異常です。サーバーが見つかりません。");
                    string appendText = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + str + Environment.NewLine;
                    System.IO.File.AppendAllText("CallAppClient.log", appendText);
                }
            }
            else
            {
                MessageBox.Show("設定ファイルが見つかりません。");
            }
            callFileName = ParentPath + @"call.cfg";
            calledFileName = ParentPath + @"called.cfg";
            emgFileName = ParentPath + @"emg.cfg";
            wakeFileName = ParentPath + @"wake.cfg";

            //ファイルが存在しているときは、上書きする
            File.WriteAllText(wakeFileName, "", enc);

            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (File.Exists(callFileName) && !File.Exists(calledFileName))
            {
                //テキストファイルの中身をすべて読み込む
                string str = File.ReadAllText(callFileName, this.enc);
                labelCall.Text = str;

                this.WindowState = FormWindowState.Maximized;
                this.Visible = true;

                labelCall.Top = (this.Height - labelCall.Height) / 2;
                labelCall.Left = (this.Width - labelCall.Width) / 2;

                if (!File.Exists(emgFileName)&&!this.CloseButton.Visible)
                {
                    timer2.Start();
                }
            }
            else
            {
                //this.WindowState = FormWindowState.Minimized;
                this.Visible = false;
                this.CloseButton.Visible = false;
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            this.CloseButton.Visible = true;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            //ファイルが存在しているときは、上書きする
            File.WriteAllText(this.calledFileName, "", this.enc);
            this.Visible = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
            else
            {
                File.Delete(wakeFileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
