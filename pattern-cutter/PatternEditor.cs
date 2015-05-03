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
    public partial class PatternEditor : Form
    {
        public PatternEditor()
        {
            InitializeComponent();
        }

        public Image Source
        {
            get
            {
                return selector.Source;
            }

            set
            {
                selector.Source = value;
            }
        }

        private void cbSelectFromCenter_CheckedChanged(object sender, EventArgs e)
        {
            selector.SelectionOrigin = cbSelectFromCenter.Checked ?
                ImageRegionSelector.SelectModeOrigin.Center :
                ImageRegionSelector.SelectModeOrigin.Corner;
        }
    }
}
