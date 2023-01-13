namespace WorstVolumeControllers
{
    partial class DicesForm
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
            this.DiceFlpn = new System.Windows.Forms.FlowLayoutPanel();
            this.RollBtn = new System.Windows.Forms.Button();
            this.VolumeLb = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DiceCountTbox = new System.Windows.Forms.TextBox();
            this.SetDiceCountBtn = new System.Windows.Forms.Button();
            this.SetRollCountBtn = new System.Windows.Forms.Button();
            this.RollCountTbox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DiceFlpn
            // 
            this.DiceFlpn.AutoScroll = true;
            this.DiceFlpn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiceFlpn.Location = new System.Drawing.Point(3, 19);
            this.DiceFlpn.Name = "DiceFlpn";
            this.DiceFlpn.Size = new System.Drawing.Size(450, 192);
            this.DiceFlpn.TabIndex = 1;
            // 
            // RollBtn
            // 
            this.RollBtn.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RollBtn.Location = new System.Drawing.Point(12, 281);
            this.RollBtn.Name = "RollBtn";
            this.RollBtn.Size = new System.Drawing.Size(160, 49);
            this.RollBtn.TabIndex = 2;
            this.RollBtn.Text = "Roll";
            this.RollBtn.UseVisualStyleBackColor = true;
            this.RollBtn.Click += new System.EventHandler(this.RollBtn_Click);
            // 
            // VolumeLb
            // 
            this.VolumeLb.AutoSize = true;
            this.VolumeLb.Font = new System.Drawing.Font("Dubai", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VolumeLb.Location = new System.Drawing.Point(178, 281);
            this.VolumeLb.Name = "VolumeLb";
            this.VolumeLb.Size = new System.Drawing.Size(140, 49);
            this.VolumeLb.TabIndex = 3;
            this.VolumeLb.Text = "Volume: 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DiceFlpn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dices";
            // 
            // DiceCountTbox
            // 
            this.DiceCountTbox.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DiceCountTbox.Location = new System.Drawing.Point(12, 232);
            this.DiceCountTbox.Name = "DiceCountTbox";
            this.DiceCountTbox.Size = new System.Drawing.Size(60, 43);
            this.DiceCountTbox.TabIndex = 4;
            this.DiceCountTbox.Text = "12";
            // 
            // SetDiceCountBtn
            // 
            this.SetDiceCountBtn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SetDiceCountBtn.Location = new System.Drawing.Point(78, 232);
            this.SetDiceCountBtn.Name = "SetDiceCountBtn";
            this.SetDiceCountBtn.Size = new System.Drawing.Size(94, 43);
            this.SetDiceCountBtn.TabIndex = 5;
            this.SetDiceCountBtn.Text = "Set Dice Count";
            this.SetDiceCountBtn.UseVisualStyleBackColor = true;
            this.SetDiceCountBtn.Click += new System.EventHandler(this.SetDiceCountBtn_Click);
            // 
            // SetRollCountBtn
            // 
            this.SetRollCountBtn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SetRollCountBtn.Location = new System.Drawing.Point(244, 232);
            this.SetRollCountBtn.Name = "SetRollCountBtn";
            this.SetRollCountBtn.Size = new System.Drawing.Size(94, 43);
            this.SetRollCountBtn.TabIndex = 7;
            this.SetRollCountBtn.Text = "Set Roll Count";
            this.SetRollCountBtn.UseVisualStyleBackColor = true;
            this.SetRollCountBtn.Click += new System.EventHandler(this.SetRollCountBtn_Click);
            // 
            // RollCountTbox
            // 
            this.RollCountTbox.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RollCountTbox.Location = new System.Drawing.Point(178, 232);
            this.RollCountTbox.Name = "RollCountTbox";
            this.RollCountTbox.Size = new System.Drawing.Size(60, 43);
            this.RollCountTbox.TabIndex = 6;
            this.RollCountTbox.Text = "25";
            // 
            // DiceVolumeController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 342);
            this.Controls.Add(this.SetRollCountBtn);
            this.Controls.Add(this.RollCountTbox);
            this.Controls.Add(this.SetDiceCountBtn);
            this.Controls.Add(this.DiceCountTbox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.VolumeLb);
            this.Controls.Add(this.RollBtn);
            this.Name = "DiceVolumeController";
            this.Text = "DiceVolumeController";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FlowLayoutPanel DiceFlpn;
        private Button RollBtn;
        private Label VolumeLb;
        private GroupBox groupBox1;
        private TextBox DiceCountTbox;
        private Button SetDiceCountBtn;
        private Button SetRollCountBtn;
        private TextBox RollCountTbox;
    }
}