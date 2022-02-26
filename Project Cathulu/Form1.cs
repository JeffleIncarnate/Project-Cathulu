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
            _ramCounter = new PerformanceCounter("Memory", "Avalible MBytes");

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
