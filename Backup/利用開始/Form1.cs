using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 利用開始
{
    public partial class Form1 : Form
    {
        string stp ="kwyny";
      
        private System.Diagnostics.Process 利用 = new System.Diagnostics.Process();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                利用.StartInfo.FileName = "C:\\Program Files (x86)\\StationTV X - コピー (2) - コピー.lnk";
                利用.StartInfo.WorkingDirectory = "C:\\Program Files (x86)\\";
                利用.Start();
                //Myexe.WaitForExit();
            }
            catch
            {
                MessageBox.Show("エラーが発生しました。プログラムを開けません。");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                利用.StartInfo.FileName = ".\\lis audio player t.exe";
                利用.StartInfo.WorkingDirectory = ".\\lis\\";
                利用.Start();
                //Myexe.WaitForExit();
            }
            catch
            {
                MessageBox.Show("エラーが発生しました。プログラムを開けません。");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                利用.StartInfo.FileName = ".\\ドキュメント作成2019.exe";
                利用.StartInfo.WorkingDirectory = ".\\D2019\\";
                利用.Start();
                //Myexe.WaitForExit();
            }
            catch
            {
                MessageBox.Show("エラーが発生しました。プログラムを開けません。");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                利用.StartInfo.FileName = ".\\写真取り込み.exe";
                利用.StartInfo.WorkingDirectory = ".\\\\";
                利用.Start();
                //Myexe.WaitForExit();
            }
            catch
            {
                MessageBox.Show("エラーが発生しました。プログラムを開けません。");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                利用.StartInfo.FileName = "C:\\Program Files (x86)\\Sony\\Music Center\\MusicCenter.exe";
                利用.StartInfo.WorkingDirectory = "C:\\Program Files (x86)\\Sony\\Music Center\\";
                利用.Start();
                //Myexe.WaitForExit();
            }
            catch
            {
                MessageBox.Show("エラーが発生しました。プログラムを開けません。");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                利用.StartInfo.FileName = ".\\Picsh.exe";
                利用.StartInfo.WorkingDirectory = ".\\Picsh\\";
                利用.Start();
                //Myexe.WaitForExit();
            }
            catch
            {
                MessageBox.Show("エラーが発生しました。プログラムを開けません。");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("このソフトウェアは他のプログラムがないと作動できないプログラムです。");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                利用.StartInfo.FileName = ".\\アラームメッセージv3.exe";
                利用.StartInfo.WorkingDirectory = ".\\アラームメッセージ\\";
                利用.Start();
                //Myexe.WaitForExit();
            }
            catch
            {
                MessageBox.Show("エラーが発生しました。プログラムを開けません。");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                利用.StartInfo.FileName = ".\\毎日日記1.exe";
                利用.StartInfo.WorkingDirectory = ".\\NK\\";
                利用.Start();
                //Myexe.WaitForExit();
            }
            catch
            {
                MessageBox.Show("エラーが発生しました。プログラムを開けません。");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                利用.StartInfo.FileName = "C:\\Program Files (x86)\\Microsoft Edge.lnk";
                利用.StartInfo.WorkingDirectory = "C:\\Program Files (x86)\\";
                利用.Start();
                //Myexe.WaitForExit();
            }
            catch
            {
                MessageBox.Show("エラーが発生しました。プログラムを開けません。");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                利用.StartInfo.FileName = "C:\\Program Files (x86)\\Anvsoft\\Any Video Converter\\AVCFree.exe";
            
                利用.StartInfo.WorkingDirectory = "C:\\Program Files (x86)\\Anvsoft\\Any Video Converter\\";
                利用.Start();
                //Myexe.WaitForExit();
            }
            catch
            {
                MessageBox.Show("エラーが発生しました。プログラムを開けません。");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                利用.StartInfo.FileName = "C:\\Users\\askke\\Desktop\\Fast Lock.exe";

                利用.StartInfo.WorkingDirectory = "C:\\Users\\askke\\Desktop\\";
                利用.Start();
                //Myexe.WaitForExit();
            }
            catch
            {
                MessageBox.Show("エラーが発生しました。プログラムを開けません。");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (stp == textBox1.Text)
            {
                try
                {
                    利用.StartInfo.FileName = "C:\\Program Files (x86)\\StationTV X - コピー (2) - コピー.lnk";
                    利用.StartInfo.WorkingDirectory = "C:\\Program Files (x86)\\";
                    利用.Start();
                    //Myexe.WaitForExit();
                }
                catch
                {
                    MessageBox.Show("エラーが発生しました。プログラムを開けません。");
                }
            }
            else
            {
                MessageBox.Show("パスワードが一致しませんでした。入力された文字列をもう一度ご確認ください。");
            }
        }
    }
}

