namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.content = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.axAcroPDF = new AxAcroPDFLib.AxAcroPDF();
            this.translation = new System.Windows.Forms.TextBox();
            this.word = new System.Windows.Forms.TextBox();
            this.hide_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.openFile = new System.Windows.Forms.Button();
            this.ucSwitch1 = new HZH_Controls.Controls.UCSwitch();
            this.header = new System.Windows.Forms.Panel();
            this.min = new HZH_Controls.Controls.UCBtnExt();
            this.max = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt1 = new HZH_Controls.Controls.UCBtnExt();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.content.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).BeginInit();
            this.panel2.SuspendLayout();
            this.header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.Controls.Add(this.panel3);
            this.content.Controls.Add(this.panel2);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1147, 756);
            this.content.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.splitContainer1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1147, 721);
            this.panel3.TabIndex = 7;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.webBrowser);
            this.splitContainer1.Panel1.Controls.Add(this.axAcroPDF);
            this.splitContainer1.Panel1MinSize = 300;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.translation);
            this.splitContainer1.Panel2.Controls.Add(this.word);
            this.splitContainer1.Panel2.Controls.Add(this.hide_btn);
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.Size = new System.Drawing.Size(1147, 721);
            this.splitContainer1.SplitterDistance = 953;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 1;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(2);
            this.webBrowser.MinimumSize = new System.Drawing.Size(15, 16);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(949, 717);
            this.webBrowser.TabIndex = 1;
            // 
            // axAcroPDF
            // 
            this.axAcroPDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axAcroPDF.Enabled = true;
            this.axAcroPDF.Location = new System.Drawing.Point(0, 0);
            this.axAcroPDF.Name = "axAcroPDF";
            this.axAcroPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF.OcxState")));
            this.axAcroPDF.Size = new System.Drawing.Size(949, 717);
            this.axAcroPDF.TabIndex = 0;
            // 
            // translation
            // 
            this.translation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.translation.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.translation.Location = new System.Drawing.Point(0, 155);
            this.translation.Multiline = true;
            this.translation.Name = "translation";
            this.translation.Size = new System.Drawing.Size(188, 562);
            this.translation.TabIndex = 4;
            // 
            // word
            // 
            this.word.BackColor = System.Drawing.Color.WhiteSmoke;
            this.word.Dock = System.Windows.Forms.DockStyle.Top;
            this.word.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word.ForeColor = System.Drawing.Color.MidnightBlue;
            this.word.Location = new System.Drawing.Point(0, 23);
            this.word.Multiline = true;
            this.word.Name = "word";
            this.word.ReadOnly = true;
            this.word.Size = new System.Drawing.Size(188, 132);
            this.word.TabIndex = 3;
            // 
            // hide_btn
            // 
            this.hide_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.hide_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.hide_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide_btn.Location = new System.Drawing.Point(0, 0);
            this.hide_btn.Margin = new System.Windows.Forms.Padding(0);
            this.hide_btn.Name = "hide_btn";
            this.hide_btn.Size = new System.Drawing.Size(188, 23);
            this.hide_btn.TabIndex = 2;
            this.hide_btn.Text = "隐藏";
            this.hide_btn.UseVisualStyleBackColor = false;
            this.hide_btn.Click += new System.EventHandler(this.hide_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.openFile);
            this.panel2.Controls.Add(this.ucSwitch1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1147, 35);
            this.panel2.TabIndex = 6;
            // 
            // openFile
            // 
            this.openFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.openFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFile.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.openFile.ForeColor = System.Drawing.Color.DarkBlue;
            this.openFile.Location = new System.Drawing.Point(8, 5);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(75, 23);
            this.openFile.TabIndex = 5;
            this.openFile.Text = "打开文件";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // ucSwitch1
            // 
            this.ucSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.ucSwitch1.Checked = false;
            this.ucSwitch1.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ucSwitch1.Location = new System.Drawing.Point(90, 3);
            this.ucSwitch1.Name = "ucSwitch1";
            this.ucSwitch1.Size = new System.Drawing.Size(71, 27);
            this.ucSwitch1.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.ucSwitch1.TabIndex = 4;
            this.ucSwitch1.Texts = new string[] {
        "关闭",
        "取词"};
            this.ucSwitch1.TrueColor = System.Drawing.Color.MidnightBlue;
            this.ucSwitch1.CheckedChanged += new System.EventHandler(this.ucSwitch1_CheckedChanged_1);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.MidnightBlue;
            this.header.Controls.Add(this.min);
            this.header.Controls.Add(this.max);
            this.header.Controls.Add(this.ucBtnExt1);
            this.header.Controls.Add(this.label2);
            this.header.Controls.Add(this.label1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1147, 54);
            this.header.TabIndex = 5;
            this.header.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.header_MouseDoubleClick);
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.header_MouseMove);
            // 
            // min
            // 
            this.min.BackColor = System.Drawing.Color.Transparent;
            this.min.BtnBackColor = System.Drawing.Color.Transparent;
            this.min.BtnFont = new System.Drawing.Font("黑体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.min.BtnForeColor = System.Drawing.Color.White;
            this.min.BtnText = "－";
            this.min.ConerRadius = 5;
            this.min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.min.Dock = System.Windows.Forms.DockStyle.Right;
            this.min.FillColor = System.Drawing.Color.Transparent;
            this.min.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.min.ForeColor = System.Drawing.Color.White;
            this.min.IsRadius = true;
            this.min.IsShowRect = true;
            this.min.IsShowTips = false;
            this.min.Location = new System.Drawing.Point(943, 0);
            this.min.Margin = new System.Windows.Forms.Padding(0);
            this.min.Name = "min";
            this.min.RectColor = System.Drawing.Color.Transparent;
            this.min.RectWidth = 1;
            this.min.Size = new System.Drawing.Size(68, 54);
            this.min.TabIndex = 4;
            this.min.TabStop = false;
            this.min.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.min.TipsText = "";
            this.min.BtnClick += new System.EventHandler(this.min_BtnClick);
            // 
            // max
            // 
            this.max.BackColor = System.Drawing.Color.Transparent;
            this.max.BtnBackColor = System.Drawing.Color.Transparent;
            this.max.BtnFont = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.max.BtnForeColor = System.Drawing.Color.White;
            this.max.BtnText = "❐";
            this.max.ConerRadius = 5;
            this.max.Cursor = System.Windows.Forms.Cursors.Hand;
            this.max.Dock = System.Windows.Forms.DockStyle.Right;
            this.max.FillColor = System.Drawing.Color.Transparent;
            this.max.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.max.ForeColor = System.Drawing.Color.White;
            this.max.IsRadius = true;
            this.max.IsShowRect = true;
            this.max.IsShowTips = false;
            this.max.Location = new System.Drawing.Point(1011, 0);
            this.max.Margin = new System.Windows.Forms.Padding(0);
            this.max.Name = "max";
            this.max.RectColor = System.Drawing.Color.Transparent;
            this.max.RectWidth = 1;
            this.max.Size = new System.Drawing.Size(68, 54);
            this.max.TabIndex = 3;
            this.max.TabStop = false;
            this.max.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.max.TipsText = "";
            this.max.BtnClick += new System.EventHandler(this.max_BtnClick);
            // 
            // ucBtnExt1
            // 
            this.ucBtnExt1.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnExt1.BtnBackColor = System.Drawing.Color.Transparent;
            this.ucBtnExt1.BtnFont = new System.Drawing.Font("黑体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt1.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnText = "×";
            this.ucBtnExt1.ConerRadius = 5;
            this.ucBtnExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt1.Dock = System.Windows.Forms.DockStyle.Right;
            this.ucBtnExt1.FillColor = System.Drawing.Color.Transparent;
            this.ucBtnExt1.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt1.ForeColor = System.Drawing.Color.White;
            this.ucBtnExt1.IsRadius = true;
            this.ucBtnExt1.IsShowRect = true;
            this.ucBtnExt1.IsShowTips = false;
            this.ucBtnExt1.Location = new System.Drawing.Point(1079, 0);
            this.ucBtnExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt1.Name = "ucBtnExt1";
            this.ucBtnExt1.RectColor = System.Drawing.Color.Transparent;
            this.ucBtnExt1.RectWidth = 1;
            this.ucBtnExt1.Size = new System.Drawing.Size(68, 54);
            this.ucBtnExt1.TabIndex = 2;
            this.ucBtnExt1.TabStop = false;
            this.ucBtnExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt1.TipsText = "";
            this.ucBtnExt1.BtnClick += new System.EventHandler(this.ucBtnExt1_BtnClick);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(222, 26);
            this.label2.MaximumSize = new System.Drawing.Size(400, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            this.label2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.header_MouseDoubleClick);
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.header_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "PDF Reader";
            this.label1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.header_MouseDoubleClick);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.header_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.content);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 756);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 810);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.content.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).EndInit();
            this.panel2.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt1;
        private HZH_Controls.Controls.UCBtnExt max;
        private HZH_Controls.Controls.UCBtnExt min;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button openFile;
        private HZH_Controls.Controls.UCSwitch ucSwitch1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.WebBrowser webBrowser;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF;
        private System.Windows.Forms.TextBox translation;
        private System.Windows.Forms.TextBox word;
        private System.Windows.Forms.Button hide_btn;
    }
}

