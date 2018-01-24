using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gathers
{
    public partial class MainFrame : Form
    {

        private ColumnHeader sourcecode_fileName;
        private ColumnHeader sourcecode_comment;
        private ColumnHeader sourcecode_language;
        private ColumnHeader sourcecode_username;
        private ColumnHeader sourcecode_date;

        // 初期化
        private void Initialize_sourcecode_list()
        {
            // プロパティを設定
            sourcecode_list.FullRowSelect = true;
            sourcecode_list.GridLines = true;
            sourcecode_list.Sorting = SortOrder.Ascending;
            sourcecode_list.View = View.Details;

            // 列（コラム）ヘッダの作成
            sourcecode_fileName = new ColumnHeader();
            sourcecode_comment = new ColumnHeader();
            sourcecode_language = new ColumnHeader();
            sourcecode_username = new ColumnHeader();
            sourcecode_date = new ColumnHeader();
            sourcecode_fileName.Text = "ファイル名";
            sourcecode_fileName.Width = 100;
            sourcecode_comment.Text = "コメント";
            sourcecode_comment.Width = 200;
            sourcecode_language.Text = "使用言語";
            sourcecode_language.Width = 150;
            sourcecode_username.Text = "作成者";
            sourcecode_username.Width = 150;
            sourcecode_date.Text = "作成日時";
            sourcecode_date.Width = 150;
            ColumnHeader[] sourcecodeRegValue =
              { this.sourcecode_fileName, this.sourcecode_comment, this.sourcecode_language, this.sourcecode_username, this.sourcecode_date};
            sourcecode_list.Columns.AddRange(sourcecodeRegValue);
        }

        private void create_share_sourcecode_Click(object sender, EventArgs e)
        {
            this.MainTab.TabPages.Add(create_share_sourcecodeTab);
            this.MainTab.SelectTab(create_share_sourcecodeTab);
        }

        private void cancel_share_sourcecode_Click(object sender, EventArgs e)
        {
            this.MainTab.TabPages.Remove(create_share_sourcecodeTab);
        }

        private void add_file_Click(object sender, EventArgs e)
        {
            //ファイル参照ダイアログを開く
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                set_file.Text += openFileDialog1.FileName;
                System.Diagnostics.Process pro = new System.Diagnostics.Process();

                pro.StartInfo.FileName = "ipconfig";            // コマンド名
                pro.StartInfo.Arguments = "/all";               // 引数
                pro.StartInfo.UseShellExecute = false;          // プロセスを新しいウィンドウで起動するか否か
                pro.StartInfo.RedirectStandardOutput = true;    // 標準出力をリダイレクトして取得したい

                pro.Start();

                string output = pro.StandardOutput.ReadToEnd();
                output.Replace("\r\r\n", "\n"); // 改行コード変換

                MessageBox.Show(output);
            }
        }

        private void FileSource_DragEnter(object sender, DragEventArgs e)
        {
            //ファイルがドラッグされている場合、カーソルを変更する
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void FileSource_DragDrop(object sender, DragEventArgs e)
        {
            //ドロップされたファイルの一覧を取得
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (fileName.Length <= 0)
            {
                return;
            }
            //labelの内容をファイル名に変更
            set_file.Text += fileName[0];
        }
    }
}
