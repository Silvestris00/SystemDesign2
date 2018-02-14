using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gathers
{
    public partial class MainFrame : Form
    {
        private String ref_directoryplace = master + "/reference/reference";
        DataTable ref_dataTable = new DataTable();
        String ref_hash;


        private void Initialize_ref_list()
        {
            ref_load_database();
        }

        private void ref_load_database()
        {
            if (System.IO.File.Exists(databaseFilePath))
            {
                this.ref_dataTable.Clear();
                for (int idx = this.ref_data.Rows.Count - 1; idx >= 0; idx--)
                {
                    this.ref_data.Rows.RemoveAt(idx);
                }
                SQLiteDataAdapter ref_readadapter = new SQLiteDataAdapter("SELECT * FROM REFERENCE;", con);
                ref_readadapter.Fill(ref_dataTable);
                ref_data.DataSource = ref_dataTable;
            }
        }

        private String ref_hashGenerate()
        {
            //ファイルを開く
            System.IO.FileStream fs = new System.IO.FileStream(
                ref_directoryplace + "/temp/" + ref_title_box.Text + ".txt", System.IO.FileMode.Open, System.IO.FileAccess.Read);

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

        private void ref_move()
        {
            try
            {
                string targetpath =master+ "/reference/reference/temp/" + ref_title_box.Text + ".txt";
                File.Move(targetpath, ref_directoryplace+ "/" + ref_title_box.Text + ".txt");
            }
            catch (Exception IOException)
            {
                MessageBox.Show(IOException.ToString());
            }
        }

        private void ref_upload_btn_Click(object sender, EventArgs e)
        {
            String ref_Genre = ref_genre.Text;
            String userid = "guest";
            if (ref_Genre != "" || ref_title_box.Text != "" || ref_body_box.Text != "")
            {
                ref_make_info();
                ref_hash = ref_hashGenerate();
                ref_directoryplace += "/" + ref_Genre + "/" + DateTime.Now.ToString("yyyy_MM") + "/" + ref_hash;
                if (!Directory.Exists(ref_directoryplace))
                {
                    Directory.CreateDirectory(ref_directoryplace);
                    ref_move();
                    run_cmd(@" cd " + master + "/database && git pull && exit ");
                    using (SQLiteCommand cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "INSERT into REFERENCE values('" + ref_hash + "','" + ref_title_box.Text + "','" + ref_Genre + "','" + userid + "'," + DateTime.Now.ToString("yyyyMM") + ");";
                        cmd.ExecuteNonQuery();
                    }
                    String[] gitpushcommand = { @" cd " + master + "/reference && git add . && exit ",
                                                @" cd " + master + "/reference && git commit -m " + ref_hash + " && exit ",
                                                @" cd " + master + "/reference && git push origin reference && exit ",
                                                @" cd " + master + "/database && git add . && exit ",
                                                @" cd " + master + "/database && git commit -m " +ref_hash + " && exit ",
                                                @" cd " + master + "/database && git push origin database && exit "};
                    run_cmd(gitpushcommand);
                    ref_load_database();
                    ref_body_box.Text = "";
                    ref_genre.Text = "";
                    ref_title_box.Text = "";
                    ref_directoryplace = master + "/reference/reference";
                    this.MainTab.TabPages.Remove(create_share_sourcecodeTab);
                    this.MainTab.SelectTab(MainPage);
                }else
                {
                    MessageBox.Show("このリファレンスはすでに登録されています。");
                }
            }
            else
            {
                MessageBox.Show("必要箇所が記入されていません!");
            }
        }

        private void ref_make_info()
        {
            StreamWriter sw = File.CreateText(ref_directoryplace + "/temp/"+ref_title_box.Text+".txt");
            sw.Write(ref_body_box.Text);
            sw.Close();
        }

        private void create_new_ref_Click(object sender, EventArgs e)
        {
            this.MainTab.TabPages.Add(reference_create);
            this.MainTab.SelectTab(reference_create);
        }

        private void ref_cancel_btn_Click(object sender, EventArgs e)
        {
            this.MainTab.TabPages.Remove(reference_create);
            this.MainTab.SelectTab(reference);
        }

    }
}