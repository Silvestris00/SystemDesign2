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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.MainTab = new System.Windows.Forms.TabControl();
            this.SoarceCode = new System.Windows.Forms.TabPage();
            this.Question = new System.Windows.Forms.TabPage();
            this.Q_and_A = new System.Windows.Forms.TabPage();
            this.reference = new System.Windows.Forms.TabPage();
            this.Gathers_Editor = new System.Windows.Forms.TabPage();
            this.toolbar = new System.Windows.Forms.ToolStrip();
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
            this.MainTab.SuspendLayout();
            this.toolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.SoarceCode);
            this.MainTab.Controls.Add(this.Question);
            this.MainTab.Controls.Add(this.Q_and_A);
            this.MainTab.Controls.Add(this.reference);
            this.MainTab.Controls.Add(this.Gathers_Editor);
            this.MainTab.Location = new System.Drawing.Point(1, 25);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(1920, 1080);
            this.MainTab.TabIndex = 0;
            // 
            // SoarceCode
            // 
            this.SoarceCode.Location = new System.Drawing.Point(4, 22);
            this.SoarceCode.Name = "SoarceCode";
            this.SoarceCode.Padding = new System.Windows.Forms.Padding(3);
            this.SoarceCode.Size = new System.Drawing.Size(1912, 1054);
            this.SoarceCode.TabIndex = 0;
            this.SoarceCode.Text = "ソースコード共有";
            this.SoarceCode.UseVisualStyleBackColor = true;
            // 
            // Question
            // 
            this.Question.Location = new System.Drawing.Point(4, 22);
            this.Question.Name = "Question";
            this.Question.Padding = new System.Windows.Forms.Padding(3);
            this.Question.Size = new System.Drawing.Size(1912, 1054);
            this.Question.TabIndex = 1;
            this.Question.Text = "Gathers道場";
            this.Question.UseVisualStyleBackColor = true;
            // 
            // Q_and_A
            // 
            this.Q_and_A.Location = new System.Drawing.Point(4, 22);
            this.Q_and_A.Name = "Q_and_A";
            this.Q_and_A.Padding = new System.Windows.Forms.Padding(3);
            this.Q_and_A.Size = new System.Drawing.Size(1912, 1054);
            this.Q_and_A.TabIndex = 2;
            this.Q_and_A.Text = "質問スレ";
            this.Q_and_A.UseVisualStyleBackColor = true;
            // 
            // reference
            // 
            this.reference.Location = new System.Drawing.Point(4, 22);
            this.reference.Name = "reference";
            this.reference.Padding = new System.Windows.Forms.Padding(3);
            this.reference.Size = new System.Drawing.Size(1912, 1054);
            this.reference.TabIndex = 3;
            this.reference.Text = "リファレンス共有";
            this.reference.UseVisualStyleBackColor = true;
            // 
            // Gathers_Editor
            // 
            this.Gathers_Editor.Location = new System.Drawing.Point(4, 22);
            this.Gathers_Editor.Name = "Gathers_Editor";
            this.Gathers_Editor.Padding = new System.Windows.Forms.Padding(3);
            this.Gathers_Editor.Size = new System.Drawing.Size(1912, 1054);
            this.Gathers_Editor.TabIndex = 4;
            this.Gathers_Editor.Text = "独自エディタ";
            this.Gathers_Editor.UseVisualStyleBackColor = true;
            // 
            // toolbar
            // 
            this.toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolbar.Size = new System.Drawing.Size(1486, 25);
            this.toolbar.TabIndex = 1;
            this.toolbar.Text = "ツールバー";
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
            this.ClientSize = new System.Drawing.Size(1486, 596);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.MainTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Gathers\'";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainTab.ResumeLayout(false);
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage SoarceCode;
        private System.Windows.Forms.TabPage Question;
        private System.Windows.Forms.TabPage Q_and_A;
        private System.Windows.Forms.TabPage reference;
        private System.Windows.Forms.TabPage Gathers_Editor;
        private System.Windows.Forms.ToolStrip toolbar;
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

