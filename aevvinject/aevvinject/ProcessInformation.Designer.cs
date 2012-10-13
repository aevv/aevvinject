namespace aevvinject
{
    partial class ProcessInformation
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
            this.lvInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bModules = new System.Windows.Forms.Button();
            this.bKill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvInfo
            // 
            this.lvInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvInfo.FullRowSelect = true;
            this.lvInfo.Location = new System.Drawing.Point(18, 17);
            this.lvInfo.Margin = new System.Windows.Forms.Padding(4);
            this.lvInfo.MultiSelect = false;
            this.lvInfo.Name = "lvInfo";
            this.lvInfo.ShowGroups = false;
            this.lvInfo.Size = new System.Drawing.Size(440, 327);
            this.lvInfo.TabIndex = 0;
            this.lvInfo.UseCompatibleStateImageBehavior = false;
            this.lvInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Property";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 400;
            // 
            // bModules
            // 
            this.bModules.Location = new System.Drawing.Point(470, 17);
            this.bModules.Margin = new System.Windows.Forms.Padding(4);
            this.bModules.Name = "bModules";
            this.bModules.Size = new System.Drawing.Size(141, 51);
            this.bModules.TabIndex = 1;
            this.bModules.Text = "Modules";
            this.bModules.UseVisualStyleBackColor = true;
            this.bModules.Click += new System.EventHandler(this.bModules_Click);
            // 
            // bKill
            // 
            this.bKill.Location = new System.Drawing.Point(470, 76);
            this.bKill.Margin = new System.Windows.Forms.Padding(4);
            this.bKill.Name = "bKill";
            this.bKill.Size = new System.Drawing.Size(141, 51);
            this.bKill.TabIndex = 2;
            this.bKill.Text = "Kill proc";
            this.bKill.UseVisualStyleBackColor = true;
            this.bKill.Click += new System.EventHandler(this.bKill_Click);
            // 
            // ProcessInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 361);
            this.Controls.Add(this.bKill);
            this.Controls.Add(this.bModules);
            this.Controls.Add(this.lvInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProcessInformation";
            this.Text = "ProcessInformation";
            this.Load += new System.EventHandler(this.ProcessInformation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button bModules;
        private System.Windows.Forms.Button bKill;

    }
}