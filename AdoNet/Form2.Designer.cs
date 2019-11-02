namespace Maraton_2
{
    partial class Form2
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerSubmitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.technicianSubmitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faultSubmitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 50);
            this.button3.TabIndex = 8;
            this.button3.Text = "fault Submit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(212, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "technician Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Customer  Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerSubmitToolStripMenuItem,
            this.technicianSubmitToolStripMenuItem,
            this.faultSubmitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(397, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customerSubmitToolStripMenuItem
            // 
            this.customerSubmitToolStripMenuItem.Name = "customerSubmitToolStripMenuItem";
            this.customerSubmitToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.customerSubmitToolStripMenuItem.Text = "Customer Submit";
            this.customerSubmitToolStripMenuItem.Click += new System.EventHandler(this.CustomerSubmitToolStripMenuItem_Click);
            // 
            // technicianSubmitToolStripMenuItem
            // 
            this.technicianSubmitToolStripMenuItem.Name = "technicianSubmitToolStripMenuItem";
            this.technicianSubmitToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.technicianSubmitToolStripMenuItem.Text = "Technician Submit";
            this.technicianSubmitToolStripMenuItem.Click += new System.EventHandler(this.TechnicianSubmitToolStripMenuItem_Click);
            // 
            // faultSubmitToolStripMenuItem
            // 
            this.faultSubmitToolStripMenuItem.Name = "faultSubmitToolStripMenuItem";
            this.faultSubmitToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.faultSubmitToolStripMenuItem.Text = "Rol Submit";
            this.faultSubmitToolStripMenuItem.Click += new System.EventHandler(this.FaultSubmitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Or With Code";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(397, 169);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerSubmitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem technicianSubmitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faultSubmitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}