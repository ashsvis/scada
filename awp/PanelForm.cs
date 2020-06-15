using awp.View;
using System;
using System.Windows.Forms;

namespace awp
{
    public partial class PanelForm : Form
    {

        public bool Primary { get; set; }

        public MainForm Host { get; set; }

        public PanelForm()
        {
            InitializeComponent();
        }

        private void PanelForm_Load(object sender, EventArgs e)
        {
            UpdateClock();
        }

        private void PanelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Пользователь не может при помощи Alt+F4 завершить приложение
            if (e.CloseReason == CloseReason.UserClosing) e.Cancel = true;
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Host.Close();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            UpdateClock();
        }

        private void UpdateClock()
        {
            lbSystemTime.Text = DateTime.Now.ToString("dd.MM.yyyy ddd HH.mm.ss");
        }

        private void tsmiDatabaseEditor_Click(object sender, EventArgs e)
        {
            pnlWorkplace.Controls.Clear();
            pnlWorkplace.Controls.Add(new ucBrowserDatabase() { Dock = DockStyle.Fill });
        }
    }
}
