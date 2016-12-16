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

        private void button1_Click(object sender, EventArgs e)
        {
            int zoom =  int.Parse( textBoxZoom.Text);
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
            int xstart = (int)tx ;
            int ystart = (int)ty ;

            tx = (lng2 + 180.0) / 360.0;
            ty = (1.0 - Math.Log(Math.Tan(lat2 * Math.PI / 180.0) +
                             1.0 / Math.Cos(lat2 * Math.PI / 180.0)) / Math.PI) / 2.0;
            tx = tx * zn;
            ty = ty * zn;
            int xstop = (int)tx ;
            int ystop = (int)ty ;
            string url = textBox_url.Text ;
            string path = textBox_path.Text;
            string[] strZ  = new string[] {"<z>"};
            string[] strX = new string[] { "<x>"};
            string[] strY = new string[] { "<y>" };
            
            

            ///
            for (int i = xstart; i < xstop; i++)
            {
                progressBar1.Value = (i - xstart) / (xstop - xstart)*100;
                progressBar1.Update();
                for (int j = ystart; j < ystop; j++)
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
                        
                        if (!File.Exists(pathdown))
                        {
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
                            while(runnningThreads>10)
                            {
                                Thread.Sleep(100);
                            }
                            BackgroundWorker bw = new BackgroundWorker();
                            bw.DoWork += new DoWorkEventHandler(
                            delegate(object o, DoWorkEventArgs args)
                            {
                                downloadMapTile(urldown, pathdown);

                            });
                            bw.RunWorkerAsync();
                            
                            
                        }

                        
                        
                    }
                    catch (Exception _ex)
                    {
                        Console.WriteLine(_ex.ToString());
                        button1.Text = "error";
                        continue;
                    }
                }
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        int runnningThreads = 0;
        private void downloadMapTile(string urldown,string pathdown)
        {
            runnningThreads++;
                using (var client = new WebClient())
                {
                    client.DownloadFile(urldown, pathdown);
                }
            runnningThreads--;
        }
    }
    
}
