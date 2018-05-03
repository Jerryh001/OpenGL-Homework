namespace HW2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TabPage tabPage1;
            System.Windows.Forms.TabPage tabPage2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.imageBox3 = new Emgu.CV.UI.ImageBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_show2 = new System.Windows.Forms.Button();
            this.button_show1 = new System.Windows.Forms.Button();
            this.button_down = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_up = new System.Windows.Forms.Button();
            this.button_load1 = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_load2 = new System.Windows.Forms.Button();
            this.button_run = new System.Windows.Forms.Button();
            this.value_t = new System.Windows.Forms.NumericUpDown();
            this.value_p = new System.Windows.Forms.NumericUpDown();
            this.value_b = new System.Windows.Forms.NumericUpDown();
            this.value_a = new System.Windows.Forms.NumericUpDown();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.button_auto = new System.Windows.Forms.Button();
            this.saveFolder = new System.Windows.Forms.FolderBrowserDialog();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage2 = new System.Windows.Forms.TabPage();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.tab.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.value_t)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_a)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(this.imageBox1);
            tabPage1.Location = new System.Drawing.Point(4, 25);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(535, 523);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "圖一";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // imageBox1
            // 
            this.imageBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox1.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBox1.Location = new System.Drawing.Point(3, 3);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(529, 517);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(this.imageBox2);
            tabPage2.Location = new System.Drawing.Point(4, 25);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(535, 523);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "圖二";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // imageBox2
            // 
            this.imageBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox2.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBox2.Location = new System.Drawing.Point(3, 3);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(529, 517);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "a:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 47);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(18, 15);
            label2.TabIndex = 1;
            label2.Text = "b:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(2, 83);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(18, 15);
            label3.TabIndex = 2;
            label3.Text = "p:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(2, 119);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(15, 15);
            label4.TabIndex = 6;
            label4.Text = "t:";
            // 
            // tab
            // 
            this.tab.Controls.Add(tabPage1);
            this.tab.Controls.Add(tabPage2);
            this.tab.Controls.Add(this.tabPage3);
            this.tab.Dock = System.Windows.Forms.DockStyle.Left;
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(543, 552);
            this.tab.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tab.TabIndex = 0;
            this.tab.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.imageBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(535, 523);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "結果";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // imageBox3
            // 
            this.imageBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox3.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBox3.Location = new System.Drawing.Point(3, 3);
            this.imageBox3.Name = "imageBox3";
            this.imageBox3.Size = new System.Drawing.Size(529, 517);
            this.imageBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox3.TabIndex = 3;
            this.imageBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(711, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 552);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "控制面板";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 21);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button_auto);
            this.splitContainer1.Panel1.Controls.Add(this.button_show2);
            this.splitContainer1.Panel1.Controls.Add(this.button_show1);
            this.splitContainer1.Panel1.Controls.Add(this.button_down);
            this.splitContainer1.Panel1.Controls.Add(this.button_remove);
            this.splitContainer1.Panel1.Controls.Add(this.button_up);
            this.splitContainer1.Panel1.Controls.Add(this.button_load1);
            this.splitContainer1.Panel1.Controls.Add(this.button_save);
            this.splitContainer1.Panel1.Controls.Add(this.button_load2);
            this.splitContainer1.Panel1.Controls.Add(this.button_run);
            this.splitContainer1.Panel1MinSize = 115;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.value_t);
            this.splitContainer1.Panel2.Controls.Add(label4);
            this.splitContainer1.Panel2.Controls.Add(this.value_p);
            this.splitContainer1.Panel2.Controls.Add(this.value_b);
            this.splitContainer1.Panel2.Controls.Add(this.value_a);
            this.splitContainer1.Panel2.Controls.Add(label3);
            this.splitContainer1.Panel2.Controls.Add(label2);
            this.splitContainer1.Panel2.Controls.Add(label1);
            this.splitContainer1.Size = new System.Drawing.Size(303, 528);
            this.splitContainer1.SplitterDistance = 115;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 2;
            // 
            // button_show2
            // 
            this.button_show2.Location = new System.Drawing.Point(3, 478);
            this.button_show2.Name = "button_show2";
            this.button_show2.Size = new System.Drawing.Size(100, 30);
            this.button_show2.TabIndex = 10;
            this.button_show2.Text = "編輯圖二";
            this.button_show2.UseVisualStyleBackColor = true;
            this.button_show2.Click += new System.EventHandler(this.button_show_Click);
            // 
            // button_show1
            // 
            this.button_show1.Location = new System.Drawing.Point(3, 442);
            this.button_show1.Name = "button_show1";
            this.button_show1.Size = new System.Drawing.Size(100, 30);
            this.button_show1.TabIndex = 9;
            this.button_show1.Text = "編輯圖一";
            this.button_show1.UseVisualStyleBackColor = true;
            this.button_show1.Click += new System.EventHandler(this.button_show_Click);
            // 
            // button_down
            // 
            this.button_down.Location = new System.Drawing.Point(0, 330);
            this.button_down.Name = "button_down";
            this.button_down.Size = new System.Drawing.Size(100, 30);
            this.button_down.TabIndex = 8;
            this.button_down.Text = "向下移動";
            this.button_down.UseVisualStyleBackColor = true;
            this.button_down.Click += new System.EventHandler(this.button_down_Click);
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(0, 366);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(100, 30);
            this.button_remove.TabIndex = 6;
            this.button_remove.Text = "移除所選";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_up
            // 
            this.button_up.Location = new System.Drawing.Point(0, 294);
            this.button_up.Name = "button_up";
            this.button_up.Size = new System.Drawing.Size(100, 30);
            this.button_up.TabIndex = 7;
            this.button_up.Text = "向上移動";
            this.button_up.UseVisualStyleBackColor = true;
            this.button_up.Click += new System.EventHandler(this.button_up_Click);
            // 
            // button_load1
            // 
            this.button_load1.Location = new System.Drawing.Point(3, 3);
            this.button_load1.Name = "button_load1";
            this.button_load1.Size = new System.Drawing.Size(100, 30);
            this.button_load1.TabIndex = 0;
            this.button_load1.Text = "載入圖一";
            this.button_load1.UseVisualStyleBackColor = true;
            this.button_load1.Click += new System.EventHandler(this.button_load_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(3, 111);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(100, 30);
            this.button_save.TabIndex = 3;
            this.button_save.Text = "儲存結果";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_load2
            // 
            this.button_load2.Location = new System.Drawing.Point(3, 39);
            this.button_load2.Name = "button_load2";
            this.button_load2.Size = new System.Drawing.Size(100, 30);
            this.button_load2.TabIndex = 1;
            this.button_load2.Text = "載入圖二";
            this.button_load2.UseVisualStyleBackColor = true;
            this.button_load2.Click += new System.EventHandler(this.button_load_Click);
            // 
            // button_run
            // 
            this.button_run.Location = new System.Drawing.Point(3, 75);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(100, 30);
            this.button_run.TabIndex = 2;
            this.button_run.Text = "開始母湯";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.button_run_Click);
            // 
            // value_t
            // 
            this.value_t.DecimalPlaces = 2;
            this.value_t.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.value_t.Location = new System.Drawing.Point(26, 117);
            this.value_t.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.value_t.Name = "value_t";
            this.value_t.Size = new System.Drawing.Size(120, 25);
            this.value_t.TabIndex = 7;
            this.value_t.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // value_p
            // 
            this.value_p.DecimalPlaces = 2;
            this.value_p.Location = new System.Drawing.Point(26, 81);
            this.value_p.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.value_p.Name = "value_p";
            this.value_p.Size = new System.Drawing.Size(120, 25);
            this.value_p.TabIndex = 5;
            // 
            // value_b
            // 
            this.value_b.DecimalPlaces = 2;
            this.value_b.Location = new System.Drawing.Point(26, 45);
            this.value_b.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.value_b.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.value_b.Name = "value_b";
            this.value_b.Size = new System.Drawing.Size(120, 25);
            this.value_b.TabIndex = 4;
            this.value_b.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // value_a
            // 
            this.value_a.DecimalPlaces = 2;
            this.value_a.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.value_a.Location = new System.Drawing.Point(26, 11);
            this.value_a.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.value_a.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.value_a.Name = "value_a";
            this.value_a.Size = new System.Drawing.Size(120, 25);
            this.value_a.TabIndex = 3;
            this.value_a.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // listBox1
            // 
            this.listBox1.DisplayMember = "Detail";
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(543, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(168, 552);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // saveFile
            // 
            this.saveFile.DefaultExt = "jpg";
            this.saveFile.FileName = "image.jpg";
            this.saveFile.Filter = "JPG|*.jpg";
            this.saveFile.Title = "存檔";
            // 
            // button_auto
            // 
            this.button_auto.Location = new System.Drawing.Point(3, 201);
            this.button_auto.Name = "button_auto";
            this.button_auto.Size = new System.Drawing.Size(100, 30);
            this.button_auto.TabIndex = 11;
            this.button_auto.Text = "全自動母湯";
            this.button_auto.UseVisualStyleBackColor = true;
            this.button_auto.Click += new System.EventHandler(this.button_auto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1020, 552);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tab);
            this.Name = "Form1";
            this.Text = "笑容逐漸母湯產生器";
            this.Load += new System.EventHandler(this.Form1_Load);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.tab.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.value_t)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_a)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private Emgu.CV.UI.ImageBox imageBox3;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_run;
        private System.Windows.Forms.Button button_load2;
        private System.Windows.Forms.Button button_load1;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NumericUpDown value_p;
        private System.Windows.Forms.NumericUpDown value_b;
        private System.Windows.Forms.NumericUpDown value_a;
        private System.Windows.Forms.NumericUpDown value_t;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_down;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_up;
        private System.Windows.Forms.Button button_show2;
        private System.Windows.Forms.Button button_show1;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Button button_auto;
        private System.Windows.Forms.FolderBrowserDialog saveFolder;
    }
}

