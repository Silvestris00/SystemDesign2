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

        private ColumnHeader question_fileName;
        private ColumnHeader question_comment;
        private ColumnHeader question_language;
        private ColumnHeader question_username;
        private ColumnHeader question_date;

        // 初期化
        private void Initialize_question_list()
        {
            // プロパティを設定
            question_list.FullRowSelect = true;
            question_list.GridLines = true;
            question_list.Sorting = SortOrder.Ascending;
            question_list.View = View.Details;

            // 列（コラム）ヘッダの作成
            question_fileName = new ColumnHeader();
            question_comment = new ColumnHeader();
            question_language = new ColumnHeader();
            question_username = new ColumnHeader();
            question_date = new ColumnHeader();
            question_fileName.Text = "ファイル名";
            question_fileName.Width = 100;
            question_comment.Text = "コメント";
            question_comment.Width = 200;
            question_language.Text = "使用言語";
            question_language.Width = 150;
            question_username.Text = "作成者";
            question_username.Width = 150;
            question_date.Text = "作成日時";
            question_date.Width = 150;
            ColumnHeader[] questionRegValue =
              { this.question_fileName, this.question_comment, this.question_language, this.question_username, this.question_date};
            question_list.Columns.AddRange(questionRegValue);
        }

        private void Question_create_Click(object sender, EventArgs e)
        {
            this.MainTab.TabPages.Add(create_Question);
            this.MainTab.SelectTab(create_Question);
        }

        private void create_question_cancel_Click(object sender, EventArgs e)
        {
            this.MainTab.TabPages.Remove(create_Question);
        }
    }
}
