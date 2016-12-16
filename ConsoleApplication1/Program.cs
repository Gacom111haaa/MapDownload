using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int zoom = 13;
            int width = 500;
            int height = 500;
            int tdim = 256;
            double lat = 21.036264;
            double lng = 105.774866;

            double zn = (double)(1 << zoom);
            double tx = (lng + 180.0) / 360.0;
            double ty = (1.0 - Math.Log(Math.Tan(lat * Math.PI / 180.0) +
                                  1.0 / Math.Cos(lat * Math.PI / 180.0)) / Math.PI) / 2.0;
            tx = tx * zn;
            ty = ty * zn;

            int xp = (int) (width / 2 - (tx - Math.Floor(tx)) * tdim);
            int yp = (int) (height / 2 - (ty - Math.Floor(ty)) * tdim);

            // first tile vertical and horizontal
            // manh ban do dau tien theo chieu doc va ngang
            int xa = (xp + tdim - 1) / tdim;
            int ya = (yp + tdim - 1) / tdim;
            int xs = (int)(tx) - xa;
            int ys = (int)(ty) - ya;

            int XX = xs;// xp - xa * tdim;
            int YY = ys;// yp - ya * tdim;

            //XX = 26020;
            //YY = 14424;

            int xstart = XX-10;
            int ystart = YY-10;
            int xstop = XX+10;
            int ystop = YY+10;

            string url2 = "http://tile.openstreetmap.org/";
            string url = @"C:\Downloads\newtask\";
            string path2 = @"D:\DOWN\MapData\OpenStreetMap\";
            string path = @"C:\HR2D\MapData\SatMap\";


            
                for (int i = xstart; i < xstop; i++)
                    for (int j = ystart; j < ystop; j++)
                    {
                        try
                        {
                            //string urldown = url + zoom + "/" + i + "/" + j + ".png";
                            string urldown = url + "gs_" + i + "_" + j + "_" + zoom + ".jpg";
                            string pathdown = path + zoom + @"\" +i;
                            if (!Directory.Exists(pathdown))
                            {
                                Directory.CreateDirectory(pathdown);
                            }

                            pathdown = pathdown +  @"\" + j + ".jpg";
                            if (!Directory.Exists(pathdown))
                            {
                                using (var client = new WebClient())
                                {
                                    client.DownloadFile(urldown, pathdown);
                                }
                            }
                        }
                        catch (Exception _ex)
                        {
                            Console.WriteLine(_ex.ToString());
                        }
                    }
            
        }
    }
}
