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

        private ColumnHeader ref_shere_filename;
        private ColumnHeader ref_shere_comment;
        private ColumnHeader ref_shere_language;
        private ColumnHeader ref_shere_username;
        private ColumnHeader ref_shere_date;

        // 初期化
        private void Initialize_ref_share_list()
        {
            // プロパティを設定
            ref_share_list.FullRowSelect = true;
            ref_share_list.GridLines = true;
            ref_share_list.Sorting = SortOrder.Ascending;
            ref_share_list.View = View.Details;

            // 列（コラム）ヘッダの作成
            ref_shere_filename = new ColumnHeader();
            ref_shere_comment = new ColumnHeader();
            ref_shere_language = new ColumnHeader();
            ref_shere_username = new ColumnHeader();
            ref_shere_date = new ColumnHeader();
            ref_shere_filename.Text = "ファイル名";
            ref_shere_filename.Width = 100;
            ref_shere_comment.Text = "コメント";
            ref_shere_comment.Width = 200;
            ref_shere_language.Text = "使用言語";
            ref_shere_language.Width = 150;
            ref_shere_username.Text = "作成者";
            ref_shere_username.Width = 150;
            ref_shere_date.Text = "作成日時";
            ref_shere_date.Width = 150;
            ColumnHeader[] colHeaderRegValue =
              { this.ref_shere_filename, this.ref_shere_comment, this.ref_shere_language, this.ref_shere_username, this.ref_shere_date};
            ref_share_list.Columns.AddRange(colHeaderRegValue);
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