using System;
using System.IO;
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
        private String sourcefile;
        private String fileName;
        private String directoryplace = "./repos/test/";
        private String sha;
        System.Diagnostics.Process pro = new System.Diagnostics.Process();


        // 初期化
        private void Initialize_sourcecode_list()
        {
            //プロセス制御の設定
            pro.StartInfo.FileName = @"C:/Program Files (x86)/Git/git-cmd.exe";
            pro.StartInfo.RedirectStandardOutput = true;
            pro.StartInfo.RedirectStandardInput = false;
            pro.StartInfo.CreateNoWindow = true;
            pro.StartInfo.UseShellExecute = false;

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
                set_file.Text = openFileDialog1.FileName.Replace("\\", "/");
                fileName = Path.GetFileName(set_file.Text);
                sourcefile = set_file.Text;
                sha = hashGenerate();
                if (!Directory.Exists(directoryplace + "/" + sha))
                {
                    Directory.CreateDirectory(directoryplace + "/" + sha);
                }
                copy();
            }
        }

        private void save_sourcecode_Click(object sender, EventArgs e)
        {
            String results;
            String commitcomment = "test";
            String[] gitcommand= { @"/c cd ./repos/test && git add . ", @"/c cd ./repos/test && git commit -m " + commitcomment, @"/c cd ./repos/test && git push " };
            if (sourcefile!=null) {
                make_info();
                for (int i = 0; i < gitcommand.Length; i++)
                {
                    pro.StartInfo.Arguments = gitcommand[i];
                    pro.Start();
                    results = pro.StandardOutput.ReadToEnd();
                    pro.WaitForExit();
                    pro.Close();
                    MessageBox.Show(results);
                    System.Threading.Thread.Sleep(1000);
                }
                this.MainTab.TabPages.Remove(create_share_sourcecodeTab);
                this.MainTab.SelectTab(MainPage);
            }
            else
            {
                MessageBox.Show("ソースコードが添付されていません!");
            }
        }

        private void copy()
        {
            try
            {
                string targetpath = directoryplace + "/" + sha + "/" + fileName;
                File.Copy(sourcefile, targetpath);
            }
            catch (Exception IOException)
            {
                MessageBox.Show(IOException.ToString());
            }
        }

        private void make_info()
        {
            StreamWriter sw = File.CreateText(directoryplace + "/" + sha + "/info.txt");
            sw.Write(sourcecode_readme.Text);
            sw.Close();
        }

        private String hashGenerate()
        {
            //ファイルを開く
            System.IO.FileStream fs = new System.IO.FileStream(
                sourcefile, System.IO.FileMode.Open, System.IO.FileAccess.Read);

            //SHA1CryptoServiceProviderオブジェクトを作成
            System.Security.Cryptography.SHA1CryptoServiceProvider sha1 =
                new System.Security.Cryptography.SHA1CryptoServiceProvider();

            //ハッシュ値を計算する
            byte[] bs = sha1.ComputeHash(fs);

            //リソースを解放する
            sha1.Clear();
            //ファイルを閉じる
            fs.Close();

            //byte型配列を16進数の文字列に変換
            string result = BitConverter.ToString(bs).ToLower().Replace("-", "");

            //結果を表示
            return result;
        }

        /// 指定したパスにディレクトリが存在しない場合
        /// すべてのディレクトリとサブディレクトリを作成します

        /*
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
        */
    }
}
