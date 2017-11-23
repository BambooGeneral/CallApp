using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CallAppServer
{
    public partial class Form1 : Form
    {
        private Encoding enc = Encoding.GetEncoding("shift_jis");
        private string ParentPath = @"%userprofile%";
        private string callFileName;
        private string calledFileName;
        private string emgFileName;
        private string wakeFileName;
        private string AppConfigFileName;
        private DirectoryInfo di;
        private DirectoryInfo[] subFolders;
        private Object[] buf;

        public Form1()
        {
            InitializeComponent();
            // 実行ファイルのディレクトリを取得する
            string stBaseDir = AppDomain.CurrentDomain.BaseDirectory;

            // カレントディレクトリを表示する
            Debug.WriteLine(stBaseDir);

            //設定ファイルを読み込む
            if (!stBaseDir.EndsWith(@"\"))
            {
                stBaseDir += @"\";
            }
            AppConfigFileName = stBaseDir + @"CallAppServer.cfg";
            Debug.WriteLine(AppConfigFileName);
            if (File.Exists(AppConfigFileName))
            {
                Debug.WriteLine("'" + AppConfigFileName + "'は存在します。");

                //テキストファイルの中身をすべて読み込む
                string str = Environment.ExpandEnvironmentVariables(File.ReadAllText(AppConfigFileName, enc));
                if (!str.EndsWith(@"\"))
                {
                    str += @"\";
                }
                Debug.WriteLine(str);
                if (Directory.Exists(str))
                {
                    ParentPath = str;
                }
                else
                {
                    MessageBox.Show("設定ファイルの内容が異常です。サーバーが見つかりません。");
                    string appendText = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + str + Environment.NewLine;
                    File.AppendAllText(stBaseDir + @"CallAppServer.log", appendText);
                }
            }
            else
            {
                MessageBox.Show("設定ファイルが見つかりません。");
            }
            //サブフォルダをすべて取得する
            this.di = new DirectoryInfo(ParentPath);
            this.subFolders = di.GetDirectories("*", SearchOption.TopDirectoryOnly);

            //ListBox1に結果を表示する
            foreach (DirectoryInfo subFolder in subFolders)
            {
                //name,wake,called,call,emg,text
                callFileName = subFolder.FullName + @"\call.cfg";
                calledFileName = subFolder.FullName + @"\called.cfg";
                emgFileName = subFolder.FullName + @"\emg.cfg";
                wakeFileName = subFolder.FullName + @"\wake.cfg";
                buf = new object[] { subFolder.Name, File.Exists(wakeFileName), File.Exists(calledFileName), File.Exists(callFileName), File.Exists(emgFileName), "SET", "" };
                dataGridView1.Rows.Add(buf);
            }
            timer1.Start();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ClientName = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string textMessage = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            Debug.Print(ClientName);
            //ファイルが存在しているときは、上書きする
            File.WriteAllText(ParentPath + ClientName + @"\call.cfg", textMessage, this.enc);
            Boolean isEMG = (Boolean)dataGridView1.Rows[e.RowIndex].Cells[4].Value;
            if (isEMG)
            {
                File.WriteAllText(ParentPath + ClientName + @"\emg.cfg", "", this.enc);
            }
            else
            {
                File.Delete(ParentPath + ClientName + @"\emg.cfg");
            }
            File.Delete(ParentPath + ClientName + @"\called.cfg");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells[0].Value == null)
                {
                    break;
                }
                callFileName = ParentPath + item.Cells[0].Value + @"\call.cfg";
                calledFileName = ParentPath + item.Cells[0].Value + @"\called.cfg";
                emgFileName = ParentPath + item.Cells[0].Value + @"\emg.cfg";
                wakeFileName = ParentPath + item.Cells[0].Value + @"\wake.cfg";

                Debug.Print(item.Cells[0].Value.ToString());
                item.Cells[1].Value = File.Exists(wakeFileName);
                item.Cells[2].Value = File.Exists(calledFileName);
                item.Cells[3].Value = File.Exists(callFileName);
                //item.Cells[4].Value = File.Exists(emgFileName);
                //
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
