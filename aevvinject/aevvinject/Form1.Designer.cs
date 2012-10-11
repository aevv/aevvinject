namespace aevvinject
{
    partial class Form1
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
            this.bInject = new System.Windows.Forms.Button();
            this.bUnject = new System.Windows.Forms.Button();
            this.gbSelect = new System.Windows.Forms.GroupBox();
            this.lbProcesses = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bRefresh = new System.Windows.Forms.Button();
            this.bSelectExe = new System.Windows.Forms.Button();
            this.bSelectPID = new System.Windows.Forms.Button();
            this.bBrowseExe = new System.Windows.Forms.Button();
            this.tbExe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPID = new System.Windows.Forms.TextBox();
            this.lbInjected = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.selectedBox = new System.Windows.Forms.GroupBox();
            this.bShowProcInfo = new System.Windows.Forms.Button();
            this.tbDllResult = new System.Windows.Forms.TextBox();
            this.bBrowseDll = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSelect.SuspendLayout();
            this.selectedBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bInject
            // 
            this.bInject.BackColor = System.Drawing.SystemColors.Control;
            this.bInject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInject.Location = new System.Drawing.Point(211, 91);
            this.bInject.Name = "bInject";
            this.bInject.Size = new System.Drawing.Size(140, 34);
            this.bInject.TabIndex = 0;
            this.bInject.Text = "inject";
            this.bInject.UseVisualStyleBackColor = true;
            this.bInject.Click += new System.EventHandler(this.bInject_Click);
            // 
            // bUnject
            // 
            this.bUnject.BackColor = System.Drawing.Color.SteelBlue;
            this.bUnject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUnject.Location = new System.Drawing.Point(211, 131);
            this.bUnject.Name = "bUnject";
            this.bUnject.Size = new System.Drawing.Size(140, 34);
            this.bUnject.TabIndex = 1;
            this.bUnject.Text = "eject";
            this.bUnject.UseVisualStyleBackColor = true;
            this.bUnject.Click += new System.EventHandler(this.bUnject_Click);
            // 
            // gbSelect
            // 
            this.gbSelect.Controls.Add(this.bSelectExe);
            this.gbSelect.Controls.Add(this.bSelectPID);
            this.gbSelect.Controls.Add(this.bBrowseExe);
            this.gbSelect.Controls.Add(this.tbExe);
            this.gbSelect.Controls.Add(this.label3);
            this.gbSelect.Controls.Add(this.label2);
            this.gbSelect.Controls.Add(this.tbPID);
            this.gbSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSelect.Location = new System.Drawing.Point(430, 21);
            this.gbSelect.Name = "gbSelect";
            this.gbSelect.Size = new System.Drawing.Size(400, 214);
            this.gbSelect.TabIndex = 2;
            this.gbSelect.TabStop = false;
            this.gbSelect.Text = "Process Select";
            // 
            // lbProcesses
            // 
            this.lbProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lbProcesses.FullRowSelect = true;
            this.lbProcesses.Location = new System.Drawing.Point(12, 27);
            this.lbProcesses.MultiSelect = false;
            this.lbProcesses.Name = "lbProcesses";
            this.lbProcesses.ShowGroups = false;
            this.lbProcesses.Size = new System.Drawing.Size(398, 438);
            this.lbProcesses.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lbProcesses.TabIndex = 11;
            this.lbProcesses.UseCompatibleStateImageBehavior = false;
            this.lbProcesses.View = System.Windows.Forms.View.Details;
            this.lbProcesses.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Process Name";
            this.columnHeader1.Width = 307;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            // 
            // bRefresh
            // 
            this.bRefresh.Image = global::aevvinject.Properties.Resources.refresh;
            this.bRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bRefresh.Location = new System.Drawing.Point(12, 477);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(398, 30);
            this.bRefresh.TabIndex = 10;
            this.bRefresh.Text = "Refresh Process List";
            this.bRefresh.UseVisualStyleBackColor = true;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // bSelectExe
            // 
            this.bSelectExe.Location = new System.Drawing.Point(160, 171);
            this.bSelectExe.Name = "bSelectExe";
            this.bSelectExe.Size = new System.Drawing.Size(201, 23);
            this.bSelectExe.TabIndex = 9;
            this.bSelectExe.Text = "Select";
            this.bSelectExe.UseVisualStyleBackColor = true;
            this.bSelectExe.Click += new System.EventHandler(this.bSelectExe_Click);
            // 
            // bSelectPID
            // 
            this.bSelectPID.Location = new System.Drawing.Point(25, 171);
            this.bSelectPID.Name = "bSelectPID";
            this.bSelectPID.Size = new System.Drawing.Size(92, 23);
            this.bSelectPID.TabIndex = 8;
            this.bSelectPID.Text = "Select";
            this.bSelectPID.UseVisualStyleBackColor = true;
            this.bSelectPID.Click += new System.EventHandler(this.bSelectPID_Click);
            // 
            // bBrowseExe
            // 
            this.bBrowseExe.Location = new System.Drawing.Point(160, 61);
            this.bBrowseExe.Name = "bBrowseExe";
            this.bBrowseExe.Size = new System.Drawing.Size(201, 26);
            this.bBrowseExe.TabIndex = 6;
            this.bBrowseExe.Text = "Browse for executable";
            this.bBrowseExe.UseVisualStyleBackColor = true;
            // 
            // tbExe
            // 
            this.tbExe.Location = new System.Drawing.Point(160, 89);
            this.tbExe.Name = "tbExe";
            this.tbExe.Size = new System.Drawing.Size(201, 24);
            this.tbExe.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "OR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter process ID";
            // 
            // tbPID
            // 
            this.tbPID.Location = new System.Drawing.Point(25, 89);
            this.tbPID.Name = "tbPID";
            this.tbPID.Size = new System.Drawing.Size(92, 24);
            this.tbPID.TabIndex = 2;
            // 
            // lbInjected
            // 
            this.lbInjected.FormattingEnabled = true;
            this.lbInjected.ItemHeight = 18;
            this.lbInjected.Location = new System.Drawing.Point(10, 61);
            this.lbInjected.Name = "lbInjected";
            this.lbInjected.Size = new System.Drawing.Size(185, 202);
            this.lbInjected.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 36);
            this.label5.TabIndex = 6;
            this.label5.Text = "DLLs already injected in this:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // selectedBox
            // 
            this.selectedBox.Controls.Add(this.label1);
            this.selectedBox.Controls.Add(this.bShowProcInfo);
            this.selectedBox.Controls.Add(this.tbDllResult);
            this.selectedBox.Controls.Add(this.bBrowseDll);
            this.selectedBox.Controls.Add(this.lbInjected);
            this.selectedBox.Controls.Add(this.label5);
            this.selectedBox.Controls.Add(this.bUnject);
            this.selectedBox.Controls.Add(this.bInject);
            this.selectedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedBox.Location = new System.Drawing.Point(430, 241);
            this.selectedBox.Name = "selectedBox";
            this.selectedBox.Size = new System.Drawing.Size(400, 274);
            this.selectedBox.TabIndex = 7;
            this.selectedBox.TabStop = false;
            this.selectedBox.Text = "Currently selected:";
            this.selectedBox.Enter += new System.EventHandler(this.selectedBox_Enter);
            // 
            // bShowProcInfo
            // 
            this.bShowProcInfo.Location = new System.Drawing.Point(211, 171);
            this.bShowProcInfo.Name = "bShowProcInfo";
            this.bShowProcInfo.Size = new System.Drawing.Size(140, 34);
            this.bShowProcInfo.TabIndex = 10;
            this.bShowProcInfo.Text = "Show proc info";
            this.bShowProcInfo.UseVisualStyleBackColor = true;
            // 
            // tbDllResult
            // 
            this.tbDllResult.Location = new System.Drawing.Point(256, 61);
            this.tbDllResult.Name = "tbDllResult";
            this.tbDllResult.Size = new System.Drawing.Size(95, 24);
            this.tbDllResult.TabIndex = 8;
            // 
            // bBrowseDll
            // 
            this.bBrowseDll.Location = new System.Drawing.Point(211, 23);
            this.bBrowseDll.Name = "bBrowseDll";
            this.bBrowseDll.Size = new System.Drawing.Size(140, 32);
            this.bBrowseDll.TabIndex = 7;
            this.bBrowseDll.Text = "Browse for DLL";
            this.bBrowseDll.UseVisualStyleBackColor = true;
            this.bBrowseDll.Click += new System.EventHandler(this.bBrowseDll_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 533);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(859, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(987, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Created by aevv";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Path:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 555);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bRefresh);
            this.Controls.Add(this.lbProcesses);
            this.Controls.Add(this.selectedBox);
            this.Controls.Add(this.gbSelect);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "aevvinject";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSelect.ResumeLayout(false);
            this.gbSelect.PerformLayout();
            this.selectedBox.ResumeLayout(false);
            this.selectedBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bInject;
        private System.Windows.Forms.Button bUnject;
        private System.Windows.Forms.GroupBox gbSelect;
        private System.Windows.Forms.Button bSelectExe;
        private System.Windows.Forms.Button bSelectPID;
        private System.Windows.Forms.Button bBrowseExe;
        private System.Windows.Forms.TextBox tbExe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPID;
        private System.Windows.Forms.ListBox lbInjected;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox selectedBox;
        private System.Windows.Forms.TextBox tbDllResult;
        private System.Windows.Forms.Button bBrowseDll;
        private System.Windows.Forms.Button bShowProcInfo;
        private System.Windows.Forms.Button bRefresh;
        private System.Windows.Forms.ListView lbProcesses;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

