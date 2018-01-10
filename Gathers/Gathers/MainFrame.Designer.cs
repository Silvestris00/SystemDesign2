namespace Gathers
{
    partial class MainFrame
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.SourceCode = new System.Windows.Forms.TabPage();
            this.MainPage = new System.Windows.Forms.TabPage();
            this.Add_CorrectionEditor = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.reference = new System.Windows.Forms.TabPage();
            this.create_new_ref = new System.Windows.Forms.Button();
            this.search_box = new System.Windows.Forms.TextBox();
            this.create_own_ref = new System.Windows.Forms.CheckBox();
            this.ref_share_list = new System.Windows.Forms.ListView();
            this.ref_share_label = new System.Windows.Forms.Label();
            this.Question = new System.Windows.Forms.TabPage();
            this.Question_search = new System.Windows.Forms.TextBox();
            this.Question_own_check = new System.Windows.Forms.CheckBox();
            this.Question_create = new System.Windows.Forms.Button();
            this.question_list = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.CorrectionEditor = new System.Windows.Forms.TabPage();
            this.Remove_CorrectionEditor = new System.Windows.Forms.Button();
            this.reference_create = new System.Windows.Forms.TabPage();
            this.ref_inf_gbox = new System.Windows.Forms.GroupBox();
            this.ref_genre_label = new System.Windows.Forms.Label();
            this.ref_title_label = new System.Windows.Forms.Label();
            this.ref_title_box = new System.Windows.Forms.TextBox();
            this.ref_cancel_btn = new System.Windows.Forms.Button();
            this.ref_upload_btn = new System.Windows.Forms.Button();
            this.ref_save_btn = new System.Windows.Forms.Button();
            this.ref_new_label = new System.Windows.Forms.Label();
            this.ref_body_box = new System.Windows.Forms.TextBox();
            this.create_Question = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.create_question_cancel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.mainnotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.reference.SuspendLayout();
            this.Question.SuspendLayout();
            this.CorrectionEditor.SuspendLayout();
            this.reference_create.SuspendLayout();
            this.ref_inf_gbox.SuspendLayout();
            this.create_Question.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SourceCode
            // 
            this.SourceCode.BackColor = System.Drawing.Color.White;
            this.SourceCode.Location = new System.Drawing.Point(4, 22);
            this.SourceCode.Name = "SourceCode";
            this.SourceCode.Padding = new System.Windows.Forms.Padding(3);
            this.SourceCode.Size = new System.Drawing.Size(858, 536);
            this.SourceCode.TabIndex = 0;
            this.SourceCode.Text = "ソースコード共有";
            // 
            // MainPage
            // 
            this.MainPage.BackColor = System.Drawing.Color.White;
            this.MainPage.Controls.Add(this.Add_CorrectionEditor);
            this.MainPage.Controls.Add(this.tableLayoutPanel1);
            this.MainPage.Location = new System.Drawing.Point(4, 22);
            this.MainPage.Name = "MainPage";
            this.MainPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainPage.Size = new System.Drawing.Size(858, 536);
            this.MainPage.TabIndex = 5;
            this.MainPage.Text = "メインページ";
            // 
            // Add_CorrectionEditor
            // 
            this.Add_CorrectionEditor.Location = new System.Drawing.Point(40, 205);
            this.Add_CorrectionEditor.Name = "Add_CorrectionEditor";
            this.Add_CorrectionEditor.Size = new System.Drawing.Size(120, 23);
            this.Add_CorrectionEditor.TabIndex = 1;
            this.Add_CorrectionEditor.Text = "添削エディタ起動";
            this.Add_CorrectionEditor.UseVisualStyleBackColor = true;
            this.Add_CorrectionEditor.Click += new System.EventHandler(this.Add_CorrectionEditor_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.46358F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.56954F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.25444F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(845, 177);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(839, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gathersへようこそ!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(839, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "通知";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(3, 83);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(839, 88);
            this.listBox1.TabIndex = 1;
            // 
            // MainTab
            // 
            this.MainTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTab.Controls.Add(this.MainPage);
            this.MainTab.Controls.Add(this.SourceCode);
            this.MainTab.Controls.Add(this.reference);
            this.MainTab.Controls.Add(this.Question);
            this.MainTab.Controls.Add(this.CorrectionEditor);
            this.MainTab.Controls.Add(this.reference_create);
            this.MainTab.Controls.Add(this.create_Question);
            this.MainTab.Location = new System.Drawing.Point(1, 28);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(866, 562);
            this.MainTab.TabIndex = 0;
            // 
            // reference
            // 
            this.reference.Controls.Add(this.create_new_ref);
            this.reference.Controls.Add(this.search_box);
            this.reference.Controls.Add(this.create_own_ref);
            this.reference.Controls.Add(this.ref_share_list);
            this.reference.Controls.Add(this.ref_share_label);
            this.reference.Location = new System.Drawing.Point(4, 22);
            this.reference.Name = "reference";
            this.reference.Padding = new System.Windows.Forms.Padding(3);
            this.reference.Size = new System.Drawing.Size(858, 536);
            this.reference.TabIndex = 8;
            this.reference.Text = "リファレンス共有";
            this.reference.UseVisualStyleBackColor = true;
            // 
            // create_new_ref
            // 
            this.create_new_ref.Location = new System.Drawing.Point(198, 34);
            this.create_new_ref.Name = "create_new_ref";
            this.create_new_ref.Size = new System.Drawing.Size(96, 30);
            this.create_new_ref.TabIndex = 6;
            this.create_new_ref.Text = "新規作成";
            this.create_new_ref.UseVisualStyleBackColor = true;
            this.create_new_ref.Click += new System.EventHandler(this.create_new_ref_Click);
            // 
            // search_box
            // 
            this.search_box.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.search_box.Location = new System.Drawing.Point(522, 36);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(228, 19);
            this.search_box.TabIndex = 5;
            this.search_box.Text = "リファレンスを検索する";
            // 
            // create_own_ref
            // 
            this.create_own_ref.AutoSize = true;
            this.create_own_ref.Location = new System.Drawing.Point(311, 40);
            this.create_own_ref.Name = "create_own_ref";
            this.create_own_ref.Size = new System.Drawing.Size(203, 16);
            this.create_own_ref.TabIndex = 4;
            this.create_own_ref.Text = "自分で作成したリファレンスのみを表示";
            this.create_own_ref.UseVisualStyleBackColor = true;
            // 
            // ref_share_list
            // 
            this.ref_share_list.Location = new System.Drawing.Point(21, 74);
            this.ref_share_list.Name = "ref_share_list";
            this.ref_share_list.Size = new System.Drawing.Size(729, 408);
            this.ref_share_list.TabIndex = 2;
            this.ref_share_list.UseCompatibleStateImageBehavior = false;
            // 
            // ref_share_label
            // 
            this.ref_share_label.AutoSize = true;
            this.ref_share_label.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ref_share_label.Location = new System.Drawing.Point(18, 40);
            this.ref_share_label.Name = "ref_share_label";
            this.ref_share_label.Size = new System.Drawing.Size(167, 16);
            this.ref_share_label.TabIndex = 1;
            this.ref_share_label.Text = "共有しているリファレンス";
            // 
            // Question
            // 
            this.Question.Controls.Add(this.Question_search);
            this.Question.Controls.Add(this.Question_own_check);
            this.Question.Controls.Add(this.Question_create);
            this.Question.Controls.Add(this.question_list);
            this.Question.Controls.Add(this.label3);
            this.Question.Location = new System.Drawing.Point(4, 22);
            this.Question.Name = "Question";
            this.Question.Padding = new System.Windows.Forms.Padding(3);
            this.Question.Size = new System.Drawing.Size(858, 536);
            this.Question.TabIndex = 9;
            this.Question.Text = "問題作成・公開";
            this.Question.UseVisualStyleBackColor = true;
            // 
            // Question_search
            // 
            this.Question_search.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.Question_search.Location = new System.Drawing.Point(522, 36);
            this.Question_search.Name = "Question_search";
            this.Question_search.Size = new System.Drawing.Size(228, 19);
            this.Question_search.TabIndex = 5;
            this.Question_search.Text = "問題を検索する";
            // 
            // Question_own_check
            // 
            this.Question_own_check.AutoSize = true;
            this.Question_own_check.Location = new System.Drawing.Point(311, 40);
            this.Question_own_check.Name = "Question_own_check";
            this.Question_own_check.Size = new System.Drawing.Size(178, 16);
            this.Question_own_check.TabIndex = 4;
            this.Question_own_check.Text = "自分で作成した問題のみを表示";
            this.Question_own_check.UseVisualStyleBackColor = true;
            // 
            // Question_create
            // 
            this.Question_create.Location = new System.Drawing.Point(198, 34);
            this.Question_create.Name = "Question_create";
            this.Question_create.Size = new System.Drawing.Size(96, 30);
            this.Question_create.TabIndex = 3;
            this.Question_create.Text = "新規作成";
            this.Question_create.UseVisualStyleBackColor = true;
            this.Question_create.Click += new System.EventHandler(this.Question_create_Click);
            // 
            // question_list
            // 
            this.question_list.Location = new System.Drawing.Point(21, 74);
            this.question_list.Name = "question_list";
            this.question_list.Size = new System.Drawing.Size(729, 408);
            this.question_list.TabIndex = 2;
            this.question_list.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(18, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "問題一覧";
            // 
            // CorrectionEditor
            // 
            this.CorrectionEditor.BackColor = System.Drawing.Color.White;
            this.CorrectionEditor.Controls.Add(this.Remove_CorrectionEditor);
            this.CorrectionEditor.Location = new System.Drawing.Point(4, 22);
            this.CorrectionEditor.Name = "CorrectionEditor";
            this.CorrectionEditor.Padding = new System.Windows.Forms.Padding(3);
            this.CorrectionEditor.Size = new System.Drawing.Size(858, 536);
            this.CorrectionEditor.TabIndex = 6;
            this.CorrectionEditor.Text = "添削エディタ";
            // 
            // Remove_CorrectionEditor
            // 
            this.Remove_CorrectionEditor.Location = new System.Drawing.Point(22, 18);
            this.Remove_CorrectionEditor.Name = "Remove_CorrectionEditor";
            this.Remove_CorrectionEditor.Size = new System.Drawing.Size(114, 23);
            this.Remove_CorrectionEditor.TabIndex = 0;
            this.Remove_CorrectionEditor.Text = "添削エディタ削除";
            this.Remove_CorrectionEditor.UseVisualStyleBackColor = true;
            this.Remove_CorrectionEditor.Click += new System.EventHandler(this.Remove_CorrectionEditor_Click);
            // 
            // reference_create
            // 
            this.reference_create.Controls.Add(this.ref_inf_gbox);
            this.reference_create.Controls.Add(this.ref_cancel_btn);
            this.reference_create.Controls.Add(this.ref_upload_btn);
            this.reference_create.Controls.Add(this.ref_save_btn);
            this.reference_create.Controls.Add(this.ref_new_label);
            this.reference_create.Controls.Add(this.ref_body_box);
            this.reference_create.Location = new System.Drawing.Point(4, 22);
            this.reference_create.Name = "reference_create";
            this.reference_create.Padding = new System.Windows.Forms.Padding(3);
            this.reference_create.Size = new System.Drawing.Size(858, 536);
            this.reference_create.TabIndex = 7;
            this.reference_create.Text = "リファレンスの新規作成";
            this.reference_create.UseVisualStyleBackColor = true;
            // 
            // ref_inf_gbox
            // 
            this.ref_inf_gbox.Controls.Add(this.ref_genre_label);
            this.ref_inf_gbox.Controls.Add(this.ref_title_label);
            this.ref_inf_gbox.Controls.Add(this.ref_title_box);
            this.ref_inf_gbox.Location = new System.Drawing.Point(21, 353);
            this.ref_inf_gbox.Name = "ref_inf_gbox";
            this.ref_inf_gbox.Size = new System.Drawing.Size(729, 127);
            this.ref_inf_gbox.TabIndex = 5;
            this.ref_inf_gbox.TabStop = false;
            this.ref_inf_gbox.Text = "リファレンス情報";
            // 
            // ref_genre_label
            // 
            this.ref_genre_label.AutoSize = true;
            this.ref_genre_label.Location = new System.Drawing.Point(293, 31);
            this.ref_genre_label.Name = "ref_genre_label";
            this.ref_genre_label.Size = new System.Drawing.Size(48, 12);
            this.ref_genre_label.TabIndex = 2;
            this.ref_genre_label.Text = "ジャンル :";
            // 
            // ref_title_label
            // 
            this.ref_title_label.AutoSize = true;
            this.ref_title_label.Location = new System.Drawing.Point(24, 31);
            this.ref_title_label.Name = "ref_title_label";
            this.ref_title_label.Size = new System.Drawing.Size(46, 12);
            this.ref_title_label.TabIndex = 1;
            this.ref_title_label.Text = "タイトル :";
            // 
            // ref_title_box
            // 
            this.ref_title_box.Location = new System.Drawing.Point(70, 28);
            this.ref_title_box.Name = "ref_title_box";
            this.ref_title_box.Size = new System.Drawing.Size(161, 19);
            this.ref_title_box.TabIndex = 0;
            // 
            // ref_cancel_btn
            // 
            this.ref_cancel_btn.Location = new System.Drawing.Point(402, 34);
            this.ref_cancel_btn.Name = "ref_cancel_btn";
            this.ref_cancel_btn.Size = new System.Drawing.Size(96, 30);
            this.ref_cancel_btn.TabIndex = 4;
            this.ref_cancel_btn.Text = "キャンセル";
            this.ref_cancel_btn.UseVisualStyleBackColor = true;
            this.ref_cancel_btn.Click += new System.EventHandler(this.ref_cancel_btn_Click);
            // 
            // ref_upload_btn
            // 
            this.ref_upload_btn.Location = new System.Drawing.Point(198, 34);
            this.ref_upload_btn.Name = "ref_upload_btn";
            this.ref_upload_btn.Size = new System.Drawing.Size(96, 30);
            this.ref_upload_btn.TabIndex = 3;
            this.ref_upload_btn.Text = "保存/公開";
            this.ref_upload_btn.UseVisualStyleBackColor = true;
            // 
            // ref_save_btn
            // 
            this.ref_save_btn.Location = new System.Drawing.Point(300, 34);
            this.ref_save_btn.Name = "ref_save_btn";
            this.ref_save_btn.Size = new System.Drawing.Size(96, 30);
            this.ref_save_btn.TabIndex = 2;
            this.ref_save_btn.Text = "下書きの保存";
            this.ref_save_btn.UseVisualStyleBackColor = true;
            // 
            // ref_new_label
            // 
            this.ref_new_label.AutoSize = true;
            this.ref_new_label.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ref_new_label.Location = new System.Drawing.Point(21, 40);
            this.ref_new_label.Name = "ref_new_label";
            this.ref_new_label.Size = new System.Drawing.Size(161, 16);
            this.ref_new_label.TabIndex = 1;
            this.ref_new_label.Text = "リファレンスの新規作成";
            // 
            // ref_body_box
            // 
            this.ref_body_box.AllowDrop = true;
            this.ref_body_box.Location = new System.Drawing.Point(21, 74);
            this.ref_body_box.Multiline = true;
            this.ref_body_box.Name = "ref_body_box";
            this.ref_body_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ref_body_box.Size = new System.Drawing.Size(729, 258);
            this.ref_body_box.TabIndex = 0;
            // 
            // create_Question
            // 
            this.create_Question.Controls.Add(this.groupBox1);
            this.create_Question.Controls.Add(this.create_question_cancel);
            this.create_Question.Controls.Add(this.button2);
            this.create_Question.Controls.Add(this.button3);
            this.create_Question.Controls.Add(this.label6);
            this.create_Question.Controls.Add(this.textBox2);
            this.create_Question.Location = new System.Drawing.Point(4, 22);
            this.create_Question.Name = "create_Question";
            this.create_Question.Padding = new System.Windows.Forms.Padding(3);
            this.create_Question.Size = new System.Drawing.Size(858, 536);
            this.create_Question.TabIndex = 10;
            this.create_Question.Text = "問題の新規作成";
            this.create_Question.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(21, 353);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 127);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "問題情報";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "ジャンル :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "タイトル :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 19);
            this.textBox1.TabIndex = 0;
            // 
            // create_question_cancel
            // 
            this.create_question_cancel.Location = new System.Drawing.Point(402, 34);
            this.create_question_cancel.Name = "create_question_cancel";
            this.create_question_cancel.Size = new System.Drawing.Size(96, 30);
            this.create_question_cancel.TabIndex = 4;
            this.create_question_cancel.Text = "キャンセル";
            this.create_question_cancel.UseVisualStyleBackColor = true;
            this.create_question_cancel.Click += new System.EventHandler(this.create_question_cancel_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "保存/公開";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(300, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "下書きの保存";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(21, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "問題の新規作成";
            // 
            // textBox2
            // 
            this.textBox2.AllowDrop = true;
            this.textBox2.Location = new System.Drawing.Point(21, 74);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(729, 258);
            this.textBox2.TabIndex = 0;
            // 
            // mainnotify
            // 
            this.mainnotify.Text = "通知";
            this.mainnotify.Visible = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.ヘルプToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(867, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // ヘルプToolStripMenuItem
            // 
            this.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem";
            this.ヘルプToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ヘルプToolStripMenuItem.Text = "ヘルプ";
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 589);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.MainTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Gathers\'";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainPage.ResumeLayout(false);
            this.MainPage.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.MainTab.ResumeLayout(false);
            this.reference.ResumeLayout(false);
            this.reference.PerformLayout();
            this.Question.ResumeLayout(false);
            this.Question.PerformLayout();
            this.CorrectionEditor.ResumeLayout(false);
            this.reference_create.ResumeLayout(false);
            this.reference_create.PerformLayout();
            this.ref_inf_gbox.ResumeLayout(false);
            this.ref_inf_gbox.PerformLayout();
            this.create_Question.ResumeLayout(false);
            this.create_Question.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage SourceCode;
        private System.Windows.Forms.TabPage MainPage;
        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.Button Add_CorrectionEditor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NotifyIcon mainnotify;
        private System.Windows.Forms.TabPage CorrectionEditor;
        private System.Windows.Forms.Button Remove_CorrectionEditor;
        private System.Windows.Forms.TabPage reference_create;
        private System.Windows.Forms.GroupBox ref_inf_gbox;
        private System.Windows.Forms.Label ref_genre_label;
        private System.Windows.Forms.Label ref_title_label;
        private System.Windows.Forms.TextBox ref_title_box;
        private System.Windows.Forms.Button ref_cancel_btn;
        private System.Windows.Forms.Button ref_upload_btn;
        private System.Windows.Forms.Button ref_save_btn;
        private System.Windows.Forms.Label ref_new_label;
        private System.Windows.Forms.TextBox ref_body_box;
        private System.Windows.Forms.TabPage reference;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプToolStripMenuItem;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.CheckBox create_own_ref;
        private System.Windows.Forms.ListView ref_share_list;
        private System.Windows.Forms.Label ref_share_label;
        private System.Windows.Forms.TabPage Question;
        private System.Windows.Forms.TextBox Question_search;
        private System.Windows.Forms.CheckBox Question_own_check;
        private System.Windows.Forms.Button Question_create;
        private System.Windows.Forms.ListView question_list;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage create_Question;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button create_question_cancel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button create_new_ref;
    }
}

