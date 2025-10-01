namespace CriminalStatisticsAnalyzer
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileOpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileExitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnFullscreen;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox countryCombo;
        private System.Windows.Forms.DateTimePicker yearFrom;
        private System.Windows.Forms.DateTimePicker yearTo;
        private System.Windows.Forms.CheckBox chkHomicide;
        private System.Windows.Forms.CheckBox chkTheft;
        private System.Windows.Forms.CheckBox chkHarmOrSexualAssault;
        private System.Windows.Forms.Button btnApplyFilters;
        private System.Windows.Forms.Button btnResetFilters;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnFullscreen = new System.Windows.Forms.ToolStripButton();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.countryCombo = new System.Windows.Forms.ComboBox();
            this.yearFrom = new System.Windows.Forms.DateTimePicker();
            this.yearTo = new System.Windows.Forms.DateTimePicker();
            this.chkHomicide = new System.Windows.Forms.CheckBox();
            this.chkTheft = new System.Windows.Forms.CheckBox();
            this.chkHarmOrSexualAssault = new System.Windows.Forms.CheckBox();
            this.btnApplyFilters = new System.Windows.Forms.Button();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();

            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.groupBoxFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.fileToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1544, 24);
            this.menuStrip1.TabIndex = 2;

            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.fileOpenToolStripMenuItem, this.fileSaveToolStripMenuItem, this.fileExitToolStripMenuItem });
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";

            this.fileOpenToolStripMenuItem.Name = "fileOpenToolStripMenuItem";
            this.fileOpenToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.fileOpenToolStripMenuItem.Text = "Open";
            this.fileOpenToolStripMenuItem.Click += new System.EventHandler(this.fileOpenToolStripMenuItem_Click);

            this.fileSaveToolStripMenuItem.Name = "fileSaveToolStripMenuItem";
            this.fileSaveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.fileSaveToolStripMenuItem.Text = "Save";

            this.fileExitToolStripMenuItem.Name = "fileExitToolStripMenuItem";
            this.fileExitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.fileExitToolStripMenuItem.Text = "Exit";

            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.btnOpen, this.btnSave, this.btnRefresh, this.btnFullscreen });
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1544, 25);
            this.toolStrip1.TabIndex = 1;

            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(40, 22);
            this.btnOpen.Text = "Open";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);

            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(35, 22);
            this.btnSave.Text = "Save";

            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(50, 22);
            this.btnRefresh.Text = "Refresh";

            this.btnFullscreen.Name = "btnFullscreen";
            this.btnFullscreen.Size = new System.Drawing.Size(64, 22);
            this.btnFullscreen.Text = "Fullscreen";

            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 49);
            this.splitContainerMain.Name = "splitContainerMain";

            this.splitContainerMain.Panel1.Controls.Add(this.groupBoxFilters);
            this.splitContainerMain.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainerMain.Size = new System.Drawing.Size(1544, 796);
            this.splitContainerMain.SplitterDistance = 411;
            this.splitContainerMain.TabIndex = 0;

            this.groupBoxFilters.BackColor = System.Drawing.Color.Black;
            this.groupBoxFilters.Controls.Add(this.txtSearch);
            this.groupBoxFilters.Controls.Add(this.countryCombo);
            this.groupBoxFilters.Controls.Add(this.yearFrom);
            this.groupBoxFilters.Controls.Add(this.yearTo);
            this.groupBoxFilters.Controls.Add(this.chkHomicide);
            this.groupBoxFilters.Controls.Add(this.chkTheft);
            this.groupBoxFilters.Controls.Add(this.chkHarmOrSexualAssault);
            this.groupBoxFilters.Controls.Add(this.btnApplyFilters);
            this.groupBoxFilters.Controls.Add(this.btnResetFilters);
            this.groupBoxFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFilters.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBoxFilters.Location = new System.Drawing.Point(0, 0);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(411, 796);
            this.groupBoxFilters.TabIndex = 0;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Filters & Search";

            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtSearch.ForeColor = System.Drawing.Color.DarkRed;
            this.txtSearch.Location = new System.Drawing.Point(10, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(290, 20);
            this.txtSearch.TabIndex = 0;

            this.countryCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.countryCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryCombo.ForeColor = System.Drawing.Color.DarkRed;
            this.countryCombo.Location = new System.Drawing.Point(10, 60);
            this.countryCombo.Name = "countryCombo";
            this.countryCombo.Size = new System.Drawing.Size(290, 21);
            this.countryCombo.TabIndex = 1;

            this.yearFrom.Location = new System.Drawing.Point(10, 100);
            this.yearFrom.Name = "yearFrom";
            this.yearFrom.ShowUpDown = true;
            this.yearFrom.Size = new System.Drawing.Size(140, 20);
            this.yearFrom.TabIndex = 2;

            this.yearTo.Location = new System.Drawing.Point(160, 100);
            this.yearTo.Name = "yearTo";
            this.yearTo.ShowUpDown = true;
            this.yearTo.Size = new System.Drawing.Size(140, 20);
            this.yearTo.TabIndex = 3;

            this.chkHomicide.BackColor = System.Drawing.Color.Black;
            this.chkHomicide.ForeColor = System.Drawing.Color.DarkRed;
            this.chkHomicide.Location = new System.Drawing.Point(10, 140);
            this.chkHomicide.Name = "chkHomicide";
            this.chkHomicide.Size = new System.Drawing.Size(104, 24);
            this.chkHomicide.TabIndex = 4;
            this.chkHomicide.Text = "Homicide";
            this.chkHomicide.UseVisualStyleBackColor = false;

            this.chkTheft.BackColor = System.Drawing.Color.Black;
            this.chkTheft.ForeColor = System.Drawing.Color.DarkRed;
            this.chkTheft.Location = new System.Drawing.Point(10, 170);
            this.chkTheft.Name = "chkTheft";
            this.chkTheft.Size = new System.Drawing.Size(104, 24);
            this.chkTheft.TabIndex = 5;
            this.chkTheft.Text = "Theft";
            this.chkTheft.UseVisualStyleBackColor = false;

            this.chkHarmOrSexualAssault.BackColor = System.Drawing.Color.Black;
            this.chkHarmOrSexualAssault.ForeColor = System.Drawing.Color.DarkRed;
            this.chkHarmOrSexualAssault.Location = new System.Drawing.Point(10, 200);
            this.chkHarmOrSexualAssault.Name = "chkHarmOrSexualAssault";
            this.chkHarmOrSexualAssault.Size = new System.Drawing.Size(160, 24);
            this.chkHarmOrSexualAssault.TabIndex = 6;
            this.chkHarmOrSexualAssault.Text = "harm or sexual assault";
            this.chkHarmOrSexualAssault.UseVisualStyleBackColor = false;

            this.btnApplyFilters.BackColor = System.Drawing.Color.DarkRed;
            this.btnApplyFilters.ForeColor = System.Drawing.Color.White;
            this.btnApplyFilters.Location = new System.Drawing.Point(10, 240);
            this.btnApplyFilters.Name = "btnApplyFilters";
            this.btnApplyFilters.Size = new System.Drawing.Size(120, 30);
            this.btnApplyFilters.TabIndex = 7;
            this.btnApplyFilters.Text = "Apply Filters";
            this.btnApplyFilters.UseVisualStyleBackColor = false;
            this.btnApplyFilters.Click += new System.EventHandler(this.btnApplyFilters_Click_1);

            this.btnResetFilters.BackColor = System.Drawing.Color.DarkRed;
            this.btnResetFilters.ForeColor = System.Drawing.Color.White;
            this.btnResetFilters.Location = new System.Drawing.Point(150, 240);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(120, 30);
            this.btnResetFilters.TabIndex = 8;
            this.btnResetFilters.Text = "Reset";
            this.btnResetFilters.UseVisualStyleBackColor = false;
            this.btnResetFilters.Click += new System.EventHandler(this.btnResetFilters_Click);

            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;

            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1129, 796);
            this.dataGridView1.TabIndex = 0;

            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.statusLabel });
            this.statusStrip1.Location = new System.Drawing.Point(0, 845);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1544, 22);
            this.statusStrip1.TabIndex = 3;

            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(134, 17);
            this.statusLabel.Text = "Status: Ready Records: 0";

            this.ClientSize = new System.Drawing.Size(1544, 867);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainForm";
            this.Text = "Criminal Statistics Analyzer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
