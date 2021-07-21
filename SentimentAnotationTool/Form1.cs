using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SentimentAnotationTool
{
    public partial class Form1 : Form
    {
        string FilePath = "";
        List<List<string>> SentenceList = new List<List<string>>();
        int SentenceNum = 0;
        public Form1()
        {
            InitializeComponent();

            BackSentence.Enabled = false;
            NegativeButton.Enabled = false;
            NeutralButton.Enabled = false;
            PositiveButton.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.FileName = "*.csv";
            ofd.InitialDirectory = @"C:\";
            ofd.Filter = "CSVファイル(*.csv)|*.*";
            ofd.FilterIndex = 2;
            //タイトルを設定する
            ofd.Title = "ファイルを選択してください";
            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            ofd.RestoreDirectory = true;

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                SentenceNum = 0;
                SentenceList.Clear();
                FilePath = ofd.FileName;
                CurrentFilePath.Text = FilePath;
                SentenceList = OpenCsv(FilePath);
                AllFilesNum.Text = ((SentenceList.Count)-1).ToString();
                NextSentence();

                BackSentence.Enabled = true;
                NegativeButton.Enabled = true;
                NeutralButton.Enabled = true;
                PositiveButton.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }
    
        private void NextSentence()
        {
            if(SentenceNum > (SentenceList.Count) - 1)
            {
                MessageBox.Show("All annotations have been completed.", "Complete");
                this.Close();
                return;
            }
            NowSentence.Text = SentenceList[SentenceNum][0];
            NowLabel.Text = "Label [" + SentenceList[SentenceNum][1] + "]";
            CurrentFileNum.Text = (SentenceNum).ToString();
        }

        private void JudgeSentiment(int label)
        {
            if(label == 0)
            {
                PrevLabel.Text = "Negative[0]";
            }
            else if(label == 1)
            {
                PrevLabel.Text = "Neutral[1]";
            }
            else
            {
                PrevLabel.Text = "Positive[2]";
            }
        }
        private List<List<string>> OpenCsv(string Path)
        {
            //読み込むcsvファイルのパスを指定して開く
            using (StreamReader sr = new StreamReader(Path, Encoding.GetEncoding("shift_jis")))
            {
                int i = 0;
                while (!sr.EndOfStream)
                {
                    //1行づつ読み取る。カンマも読み取っている。
                    string line = sr.ReadLine();
                    //カンマで区切った文の塊を格納する
                    SentenceList.Add(new List<string>());
                    SentenceList[i].Add(line.Split(',')[0]);
                    SentenceList[i].Add(line.Split(',')[1]);
                    i++;
                }
            }
            return SentenceList;
        }

        private void SaveCsv()
        {
            // CSVにListの内容を保存
            FileStream fs = new FileStream(FilePath, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("shift_jis"));
            for (int i = 0; i < SentenceList.Count; i++)
            {
                sw.WriteLine(SentenceList[i][0] + "," + SentenceList[i][1]);
            }
            sw.Close();
        }

        private void NegativeButton_Click(object sender, EventArgs e)
        {
            SentenceList[SentenceNum][1] = "0";
            SaveCsv();
            SentenceNum++;
            NextSentence();
            JudgeSentiment(0);
        }

        private void NeutralButton_Click(object sender, EventArgs e)
        {
            SentenceList[SentenceNum][1] = "1";
            SaveCsv();
            SentenceNum++;
            NextSentence();
            JudgeSentiment(1);
        }

        private void PositiveButton_Click(object sender, EventArgs e)
        {
            SentenceList[SentenceNum][1] = "2";
            SaveCsv();
            SentenceNum++;
            NextSentence();
            JudgeSentiment(2);
        }

        private void BackSentence_Click(object sender, EventArgs e)
        {
            SaveCsv();
            SentenceNum--;
            if(SentenceNum < 0)
            {
                SentenceNum = 0;
            }
            NextSentence();
        }

        private void CurrentFileNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                //押されたキーが 0～9でない場合は、イベントをキャンセルする
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveCsv();
            SentenceNum = int.Parse(CurrentFileNum.Text);
            NextSentence();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SentenceList[SentenceNum][1] = "99";
            SaveCsv();
            SentenceNum++;
            NextSentence();
        }
    }
}
