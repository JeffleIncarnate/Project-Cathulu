namespace Project_Cathulu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CPU_Usage = new System.Windows.Forms.Label();
            this.CPU_Timer = new System.Windows.Forms.Timer(this.components);
            this.RAM_Usage = new System.Windows.Forms.Label();
            this.RAM_Timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RAM_Usage);
            this.panel1.Controls.Add(this.CPU_Usage);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 397);
            this.panel1.TabIndex = 0;
            // 
            // CPU_Usage
            // 
            this.CPU_Usage.AutoSize = true;
            this.CPU_Usage.Font = new System.Drawing.Font("Garamond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPU_Usage.Location = new System.Drawing.Point(437, 340);
            this.CPU_Usage.Name = "CPU_Usage";
            this.CPU_Usage.Size = new System.Drawing.Size(54, 25);
            this.CPU_Usage.TabIndex = 0;
            this.CPU_Usage.Text = "CPU";
            // 
            // CPU_Timer
            // 
            this.CPU_Timer.Enabled = true;
            this.CPU_Timer.Interval = 700;
            this.CPU_Timer.Tick += new System.EventHandler(this.CPU_Timer_Tick);
            // 
            // RAM_Usage
            // 
            this.RAM_Usage.AutoSize = true;
            this.RAM_Usage.Font = new System.Drawing.Font("Garamond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RAM_Usage.Location = new System.Drawing.Point(342, 340);
            this.RAM_Usage.Name = "RAM_Usage";
            this.RAM_Usage.Size = new System.Drawing.Size(59, 25);
            this.RAM_Usage.TabIndex = 1;
            this.RAM_Usage.Text = "RAM";
            // 
            // RAM_Timer
            // 
            this.RAM_Timer.Enabled = true;
            this.RAM_Timer.Interval = 800;
            this.RAM_Timer.Tick += new System.EventHandler(this.RAM_Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 422);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CPU_Usage;
        private System.Windows.Forms.Timer CPU_Timer;
        private System.Windows.Forms.Label RAM_Usage;
        private System.Windows.Forms.Timer RAM_Timer;
    }
}

