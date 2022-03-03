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
using NAudio.Wave;
using Newtonsoft.Json;

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

        public static void Form1_Load(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string typesURL = "";
            typesURL = textBox1.Text;

            UrlSend(typesURL);
        }

        protected static void UrlSend(string sString)
        {
            string result;

            result = sString;

            Start_Program_Click(new object(), new EventArgs(), sString);
        }

        public static void Start_Program_Click(object sender, EventArgs e, string bString)
        {
            var url = "http://media.ch9.ms/ch9/2876/fd36ef30-cfd2-4558-8412-3cf7a0852876/AzureWebJobs103.mp3";
            using (var mf = new MediaFoundationReader(url))
            using (var wo = new WaveOutEvent())
            {
                wo.Init(mf);
                wo.Play();
                while (wo.PlaybackState == PlaybackState.Playing);
                    Console.WriteLine("1");
            }
        }
    }
}
