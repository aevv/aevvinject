namespace aevvinject
{
    partial class Modules
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
            this.lbModules = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbModules
            // 
            this.lbModules.FormattingEnabled = true;
            this.lbModules.ItemHeight = 18;
            this.lbModules.Location = new System.Drawing.Point(18, 17);
            this.lbModules.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbModules.Name = "lbModules";
            this.lbModules.Size = new System.Drawing.Size(176, 328);
            this.lbModules.TabIndex = 0;
            // 
            // Modules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 363);
            this.Controls.Add(this.lbModules);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Modules";
            this.Text = "Modules";
            this.Load += new System.EventHandler(this.Modules_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbModules;
    }
}