using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pattern_cutter
{
    public partial class Main : Form
    {
        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        private extern static int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

        List<Pattern> patterns = new List<Pattern>();
        String filename = "Untitled";
        bool unsavedChanges = false;

        Configuration config = new Configuration();

        public Main()
        {
            InitializeComponent();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pattern Cutter is open source software written by Alex Bock and released under the MIT license." +
                "\n\nFugue Icons (C) 2013 Yusuke Kamiyamane. All rights reserved.", "Pattern Cutter v1.01");
        }

        private Pattern CreateNewPattern()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.png;*.jpeg;*.jpg;*.bmp;*.gif";
            ofd.Title = "Open Image";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PatternEditor pe = new PatternEditor();
                Image image = Bitmap.FromFile(ofd.FileName);
                pe.Source = image;
                var result = pe.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Pattern p = pe.MakePattern();
                    return p;
                }
            }
            return null;
        }

        private void AddPattern(Pattern pattern)
        {
            if (pattern == null) return;
            patterns.Add(pattern);
            Bitmap cropped = new Bitmap(pattern.SourceRegion.Width, pattern.SourceRegion.Height);
            Graphics g = Graphics.FromImage(cropped);
            g.DrawImage(pattern.Source, new Rectangle(0, 0, cropped.Width, cropped.Height), pattern.SourceRegion, GraphicsUnit.Pixel);
            ilSheet.Images.Add(cropped);
            ListViewItem lvi = new ListViewItem();
            lvSheet.Items.Add(pattern.Name, ilSheet.Images.Count - 1);
            lvSheet.Items[lvSheet.Items.Count - 1].Tag = pattern;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPattern(CreateNewPattern());
            unsavedChanges = true;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            SetWindowTheme(lvSheet.Handle, "explorer", null);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvSheet.SelectedItems)
            {
                patterns.Remove((Pattern)item.Tag);
                lvSheet.Items.Remove(item);
            }
            unsavedChanges = true;
        }

        private void btnDuplicate_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvSheet.SelectedItems)
            {
                Pattern pattern = (Pattern)item.Tag;
                Pattern copy = new Pattern(pattern.Name, (Image)pattern.Source.Clone(), pattern.SourceRegion);
                AddPattern(copy);
            }
            unsavedChanges = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void ClearSheet()
        {
            filename = "untitled";
            lvSheet.Clear();
            patterns.Clear();
            ilSheet.Images.Clear();
            UpdateFilename();
            unsavedChanges = false;
        }

        private bool ConfirmClear()
        {
#if false
            if (!unsavedChanges) return true;
            var r = MessageBox.Show("You have unsaved changes; are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return r == DialogResult.Yes;
#endif
            return true;
        }

        private void menuItemNewSheet_Click(object sender, EventArgs e)
        {
            if (!ConfirmClear()) return;
            ClearSheet();
        }

        private void menuItemOpenSheet_Click(object sender, EventArgs e)
        {
            if (!ConfirmClear()) return;
            ClearSheet();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Pattern Cutter Sheets|*.pcs";
            ofd.Title = "Open Sheet";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filename = ofd.FileName;
                UpdateFilename();
                using (FileStream file = new FileStream(filename, FileMode.Open))
                {
                    using (BinaryReader br = new BinaryReader(file))
                    {
                        int count = br.ReadInt32();
                        for (int i = 0; i < count; ++i)
                        {
                            String name = br.ReadString();
                            double overscan = br.ReadDouble();
                            int srx = br.ReadInt32();
                            int sry = br.ReadInt32();
                            int srw = br.ReadInt32();
                            int srh = br.ReadInt32();
                            long dataLength = br.ReadInt64();
                            byte[] imgData = br.ReadBytes((int)dataLength);
                            MemoryStream imgStream = new MemoryStream(imgData);
                            Image image = Image.FromStream(imgStream);
                            Pattern pattern = new Pattern(name, image, new Rectangle(srx, sry, srw, srh));
                            pattern.Overscan = overscan;
                            AddPattern(pattern);
                        }
                    }
                }
            }
        }

        private void menuItemSaveSheet_Click(object sender, EventArgs e)
        {
            if (filename == "untitled")
            {
                menuItemSaveSheetAs_Click(sender, e);
            }
            else
            {
                unsavedChanges = false;
                using (FileStream file = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    using (BinaryWriter writer = new BinaryWriter(file))
                    {
                        writer.Write(lvSheet.Items.Count);
                        foreach (Pattern pattern in patterns)
                        {
                            writer.Write(pattern.Name);
                            writer.Write(pattern.Overscan);
                            writer.Write(pattern.SourceRegion.X);
                            writer.Write(pattern.SourceRegion.Y);
                            writer.Write(pattern.SourceRegion.Width);
                            writer.Write(pattern.SourceRegion.Height);
                            using (MemoryStream mem = new MemoryStream())
                            {
                                pattern.Source.Save(mem, System.Drawing.Imaging.ImageFormat.Png);
                                writer.Write(mem.Length);
                                writer.Write(mem.ToArray());
                            }
                        }
                    }
                }
            }
        }

        private void menuItemSaveSheetAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Pattern Cutter Sheets|*.pcs";
            sfd.Title = "Save Sheet";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                filename = sfd.FileName;
                UpdateFilename();
                menuItemSaveSheet_Click(sender, e);
            }
        }

        private void menuItemAddPattern_Click(object sender, EventArgs e)
        {
            AddPattern(CreateNewPattern());
        }

        private Image PrepareForExport()
        {
            int paperWidth = (int)(config.PaperWidthInches * config.DPI);
            int paperHeight = (int)(config.PaperHeightInches * config.DPI);
            Bitmap surface = new Bitmap(paperWidth, paperHeight);
            Graphics g = Graphics.FromImage(surface);
            g.FillRectangle(Brushes.White, 0, 0, surface.Width, surface.Height);
            Point put = Point.Empty;
            foreach (ListViewItem item in lvSheet.Items)
            {
                Pattern pattern = (Pattern)item.Tag;
                int patternWidth = (int)(pattern.SourceRegion.Width * (1.0 + pattern.Overscan));
                int patternHeight = (int)(pattern.SourceRegion.Height * (1.0 + pattern.Overscan));
                int diffX = patternWidth - pattern.SourceRegion.Width;
                int diffY = patternHeight - pattern.SourceRegion.Height;
                Rectangle source = pattern.SourceRegion;
                source.X -= diffX / 2;
                source.Width = patternWidth;
                source.Y -= diffY / 2;
                source.Height = patternHeight;
                int tileSize = (int)(config.TargetInches * (1.0 + config.DefaultOverscan) * config.DPI);
                if (put.X + tileSize >= surface.Width)
                {
                    put.X = 0;
                    put.Y += tileSize;
                }
                g.DrawImage(pattern.Source, new Rectangle(put.X, put.Y, tileSize, tileSize), source, GraphicsUnit.Pixel);
                put.X += tileSize;
            }
            surface.SetResolution((float)config.DPI, (float)config.DPI);
            return surface;
        }

        private void menuItemPrint_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            pd.AllowCurrentPage = false;
            pd.AllowPrintToFile = false;
            pd.AllowSomePages = false;
            pd.AllowSelection = false;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                PrintDocument doc = new PrintDocument();
                doc.DocumentName = filename;
                doc.PrintPage += (sender_, e_) =>
                {
                    e_.Graphics.DrawImage(PrepareForExport(), Point.Empty);
                };
                doc.Print();
            }
        }

        private void menuItemExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Export...";
            sfd.Filter = "PNG Files|*.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                PrepareForExport().Save(sfd.FileName);
            }
        }

        private void UpdateFilename()
        {
            Text = "Pattern Cutter - " + filename;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ConfirmClear()) e.Cancel = true;
        }
    }
}
