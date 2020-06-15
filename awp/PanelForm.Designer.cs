namespace awp
{
    partial class PanelForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatus = new System.Windows.Forms.StatusStrip();
            this.pnlWorkplace = new System.Windows.Forms.Panel();
            this.tlpCaption = new System.Windows.Forms.TableLayoutPanel();
            this.lbCaption = new System.Windows.Forms.Label();
            this.lbSystemTime = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.tsmiLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStorage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTuning = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCommonView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOtherPrograms = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAlarmLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSwitchLog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAlarmlogStorage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSwitchlogStorage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserActionslog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSystemLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrends = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTables = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReports = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiReportStorage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDatabaseEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStorageGroups = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSystemTuning = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSchemeEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReportEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActivation = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.tlpCaption.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.mainMenu, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.mainStatus, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pnlWorkplace, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tlpCaption, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(933, 519);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSystem,
            this.tsmiLogs,
            this.tsmiStorage,
            this.tsmiTuning,
            this.tsmiHelp});
            this.mainMenu.Location = new System.Drawing.Point(0, 25);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(933, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // tsmiSystem
            // 
            this.tsmiSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCommonView,
            this.tsmiLogin,
            this.tsmiOtherPrograms,
            this.toolStripMenuItem1,
            this.tsmiExit});
            this.tsmiSystem.Name = "tsmiSystem";
            this.tsmiSystem.Size = new System.Drawing.Size(66, 20);
            this.tsmiSystem.Text = "Система";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(182, 22);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // mainStatus
            // 
            this.mainStatus.Location = new System.Drawing.Point(0, 497);
            this.mainStatus.Name = "mainStatus";
            this.mainStatus.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.mainStatus.Size = new System.Drawing.Size(933, 22);
            this.mainStatus.SizingGrip = false;
            this.mainStatus.TabIndex = 1;
            this.mainStatus.Text = "statusStrip1";
            // 
            // pnlWorkplace
            // 
            this.pnlWorkplace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWorkplace.Location = new System.Drawing.Point(0, 49);
            this.pnlWorkplace.Margin = new System.Windows.Forms.Padding(0);
            this.pnlWorkplace.Name = "pnlWorkplace";
            this.pnlWorkplace.Size = new System.Drawing.Size(933, 448);
            this.pnlWorkplace.TabIndex = 2;
            // 
            // tlpCaption
            // 
            this.tlpCaption.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tlpCaption.ColumnCount = 2;
            this.tlpCaption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCaption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCaption.Controls.Add(this.lbCaption, 0, 0);
            this.tlpCaption.Controls.Add(this.lbSystemTime, 1, 0);
            this.tlpCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCaption.Location = new System.Drawing.Point(0, 0);
            this.tlpCaption.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCaption.Name = "tlpCaption";
            this.tlpCaption.RowCount = 1;
            this.tlpCaption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCaption.Size = new System.Drawing.Size(933, 25);
            this.tlpCaption.TabIndex = 3;
            // 
            // lbCaption
            // 
            this.lbCaption.AutoSize = true;
            this.lbCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCaption.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbCaption.Location = new System.Drawing.Point(3, 0);
            this.lbCaption.Name = "lbCaption";
            this.lbCaption.Size = new System.Drawing.Size(790, 25);
            this.lbCaption.TabIndex = 0;
            this.lbCaption.Text = "АРМ";
            this.lbCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSystemTime
            // 
            this.lbSystemTime.AutoSize = true;
            this.lbSystemTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSystemTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSystemTime.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbSystemTime.Location = new System.Drawing.Point(799, 0);
            this.lbSystemTime.Name = "lbSystemTime";
            this.lbSystemTime.Size = new System.Drawing.Size(131, 25);
            this.lbSystemTime.TabIndex = 1;
            this.lbSystemTime.Text = "00.00.00 XX 00:00:00";
            this.lbSystemTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // tsmiLogs
            // 
            this.tsmiLogs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAlarmLog,
            this.tsmiSwitchLog,
            this.toolStripMenuItem2,
            this.tsmiAlarmlogStorage,
            this.tsmiSwitchlogStorage,
            this.tsmiUserActionslog,
            this.toolStripMenuItem3,
            this.tsmiSystemLog});
            this.tsmiLogs.Name = "tsmiLogs";
            this.tsmiLogs.Size = new System.Drawing.Size(72, 20);
            this.tsmiLogs.Text = "Журналы";
            // 
            // tsmiStorage
            // 
            this.tsmiStorage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTrends,
            this.tsmiTables,
            this.tsmiReports,
            this.toolStripMenuItem4,
            this.tsmiReportStorage});
            this.tsmiStorage.Name = "tsmiStorage";
            this.tsmiStorage.Size = new System.Drawing.Size(53, 20);
            this.tsmiStorage.Text = "Архив";
            // 
            // tsmiTuning
            // 
            this.tsmiTuning.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDatabaseEditor,
            this.tsmiStorageGroups,
            this.tsmiSystemTuning,
            this.toolStripMenuItem5,
            this.tsmiSchemeEditor,
            this.tsmiReportEditor,
            this.tsmiUserEditor});
            this.tsmiTuning.Name = "tsmiTuning";
            this.tsmiTuning.Size = new System.Drawing.Size(78, 20);
            this.tsmiTuning.Text = "Настройка";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout,
            this.tsmiActivation});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(68, 20);
            this.tsmiHelp.Text = "Помощь";
            // 
            // tsmiCommonView
            // 
            this.tsmiCommonView.Name = "tsmiCommonView";
            this.tsmiCommonView.Size = new System.Drawing.Size(182, 22);
            this.tsmiCommonView.Text = "Общий вид";
            // 
            // tsmiLogin
            // 
            this.tsmiLogin.Name = "tsmiLogin";
            this.tsmiLogin.Size = new System.Drawing.Size(182, 22);
            this.tsmiLogin.Text = "Регистрация";
            // 
            // tsmiOtherPrograms
            // 
            this.tsmiOtherPrograms.Name = "tsmiOtherPrograms";
            this.tsmiOtherPrograms.Size = new System.Drawing.Size(182, 22);
            this.tsmiOtherPrograms.Text = "Другие программы";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(179, 6);
            // 
            // tsmiAlarmLog
            // 
            this.tsmiAlarmLog.Name = "tsmiAlarmLog";
            this.tsmiAlarmLog.Size = new System.Drawing.Size(240, 22);
            this.tsmiAlarmLog.Text = "Аварийные сообщения";
            // 
            // tsmiSwitchLog
            // 
            this.tsmiSwitchLog.Name = "tsmiSwitchLog";
            this.tsmiSwitchLog.Size = new System.Drawing.Size(240, 22);
            this.tsmiSwitchLog.Text = "Переключения";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(237, 6);
            // 
            // tsmiAlarmlogStorage
            // 
            this.tsmiAlarmlogStorage.Name = "tsmiAlarmlogStorage";
            this.tsmiAlarmlogStorage.Size = new System.Drawing.Size(240, 22);
            this.tsmiAlarmlogStorage.Text = "Архив аварийных сообщений";
            // 
            // tsmiSwitchlogStorage
            // 
            this.tsmiSwitchlogStorage.Name = "tsmiSwitchlogStorage";
            this.tsmiSwitchlogStorage.Size = new System.Drawing.Size(240, 22);
            this.tsmiSwitchlogStorage.Text = "Архив переключений";
            // 
            // tsmiUserActionslog
            // 
            this.tsmiUserActionslog.Name = "tsmiUserActionslog";
            this.tsmiUserActionslog.Size = new System.Drawing.Size(240, 22);
            this.tsmiUserActionslog.Text = "Действия пользователей";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(237, 6);
            // 
            // tsmiSystemLog
            // 
            this.tsmiSystemLog.Name = "tsmiSystemLog";
            this.tsmiSystemLog.Size = new System.Drawing.Size(240, 22);
            this.tsmiSystemLog.Text = "Системые сообщения";
            // 
            // tsmiTrends
            // 
            this.tsmiTrends.Name = "tsmiTrends";
            this.tsmiTrends.Size = new System.Drawing.Size(180, 22);
            this.tsmiTrends.Text = "Графики";
            // 
            // tsmiTables
            // 
            this.tsmiTables.Name = "tsmiTables";
            this.tsmiTables.Size = new System.Drawing.Size(180, 22);
            this.tsmiTables.Text = "Таблицы";
            // 
            // tsmiReports
            // 
            this.tsmiReports.Name = "tsmiReports";
            this.tsmiReports.Size = new System.Drawing.Size(180, 22);
            this.tsmiReports.Text = "Отчёты";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiReportStorage
            // 
            this.tsmiReportStorage.Name = "tsmiReportStorage";
            this.tsmiReportStorage.Size = new System.Drawing.Size(180, 22);
            this.tsmiReportStorage.Text = "Архив отчётов";
            // 
            // tsmiDatabaseEditor
            // 
            this.tsmiDatabaseEditor.Name = "tsmiDatabaseEditor";
            this.tsmiDatabaseEditor.Size = new System.Drawing.Size(209, 22);
            this.tsmiDatabaseEditor.Text = "База данных";
            // 
            // tsmiStorageGroups
            // 
            this.tsmiStorageGroups.Name = "tsmiStorageGroups";
            this.tsmiStorageGroups.Size = new System.Drawing.Size(209, 22);
            this.tsmiStorageGroups.Text = "Группы параметров";
            // 
            // tsmiSystemTuning
            // 
            this.tsmiSystemTuning.Name = "tsmiSystemTuning";
            this.tsmiSystemTuning.Size = new System.Drawing.Size(209, 22);
            this.tsmiSystemTuning.Text = "Настройка системы";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(206, 6);
            // 
            // tsmiSchemeEditor
            // 
            this.tsmiSchemeEditor.Name = "tsmiSchemeEditor";
            this.tsmiSchemeEditor.Size = new System.Drawing.Size(209, 22);
            this.tsmiSchemeEditor.Text = "Редактор мнемосхем";
            // 
            // tsmiReportEditor
            // 
            this.tsmiReportEditor.Name = "tsmiReportEditor";
            this.tsmiReportEditor.Size = new System.Drawing.Size(209, 22);
            this.tsmiReportEditor.Text = "Редактор отчётов";
            // 
            // tsmiUserEditor
            // 
            this.tsmiUserEditor.Name = "tsmiUserEditor";
            this.tsmiUserEditor.Size = new System.Drawing.Size(209, 22);
            this.tsmiUserEditor.Text = "Редактор пользователей";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(180, 22);
            this.tsmiAbout.Text = "О программе...";
            // 
            // tsmiActivation
            // 
            this.tsmiActivation.Name = "tsmiActivation";
            this.tsmiActivation.Size = new System.Drawing.Size(180, 22);
            this.tsmiActivation.Text = "Активация";
            // 
            // PanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "PanelForm";
            this.Text = "PanelForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PanelForm_FormClosing);
            this.Load += new System.EventHandler(this.PanelForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.tlpCaption.ResumeLayout(false);
            this.tlpCaption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiSystem;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.StatusStrip mainStatus;
        private System.Windows.Forms.Panel pnlWorkplace;
        private System.Windows.Forms.TableLayoutPanel tlpCaption;
        private System.Windows.Forms.Label lbCaption;
        private System.Windows.Forms.Label lbSystemTime;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.ToolStripMenuItem tsmiCommonView;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogin;
        private System.Windows.Forms.ToolStripMenuItem tsmiOtherPrograms;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogs;
        private System.Windows.Forms.ToolStripMenuItem tsmiAlarmLog;
        private System.Windows.Forms.ToolStripMenuItem tsmiSwitchLog;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiAlarmlogStorage;
        private System.Windows.Forms.ToolStripMenuItem tsmiSwitchlogStorage;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserActionslog;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmiSystemLog;
        private System.Windows.Forms.ToolStripMenuItem tsmiStorage;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrends;
        private System.Windows.Forms.ToolStripMenuItem tsmiTables;
        private System.Windows.Forms.ToolStripMenuItem tsmiReports;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem tsmiReportStorage;
        private System.Windows.Forms.ToolStripMenuItem tsmiTuning;
        private System.Windows.Forms.ToolStripMenuItem tsmiDatabaseEditor;
        private System.Windows.Forms.ToolStripMenuItem tsmiStorageGroups;
        private System.Windows.Forms.ToolStripMenuItem tsmiSystemTuning;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem tsmiSchemeEditor;
        private System.Windows.Forms.ToolStripMenuItem tsmiReportEditor;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserEditor;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiActivation;
    }
}