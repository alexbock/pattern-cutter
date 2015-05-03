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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDPI = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTargetSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSizeWithOverscan = new System.Windows.Forms.ToolStripStatusLabel();
            this.ilSheet = new System.Windows.Forms.ImageList(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItemPrint = new System.Windows.Forms.MenuItem();
            this.lvSheet = new System.Windows.Forms.ListView();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnDuplicate = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnEdit = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnRemove = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAdd = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItemAddPattern = new System.Windows.Forms.MenuItem();
            this.menuItemExport = new System.Windows.Forms.MenuItem();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFile,
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
            this.menuItemExport,
            this.menuItem2,
            this.menuItemAddPattern,
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
            this.menuItemNewSheet.Click += new System.EventHandler(this.menuItemNewSheet_Click);
            // 
            // menuItemOpenSheet
            // 
            this.menuItemOpenSheet.Index = 1;
            this.menuItemOpenSheet.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.menuItemOpenSheet.Text = "&Open Sheet...";
            this.menuItemOpenSheet.Click += new System.EventHandler(this.menuItemOpenSheet_Click);
            // 
            // menuItemSaveSheet
            // 
            this.menuItemSaveSheet.Index = 2;
            this.menuItemSaveSheet.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.menuItemSaveSheet.Text = "&Save Sheet";
            this.menuItemSaveSheet.Click += new System.EventHandler(this.menuItemSaveSheet_Click);
            // 
            // menuItemSaveSheetAs
            // 
            this.menuItemSaveSheetAs.Index = 3;
            this.menuItemSaveSheetAs.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS;
            this.menuItemSaveSheetAs.Text = "Save Sheet &As...";
            this.menuItemSaveSheetAs.Click += new System.EventHandler(this.menuItemSaveSheetAs_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 7;
            this.menuItem5.Text = "-";
            // 
            // menuItemExit
            // 
            this.menuItemExit.Index = 10;
            this.menuItemExit.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.menuItemExit.Text = "E&xit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.Index = 1;
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
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDPI,
            this.lblTargetSize,
            this.lblSizeWithOverscan,
            this.toolStripStatusLabel1,
            this.btnAdd,
            this.btnEdit,
            this.btnDuplicate,
            this.btnRemove});
            this.statusStrip1.Location = new System.Drawing.Point(0, 475);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(874, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDPI
            // 
            this.lblDPI.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblDPI.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblDPI.Name = "lblDPI";
            this.lblDPI.Size = new System.Drawing.Size(53, 20);
            this.lblDPI.Text = "DPI: 300";
            // 
            // lblTargetSize
            // 
            this.lblTargetSize.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblTargetSize.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblTargetSize.Name = "lblTargetSize";
            this.lblTargetSize.Size = new System.Drawing.Size(100, 20);
            this.lblTargetSize.Text = "Target Size: 1.25\"";
            // 
            // lblSizeWithOverscan
            // 
            this.lblSizeWithOverscan.Name = "lblSizeWithOverscan";
            this.lblSizeWithOverscan.Size = new System.Drawing.Size(131, 20);
            this.lblSizeWithOverscan.Text = "Size with Overscan: 1.5\"";
            // 
            // ilSheet
            // 
            this.ilSheet.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilSheet.ImageSize = new System.Drawing.Size(48, 48);
            this.ilSheet.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 9;
            this.menuItem1.Text = "-";
            // 
            // menuItemPrint
            // 
            this.menuItemPrint.Index = 8;
            this.menuItemPrint.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
            this.menuItemPrint.Text = "&Print...";
            this.menuItemPrint.Click += new System.EventHandler(this.menuItemPrint_Click);
            // 
            // lvSheet
            // 
            this.lvSheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSheet.LargeImageList = this.ilSheet;
            this.lvSheet.Location = new System.Drawing.Point(0, 0);
            this.lvSheet.Name = "lvSheet";
            this.lvSheet.Size = new System.Drawing.Size(874, 475);
            this.lvSheet.TabIndex = 3;
            this.lvSheet.UseCompatibleStateImageBehavior = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(301, 20);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // btnDuplicate
            // 
            this.btnDuplicate.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.btnDuplicate.Image = ((System.Drawing.Image)(resources.GetObject("btnDuplicate.Image")));
            this.btnDuplicate.Name = "btnDuplicate";
            this.btnDuplicate.Size = new System.Drawing.Size(77, 20);
            this.btnDuplicate.Text = "Duplicate";
            this.btnDuplicate.Visible = false;
            this.btnDuplicate.Click += new System.EventHandler(this.btnDuplicate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(47, 20);
            this.btnEdit.Text = "Edit";
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(70, 20);
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(49, 20);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 5;
            this.menuItem2.Text = "-";
            // 
            // menuItemAddPattern
            // 
            this.menuItemAddPattern.Index = 6;
            this.menuItemAddPattern.Shortcut = System.Windows.Forms.Shortcut.CtrlT;
            this.menuItemAddPattern.Text = "Add Pa&ttern...";
            this.menuItemAddPattern.Click += new System.EventHandler(this.menuItemAddPattern_Click);
            // 
            // menuItemExport
            // 
            this.menuItemExport.Index = 4;
            this.menuItemExport.Shortcut = System.Windows.Forms.Shortcut.CtrlE;
            this.menuItemExport.Text = "&Export as Image...";
            this.menuItemExport.Click += new System.EventHandler(this.menuItemExport_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(874, 500);
            this.Controls.Add(this.lvSheet);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Main";
            this.Text = "Pattern Cutter - untitled";
            this.Load += new System.EventHandler(this.Main_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDPI;
        private System.Windows.Forms.ToolStripStatusLabel lblTargetSize;
        private System.Windows.Forms.ToolStripStatusLabel lblSizeWithOverscan;
        private System.Windows.Forms.ImageList ilSheet;
        private System.Windows.Forms.MenuItem menuItemPrint;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.ListView lvSheet;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel btnDuplicate;
        private System.Windows.Forms.ToolStripStatusLabel btnEdit;
        private System.Windows.Forms.ToolStripStatusLabel btnRemove;
        private System.Windows.Forms.ToolStripStatusLabel btnAdd;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItemAddPattern;
        private System.Windows.Forms.MenuItem menuItemExport;
    }
}

