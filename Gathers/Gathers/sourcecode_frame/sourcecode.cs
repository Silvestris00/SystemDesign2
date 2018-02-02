using System;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace Gathers
{
    public partial class MainFrame : Form
    {
        private String fileName;
        static private String master = Application.StartupPath+ "/repos/gathers_data";
        static private String databaseFilePath = master + "/database/database/Gathers.db";
        private String directoryplace = master+"/sourcecode/sourcecode";
        private System.Diagnostics.Process pro = new System.Diagnostics.Process();
        SQLiteConnection con = new SQLiteConnection("Data Source=" + databaseFilePath);
        DataTable dataTable = new DataTable();

        // 初期化
        private void Initialize_sourcecode_list()
        {
            //プロセス制御の設定
            pro.StartInfo.FileName = @"C:/Program Files/Git/git-cmd.exe";
            //出力を読み取れるようにする
            pro.StartInfo.UseShellExecute = false;
            //pro.StartInfo.RedirectStandardOutput = true;
            //pro.StartInfo.RedirectStandardInput = false;
            //ウィンドウを表示しないようにする
            pro.StartInfo.CreateNoWindow = false;
        }

        private void soucecode_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 閲覧ボタン列かどうかを確認
            if (e.ColumnIndex == this.soucecode_datalist.Columns["showbtn"].Index)
            {
                MessageBox.Show("動作確認!");
            }
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

        private void cloneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String[] gitclonecommand = { @" cd " + master + "&& git clone gathers@192.168.11.2:/home/gathers/test.git",
                                         @" cd " + master + "&& rename test database",
                                         @" cd " + master + "/database && git checkout -b database origin/database",
                                         @" cd " + master + "&& git clone gathers@192.168.11.2:/home/gathers/test.git",
                                         @" cd " + master + "&& rename test sourcecode",
                                         @" cd " + master + "/sourcecode && git checkout -b sourcecode origin/sourcecode"};
            run_cmd(gitclonecommand);
            load_database();
        }

        private void pull_sourcecode_Click(object sender, EventArgs e)
        {
            String[] gitpullcommand = { @" cd " + master + "/database && git pull ",
                                        @" cd " + master + "/sourcecode && git pull "};
            run_cmd(gitpullcommand);
            load_database();
        }

        private void load_database()
        {
            this.dataTable.Clear();
            SQLiteDataAdapter readadapter = new SQLiteDataAdapter("SELECT * FROM SOURCE;", con);
            readadapter.Fill(dataTable);
            soucecode_datalist.DataSource = dataTable;
        }

        private void add_file_Click(object sender, EventArgs e)
        {
            //ファイル参照ダイアログを開く
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                set_file.Text = openFileDialog1.FileName.Replace("\\", "/");
                fileName = Path.GetFileName(set_file.Text);
            }
        }

        private void save_sourcecode_Click(object sender, EventArgs e)
        {
            String sourcecodeGenre = genre.Text;
            String userid = "guest";
            String hash = hashGenerate();
            if (sourcecodeGenre!="") {
                directoryplace += "/"+ sourcecodeGenre + "/" + DateTime.Now.ToString("yyyy_MM") + "/" + hash;
                if (!Directory.Exists(directoryplace))
                {
                    Directory.CreateDirectory(directoryplace);
                }
                copy();
                if (fileName != null)
                {
                    make_info();
                    run_cmd(@" cd " + master + "/database && git pull ");
                    using (SQLiteCommand cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "INSERT into SOURCE values('" + hash + "','" + fileName + "','" + sourcecodeGenre + "','" + userid + "'," + DateTime.Now.ToString("yyyyMM") + ");";
                        cmd.ExecuteNonQuery();
                    }
                    String[] gitpushcommand = { @" cd " + master + "/sourcecode && git add . ",
                                                @" cd " + master + "/sourcecode && git commit -m " + hash,
                                                @" cd " + master + "/sourcecode && git push origin sourcecode",
                                                @" cd " + master + "/database && git add . ",
                                                @" cd " + master + "/database && git commit -m " + hash,
                                                @" cd " + master + "/database && git push origin database"};
                    run_cmd(gitpushcommand);
                    load_database();
                    this.MainTab.TabPages.Remove(create_share_sourcecodeTab);
                    this.MainTab.SelectTab(SourceCode);
                }
                else
                {
                    MessageBox.Show("ソースコードが添付されていません!");
                }
            }
            else
            {
                MessageBox.Show("ジャンルが指定されていません!");
            }
        }

        private void run_cmd(String [] command)
        {
            //String results;
            for (int i = 0; i < command.Length; i++)
            {
                pro.StartInfo.Arguments = command[i];
                pro.Start();
                //results = pro.StandardOutput.ReadToEnd();
                pro.WaitForExit();
                pro.Close();
                //Console.WriteLine(results);
                System.Threading.Thread.Sleep(1000);
            }
        }

        private void run_cmd(String command)
        {
            //String results;
            pro.StartInfo.Arguments = command;
            pro.Start();
            //results = pro.StandardOutput.ReadToEnd();
            pro.WaitForExit();
            pro.Close();
            //Console.WriteLine(results);
            System.Threading.Thread.Sleep(1000);
        }

        private void copy()
        {
            try
            {
                string targetpath = directoryplace + "/" + fileName;
                File.Copy(set_file.Text, targetpath);
            }
            catch (Exception IOException)
            {
                MessageBox.Show(IOException.ToString());
            }
        }

        private void make_info()
        {
            StreamWriter sw = File.CreateText(directoryplace + "/info.txt");
            sw.Write(sourcecode_readme.Text);
            sw.Close();
        }

        private String hashGenerate()
        {
            //ファイルを開く
            System.IO.FileStream fs = new System.IO.FileStream(
                set_file.Text, System.IO.FileMode.Open, System.IO.FileAccess.Read);

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
