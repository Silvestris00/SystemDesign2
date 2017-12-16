﻿namespace Gathers
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
            this.reference = new System.Windows.Forms.TabPage();
            this.Q_and_A = new System.Windows.Forms.TabPage();
            this.Question = new System.Windows.Forms.TabPage();
            this.SourceCode = new System.Windows.Forms.TabPage();
            this.MainPage = new System.Windows.Forms.TabPage();
            this.Add_CorrectionEditor = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.CorrectionEditor = new System.Windows.Forms.TabPage();
            this.Remove_CorrectionEditor = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.新規作成NToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.開くOToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.上書き保存SToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.印刷PToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.切り取りUToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.コピーCToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.貼り付けPToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ヘルプLToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.MainPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.CorrectionEditor.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reference
            // 
            this.reference.BackColor = System.Drawing.Color.White;
            this.reference.Location = new System.Drawing.Point(4, 22);
            this.reference.Name = "reference";
            this.reference.Padding = new System.Windows.Forms.Padding(3);
            this.reference.Size = new System.Drawing.Size(858, 474);
            this.reference.TabIndex = 3;
            this.reference.Text = "リファレンス共有";
            // 
            // Q_and_A
            // 
            this.Q_and_A.BackColor = System.Drawing.Color.White;
            this.Q_and_A.Location = new System.Drawing.Point(4, 22);
            this.Q_and_A.Name = "Q_and_A";
            this.Q_and_A.Padding = new System.Windows.Forms.Padding(3);
            this.Q_and_A.Size = new System.Drawing.Size(858, 474);
            this.Q_and_A.TabIndex = 2;
            this.Q_and_A.Text = "質問スレ";
            // 
            // Question
            // 
            this.Question.BackColor = System.Drawing.Color.White;
            this.Question.Location = new System.Drawing.Point(4, 22);
            this.Question.Name = "Question";
            this.Question.Padding = new System.Windows.Forms.Padding(3);
            this.Question.Size = new System.Drawing.Size(858, 474);
            this.Question.TabIndex = 1;
            this.Question.Text = "Gathers道場";
            // 
            // SourceCode
            // 
            this.SourceCode.BackColor = System.Drawing.Color.White;
            this.SourceCode.Location = new System.Drawing.Point(4, 22);
            this.SourceCode.Name = "SourceCode";
            this.SourceCode.Padding = new System.Windows.Forms.Padding(3);
            this.SourceCode.Size = new System.Drawing.Size(858, 474);
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
            this.MainPage.Size = new System.Drawing.Size(858, 474);
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
            this.MainTab.Controls.Add(this.MainPage);
            this.MainTab.Controls.Add(this.SourceCode);
            this.MainTab.Controls.Add(this.Question);
            this.MainTab.Controls.Add(this.Q_and_A);
            this.MainTab.Controls.Add(this.reference);
            this.MainTab.Controls.Add(this.CorrectionEditor);
            this.MainTab.Location = new System.Drawing.Point(1, 28);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(866, 500);
            this.MainTab.TabIndex = 0;
            // 
            // CorrectionEditor
            // 
            this.CorrectionEditor.BackColor = System.Drawing.Color.White;
            this.CorrectionEditor.Controls.Add(this.Remove_CorrectionEditor);
            this.CorrectionEditor.Location = new System.Drawing.Point(4, 22);
            this.CorrectionEditor.Name = "CorrectionEditor";
            this.CorrectionEditor.Padding = new System.Windows.Forms.Padding(3);
            this.CorrectionEditor.Size = new System.Drawing.Size(858, 474);
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
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新規作成NToolStripButton,
            this.開くOToolStripButton,
            this.上書き保存SToolStripButton,
            this.印刷PToolStripButton,
            this.toolStripSeparator,
            this.切り取りUToolStripButton,
            this.コピーCToolStripButton,
            this.貼り付けPToolStripButton,
            this.toolStripSeparator1,
            this.ヘルプLToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(867, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // 新規作成NToolStripButton
            // 
            this.新規作成NToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.新規作成NToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("新規作成NToolStripButton.Image")));
            this.新規作成NToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新規作成NToolStripButton.Name = "新規作成NToolStripButton";
            this.新規作成NToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.新規作成NToolStripButton.Text = "新規作成(&N)";
            // 
            // 開くOToolStripButton
            // 
            this.開くOToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.開くOToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("開くOToolStripButton.Image")));
            this.開くOToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.開くOToolStripButton.Name = "開くOToolStripButton";
            this.開くOToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.開くOToolStripButton.Text = "開く(&O)";
            // 
            // 上書き保存SToolStripButton
            // 
            this.上書き保存SToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.上書き保存SToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("上書き保存SToolStripButton.Image")));
            this.上書き保存SToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.上書き保存SToolStripButton.Name = "上書き保存SToolStripButton";
            this.上書き保存SToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.上書き保存SToolStripButton.Text = "上書き保存(&S)";
            // 
            // 印刷PToolStripButton
            // 
            this.印刷PToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.印刷PToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("印刷PToolStripButton.Image")));
            this.印刷PToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.印刷PToolStripButton.Name = "印刷PToolStripButton";
            this.印刷PToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.印刷PToolStripButton.Text = "印刷(&P)";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // 切り取りUToolStripButton
            // 
            this.切り取りUToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.切り取りUToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("切り取りUToolStripButton.Image")));
            this.切り取りUToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.切り取りUToolStripButton.Name = "切り取りUToolStripButton";
            this.切り取りUToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.切り取りUToolStripButton.Text = "切り取り(&U)";
            // 
            // コピーCToolStripButton
            // 
            this.コピーCToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.コピーCToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("コピーCToolStripButton.Image")));
            this.コピーCToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.コピーCToolStripButton.Name = "コピーCToolStripButton";
            this.コピーCToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.コピーCToolStripButton.Text = "コピー(&C)";
            // 
            // 貼り付けPToolStripButton
            // 
            this.貼り付けPToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.貼り付けPToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("貼り付けPToolStripButton.Image")));
            this.貼り付けPToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.貼り付けPToolStripButton.Name = "貼り付けPToolStripButton";
            this.貼り付けPToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.貼り付けPToolStripButton.Text = "貼り付け(&P)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ヘルプLToolStripButton
            // 
            this.ヘルプLToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ヘルプLToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ヘルプLToolStripButton.Image")));
            this.ヘルプLToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ヘルプLToolStripButton.Name = "ヘルプLToolStripButton";
            this.ヘルプLToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ヘルプLToolStripButton.Text = "ヘルプ(&L)";
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 461);
            this.Controls.Add(this.toolStrip1);
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
            this.CorrectionEditor.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage reference;
        private System.Windows.Forms.TabPage Q_and_A;
        private System.Windows.Forms.TabPage Question;
        private System.Windows.Forms.TabPage SourceCode;
        private System.Windows.Forms.TabPage MainPage;
        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.Button Add_CorrectionEditor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TabPage CorrectionEditor;
        private System.Windows.Forms.Button Remove_CorrectionEditor;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton 新規作成NToolStripButton;
        private System.Windows.Forms.ToolStripButton 開くOToolStripButton;
        private System.Windows.Forms.ToolStripButton 上書き保存SToolStripButton;
        private System.Windows.Forms.ToolStripButton 印刷PToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton 切り取りUToolStripButton;
        private System.Windows.Forms.ToolStripButton コピーCToolStripButton;
        private System.Windows.Forms.ToolStripButton 貼り付けPToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ヘルプLToolStripButton;
    }
}

