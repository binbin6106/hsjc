namespace HSJC
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.独立控制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SingelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ControlerSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetZeroPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EleSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.独立控制ToolStripMenuItem,
            this.SingelToolStripMenuItem1,
            this.ControlerSetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(606, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 独立控制ToolStripMenuItem
            // 
            this.独立控制ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddProductToolStripMenuItem,
            this.ViewProductToolStripMenuItem});
            this.独立控制ToolStripMenuItem.Name = "独立控制ToolStripMenuItem";
            this.独立控制ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.独立控制ToolStripMenuItem.Text = "产品管理";
            // 
            // AddProductToolStripMenuItem
            // 
            this.AddProductToolStripMenuItem.Name = "AddProductToolStripMenuItem";
            this.AddProductToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.AddProductToolStripMenuItem.Text = "添加产品";
            this.AddProductToolStripMenuItem.Click += new System.EventHandler(this.AddProductToolStripMenuItem_Click);
            // 
            // ViewProductToolStripMenuItem
            // 
            this.ViewProductToolStripMenuItem.Name = "ViewProductToolStripMenuItem";
            this.ViewProductToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.ViewProductToolStripMenuItem.Text = "查看产品";
            this.ViewProductToolStripMenuItem.Click += new System.EventHandler(this.ViewProductToolStripMenuItem_Click);
            // 
            // SingelToolStripMenuItem1
            // 
            this.SingelToolStripMenuItem1.Name = "SingelToolStripMenuItem1";
            this.SingelToolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.SingelToolStripMenuItem1.Text = "独立控制";
            this.SingelToolStripMenuItem1.Click += new System.EventHandler(this.SingelToolStripMenuItem1_Click);
            // 
            // ControlerSetToolStripMenuItem
            // 
            this.ControlerSetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetZeroPositionToolStripMenuItem,
            this.EleSetToolStripMenuItem});
            this.ControlerSetToolStripMenuItem.Name = "ControlerSetToolStripMenuItem";
            this.ControlerSetToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.ControlerSetToolStripMenuItem.Text = "控制器设置";
            // 
            // SetZeroPositionToolStripMenuItem
            // 
            this.SetZeroPositionToolStripMenuItem.Name = "SetZeroPositionToolStripMenuItem";
            this.SetZeroPositionToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.SetZeroPositionToolStripMenuItem.Text = "定义原点";
            this.SetZeroPositionToolStripMenuItem.Click += new System.EventHandler(this.SetZeroPositionToolStripMenuItem_Click);
            // 
            // EleSetToolStripMenuItem
            // 
            this.EleSetToolStripMenuItem.Name = "EleSetToolStripMenuItem";
            this.EleSetToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.EleSetToolStripMenuItem.Text = "参数设置";
            this.EleSetToolStripMenuItem.Click += new System.EventHandler(this.EleSetToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "开始";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(148, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "急停";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(249, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "复位";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 50);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "产品选择";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(278, 16);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "命令查看";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(191, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "打开产品";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "当前产品";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(13, 156);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(359, 65);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "运动控制";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ver1.0.1 Copyright © 2019 ZWB.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 48);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设备状态";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "初始化设备";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "未就绪";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "  ";
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(378, 12);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(216, 209);
            this.Output.TabIndex = 10;
            this.Output.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 247);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(400, 280);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "活塞检测系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 独立控制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SingelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ControlerSetToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.ToolStripMenuItem SetZeroPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EleSetToolStripMenuItem;
    }
}

