namespace pattern_cutter
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuFile = new System.Windows.Forms.MenuItem();
            this.menuItemNewSheet = new System.Windows.Forms.MenuItem();
            this.menuItemOpenSheet = new System.Windows.Forms.MenuItem();
            this.menuItemSaveSheet = new System.Windows.Forms.MenuItem();
            this.menuItemSaveSheetAs = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItemExit = new System.Windows.Forms.MenuItem();
            this.menuHelp = new System.Windows.Forms.MenuItem();
            this.menuItemAbout = new System.Windows.Forms.MenuItem();
            this.menuLibrary = new System.Windows.Forms.MenuItem();
            this.menuSheet = new System.Windows.Forms.MenuItem();
            this.menuItemLibraryNewPattern = new System.Windows.Forms.MenuItem();
            this.menuItemSheetNewPattern = new System.Windows.Forms.MenuItem();
            this.menuItemSheetAddPattern = new System.Windows.Forms.MenuItem();
            this.ilLibrary = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.lvLibrary = new System.Windows.Forms.ListView();
            this.lblDPI = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTargetSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSizeWithOverscan = new System.Windows.Forms.ToolStripStatusLabel();
            this.lvSheet = new System.Windows.Forms.ListView();
            this.ilSheet = new System.Windows.Forms.ImageList(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItemPrint = new System.Windows.Forms.MenuItem();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFile,
            this.menuSheet,
            this.menuLibrary,
            this.menuHelp});
            // 
            // menuFile
            // 
            this.menuFile.Index = 0;
            this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemNewSheet,
            this.menuItemOpenSheet,
            this.menuItemSaveSheet,
            this.menuItemSaveSheetAs,
            this.menuItem5,
            this.menuItemPrint,
            this.menuItem1,
            this.menuItemExit});
            this.menuFile.Text = "&File";
            // 
            // menuItemNewSheet
            // 
            this.menuItemNewSheet.Index = 0;
            this.menuItemNewSheet.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.menuItemNewSheet.Text = "&New Sheet";
            // 
            // menuItemOpenSheet
            // 
            this.menuItemOpenSheet.Index = 1;
            this.menuItemOpenSheet.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.menuItemOpenSheet.Text = "&Open Sheet";
            // 
            // menuItemSaveSheet
            // 
            this.menuItemSaveSheet.Index = 2;
            this.menuItemSaveSheet.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.menuItemSaveSheet.Text = "&Save Sheet";
            // 
            // menuItemSaveSheetAs
            // 
            this.menuItemSaveSheetAs.Index = 3;
            this.menuItemSaveSheetAs.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS;
            this.menuItemSaveSheetAs.Text = "Save Sheet &As...";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 4;
            this.menuItem5.Text = "-";
            // 
            // menuItemExit
            // 
            this.menuItemExit.Index = 7;
            this.menuItemExit.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.menuItemExit.Text = "E&xit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.Index = 3;
            this.menuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemAbout});
            this.menuHelp.Text = "&Help";
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Index = 0;
            this.menuItemAbout.Text = "&About";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // menuLibrary
            // 
            this.menuLibrary.Index = 2;
            this.menuLibrary.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemLibraryNewPattern});
            this.menuLibrary.Text = "&Library";
            // 
            // menuSheet
            // 
            this.menuSheet.Index = 1;
            this.menuSheet.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemSheetNewPattern,
            this.menuItemSheetAddPattern});
            this.menuSheet.Text = "&Sheet";
            // 
            // menuItemLibraryNewPattern
            // 
            this.menuItemLibraryNewPattern.Index = 0;
            this.menuItemLibraryNewPattern.Text = "&New Pattern...";
            this.menuItemLibraryNewPattern.Click += new System.EventHandler(this.menuItemLibraryNewPattern_Click);
            // 
            // menuItemSheetNewPattern
            // 
            this.menuItemSheetNewPattern.Index = 0;
            this.menuItemSheetNewPattern.Text = "&New Pattern...";
            // 
            // menuItemSheetAddPattern
            // 
            this.menuItemSheetAddPattern.Index = 1;
            this.menuItemSheetAddPattern.Text = "&Add Pattern";
            // 
            // ilLibrary
            // 
            this.ilLibrary.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilLibrary.ImageSize = new System.Drawing.Size(48, 48);
            this.ilLibrary.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDPI,
            this.lblTargetSize,
            this.lblSizeWithOverscan});
            this.statusStrip1.Location = new System.Drawing.Point(0, 476);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(874, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.lvSheet);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.lvLibrary);
            this.splitContainer.Size = new System.Drawing.Size(874, 476);
            this.splitContainer.SplitterDistance = 657;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 2;
            // 
            // lvLibrary
            // 
            this.lvLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLibrary.LargeImageList = this.ilLibrary;
            this.lvLibrary.Location = new System.Drawing.Point(0, 0);
            this.lvLibrary.Name = "lvLibrary";
            this.lvLibrary.Size = new System.Drawing.Size(214, 474);
            this.lvLibrary.TabIndex = 1;
            this.lvLibrary.UseCompatibleStateImageBehavior = false;
            // 
            // lblDPI
            // 
            this.lblDPI.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblDPI.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblDPI.Name = "lblDPI";
            this.lblDPI.Size = new System.Drawing.Size(53, 19);
            this.lblDPI.Text = "DPI: 300";
            // 
            // lblTargetSize
            // 
            this.lblTargetSize.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblTargetSize.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblTargetSize.Name = "lblTargetSize";
            this.lblTargetSize.Size = new System.Drawing.Size(100, 19);
            this.lblTargetSize.Text = "Target Size: 1.25\"";
            // 
            // lblSizeWithOverscan
            // 
            this.lblSizeWithOverscan.Name = "lblSizeWithOverscan";
            this.lblSizeWithOverscan.Size = new System.Drawing.Size(131, 19);
            this.lblSizeWithOverscan.Text = "Size with Overscan: 1.5\"";
            // 
            // lvSheet
            // 
            this.lvSheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSheet.LargeImageList = this.ilSheet;
            this.lvSheet.Location = new System.Drawing.Point(0, 0);
            this.lvSheet.Name = "lvSheet";
            this.lvSheet.Size = new System.Drawing.Size(655, 474);
            this.lvSheet.TabIndex = 2;
            this.lvSheet.UseCompatibleStateImageBehavior = false;
            // 
            // ilSheet
            // 
            this.ilSheet.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilSheet.ImageSize = new System.Drawing.Size(48, 48);
            this.ilSheet.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 6;
            this.menuItem1.Text = "-";
            // 
            // menuItemPrint
            // 
            this.menuItemPrint.Index = 5;
            this.menuItemPrint.Text = "Print...";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(874, 500);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu = this.mainMenu;
            this.Name = "Main";
            this.Text = "Pattern Cutter";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem menuFile;
        private System.Windows.Forms.MenuItem menuItemNewSheet;
        private System.Windows.Forms.MenuItem menuItemOpenSheet;
        private System.Windows.Forms.MenuItem menuItemSaveSheet;
        private System.Windows.Forms.MenuItem menuItemSaveSheetAs;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItemExit;
        private System.Windows.Forms.MenuItem menuHelp;
        private System.Windows.Forms.MenuItem menuItemAbout;
        private System.Windows.Forms.MenuItem menuSheet;
        private System.Windows.Forms.MenuItem menuLibrary;
        private System.Windows.Forms.MenuItem menuItemLibraryNewPattern;
        private System.Windows.Forms.MenuItem menuItemSheetNewPattern;
        private System.Windows.Forms.MenuItem menuItemSheetAddPattern;
        private System.Windows.Forms.ImageList ilLibrary;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ListView lvLibrary;
        private System.Windows.Forms.ToolStripStatusLabel lblDPI;
        private System.Windows.Forms.ToolStripStatusLabel lblTargetSize;
        private System.Windows.Forms.ToolStripStatusLabel lblSizeWithOverscan;
        private System.Windows.Forms.ListView lvSheet;
        private System.Windows.Forms.ImageList ilSheet;
        private System.Windows.Forms.MenuItem menuItemPrint;
        private System.Windows.Forms.MenuItem menuItem1;
    }
}

