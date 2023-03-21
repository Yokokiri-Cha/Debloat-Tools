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
        string stp ="";
      
        private System.Diagnostics.Process 利用 = new System.Diagnostics.Process();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                利用.StartInfo.FileName = "C:\\Program Files (x86)\\S.lnk";
                利用.StartInfo.WorkingDirectory = "C:\\Program Files (x86)\\";
                利用.Start();
                //unused
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
                //unused
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
                //unused
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
                //unused
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
                利用.StartInfo.FileName = ".\\dappsfull.bat";
                利用.StartInfo.WorkingDirectory = ".\\\\";
                利用.Start();
                //dapps full
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
                //Unused
            }
            catch
            {
                MessageBox.Show("エラーが発生しました。プログラムを開けません。");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("このソフトウェアは他のプログラムがないと作動できないプログラムです。");
            //unused message hokano project nimo tsukatte ita kara ...
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                利用.StartInfo.FileName = ".\\アラームメッセージv3.exe";
                利用.StartInfo.WorkingDirectory = ".\\アラームメッセージ\\";
                利用.Start();
                //unused
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
                //unused
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
                利用.StartInfo.FileName = ".\\auall.bat";
                利用.StartInfo.WorkingDirectory = ".\\\\";
                利用.Start();
                //auall
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
                利用.StartInfo.FileName = ".\\sofall.bat";
            
                利用.StartInfo.WorkingDirectory = ".\\\\";
                利用.Start();
                //sofall
            }
            catch
            {
                MessageBox.Show("エラーが発生しました。プログラムを開けません。");
            }
        }

   

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //simple message
            MessageBox.Show("このソフトウェアは、ADBを使用して、携帯電話キャリアのプリインストールアプリ(ブロートウェア)を無効化します。キャリア製のアプリを無効化すると、端末動作が不安定になったり、 キャリアのサポートが受けられなくなる恐れがありますので、使用する際は 自己責任でお願い致します。 製作者は一切の責任を負いかねます。 このソフトウェアの機能を利用することでこの注意事項に同意したものとみなします。 横茶横葉");
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            try
            {
                利用.StartInfo.FileName = ".\\dall.bat";

                利用.StartInfo.WorkingDirectory = ".\\\\";
                利用.Start();
                
            }
            catch
            {
                MessageBox.Show("エラーが発生しました。プログラムを開けません。");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                利用.StartInfo.FileName = ".\\dareamail.bat";

                利用.StartInfo.WorkingDirectory = ".\\\\";
                利用.Start();

            }
            catch
            {
                MessageBox.Show("エラーが発生しました。プログラムを開けません。");
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                利用.StartInfo.FileName = ".\\dota.bat";

                利用.StartInfo.WorkingDirectory = ".\\\\";
                利用.Start();

            }
            catch
            {
                MessageBox.Show("エラーが発生しました。プログラムを開けません。");
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            try
            {
                利用.StartInfo.FileName = ".\\dtp.bat";

                利用.StartInfo.WorkingDirectory = ".\\\\";
                利用.Start();

            }
            catch
            {
                MessageBox.Show("エラーが発生しました。プログラムを開けません。");
            }
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            try
            {
                利用.StartInfo.FileName = ".\\auena.bat";

                利用.StartInfo.WorkingDirectory = ".\\\\";
                利用.Start();

            }
            catch
            {
                MessageBox.Show("エラーが発生しました。プログラムを開けません。");
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            try
            {
                利用.StartInfo.FileName = ".\\sofena.bat";

                利用.StartInfo.WorkingDirectory = ".\\\\";
                利用.Start();

            }
            catch
            {
                MessageBox.Show("エラーが発生しました。プログラムを開けません。");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ステップ1 USBケーブルを用いて携帯電話を接続しているかを確認して下さい。");
            MessageBox.Show("ステップ2 USBデバッグモードがAndroidの開発者向けオプションにて有効化されているか確認して下さい。");
            MessageBox.Show("ステップ3 この後の画面で、デバイスがリストに表示されていればADB,携帯電話の準備は完了です。ADBが存在しない場合,デバイスが正しく接続されていない場合は表示されません。");
            try
            {
                利用.StartInfo.FileName = ".\\adbchk.bat";

                利用.StartInfo.WorkingDirectory = ".\\\\";
                利用.Start();

            }
            catch
            {
                MessageBox.Show("エラーが発生しました。プログラムを開けません。");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                利用.StartInfo.FileName = ".\\dena.bat";

                利用.StartInfo.WorkingDirectory = ".\\\\";
                利用.Start();

            }
            catch
            {
                MessageBox.Show("エラーが発生しました。プログラムを開けません。");
            }
        }
    }
}

