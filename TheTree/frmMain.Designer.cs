
namespace TheTree
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonToolStrip1 = new Krypton.Toolkit.KryptonToolStrip();
            this.cmdConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.kryptonNavigator1 = new Krypton.Navigator.KryptonNavigator();
            this.pgMain = new Krypton.Navigator.KryptonPage();
            this.kryptonSplitContainer1 = new Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonSplitContainer2 = new Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonTreeView1 = new Krypton.Toolkit.KryptonTreeView();
            this.kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonSplitContainer3 = new Krypton.Toolkit.KryptonSplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pgGroup = new Krypton.Navigator.KryptonPage();
            this.logListView = new System.Windows.Forms.ListView();
            this.dt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventss = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mnuMain.SuspendLayout();
            this.kryptonToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).BeginInit();
            this.kryptonNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pgMain)).BeginInit();
            this.pgMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel1)).BeginInit();
            this.kryptonSplitContainer2.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel2)).BeginInit();
            this.kryptonSplitContainer2.Panel2.SuspendLayout();
            this.kryptonSplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer3.Panel1)).BeginInit();
            this.kryptonSplitContainer3.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer3.Panel2)).BeginInit();
            this.kryptonSplitContainer3.Panel2.SuspendLayout();
            this.kryptonSplitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(912, 24);
            this.mnuMain.TabIndex = 3;
            this.mnuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // kryptonToolStrip1
            // 
            this.kryptonToolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kryptonToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdConnect,
            this.toolStripButton2,
            this.toolStripButton3});
            this.kryptonToolStrip1.Location = new System.Drawing.Point(0, 24);
            this.kryptonToolStrip1.Name = "kryptonToolStrip1";
            this.kryptonToolStrip1.Size = new System.Drawing.Size(912, 25);
            this.kryptonToolStrip1.TabIndex = 4;
            this.kryptonToolStrip1.Text = "kryptonToolStrip1";
            // 
            // cmdConnect
            // 
            this.cmdConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdConnect.Image = ((System.Drawing.Image)(resources.GetObject("cmdConnect.Image")));
            this.cmdConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.Size = new System.Drawing.Size(23, 22);
            this.cmdConnect.Text = "toolStripButton1";
            this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // kryptonNavigator1
            // 
            this.kryptonNavigator1.Bar.BarMapImage = Krypton.Navigator.MapKryptonPageImage.SmallMedium;
            this.kryptonNavigator1.Bar.ItemSizing = Krypton.Navigator.BarItemSizing.SameWidthAndHeight;
            this.kryptonNavigator1.Bar.TabBorderStyle = Krypton.Toolkit.TabBorderStyle.SquareEqualMedium;
            this.kryptonNavigator1.Button.CloseButtonDisplay = Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonNavigator1.Location = new System.Drawing.Point(0, 49);
            this.kryptonNavigator1.Name = "kryptonNavigator1";
            this.kryptonNavigator1.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.ButtonStandalone;
            this.kryptonNavigator1.Pages.AddRange(new Krypton.Navigator.KryptonPage[] {
            this.pgMain,
            this.pgGroup});
            this.kryptonNavigator1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonNavigator1.SelectedIndex = 0;
            this.kryptonNavigator1.Size = new System.Drawing.Size(912, 424);
            this.kryptonNavigator1.TabIndex = 5;
            this.kryptonNavigator1.Text = "kryptonNavigator1";
            // 
            // pgMain
            // 
            this.pgMain.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pgMain.Controls.Add(this.kryptonSplitContainer1);
            this.pgMain.Flags = 65534;
            this.pgMain.LastVisibleSet = true;
            this.pgMain.MinimumSize = new System.Drawing.Size(50, 50);
            this.pgMain.Name = "pgMain";
            this.pgMain.Size = new System.Drawing.Size(910, 398);
            this.pgMain.Text = "Основная";
            this.pgMain.ToolTipTitle = "Page ToolTip";
            this.pgMain.UniqueName = "7e6c170a32ea4737b32a1b4748bb9bf8";
            // 
            // kryptonSplitContainer1
            // 
            this.kryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.kryptonSplitContainer1.Name = "kryptonSplitContainer1";
            this.kryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // kryptonSplitContainer1.Panel1
            // 
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.kryptonSplitContainer2);
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.kryptonSplitContainer3);
            this.kryptonSplitContainer1.SeparatorStyle = Krypton.Toolkit.SeparatorStyle.HighProfile;
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(910, 398);
            this.kryptonSplitContainer1.SplitterDistance = 265;
            this.kryptonSplitContainer1.TabIndex = 0;
            // 
            // kryptonSplitContainer2
            // 
            this.kryptonSplitContainer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.kryptonSplitContainer2.Name = "kryptonSplitContainer2";
            // 
            // kryptonSplitContainer2.Panel1
            // 
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonTreeView1);
            this.kryptonSplitContainer2.Panel1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            // 
            // kryptonSplitContainer2.Panel2
            // 
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.kryptonDataGridView1);
            this.kryptonSplitContainer2.Panel2.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonSplitContainer2.Size = new System.Drawing.Size(910, 265);
            this.kryptonSplitContainer2.SplitterDistance = 303;
            this.kryptonSplitContainer2.TabIndex = 0;
            // 
            // kryptonTreeView1
            // 
            this.kryptonTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTreeView1.Location = new System.Drawing.Point(0, 0);
            this.kryptonTreeView1.Name = "kryptonTreeView1";
            this.kryptonTreeView1.Size = new System.Drawing.Size(303, 265);
            this.kryptonTreeView1.TabIndex = 0;
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.Size = new System.Drawing.Size(602, 265);
            this.kryptonDataGridView1.TabIndex = 0;
            // 
            // kryptonSplitContainer3
            // 
            this.kryptonSplitContainer3.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer3.Location = new System.Drawing.Point(0, 0);
            this.kryptonSplitContainer3.Name = "kryptonSplitContainer3";
            // 
            // kryptonSplitContainer3.Panel1
            // 
            this.kryptonSplitContainer3.Panel1.Controls.Add(this.pictureBox1);
            this.kryptonSplitContainer3.Panel1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            // 
            // kryptonSplitContainer3.Panel2
            // 
            this.kryptonSplitContainer3.Panel2.Controls.Add(this.logListView);
            this.kryptonSplitContainer3.Panel2.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonSplitContainer3.SeparatorStyle = Krypton.Toolkit.SeparatorStyle.HighProfile;
            this.kryptonSplitContainer3.Size = new System.Drawing.Size(910, 128);
            this.kryptonSplitContainer3.SplitterDistance = 342;
            this.kryptonSplitContainer3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pgGroup
            // 
            this.pgGroup.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pgGroup.Flags = 65534;
            this.pgGroup.LastVisibleSet = true;
            this.pgGroup.MinimumSize = new System.Drawing.Size(50, 50);
            this.pgGroup.Name = "pgGroup";
            this.pgGroup.Size = new System.Drawing.Size(910, 351);
            this.pgGroup.Text = "Группы";
            this.pgGroup.ToolTipTitle = "Page ToolTip";
            this.pgGroup.UniqueName = "8881e8769e664cc6adfe8d5d15a91b06";
            // 
            // logListView
            // 
            this.logListView.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.logListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dt,
            this.eventss});
            this.logListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logListView.FullRowSelect = true;
            this.logListView.GridLines = true;
            this.logListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.logListView.HideSelection = false;
            this.logListView.Location = new System.Drawing.Point(0, 0);
            this.logListView.Name = "logListView";
            this.logListView.Size = new System.Drawing.Size(563, 128);
            this.logListView.TabIndex = 0;
            this.logListView.UseCompatibleStateImageBehavior = false;
            this.logListView.View = System.Windows.Forms.View.Details;
            // 
            // dt
            // 
            this.dt.Text = "Дата";
            // 
            // eventss
            // 
            this.eventss.Text = "События";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 473);
            this.Controls.Add(this.kryptonNavigator1);
            this.Controls.Add(this.kryptonToolStrip1);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.Text = "TheTree";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.kryptonToolStrip1.ResumeLayout(false);
            this.kryptonToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            this.kryptonNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pgMain)).EndInit();
            this.pgMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel1)).EndInit();
            this.kryptonSplitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel2)).EndInit();
            this.kryptonSplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2)).EndInit();
            this.kryptonSplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer3.Panel1)).EndInit();
            this.kryptonSplitContainer3.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer3.Panel2)).EndInit();
            this.kryptonSplitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer3)).EndInit();
            this.kryptonSplitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private Krypton.Toolkit.KryptonToolStrip kryptonToolStrip1;
        private System.Windows.Forms.ToolStripButton cmdConnect;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private Krypton.Navigator.KryptonPage pgMain;
        private Krypton.Navigator.KryptonPage pgGroup;
        private Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer2;
        private Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer3;
        private Krypton.Toolkit.KryptonTreeView kryptonTreeView1;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView logListView;
        private System.Windows.Forms.ColumnHeader dt;
        private System.Windows.Forms.ColumnHeader eventss;
    }
}

