using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System;
using System.Drawing;

namespace MatrixForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.imgPanel = new System.Windows.Forms.Panel();
            this.imgBtn = new System.Windows.Forms.Button();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.ShowPanel = new System.Windows.Forms.Panel();
            this.tcpTextBox = new System.Windows.Forms.TextBox();
            this.TopBtnPanel = new System.Windows.Forms.Panel();
            this.IntervalBox = new System.Windows.Forms.TextBox();
            this.IntervalLabel = new System.Windows.Forms.Label();
            this.StopTcpBtn = new System.Windows.Forms.Button();
            this.EncodingComboBox = new System.Windows.Forms.ComboBox();
            this.EncodingLabel = new System.Windows.Forms.Label();
            this.TcpTypeBox = new System.Windows.Forms.ComboBox();
            this.TcpType = new System.Windows.Forms.Label();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.IPLabel = new System.Windows.Forms.Label();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.TcpBtn = new System.Windows.Forms.Button();
            this.imgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.LeftPanel.SuspendLayout();
            this.ShowPanel.SuspendLayout();
            this.TopBtnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgPanel
            // 
            this.imgPanel.AutoSize = true;
            this.imgPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imgPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imgPanel.Controls.Add(this.imgBtn);
            this.imgPanel.Controls.Add(this.imgBox);
            this.imgPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.imgPanel.Location = new System.Drawing.Point(1565, 0);
            this.imgPanel.Name = "imgPanel";
            this.imgPanel.Size = new System.Drawing.Size(355, 1080);
            this.imgPanel.TabIndex = 1;
            // 
            // imgBtn
            // 
            this.imgBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imgBtn.Location = new System.Drawing.Point(160, 25);
            this.imgBtn.Name = "imgBtn";
            this.imgBtn.Size = new System.Drawing.Size(56, 32);
            this.imgBtn.TabIndex = 2;
            this.imgBtn.Text = "获取";
            this.imgBtn.UseVisualStyleBackColor = true;
            this.imgBtn.Click += new System.EventHandler(this.imgBtn_Click);
            // 
            // imgBox
            // 
            this.imgBox.Location = new System.Drawing.Point(13, 90);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(339, 960);
            this.imgBox.TabIndex = 1;
            this.imgBox.TabStop = false;
            // 
            // LeftPanel
            // 
            this.LeftPanel.AutoSize = true;
            this.LeftPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LeftPanel.Controls.Add(this.ShowPanel);
            this.LeftPanel.Controls.Add(this.TopBtnPanel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(1565, 1080);
            this.LeftPanel.TabIndex = 2;
            // 
            // ShowPanel
            // 
            this.ShowPanel.AutoSize = true;
            this.ShowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShowPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ShowPanel.Controls.Add(this.tcpTextBox);
            this.ShowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowPanel.Location = new System.Drawing.Point(0, 46);
            this.ShowPanel.Name = "ShowPanel";
            this.ShowPanel.Size = new System.Drawing.Size(1565, 1034);
            this.ShowPanel.TabIndex = 1;
            // 
            // tcpTextBox
            // 
            this.tcpTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tcpTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcpTextBox.Location = new System.Drawing.Point(0, 0);
            this.tcpTextBox.Multiline = true;
            this.tcpTextBox.Name = "tcpTextBox";
            this.tcpTextBox.ReadOnly = true;
            this.tcpTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tcpTextBox.Size = new System.Drawing.Size(1565, 1034);
            this.tcpTextBox.TabIndex = 0;
            // 
            // TopBtnPanel
            // 
            this.TopBtnPanel.AutoScroll = true;
            this.TopBtnPanel.AutoSize = true;
            this.TopBtnPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TopBtnPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TopBtnPanel.Controls.Add(this.IntervalBox);
            this.TopBtnPanel.Controls.Add(this.IntervalLabel);
            this.TopBtnPanel.Controls.Add(this.StopTcpBtn);
            this.TopBtnPanel.Controls.Add(this.EncodingComboBox);
            this.TopBtnPanel.Controls.Add(this.EncodingLabel);
            this.TopBtnPanel.Controls.Add(this.TcpTypeBox);
            this.TopBtnPanel.Controls.Add(this.TcpType);
            this.TopBtnPanel.Controls.Add(this.PortBox);
            this.TopBtnPanel.Controls.Add(this.PortLabel);
            this.TopBtnPanel.Controls.Add(this.IPLabel);
            this.TopBtnPanel.Controls.Add(this.IPBox);
            this.TopBtnPanel.Controls.Add(this.TcpBtn);
            this.TopBtnPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBtnPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBtnPanel.Name = "TopBtnPanel";
            this.TopBtnPanel.Padding = new System.Windows.Forms.Padding(2);
            this.TopBtnPanel.Size = new System.Drawing.Size(1565, 46);
            this.TopBtnPanel.TabIndex = 0;
            // 
            // IntervalBox
            // 
            this.IntervalBox.Location = new System.Drawing.Point(855, 8);
            this.IntervalBox.Name = "IntervalBox";
            this.IntervalBox.Size = new System.Drawing.Size(36, 28);
            this.IntervalBox.TabIndex = 10;
            // 
            // IntervalLabel
            // 
            this.IntervalLabel.AutoSize = true;
            this.IntervalLabel.Location = new System.Drawing.Point(750, 13);
            this.IntervalLabel.Name = "IntervalLabel";
            this.IntervalLabel.Size = new System.Drawing.Size(98, 18);
            this.IntervalLabel.TabIndex = 9;
            this.IntervalLabel.Text = "通信间隔/S";
            // 
            // StopTcpBtn
            // 
            this.StopTcpBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StopTcpBtn.Location = new System.Drawing.Point(1206, 5);
            this.StopTcpBtn.Name = "StopTcpBtn";
            this.StopTcpBtn.Size = new System.Drawing.Size(96, 36);
            this.StopTcpBtn.TabIndex = 8;
            this.StopTcpBtn.Text = "停止监听";
            this.StopTcpBtn.UseVisualStyleBackColor = true;
            this.StopTcpBtn.Click += new System.EventHandler(this.StopTcpBtn_Click);
            // 
            // EncodingComboBox
            // 
            this.EncodingComboBox.FormattingEnabled = true;
            this.EncodingComboBox.Items.AddRange(new object[] {
            "UTF8",
            "ASCLL",
            "Unicode"});
            this.EncodingComboBox.Location = new System.Drawing.Point(627, 7);
            this.EncodingComboBox.Name = "EncodingComboBox";
            this.EncodingComboBox.Size = new System.Drawing.Size(96, 26);
            this.EncodingComboBox.TabIndex = 7;
            // 
            // EncodingLabel
            // 
            this.EncodingLabel.AutoSize = true;
            this.EncodingLabel.Location = new System.Drawing.Point(540, 14);
            this.EncodingLabel.Name = "EncodingLabel";
            this.EncodingLabel.Size = new System.Drawing.Size(80, 18);
            this.EncodingLabel.TabIndex = 6;
            this.EncodingLabel.Text = "编码方式";
            // 
            // TcpTypeBox
            // 
            this.TcpTypeBox.FormattingEnabled = true;
            this.TcpTypeBox.Items.AddRange(new object[] {
            "TCP",
            "UDP"});
            this.TcpTypeBox.Location = new System.Drawing.Point(456, 8);
            this.TcpTypeBox.Name = "TcpTypeBox";
            this.TcpTypeBox.Size = new System.Drawing.Size(68, 26);
            this.TcpTypeBox.TabIndex = 5;
            // 
            // TcpType
            // 
            this.TcpType.AutoSize = true;
            this.TcpType.Location = new System.Drawing.Point(369, 13);
            this.TcpType.Name = "TcpType";
            this.TcpType.Size = new System.Drawing.Size(80, 18);
            this.TcpType.TabIndex = 4;
            this.TcpType.Text = "通信方式";
            // 
            // PortBox
            // 
            this.PortBox.Location = new System.Drawing.Point(274, 8);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(80, 28);
            this.PortBox.TabIndex = 3;
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(223, 14);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(44, 18);
            this.PortLabel.TabIndex = 2;
            this.PortLabel.Text = "端口";
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.Location = new System.Drawing.Point(25, 14);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(26, 18);
            this.IPLabel.TabIndex = 1;
            this.IPLabel.Text = "IP";
            // 
            // IPBox
            // 
            this.IPBox.Location = new System.Drawing.Point(57, 10);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(160, 28);
            this.IPBox.TabIndex = 0;
            // 
            // TcpBtn
            // 
            this.TcpBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TcpBtn.BackColor = System.Drawing.SystemColors.Info;
            this.TcpBtn.Location = new System.Drawing.Point(1113, 5);
            this.TcpBtn.Name = "TcpBtn";
            this.TcpBtn.Size = new System.Drawing.Size(66, 36);
            this.TcpBtn.TabIndex = 0;
            this.TcpBtn.Text = "通信";
            this.TcpBtn.UseVisualStyleBackColor = false;
            this.TcpBtn.Click += new System.EventHandler(this.TcpBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.imgPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "服务助手";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.imgPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.ShowPanel.ResumeLayout(false);
            this.ShowPanel.PerformLayout();
            this.TopBtnPanel.ResumeLayout(false);
            this.TopBtnPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel imgPanel;//
        private PictureBox imgBox;
        private Button imgBtn;
        private Panel LeftPanel;//左边画布
        private Panel TopBtnPanel;//左边顶部按钮画布
        private Button TcpBtn;//通信按钮
        private Panel ShowPanel;//显示画布
        private TextBox IPBox;//IP输入框
        private Label IPLabel;//IP文本
        private TextBox PortBox;//端口输入框
        private Label PortLabel;//端口文本
        private TextBox tcpTextBox;//通信消息内容框
        private Label TcpType;//通信类型文本
        private ComboBox TcpTypeBox;//通信类型选择框
        private Label EncodingLabel;//通信编码文本
        private ComboBox EncodingComboBox;//通信编码选择框
        private Button StopTcpBtn;//停止通信按钮
        private Label IntervalLabel;//通信间隔文本
        private TextBox IntervalBox;//通信间隔输入
    }
}

