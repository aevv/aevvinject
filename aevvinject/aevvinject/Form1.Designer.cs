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
            this.bInject = new System.Windows.Forms.Button();
            this.bUnject = new System.Windows.Forms.Button();
            this.gbSelect = new System.Windows.Forms.GroupBox();
            this.bRefresh = new System.Windows.Forms.Button();
            this.bSelectExe = new System.Windows.Forms.Button();
            this.bSelectPID = new System.Windows.Forms.Button();
            this.bSelectProc = new System.Windows.Forms.Button();
            this.bBrowseExe = new System.Windows.Forms.Button();
            this.tbExe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbProcesses = new System.Windows.Forms.ListBox();
            this.lbInjected = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.selectedBox = new System.Windows.Forms.GroupBox();
            this.bShowProcInfo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDllResult = new System.Windows.Forms.TextBox();
            this.bBrowseDll = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gbSelect.SuspendLayout();
            this.selectedBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // bInject
            // 
            this.bInject.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bInject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInject.Location = new System.Drawing.Point(246, 91);
            this.bInject.Name = "bInject";
            this.bInject.Size = new System.Drawing.Size(304, 74);
            this.bInject.TabIndex = 0;
            this.bInject.Text = "inject";
            this.bInject.UseVisualStyleBackColor = false;
            this.bInject.Click += new System.EventHandler(this.bInject_Click);
            // 
            // bUnject
            // 
            this.bUnject.BackColor = System.Drawing.Color.SteelBlue;
            this.bUnject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUnject.Location = new System.Drawing.Point(132, 189);
            this.bUnject.Name = "bUnject";
            this.bUnject.Size = new System.Drawing.Size(115, 74);
            this.bUnject.TabIndex = 1;
            this.bUnject.Text = "unject";
            this.bUnject.UseVisualStyleBackColor = false;
            this.bUnject.Click += new System.EventHandler(this.bUnject_Click);
            // 
            // gbSelect
            // 
            this.gbSelect.Controls.Add(this.bRefresh);
            this.gbSelect.Controls.Add(this.bSelectExe);
            this.gbSelect.Controls.Add(this.bSelectPID);
            this.gbSelect.Controls.Add(this.bSelectProc);
            this.gbSelect.Controls.Add(this.bBrowseExe);
            this.gbSelect.Controls.Add(this.tbExe);
            this.gbSelect.Controls.Add(this.label3);
            this.gbSelect.Controls.Add(this.label2);
            this.gbSelect.Controls.Add(this.tbPID);
            this.gbSelect.Controls.Add(this.label1);
            this.gbSelect.Controls.Add(this.lbProcesses);
            this.gbSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSelect.Location = new System.Drawing.Point(12, 12);
            this.gbSelect.Name = "gbSelect";
            this.gbSelect.Size = new System.Drawing.Size(556, 214);
            this.gbSelect.TabIndex = 2;
            this.gbSelect.TabStop = false;
            this.gbSelect.Text = "Process Select";
            // 
            // bRefresh
            // 
            this.bRefresh.Image = global::aevvinject.Properties.Resources.refresh;
            this.bRefresh.Location = new System.Drawing.Point(171, 18);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(30, 30);
            this.bRefresh.TabIndex = 10;
            this.bRefresh.UseVisualStyleBackColor = true;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // bSelectExe
            // 
            this.bSelectExe.Location = new System.Drawing.Point(349, 185);
            this.bSelectExe.Name = "bSelectExe";
            this.bSelectExe.Size = new System.Drawing.Size(201, 23);
            this.bSelectExe.TabIndex = 9;
            this.bSelectExe.Text = "Select";
            this.bSelectExe.UseVisualStyleBackColor = true;
            // 
            // bSelectPID
            // 
            this.bSelectPID.Location = new System.Drawing.Point(214, 185);
            this.bSelectPID.Name = "bSelectPID";
            this.bSelectPID.Size = new System.Drawing.Size(92, 23);
            this.bSelectPID.TabIndex = 8;
            this.bSelectPID.Text = "Select";
            this.bSelectPID.UseVisualStyleBackColor = true;
            // 
            // bSelectProc
            // 
            this.bSelectProc.Location = new System.Drawing.Point(6, 185);
            this.bSelectProc.Name = "bSelectProc";
            this.bSelectProc.Size = new System.Drawing.Size(165, 23);
            this.bSelectProc.TabIndex = 7;
            this.bSelectProc.Text = "Select";
            this.bSelectProc.UseVisualStyleBackColor = true;
            this.bSelectProc.Click += new System.EventHandler(this.bSelectProc_Click);
            // 
            // bBrowseExe
            // 
            this.bBrowseExe.Location = new System.Drawing.Point(349, 59);
            this.bBrowseExe.Name = "bBrowseExe";
            this.bBrowseExe.Size = new System.Drawing.Size(201, 38);
            this.bBrowseExe.TabIndex = 6;
            this.bBrowseExe.Text = "Browse for executable";
            this.bBrowseExe.UseVisualStyleBackColor = true;
            // 
            // tbExe
            // 
            this.tbExe.Location = new System.Drawing.Point(349, 103);
            this.tbExe.Name = "tbExe";
            this.tbExe.Size = new System.Drawing.Size(201, 24);
            this.tbExe.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(312, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "OR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter process ID";
            // 
            // tbPID
            // 
            this.tbPID.Location = new System.Drawing.Point(214, 89);
            this.tbPID.Name = "tbPID";
            this.tbPID.Size = new System.Drawing.Size(92, 24);
            this.tbPID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "OR";
            // 
            // lbProcesses
            // 
            this.lbProcesses.FormattingEnabled = true;
            this.lbProcesses.ItemHeight = 18;
            this.lbProcesses.Location = new System.Drawing.Point(6, 19);
            this.lbProcesses.Name = "lbProcesses";
            this.lbProcesses.Size = new System.Drawing.Size(165, 148);
            this.lbProcesses.TabIndex = 0;
            // 
            // lbInjected
            // 
            this.lbInjected.FormattingEnabled = true;
            this.lbInjected.ItemHeight = 18;
            this.lbInjected.Location = new System.Drawing.Point(6, 61);
            this.lbInjected.Name = "lbInjected";
            this.lbInjected.Size = new System.Drawing.Size(120, 202);
            this.lbInjected.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 36);
            this.label5.TabIndex = 6;
            this.label5.Text = "Things already \r\ninjected to this:";
            // 
            // selectedBox
            // 
            this.selectedBox.Controls.Add(this.label6);
            this.selectedBox.Controls.Add(this.bShowProcInfo);
            this.selectedBox.Controls.Add(this.label4);
            this.selectedBox.Controls.Add(this.tbDllResult);
            this.selectedBox.Controls.Add(this.bBrowseDll);
            this.selectedBox.Controls.Add(this.lbInjected);
            this.selectedBox.Controls.Add(this.label5);
            this.selectedBox.Controls.Add(this.bUnject);
            this.selectedBox.Controls.Add(this.bInject);
            this.selectedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedBox.Location = new System.Drawing.Point(12, 232);
            this.selectedBox.Name = "selectedBox";
            this.selectedBox.Size = new System.Drawing.Size(556, 274);
            this.selectedBox.TabIndex = 7;
            this.selectedBox.TabStop = false;
            this.selectedBox.Text = "Currently selected:";
            // 
            // bShowProcInfo
            // 
            this.bShowProcInfo.Location = new System.Drawing.Point(253, 189);
            this.bShowProcInfo.Name = "bShowProcInfo";
            this.bShowProcInfo.Size = new System.Drawing.Size(136, 74);
            this.bShowProcInfo.TabIndex = 10;
            this.bShowProcInfo.Text = "Show proc info";
            this.bShowProcInfo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "made by aevv";
            // 
            // tbDllResult
            // 
            this.tbDllResult.Location = new System.Drawing.Point(246, 61);
            this.tbDllResult.Name = "tbDllResult";
            this.tbDllResult.Size = new System.Drawing.Size(304, 24);
            this.tbDllResult.TabIndex = 8;
            // 
            // bBrowseDll
            // 
            this.bBrowseDll.Location = new System.Drawing.Point(246, 23);
            this.bBrowseDll.Name = "bBrowseDll";
            this.bBrowseDll.Size = new System.Drawing.Size(304, 32);
            this.bBrowseDll.TabIndex = 7;
            this.bBrowseDll.Text = "Browse for DLL";
            this.bBrowseDll.UseVisualStyleBackColor = true;
            this.bBrowseDll.Click += new System.EventHandler(this.bBrowseDll_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 72);
            this.label6.TabIndex = 11;
            this.label6.Text = "Note: doesnt \r\npersist through\r\nprogram \r\ntermination";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 511);
            this.Controls.Add(this.selectedBox);
            this.Controls.Add(this.gbSelect);
            this.Name = "Form1";
            this.Text = "aevvinject";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSelect.ResumeLayout(false);
            this.gbSelect.PerformLayout();
            this.selectedBox.ResumeLayout(false);
            this.selectedBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bInject;
        private System.Windows.Forms.Button bUnject;
        private System.Windows.Forms.GroupBox gbSelect;
        private System.Windows.Forms.ListBox lbProcesses;
        private System.Windows.Forms.Button bSelectExe;
        private System.Windows.Forms.Button bSelectPID;
        private System.Windows.Forms.Button bSelectProc;
        private System.Windows.Forms.Button bBrowseExe;
        private System.Windows.Forms.TextBox tbExe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbInjected;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox selectedBox;
        private System.Windows.Forms.TextBox tbDllResult;
        private System.Windows.Forms.Button bBrowseDll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bShowProcInfo;
        private System.Windows.Forms.Button bRefresh;
        private System.Windows.Forms.Label label6;
    }
}

