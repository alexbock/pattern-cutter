using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pattern_cutter
{
    public partial class Main : Form
    {
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
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PatternEditor pe = new PatternEditor();
                Image image = Bitmap.FromFile(ofd.FileName);
                pe.Source = image;
                if (pe.ShowDialog() == DialogResult.OK)
                {
                    Pattern p = pe.MakePattern();
                    // TODO Add to library
                    return p;
                }
            }
            return null;
        }

        private void menuItemLibraryNewPattern_Click(object sender, EventArgs e)
        {
            CreateNewPattern();
        }
    }
}
