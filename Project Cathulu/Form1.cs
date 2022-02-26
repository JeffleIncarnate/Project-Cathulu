using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Project_Cathulu
{
    public partial class Form1 : Form
    {
        protected PerformanceCounter _cpuCounter;

        protected PerformanceCounter _ramCounter;

        public Form1()
        {
            _cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            _ramCounter = new PerformanceCounter("Memory", "Available MBytes");

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// All of these methods are getter methods, they will get information, then dispay what they have gathered
        /// </summary>
        

        // CPU
        protected string GetCurrentCpuUsage()
        {
            return Convert.ToString(Math.Round(_cpuCounter.NextValue()) + "%");
        }

        protected void CPU_Timer_Tick(object sender, EventArgs e)
        {
            CPU_Usage.Text = GetCurrentCpuUsage();
        }


        // RAM
        protected string GetCurrentRamUSage()
        {
            return Convert.ToString(Math.Round(_ramCounter.NextValue()) + "Mb");
        }

        protected void RAM_Timer_Tick(object sender, EventArgs e)
        {
            RAM_Usage.Text = GetCurrentRamUSage();
        }
    }
}
