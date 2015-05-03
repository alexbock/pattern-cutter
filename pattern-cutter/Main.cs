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

        private void btnTest_Click(object sender, EventArgs e)
        {
            Image img = Bitmap.FromFile(@"C:\Users\alex\Desktop\img\earliest-dogs-660x433-130306-akita-660x433.jpg");
            PatternEditor pe = new PatternEditor();
            pe.Source = img;
            pe.ShowDialog();
        }
    }
}
