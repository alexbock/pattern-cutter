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

        public Pattern MakePattern()
        {
            if (selector.Selection.Size.Width == 0 || selector.Selection.Size.Height == 0) return null;
            return new Pattern(txtName.Text, Source, selector.Selection);
        }

        private void PatternEditor_Load(object sender, EventArgs e)
        {
            txtName.SelectAll();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
