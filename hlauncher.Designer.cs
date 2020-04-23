namespace Half_Life_Launcher
{
    partial class hlauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hlauncher));
            this.valve = new System.Windows.Forms.Button();
            this.bshift = new System.Windows.Forms.Button();
            this.gearbox = new System.Windows.Forms.Button();
            this.bottomtext = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.advanced = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valve
            // 
            this.valve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.valve.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.valve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valve.Location = new System.Drawing.Point(12, 12);
            this.valve.Name = "valve";
            this.valve.Size = new System.Drawing.Size(328, 56);
            this.valve.TabIndex = 0;
            this.valve.Text = "Half-Life";
            this.valve.UseVisualStyleBackColor = false;
            this.valve.Click += new System.EventHandler(this.Valve_Click);
            // 
            // bshift
            // 
            this.bshift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bshift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bshift.Location = new System.Drawing.Point(12, 74);
            this.bshift.Name = "bshift";
            this.bshift.Size = new System.Drawing.Size(160, 49);
            this.bshift.TabIndex = 1;
            this.bshift.Text = "Blue Shift";
            this.bshift.UseVisualStyleBackColor = false;
            this.bshift.Click += new System.EventHandler(this.Bshift_Click);
            // 
            // gearbox
            // 
            this.gearbox.BackColor = System.Drawing.Color.Green;
            this.gearbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gearbox.ForeColor = System.Drawing.Color.White;
            this.gearbox.Location = new System.Drawing.Point(178, 74);
            this.gearbox.Name = "gearbox";
            this.gearbox.Size = new System.Drawing.Size(162, 49);
            this.gearbox.TabIndex = 2;
            this.gearbox.Text = "Opposing Force";
            this.gearbox.UseVisualStyleBackColor = false;
            this.gearbox.Click += new System.EventHandler(this.Gearbox_Click);
            // 
            // bottomtext
            // 
            this.bottomtext.AutoSize = true;
            this.bottomtext.Location = new System.Drawing.Point(12, 139);
            this.bottomtext.Name = "bottomtext";
            this.bottomtext.Size = new System.Drawing.Size(0, 13);
            this.bottomtext.TabIndex = 3;
            this.bottomtext.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 156);
            this.label1.MaximumSize = new System.Drawing.Size(330, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Half-Life, Blue Shift, and Opposing Force, and the Lambda logo are Valve, Gearbox" +
    " and Sierra\'s work. This is unofficial.";
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // advanced
            // 
            this.advanced.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.advanced.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.advanced.Location = new System.Drawing.Point(12, 129);
            this.advanced.Name = "advanced";
            this.advanced.Size = new System.Drawing.Size(328, 23);
            this.advanced.TabIndex = 3;
            this.advanced.Text = "Advanced... (in development)";
            this.advanced.UseVisualStyleBackColor = false;
            this.advanced.Click += new System.EventHandler(this.Advanced_Click);
            // 
            // hlauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(354, 191);
            this.Controls.Add(this.advanced);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bottomtext);
            this.Controls.Add(this.gearbox);
            this.Controls.Add(this.bshift);
            this.Controls.Add(this.valve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(370, 230);
            this.MinimumSize = new System.Drawing.Size(370, 230);
            this.Name = "hlauncher";
            this.Text = "Half-Life Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button valve;
        private System.Windows.Forms.Button bshift;
        private System.Windows.Forms.Button gearbox;
        private System.Windows.Forms.Label bottomtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button advanced;
    }
}

