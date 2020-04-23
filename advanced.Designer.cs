namespace hlauncher
{
    partial class advanced
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(advanced));
            this.label1 = new System.Windows.Forms.Label();
            this.valvea = new System.Windows.Forms.CheckBox();
            this.bshifta = new System.Windows.Forms.CheckBox();
            this.gearboxa = new System.Windows.Forms.CheckBox();
            this.valveo = new System.Windows.Forms.OpenFileDialog();
            this.bshifto = new System.Windows.Forms.OpenFileDialog();
            this.gearboxo = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Check the game you want to play. Only select ONE.";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // valvea
            // 
            this.valvea.AutoSize = true;
            this.valvea.Location = new System.Drawing.Point(31, 36);
            this.valvea.Name = "valvea";
            this.valvea.Size = new System.Drawing.Size(65, 17);
            this.valvea.TabIndex = 2;
            this.valvea.Text = "Half-Life";
            this.valvea.UseVisualStyleBackColor = true;
            this.valvea.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged_1);
            // 
            // bshifta
            // 
            this.bshifta.AutoSize = true;
            this.bshifta.Location = new System.Drawing.Point(31, 59);
            this.bshifta.Name = "bshifta";
            this.bshifta.Size = new System.Drawing.Size(71, 17);
            this.bshifta.TabIndex = 3;
            this.bshifta.Text = "Blue Shift";
            this.bshifta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bshifta.UseVisualStyleBackColor = true;
            this.bshifta.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged_2);
            // 
            // gearboxa
            // 
            this.gearboxa.AutoSize = true;
            this.gearboxa.Location = new System.Drawing.Point(31, 82);
            this.gearboxa.Name = "gearboxa";
            this.gearboxa.Size = new System.Drawing.Size(101, 17);
            this.gearboxa.TabIndex = 4;
            this.gearboxa.Text = "Opposing Force";
            this.gearboxa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gearboxa.UseVisualStyleBackColor = true;
            // 
            // valveo
            // 
            this.valveo.FileName = "Locate your Half-Life install, and click \"hl.exe\".";
            // 
            // bshifto
            // 
            this.bshifto.FileName = "Locate your Half-Life install, and click \"hl.exe\".";
            // 
            // gearboxo
            // 
            this.gearboxo.FileName = "Locate your Half-Life install, and click \"hl.exe\".";
            // 
            // advanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gearboxa);
            this.Controls.Add(this.bshifta);
            this.Controls.Add(this.valvea);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "advanced";
            this.Text = "Half-Life Launcher: Advanced Options...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox valvea;
        private System.Windows.Forms.CheckBox bshifta;
        private System.Windows.Forms.CheckBox gearboxa;
        private System.Windows.Forms.OpenFileDialog valveo;
        private System.Windows.Forms.OpenFileDialog bshifto;
        private System.Windows.Forms.OpenFileDialog gearboxo;
    }
}