namespace SystemDesign2_gathers
{
    partial class gathers
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.search_box = new System.Windows.Forms.TextBox();
            this.create_own_ref = new System.Windows.Forms.CheckBox();
            this.create_new_ref = new System.Windows.Forms.Button();
            this.ref_share_list = new System.Windows.Forms.ListView();
            this.ref_share_label = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ref_inf_gbox = new System.Windows.Forms.GroupBox();
            this.ref_genre_label = new System.Windows.Forms.Label();
            this.ref_title_label = new System.Windows.Forms.Label();
            this.ref_title_box = new System.Windows.Forms.TextBox();
            this.ref_cancel_btn = new System.Windows.Forms.Button();
            this.ref_upload_btn = new System.Windows.Forms.Button();
            this.ref_save_btn = new System.Windows.Forms.Button();
            this.ref_new_label = new System.Windows.Forms.Label();
            this.ref_body_box = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.ref_inf_gbox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(779, 517);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.search_box);
            this.tabPage1.Controls.Add(this.create_own_ref);
            this.tabPage1.Controls.Add(this.create_new_ref);
            this.tabPage1.Controls.Add(this.ref_share_list);
            this.tabPage1.Controls.Add(this.ref_share_label);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(771, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "refference";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // create_new_ref
            // 
            this.create_new_ref.Location = new System.Drawing.Point(198, 34);
            this.create_new_ref.Name = "create_new_ref";
            this.create_new_ref.Size = new System.Drawing.Size(96, 30);
            this.create_new_ref.TabIndex = 3;
            this.create_new_ref.Text = "新規作成";
            this.create_new_ref.UseVisualStyleBackColor = true;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ref_inf_gbox);
            this.tabPage2.Controls.Add(this.ref_cancel_btn);
            this.tabPage2.Controls.Add(this.ref_upload_btn);
            this.tabPage2.Controls.Add(this.ref_save_btn);
            this.tabPage2.Controls.Add(this.ref_new_label);
            this.tabPage2.Controls.Add(this.ref_body_box);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(771, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(771, 491);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(771, 491);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(771, 491);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.ヘルプToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
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
            // gathers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 548);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "gathers";
            this.Text = "Gathers\'";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ref_inf_gbox.ResumeLayout(false);
            this.ref_inf_gbox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView ref_share_list;
        private System.Windows.Forms.Label ref_share_label;
        private System.Windows.Forms.CheckBox create_own_ref;
        private System.Windows.Forms.Button create_new_ref;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.TextBox ref_body_box;
        private System.Windows.Forms.Label ref_new_label;
        private System.Windows.Forms.Button ref_cancel_btn;
        private System.Windows.Forms.Button ref_upload_btn;
        private System.Windows.Forms.Button ref_save_btn;
        private System.Windows.Forms.GroupBox ref_inf_gbox;
        private System.Windows.Forms.Label ref_title_label;
        private System.Windows.Forms.TextBox ref_title_box;
        private System.Windows.Forms.Label ref_genre_label;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプToolStripMenuItem;
    }
}

