using core;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Permissions;
using System.Windows.Forms;

namespace awp
{
    public partial class MainForm : Form
    {
        private static PanelForm[] _panels = new PanelForm[] { };

        private ModbusTcpChannel tcpChannel;
        private ModbusTcpChannel tcpChannel1;

        public MainForm()
        {
            InitializeComponent();
            Size = new Size();
            Location = new Point();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            #region Защита от повторного запуска
            var process = RunningInstance();
            if (process != null) { Application.Exit(); return; }
            #endregion
            tcpChannel = new ModbusTcpChannel();
            tcpChannel.AddToQueue(new ModbusRegister() { Active = true });
            tcpChannel.AddToQueue(new ModbusInput() { Active = true });

            tcpChannel.Open();

            tcpChannel1 = new ModbusTcpChannel("192.168.0.22");
            tcpChannel1.Open();

            LoadPanelForms();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            tcpChannel.Close();
            tcpChannel1.Close();
        }

        private void LoadPanelForms()
        {
            var monitors = Screen.AllScreens;
            _panels = new PanelForm[monitors.Length];
            for (var i = 0; i < monitors.Length; i++)
            {
                var bounds = monitors[i].Bounds;
                _panels[i] = new PanelForm
                {
                    Host = this,
                    Primary = monitors[i].Primary,
                    FormBorderStyle = FormBorderStyle.None,
                    Left = bounds.X,
                    Top = bounds.Y,
                    Width = bounds.Width,
                    Height = bounds.Height
                };
                _panels[i].Show(this);
            }
        }

        [EnvironmentPermission(SecurityAction.LinkDemand, Unrestricted = true)]
        private static Process RunningInstance()
        {
            var current = Process.GetCurrentProcess();
            var processes = Process.GetProcessesByName(current.ProcessName);
            // Просматриваем все процессы
            return processes.Where(process => process.Id != current.Id).
                FirstOrDefault(process => Assembly.GetExecutingAssembly().
                    Location.Replace("/", "\\") == current.MainModule.FileName);
            // нет, таких процессов не найдено
        }

    }
}
