namespace WorstVolumeControllers
{
    partial class SelectValueForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VolumeValuesFlpn = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VolumeValuesFlpn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select value";
            // 
            // VolumeValuesFlpn
            // 
            this.VolumeValuesFlpn.AutoScroll = true;
            this.VolumeValuesFlpn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VolumeValuesFlpn.Location = new System.Drawing.Point(3, 19);
            this.VolumeValuesFlpn.Name = "VolumeValuesFlpn";
            this.VolumeValuesFlpn.Size = new System.Drawing.Size(518, 231);
            this.VolumeValuesFlpn.TabIndex = 0;
            // 
            // SelectVolumeController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 253);
            this.Controls.Add(this.groupBox1);
            this.Name = "SelectVolumeController";
            this.Text = "SelectVolumeController";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private FlowLayoutPanel VolumeValuesFlpn;
    }
}