using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowdownTeamRando
{
    [SupportedOSPlatform("windows")]
    public partial class frmPasteDialog : Form
    {
        public frmPasteDialog()
        {
            InitializeComponent();
        }

        public string Paste { get; set; } = "";

        private void btnOk_Click(object sender, EventArgs e)
        {
            Paste = txtPaste.Text;
        }
    }
}
