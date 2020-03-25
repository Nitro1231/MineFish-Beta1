namespace MineFish {
    partial class Main {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.closePanel = new System.Windows.Forms.Panel();
            this.minPanel = new System.Windows.Forms.Panel();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.uiTimer = new System.Windows.Forms.Timer(this.components);
            this.socialPanel = new System.Windows.Forms.Panel();
            this.discordBox = new System.Windows.Forms.PictureBox();
            this.youtubeBox = new System.Windows.Forms.PictureBox();
            this.githubBox = new System.Windows.Forms.PictureBox();
            this.mailBox = new System.Windows.Forms.PictureBox();
            this.blogBox = new System.Windows.Forms.PictureBox();
            this.webBox = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.macroBox = new System.Windows.Forms.PictureBox();
            this.startTimer = new System.Windows.Forms.Timer(this.components);
            this.helpLabel = new System.Windows.Forms.Label();
            this.socialPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discordBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.youtubeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.githubBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.macroBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(5, 80);
            this.sidePanel.TabIndex = 0;
            this.sidePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // closePanel
            // 
            this.closePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.closePanel.Location = new System.Drawing.Point(378, 2);
            this.closePanel.Margin = new System.Windows.Forms.Padding(1);
            this.closePanel.Name = "closePanel";
            this.closePanel.Size = new System.Drawing.Size(20, 20);
            this.closePanel.TabIndex = 1;
            this.closePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClosePanel_MouseDown);
            // 
            // minPanel
            // 
            this.minPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.minPanel.Location = new System.Drawing.Point(354, 2);
            this.minPanel.Name = "minPanel";
            this.minPanel.Size = new System.Drawing.Size(20, 20);
            this.minPanel.TabIndex = 2;
            this.minPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MinPanel_MouseDown);
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 300;
            this.mainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // uiTimer
            // 
            this.uiTimer.Interval = 200;
            this.uiTimer.Tick += new System.EventHandler(this.UiTimer_Tick);
            // 
            // socialPanel
            // 
            this.socialPanel.Controls.Add(this.discordBox);
            this.socialPanel.Controls.Add(this.youtubeBox);
            this.socialPanel.Controls.Add(this.githubBox);
            this.socialPanel.Controls.Add(this.mailBox);
            this.socialPanel.Controls.Add(this.blogBox);
            this.socialPanel.Controls.Add(this.webBox);
            this.socialPanel.Location = new System.Drawing.Point(220, 50);
            this.socialPanel.Name = "socialPanel";
            this.socialPanel.Size = new System.Drawing.Size(180, 30);
            this.socialPanel.TabIndex = 4;
            // 
            // discordBox
            // 
            this.discordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.discordBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.discordBox.Image = global::MineFish.Properties.Resources.icons8_discord_30;
            this.discordBox.Location = new System.Drawing.Point(150, 0);
            this.discordBox.Name = "discordBox";
            this.discordBox.Size = new System.Drawing.Size(30, 30);
            this.discordBox.TabIndex = 5;
            this.discordBox.TabStop = false;
            this.discordBox.Click += new System.EventHandler(this.DiscordBox_Click);
            this.discordBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // youtubeBox
            // 
            this.youtubeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.youtubeBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.youtubeBox.Image = global::MineFish.Properties.Resources.icons8_play_button_30;
            this.youtubeBox.Location = new System.Drawing.Point(120, 0);
            this.youtubeBox.Name = "youtubeBox";
            this.youtubeBox.Size = new System.Drawing.Size(30, 30);
            this.youtubeBox.TabIndex = 4;
            this.youtubeBox.TabStop = false;
            this.youtubeBox.Click += new System.EventHandler(this.YoutubeBox_Click);
            this.youtubeBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // githubBox
            // 
            this.githubBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.githubBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.githubBox.Image = global::MineFish.Properties.Resources.icons8_github_30;
            this.githubBox.Location = new System.Drawing.Point(90, 0);
            this.githubBox.Name = "githubBox";
            this.githubBox.Size = new System.Drawing.Size(30, 30);
            this.githubBox.TabIndex = 3;
            this.githubBox.TabStop = false;
            this.githubBox.Click += new System.EventHandler(this.GithubBox_Click);
            this.githubBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // mailBox
            // 
            this.mailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.mailBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.mailBox.Image = global::MineFish.Properties.Resources.icons8_email_30;
            this.mailBox.Location = new System.Drawing.Point(60, 0);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(30, 30);
            this.mailBox.TabIndex = 2;
            this.mailBox.TabStop = false;
            this.mailBox.Click += new System.EventHandler(this.MailBox_Click);
            this.mailBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // blogBox
            // 
            this.blogBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.blogBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.blogBox.Image = global::MineFish.Properties.Resources.icons8_book_shelf_30;
            this.blogBox.Location = new System.Drawing.Point(30, 0);
            this.blogBox.Name = "blogBox";
            this.blogBox.Size = new System.Drawing.Size(30, 30);
            this.blogBox.TabIndex = 1;
            this.blogBox.TabStop = false;
            this.blogBox.Click += new System.EventHandler(this.BlogBox_Click);
            this.blogBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // webBox
            // 
            this.webBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.webBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.webBox.Image = global::MineFish.Properties.Resources.icons8_internet_30;
            this.webBox.Location = new System.Drawing.Point(0, 0);
            this.webBox.Name = "webBox";
            this.webBox.Size = new System.Drawing.Size(30, 30);
            this.webBox.TabIndex = 0;
            this.webBox.TabStop = false;
            this.webBox.Click += new System.EventHandler(this.WebBox_Click);
            this.webBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(12, 5);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(265, 17);
            this.title.TabIndex = 5;
            this.title.Text = "MineFish - Auto Fishing Macro for Minecraft";
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(78, 30);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(136, 45);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "00:00:00";
            this.timeLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // macroBox
            // 
            this.macroBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.macroBox.Image = global::MineFish.Properties.Resources.icons8_play_50;
            this.macroBox.Location = new System.Drawing.Point(15, 30);
            this.macroBox.Name = "macroBox";
            this.macroBox.Size = new System.Drawing.Size(50, 50);
            this.macroBox.TabIndex = 8;
            this.macroBox.TabStop = false;
            this.macroBox.Click += new System.EventHandler(this.MacroBox_Click);
            // 
            // startTimer
            // 
            this.startTimer.Interval = 1000;
            this.startTimer.Tick += new System.EventHandler(this.StartTimer_Tick);
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.Location = new System.Drawing.Point(271, 30);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(126, 17);
            this.helpLabel.TabIndex = 9;
            this.helpLabel.Text = "\'ESC\' to stop macro.";
            this.helpLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(400, 80);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.macroBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.title);
            this.Controls.Add(this.socialPanel);
            this.Controls.Add(this.minPanel);
            this.Controls.Add(this.closePanel);
            this.Controls.Add(this.sidePanel);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "MineFish";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.socialPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.discordBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.youtubeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.githubBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.macroBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel closePanel;
        private System.Windows.Forms.Panel minPanel;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Timer uiTimer;
        private System.Windows.Forms.Panel socialPanel;
        private System.Windows.Forms.PictureBox discordBox;
        private System.Windows.Forms.PictureBox youtubeBox;
        private System.Windows.Forms.PictureBox githubBox;
        private System.Windows.Forms.PictureBox mailBox;
        private System.Windows.Forms.PictureBox blogBox;
        private System.Windows.Forms.PictureBox webBox;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.PictureBox macroBox;
        private System.Windows.Forms.Timer startTimer;
        private System.Windows.Forms.Label helpLabel;
    }
}

