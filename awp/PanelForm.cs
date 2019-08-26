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

        private void PanelForm_Load(object sender, System.EventArgs e)
        {
            UpdateClock();
        }

        private void PanelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Пользователь не может при помощи Alt+F4 завершить приложение
            if (e.CloseReason == CloseReason.UserClosing) e.Cancel = true;
        }

        private void tsmiExit_Click(object sender, System.EventArgs e)
        {
            Host.Close();
        }

        private void timerClock_Tick(object sender, System.EventArgs e)
        {
            UpdateClock();
        }

        private void UpdateClock()
        {
            lbSystemTime.Text = DateTime.Now.ToString("dd.MM.yyyy ddd HH.mm.ss");
        }
    }
}
