namespace awp.View
{
    partial class ucBrowserDatabase
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Рабочая станция");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBrowserDatabase));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvDatabase = new System.Windows.Forms.TreeView();
            this.lvTable = new System.Windows.Forms.ListView();
            this.chTag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescriptor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chChannel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFetch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFetchTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsbNewEntity = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiModbusRtuPoints = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAnalogRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDigitalCoil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFetchChannels = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFetchNodes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEthernet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSerial = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1016, 555);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvDatabase);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvTable);
            this.splitContainer1.Size = new System.Drawing.Size(1010, 502);
            this.splitContainer1.SplitterDistance = 259;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvDatabase
            // 
            this.tvDatabase.BackColor = System.Drawing.Color.Black;
            this.tvDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvDatabase.ForeColor = System.Drawing.Color.YellowGreen;
            this.tvDatabase.Location = new System.Drawing.Point(0, 0);
            this.tvDatabase.Name = "tvDatabase";
            treeNode1.Name = "Workstation";
            treeNode1.Text = "Рабочая станция";
            this.tvDatabase.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tvDatabase.Size = new System.Drawing.Size(259, 502);
            this.tvDatabase.TabIndex = 0;
            // 
            // lvTable
            // 
            this.lvTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTag,
            this.chDescriptor,
            this.chChannel,
            this.chNode,
            this.chFetch,
            this.chFetchTime});
            this.lvTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTable.FullRowSelect = true;
            this.lvTable.HideSelection = false;
            this.lvTable.Location = new System.Drawing.Point(0, 0);
            this.lvTable.Name = "lvTable";
            this.lvTable.Size = new System.Drawing.Size(747, 502);
            this.lvTable.TabIndex = 0;
            this.lvTable.UseCompatibleStateImageBehavior = false;
            this.lvTable.View = System.Windows.Forms.View.Details;
            // 
            // chTag
            // 
            this.chTag.Text = "Тег";
            this.chTag.Width = 120;
            // 
            // chDescriptor
            // 
            this.chDescriptor.Text = "Дескриптор";
            this.chDescriptor.Width = 350;
            // 
            // chChannel
            // 
            this.chChannel.Text = "Канал";
            this.chChannel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chNode
            // 
            this.chNode.Text = "Узел";
            this.chNode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chFetch
            // 
            this.chFetch.Text = "Опрос";
            this.chFetch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chFetch.Width = 50;
            // 
            // chFetchTime
            // 
            this.chFetchTime.Text = "Время опроса";
            this.chFetchTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewEntity});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1016, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 533);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1016, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsbNewEntity
            // 
            this.tsbNewEntity.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNewEntity.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFetchChannels,
            this.tsmiFetchNodes,
            this.tsmiModbusRtuPoints});
            this.tsbNewEntity.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewEntity.Image")));
            this.tsbNewEntity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewEntity.Name = "tsbNewEntity";
            this.tsbNewEntity.Size = new System.Drawing.Size(67, 22);
            this.tsbNewEntity.Text = "Новый...";
            this.tsbNewEntity.ToolTipText = "Добавить новую позицию для опроса";
            // 
            // tsmiModbusRtuPoints
            // 
            this.tsmiModbusRtuPoints.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAnalogRegister,
            this.tsmiDigitalCoil});
            this.tsmiModbusRtuPoints.Name = "tsmiModbusRtuPoints";
            this.tsmiModbusRtuPoints.Size = new System.Drawing.Size(211, 22);
            this.tsmiModbusRtuPoints.Text = "Устройства MODBUS RTU";
            // 
            // tsmiAnalogRegister
            // 
            this.tsmiAnalogRegister.Name = "tsmiAnalogRegister";
            this.tsmiAnalogRegister.Size = new System.Drawing.Size(246, 22);
            this.tsmiAnalogRegister.Text = "Аналоговое значение MODBUS";
            // 
            // tsmiDigitalCoil
            // 
            this.tsmiDigitalCoil.Name = "tsmiDigitalCoil";
            this.tsmiDigitalCoil.Size = new System.Drawing.Size(246, 22);
            this.tsmiDigitalCoil.Text = "Дискретное значение MODBUS";
            // 
            // tsmiFetchChannels
            // 
            this.tsmiFetchChannels.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEthernet,
            this.tsmiSerial});
            this.tsmiFetchChannels.Name = "tsmiFetchChannels";
            this.tsmiFetchChannels.Size = new System.Drawing.Size(211, 22);
            this.tsmiFetchChannels.Text = "Каналы связи";
            // 
            // tsmiFetchNodes
            // 
            this.tsmiFetchNodes.Name = "tsmiFetchNodes";
            this.tsmiFetchNodes.Size = new System.Drawing.Size(211, 22);
            this.tsmiFetchNodes.Text = "Полевые узлы";
            // 
            // tsmiEthernet
            // 
            this.tsmiEthernet.Name = "tsmiEthernet";
            this.tsmiEthernet.Size = new System.Drawing.Size(180, 22);
            this.tsmiEthernet.Text = "Ethernet/TCP/UDP";
            // 
            // tsmiSerial
            // 
            this.tsmiSerial.Name = "tsmiSerial";
            this.tsmiSerial.Size = new System.Drawing.Size(180, 22);
            this.tsmiSerial.Text = "RS-232/RS-485";
            // 
            // ucBrowserDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucBrowserDatabase";
            this.Size = new System.Drawing.Size(1016, 555);
            this.Load += new System.EventHandler(this.ucBrowserDatabase_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TreeView tvDatabase;
        private System.Windows.Forms.ListView lvTable;
        private System.Windows.Forms.ColumnHeader chTag;
        private System.Windows.Forms.ColumnHeader chDescriptor;
        private System.Windows.Forms.ColumnHeader chChannel;
        private System.Windows.Forms.ColumnHeader chNode;
        private System.Windows.Forms.ColumnHeader chFetch;
        private System.Windows.Forms.ColumnHeader chFetchTime;
        private System.Windows.Forms.ToolStripDropDownButton tsbNewEntity;
        private System.Windows.Forms.ToolStripMenuItem tsmiModbusRtuPoints;
        private System.Windows.Forms.ToolStripMenuItem tsmiAnalogRegister;
        private System.Windows.Forms.ToolStripMenuItem tsmiDigitalCoil;
        private System.Windows.Forms.ToolStripMenuItem tsmiFetchChannels;
        private System.Windows.Forms.ToolStripMenuItem tsmiFetchNodes;
        private System.Windows.Forms.ToolStripMenuItem tsmiEthernet;
        private System.Windows.Forms.ToolStripMenuItem tsmiSerial;
    }
}
