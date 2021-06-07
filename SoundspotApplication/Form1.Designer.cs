namespace SoundspotApplication {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Playlists", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            " Foobar"}, -1, System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(241)))), ((int)(((byte)(241))))), System.Drawing.Color.Empty, new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.closeButton = new Bunifu.UI.WinForms.BunifuShapes();
            this.minimizeButton = new Bunifu.UI.WinForms.BunifuShapes();
            this.expandButton = new Bunifu.UI.WinForms.BunifuShapes();
            this.playlistView = new System.Windows.Forms.ListView();
            this.playBtn = new Siticone.UI.WinForms.SiticoneCircleButton();
            this.siticoneProgressBar1 = new Siticone.UI.WinForms.SiticoneProgressBar();
            this.siticonePanel1 = new Siticone.UI.WinForms.SiticonePanel();
            this.media_controlPanel = new Siticone.UI.WinForms.SiticonePanel();
            this.media_controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = true;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = true;
            this.bunifuFormDock1.ShowDockingIndicators = true;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // closeButton
            // 
            this.closeButton.Angle = 0F;
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BorderColor = System.Drawing.Color.Transparent;
            this.closeButton.BorderThickness = 2;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.closeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(92)))));
            this.closeButton.FillShape = true;
            this.closeButton.Location = new System.Drawing.Point(5, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Circle;
            this.closeButton.Sides = 5;
            this.closeButton.Size = new System.Drawing.Size(15, 15);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "bunifuShapes1";
            this.closeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closeButton_MouseClick);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Angle = 0F;
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.BorderColor = System.Drawing.Color.Transparent;
            this.minimizeButton.BorderThickness = 2;
            this.minimizeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(68)))));
            this.minimizeButton.FillShape = true;
            this.minimizeButton.Location = new System.Drawing.Point(25, 5);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Circle;
            this.minimizeButton.Sides = 5;
            this.minimizeButton.Size = new System.Drawing.Size(15, 15);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.Text = "bunifuShapes1";
            this.minimizeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.minimizeButton_MouseClick);
            // 
            // expandButton
            // 
            this.expandButton.Angle = 0F;
            this.expandButton.BackColor = System.Drawing.Color.Transparent;
            this.expandButton.BorderColor = System.Drawing.Color.Transparent;
            this.expandButton.BorderThickness = 2;
            this.expandButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(202)))), ((int)(((byte)(78)))));
            this.expandButton.FillShape = true;
            this.expandButton.Location = new System.Drawing.Point(45, 5);
            this.expandButton.Name = "expandButton";
            this.expandButton.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Circle;
            this.expandButton.Sides = 5;
            this.expandButton.Size = new System.Drawing.Size(15, 15);
            this.expandButton.TabIndex = 2;
            this.expandButton.Text = "bunifuShapes1";
            this.expandButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.expandButton_MouseClick);
            // 
            // playlistView
            // 
            this.playlistView.AutoArrange = false;
            this.playlistView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(76)))), ((int)(((byte)(82)))));
            this.playlistView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playlistView.Dock = System.Windows.Forms.DockStyle.Right;
            listViewGroup1.Header = "Playlists";
            listViewGroup1.Name = "Playlists";
            this.playlistView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.playlistView.HideSelection = false;
            listViewItem1.UseItemStyleForSubItems = false;
            this.playlistView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.playlistView.Location = new System.Drawing.Point(655, 0);
            this.playlistView.Name = "playlistView";
            this.playlistView.Size = new System.Drawing.Size(121, 476);
            this.playlistView.TabIndex = 3;
            this.playlistView.UseCompatibleStateImageBehavior = false;
            this.playlistView.View = System.Windows.Forms.View.List;
            this.playlistView.SelectedIndexChanged += new System.EventHandler(this.playlistView_SelectedIndexChanged);
            // 
            // playBtn
            // 
            this.playBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.playBtn.Animated = false;
            this.playBtn.BackColor = System.Drawing.Color.Transparent;
            this.playBtn.BorderRadius = 5;
            this.playBtn.CheckedState.Parent = this.playBtn;
            this.playBtn.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(107)))), ((int)(((byte)(114)))));
            this.playBtn.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.playBtn.CustomImages.Parent = this.playBtn;
            this.playBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(107)))), ((int)(((byte)(114)))));
            this.playBtn.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playBtn.ForeColor = System.Drawing.Color.White;
            this.playBtn.HoveredState.Parent = this.playBtn;
            this.playBtn.Image = global::SoundspotApplication.Properties.Resources.playIconWhite;
            this.playBtn.ImageSize = new System.Drawing.Size(10, 15);
            this.playBtn.Location = new System.Drawing.Point(312, 10);
            this.playBtn.Name = "playBtn";
            this.playBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(68)))), ((int)(((byte)(73)))));
            this.playBtn.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.playBtn.ShadowDecoration.Parent = this.playBtn;
            this.playBtn.Size = new System.Drawing.Size(30, 30);
            this.playBtn.TabIndex = 0;
            this.playBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.playBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.playBtn.Tile = false;
            this.playBtn.UseTransparentBackground = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // siticoneProgressBar1
            // 
            this.siticoneProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneProgressBar1.BorderRadius = 15;
            this.siticoneProgressBar1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.siticoneProgressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.siticoneProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.siticoneProgressBar1.Location = new System.Drawing.Point(25, 250);
            this.siticoneProgressBar1.Name = "siticoneProgressBar1";
            this.siticoneProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(82)))), ((int)(((byte)(86)))));
            this.siticoneProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(82)))), ((int)(((byte)(86)))));
            this.siticoneProgressBar1.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneProgressBar1.ShadowDecoration.Parent = this.siticoneProgressBar1;
            this.siticoneProgressBar1.Size = new System.Drawing.Size(625, 30);
            this.siticoneProgressBar1.TabIndex = 4;
            this.siticoneProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.siticoneProgressBar1.UseTransparentBackground = true;
            this.siticoneProgressBar1.Value = 99;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.AutoSize = true;
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticonePanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(94)))), ((int)(((byte)(101)))));
            this.siticonePanel1.Location = new System.Drawing.Point(0, 476);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(655, 0);
            this.siticonePanel1.TabIndex = 5;
            this.siticonePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.siticonePanel1_Paint);
            // 
            // media_controlPanel
            // 
            this.media_controlPanel.Controls.Add(this.playBtn);
            this.media_controlPanel.Location = new System.Drawing.Point(0, 425);
            this.media_controlPanel.Name = "media_controlPanel";
            this.media_controlPanel.ShadowDecoration.Parent = this.media_controlPanel;
            this.media_controlPanel.Size = new System.Drawing.Size(655, 50);
            this.media_controlPanel.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(776, 476);
            this.ControlBox = false;
            this.Controls.Add(this.media_controlPanel);
            this.Controls.Add(this.siticoneProgressBar1);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.playlistView);
            this.Controls.Add(this.expandButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.media_controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private Bunifu.UI.WinForms.BunifuShapes expandButton;
        private Bunifu.UI.WinForms.BunifuShapes minimizeButton;
        private Bunifu.UI.WinForms.BunifuShapes closeButton;
        private System.Windows.Forms.ListView playlistView;
        private Siticone.UI.WinForms.SiticonePanel media_controlPanel;
        private Siticone.UI.WinForms.SiticoneCircleButton playBtn;
        private Siticone.UI.WinForms.SiticoneProgressBar siticoneProgressBar1;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel1;
    }
}

