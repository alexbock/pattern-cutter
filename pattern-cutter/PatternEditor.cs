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
            return new Pattern(txtName.Text, Source, selector.Selection);
        }

        private void PatternEditor_Load(object sender, EventArgs e)
        {
            txtName.SelectAll();
        }
    }
}
