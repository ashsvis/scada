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

        //private OPCServer opcServer;


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


            //NpgsqHelper.CreateNotExistDatabase("test");
            //NpgsqHelper.CreatePointsTable("test");

            /*
            tcpChannel = new ModbusTcpChannel();
            tcpChannel.AddToQueue(new ModbusRegister() { Active = true });
            tcpChannel.AddToQueue(new ModbusInput() { Active = true });

            tcpChannel.Open();

            tcpChannel1 = new ModbusTcpChannel("192.168.0.22");
            tcpChannel1.Open();

            opcServer = new OPCServer();
            
            object opc_servers = opcServer.GetOPCServers();
            var servers = (Array)opc_servers;
            foreach (var item in servers)
            {
                Console.WriteLine(item);
            }


            opcServer.Connect("Graybox.Simulator"); //Lectus.OPC.1

            var browser = opcServer.CreateBrowser();
            browser.ShowBranches();

            foreach (var item in browser)
            {
                Console.WriteLine(item);

            }

            // Then a Object group because to add an item changed event.
            var opcGroups = opcServer.OPCGroups;
            var opcGroup = opcGroups.Add("OPCGroup1");
            // The item changed event.
            opcGroup.DataChange += new DIOPCGroupEvent_DataChangeEventHandler(opcGroup_DataChange);
            // Now the Iteem
            try
            {
                opcGroup.OPCItems.AddItem("numeric.random.double", 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // Update rate and other miscellaneous
            opcGroup.UpdateRate = 10;
            opcGroup.IsActive = true;
            opcGroup.IsSubscribed = true;
            */

            LoadPanelForms();
        }

        private void opcGroup_DataChange(int TransactionID, int NumItems, ref Array ClientHandles, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps)
        {
            for (int i = 1; i <= NumItems; i++){
                if ((Convert.ToInt32(ClientHandles.GetValue(i)) == 1))
                {
                    this.Text = ItemValues.GetValue(i).ToString();
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            opcServer.Disconnect();

            tcpChannel.Close();
            tcpChannel1.Close();
            */
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
