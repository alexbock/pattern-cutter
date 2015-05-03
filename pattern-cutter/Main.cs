using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            MessageBox.Show("Pattern Cutter is open source software written by Alex Bock and released under the MIT license.");
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
        }

        private void btnDuplicate_Click(object sender, EventArgs e)
        {
            // TODO
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
        }

        private void menuItemNewSheet_Click(object sender, EventArgs e)
        {
            ClearSheet();
        }

        private void menuItemOpenSheet_Click(object sender, EventArgs e)
        {
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

        private void menuItemPrint_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void menuItemExport_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void UpdateFilename()
        {
            Text = "Pattern Cutter - " + filename;
        }
    }
}
