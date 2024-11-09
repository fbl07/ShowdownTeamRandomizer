using System.Runtime.Versioning;

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
