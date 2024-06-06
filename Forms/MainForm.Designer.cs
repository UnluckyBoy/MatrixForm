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
            this.imgComboBox = new System.Windows.Forms.ComboBox();
            this.imgBtn = new System.Windows.Forms.Button();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.ShowPanel = new System.Windows.Forms.Panel();
            this.tcpTextBox = new System.Windows.Forms.TextBox();
            this.TopMainPanel = new System.Windows.Forms.Panel();
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
            this.TopLeftPanel = new System.Windows.Forms.Panel();
            this.TopRightPanel = new System.Windows.Forms.Panel();
            this.RePushBtn = new System.Windows.Forms.Button();
            this.RePushPanel = new System.Windows.Forms.Panel();
            this.SqidBox = new System.Windows.Forms.TextBox();
            this.PushBtn = new System.Windows.Forms.Button();
            this.TipsLabel = new System.Windows.Forms.Label();
            this.imgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.LeftPanel.SuspendLayout();
            this.ShowPanel.SuspendLayout();
            this.TopMainPanel.SuspendLayout();
            this.TopLeftPanel.SuspendLayout();
            this.TopRightPanel.SuspendLayout();
            this.RePushPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgPanel
            // 
            this.imgPanel.AutoSize = true;
            this.imgPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imgPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imgPanel.Controls.Add(this.imgComboBox);
            this.imgPanel.Controls.Add(this.imgBtn);
            this.imgPanel.Controls.Add(this.imgBox);
            this.imgPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.imgPanel.Location = new System.Drawing.Point(1565, 0);
            this.imgPanel.Name = "imgPanel";
            this.imgPanel.Size = new System.Drawing.Size(355, 1080);
            this.imgPanel.TabIndex = 1;
            // 
            // imgComboBox
            // 
            this.imgComboBox.FormattingEnabled = true;
            this.imgComboBox.Location = new System.Drawing.Point(83, 52);
            this.imgComboBox.Name = "imgComboBox";
            this.imgComboBox.Size = new System.Drawing.Size(207, 26);
            this.imgComboBox.TabIndex = 3;
            this.imgComboBox.SelectedIndexChanged += new System.EventHandler(this.ShowImgHandle);
            // 
            // imgBtn
            // 
            this.imgBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imgBtn.Location = new System.Drawing.Point(170, 14);
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
            this.LeftPanel.Controls.Add(this.TopMainPanel);
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
            this.ShowPanel.Controls.Add(this.RePushPanel);
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
            // TopMainPanel
            // 
            this.TopMainPanel.AutoScroll = true;
            this.TopMainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TopMainPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TopMainPanel.Controls.Add(this.TopRightPanel);
            this.TopMainPanel.Controls.Add(this.TopLeftPanel);
            this.TopMainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopMainPanel.Location = new System.Drawing.Point(0, 0);
            this.TopMainPanel.Name = "TopMainPanel";
            this.TopMainPanel.Padding = new System.Windows.Forms.Padding(2);
            this.TopMainPanel.Size = new System.Drawing.Size(1565, 46);
            this.TopMainPanel.TabIndex = 0;
            // 
            // IntervalBox
            // 
            this.IntervalBox.Location = new System.Drawing.Point(841, 7);
            this.IntervalBox.Name = "IntervalBox";
            this.IntervalBox.Size = new System.Drawing.Size(36, 28);
            this.IntervalBox.TabIndex = 10;
            // 
            // IntervalLabel
            // 
            this.IntervalLabel.AutoSize = true;
            this.IntervalLabel.Location = new System.Drawing.Point(736, 12);
            this.IntervalLabel.Name = "IntervalLabel";
            this.IntervalLabel.Size = new System.Drawing.Size(98, 18);
            this.IntervalLabel.TabIndex = 9;
            this.IntervalLabel.Text = "通信间隔/S";
            // 
            // StopTcpBtn
            // 
            this.StopTcpBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StopTcpBtn.Location = new System.Drawing.Point(992, 4);
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
            "ASCII",
            "Unicode"});
            this.EncodingComboBox.Location = new System.Drawing.Point(613, 8);
            this.EncodingComboBox.Name = "EncodingComboBox";
            this.EncodingComboBox.Size = new System.Drawing.Size(96, 26);
            this.EncodingComboBox.TabIndex = 7;
            // 
            // EncodingLabel
            // 
            this.EncodingLabel.AutoSize = true;
            this.EncodingLabel.Location = new System.Drawing.Point(526, 13);
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
            this.TcpTypeBox.Location = new System.Drawing.Point(442, 8);
            this.TcpTypeBox.Name = "TcpTypeBox";
            this.TcpTypeBox.Size = new System.Drawing.Size(68, 26);
            this.TcpTypeBox.TabIndex = 5;
            // 
            // TcpType
            // 
            this.TcpType.AutoSize = true;
            this.TcpType.Location = new System.Drawing.Point(355, 12);
            this.TcpType.Name = "TcpType";
            this.TcpType.Size = new System.Drawing.Size(80, 18);
            this.TcpType.TabIndex = 4;
            this.TcpType.Text = "通信方式";
            // 
            // PortBox
            // 
            this.PortBox.Location = new System.Drawing.Point(260, 7);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(80, 28);
            this.PortBox.TabIndex = 3;
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(209, 13);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(44, 18);
            this.PortLabel.TabIndex = 2;
            this.PortLabel.Text = "端口";
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.Location = new System.Drawing.Point(11, 13);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(26, 18);
            this.IPLabel.TabIndex = 1;
            this.IPLabel.Text = "IP";
            // 
            // IPBox
            // 
            this.IPBox.Location = new System.Drawing.Point(43, 8);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(160, 28);
            this.IPBox.TabIndex = 0;
            // 
            // TcpBtn
            // 
            this.TcpBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TcpBtn.BackColor = System.Drawing.SystemColors.Info;
            this.TcpBtn.Location = new System.Drawing.Point(908, 4);
            this.TcpBtn.Name = "TcpBtn";
            this.TcpBtn.Size = new System.Drawing.Size(66, 36);
            this.TcpBtn.TabIndex = 0;
            this.TcpBtn.Text = "通信";
            this.TcpBtn.UseVisualStyleBackColor = false;
            this.TcpBtn.Click += new System.EventHandler(this.TcpBtn_Click);
            // 
            // TopLeftPanel
            // 
            this.TopLeftPanel.AutoSize = true;
            this.TopLeftPanel.Controls.Add(this.IntervalBox);
            this.TopLeftPanel.Controls.Add(this.IPBox);
            this.TopLeftPanel.Controls.Add(this.PortBox);
            this.TopLeftPanel.Controls.Add(this.IntervalLabel);
            this.TopLeftPanel.Controls.Add(this.PortLabel);
            this.TopLeftPanel.Controls.Add(this.TcpType);
            this.TopLeftPanel.Controls.Add(this.TcpTypeBox);
            this.TopLeftPanel.Controls.Add(this.StopTcpBtn);
            this.TopLeftPanel.Controls.Add(this.IPLabel);
            this.TopLeftPanel.Controls.Add(this.TcpBtn);
            this.TopLeftPanel.Controls.Add(this.EncodingLabel);
            this.TopLeftPanel.Controls.Add(this.EncodingComboBox);
            this.TopLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TopLeftPanel.Location = new System.Drawing.Point(2, 2);
            this.TopLeftPanel.Margin = new System.Windows.Forms.Padding(2);
            this.TopLeftPanel.Name = "TopLeftPanel";
            this.TopLeftPanel.Size = new System.Drawing.Size(1091, 42);
            this.TopLeftPanel.TabIndex = 0;
            // 
            // TopRightPanel
            // 
            this.TopRightPanel.AutoSize = true;
            this.TopRightPanel.Controls.Add(this.RePushBtn);
            this.TopRightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopRightPanel.Location = new System.Drawing.Point(1093, 2);
            this.TopRightPanel.Margin = new System.Windows.Forms.Padding(2);
            this.TopRightPanel.Name = "TopRightPanel";
            this.TopRightPanel.Size = new System.Drawing.Size(470, 42);
            this.TopRightPanel.TabIndex = 1;
            // 
            // RePushBtn
            // 
            this.RePushBtn.BackColor = System.Drawing.Color.LawnGreen;
            this.RePushBtn.Location = new System.Drawing.Point(15, 4);
            this.RePushBtn.Name = "RePushBtn";
            this.RePushBtn.Size = new System.Drawing.Size(64, 36);
            this.RePushBtn.TabIndex = 0;
            this.RePushBtn.Text = "重推";
            this.RePushBtn.UseVisualStyleBackColor = false;
            this.RePushBtn.Click += new System.EventHandler(this.ShowRePushPanel);
            // 
            // RePushPanel
            // 
            this.RePushPanel.BackColor = System.Drawing.Color.LightYellow;
            this.RePushPanel.Controls.Add(this.TipsLabel);
            this.RePushPanel.Controls.Add(this.PushBtn);
            this.RePushPanel.Controls.Add(this.SqidBox);
            this.RePushPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RePushPanel.Location = new System.Drawing.Point(0, 0);
            this.RePushPanel.Name = "RePushPanel";
            this.RePushPanel.Size = new System.Drawing.Size(1565, 1034);
            this.RePushPanel.TabIndex = 1;
            this.RePushPanel.Visible = false;
            // 
            // SqidBox
            // 
            this.SqidBox.Location = new System.Drawing.Point(12, 60);
            this.SqidBox.Name = "SqidBox";
            this.SqidBox.Size = new System.Drawing.Size(645, 28);
            this.SqidBox.TabIndex = 0;
            // 
            // PushBtn
            // 
            this.PushBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.PushBtn.Location = new System.Drawing.Point(680, 58);
            this.PushBtn.Name = "PushBtn";
            this.PushBtn.Size = new System.Drawing.Size(64, 36);
            this.PushBtn.TabIndex = 1;
            this.PushBtn.Text = "刷新";
            this.PushBtn.UseVisualStyleBackColor = false;
            this.PushBtn.Click += new System.EventHandler(this.PushData);
            // 
            // TipsLabel
            // 
            this.TipsLabel.AutoSize = true;
            this.TipsLabel.ForeColor = System.Drawing.Color.Red;
            this.TipsLabel.Location = new System.Drawing.Point(13, 23);
            this.TipsLabel.Name = "TipsLabel";
            this.TipsLabel.Size = new System.Drawing.Size(692, 18);
            this.TipsLabel.TabIndex = 2;
            this.TipsLabel.Text = "提示：申请ID(条码号)中间使用“，”、“,”、“；”、“;”、“、”以及空格分开";
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
            this.Text = "工作小助手 By 无名";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.imgPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.ShowPanel.ResumeLayout(false);
            this.ShowPanel.PerformLayout();
            this.TopMainPanel.ResumeLayout(false);
            this.TopMainPanel.PerformLayout();
            this.TopLeftPanel.ResumeLayout(false);
            this.TopLeftPanel.PerformLayout();
            this.TopRightPanel.ResumeLayout(false);
            this.RePushPanel.ResumeLayout(false);
            this.RePushPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel imgPanel;//
        private PictureBox imgBox;
        private Button imgBtn;
        private Panel LeftPanel;//左边画布
        private Panel TopMainPanel;//左边顶部按钮画布
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
        private ComboBox imgComboBox;
        private Panel TopLeftPanel;
        private Panel TopRightPanel;
        private Button RePushBtn;
        private Panel RePushPanel;
        private TextBox SqidBox;
        private Button PushBtn;
        private Label TipsLabel;
    }
}

