using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        bool isRunning = false;
        private void button1_Click(object sender, EventArgs e)
        {
            
            BackgroundWorker bw = new BackgroundWorker();
            
            bw.DoWork += new DoWorkEventHandler(
            delegate(object o, DoWorkEventArgs args)
            {
                
                startDownload();
                isRunning = false;

            });
            bw.RunWorkerAsync();
            
        }

        private void startDownload()
        {
            int zoom = int.Parse(textBoxZoom.Text);
            double lat1 = double.Parse(textBox_lat_max.Text);
            double lng1 = double.Parse(textBox_lon_min.Text);
            double lat2 = double.Parse(textBox_lat_min.Text);
            double lng2 = double.Parse(textBox_lon_max.Text);

            double zn = (double)(1 << zoom);
            double tx = (lng1 + 180.0) / 360.0;
            double ty = (1.0 - Math.Log(Math.Tan(lat1 * Math.PI / 180.0) +
                                  1.0 / Math.Cos(lat1 * Math.PI / 180.0)) / Math.PI) / 2.0;
            tx = tx * zn;
            ty = ty * zn;
            int xstart = (int)tx;
            int ystart = (int)ty;

            tx = (lng2 + 180.0) / 360.0;
            ty = (1.0 - Math.Log(Math.Tan(lat2 * Math.PI / 180.0) +
                             1.0 / Math.Cos(lat2 * Math.PI / 180.0)) / Math.PI) / 2.0;
            tx = tx * zn;
            ty = ty * zn;
            int xstop = (int)tx;
            int ystop = (int)ty;
            string url = textBox_url.Text;
            string path = textBox_path.Text;
            string[] strZ = new string[] { "<z>" };
            string[] strX = new string[] { "<x>" };
            string[] strY = new string[] { "<y>" };

            double sumTile = (xstop+1 - xstart) * (ystop+1 - ystart);
            int ntile = 0;
            ///
            for (int i = xstart; i <=xstop; i++)
            {
                
                
                for (int j = ystart; j <=ystop; j++)
                {
                    
                    try
                    {

                        //path
                        string pathdown = path;
                        //add z to path
                        string[] strList = pathdown.Split(strZ, StringSplitOptions.None);
                        if (strList.Length < 2)
                            return;
                        pathdown = strList[0] + zoom + strList[1];
                        // add X to path
                        strList = pathdown.Split(strX, StringSplitOptions.None);
                        if (strList.Length < 2)
                            return;
                        pathdown = strList[0] + i + strList[1];
                        // add y to path
                        strList = pathdown.Split(strY, StringSplitOptions.None);
                        if (strList.Length < 2)
                            return;
                        if (!Directory.Exists(strList[0]))
                        {
                            Directory.CreateDirectory(strList[0]);
                        }
                        pathdown = strList[0] + j + strList[1];

                        if (File.Exists(pathdown)&&(!checkBoxoverWrite.Checked))
                        {
                            continue;
                        }
                        //
                        string urldown = url;
                        //add z to url
                        strList = urldown.Split(strZ, StringSplitOptions.None);
                        if (strList.Length < 2)
                            return;
                        urldown = strList[0] + zoom + strList[1];
                        // add X to url
                        strList = urldown.Split(strX, StringSplitOptions.None);
                        if (strList.Length < 2)
                            return;
                        urldown = strList[0] + i + strList[1];
                        // add y to url
                        strList = urldown.Split(strY, StringSplitOptions.None);
                        if (strList.Length < 2)
                            return;
                        urldown = strList[0] + j + strList[1];
                        while (runnningThreads > 40)
                        {
                            Thread.Sleep(500);
                        }
                        BackgroundWorker bw = new BackgroundWorker();
                        bw.DoWork += new DoWorkEventHandler(
                        delegate(object o, DoWorkEventArgs args)
                        {
                            
                            downloadMapTile(urldown, pathdown);
                            runnningThreads--;

                        });
                        bw.RunWorkerAsync();
                        runnningThreads++;
                    }
                    catch (Exception _ex)
                    {
                        Console.WriteLine(_ex.ToString());
                        
                        
                    }
                    ntile++;
                    downProg = (int)((double)ntile * 100.0 / sumTile);
                }
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        int runnningThreads = 0;
        private int downProg;
        private bool isLocal;
        private void downloadMapTile(string urldown,string pathdown)
        {
            
            isRunning = true;
            try {
                if (isLocal)
                {
                    File.Copy(urldown, pathdown);
                }
                else
                using (var client = new WebClient())
                {
                    client.DownloadFile(urldown, pathdown);
                }
            }
                
            catch (Exception _ex)
                    {
                        Console.WriteLine(_ex.ToString());
                        
                        
                    }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (runnningThreads > 0)
            {
                progressBar1.Value = downProg;
                button1.Text = "Downloading...";
                textBox_threads.Text = runnningThreads.ToString();
            }
            else
            {
                progressBar1.Value = 0;
                button1.Text = "Download";
            }
        }

        private void checkBox_localComputer_CheckedChanged(object sender, EventArgs e)
        {
            isLocal = checkBox_localComputer.Checked;
        }
    }
    
}
