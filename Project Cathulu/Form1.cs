using System;
using System.Diagnostics;
using System.Windows.Forms;
using SpotifyAPI.Web;
using System.IO;
using System.Media;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Management;

namespace Project_Cathulu
{
    public partial class Form1 : Form
    {
        protected PerformanceCounter _cpuCounter;

        protected PerformanceCounter _ramCounter;

        protected string soundOutput;

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
        /// All of these methods are getter and setter methods, they will get information, then dispay what they have gathered
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
            var GB = Math.Round(_ramCounter.NextValue());
            GB = GB / 1000;
            return Convert.ToString(GB) + "GB";
        }

        protected void RAM_Timer_Tick(object sender, EventArgs e)
        {
            RAM_Usage.Text = GetCurrentRamUSage();
        }

        private void Start_Program_Click(object sender, EventArgs e)
        {
            string spotify = @"C:\Users\Test\AppData\Roaming\Spotify\Spotify.exe";

            Process.Start(spotify);
        }

        private void SoundCheckerRequest_Tick(object sender, EventArgs e)
        {
            ManagementObjectSearcher objSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_SoundDevice");

            ManagementObjectCollection objCollection = objSearcher.Get();

            foreach (ManagementObject obj in objCollection)
            {
                foreach (PropertyData property in obj.Properties)
                {
                    Console.Out.WriteLine(String.Format("{0}:{1}", property.Name, property.Value));
                    label1.Text = String.Format("{0}:{1}", property.Name, property.Qualifiers);
                }
            }
        }
    }
}
