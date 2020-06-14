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
            this.tsmiSystem});
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
            this.tsmiExit});
            this.tsmiSystem.Name = "tsmiSystem";
            this.tsmiSystem.Size = new System.Drawing.Size(66, 20);
            this.tsmiSystem.Text = "Система";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(109, 22);
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
    }
}