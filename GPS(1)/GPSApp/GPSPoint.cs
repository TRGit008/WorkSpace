using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSApp
{
    public class GPSPoint
    {
        
        public DateTime Date { get; internal set; }
        public float Lng { get; internal set; }
        public float Lat { get; internal set; }
        public float Speed { get; internal set; }
        public float Distance { get; internal set; }

        /// <summary>
        /// $BDGSV,2,2,07,10,85,101,28,12,70,261,21,13,63,223,26*5B
        /// $GNRMC,222424.000,A,3246.6099,N,10337.1339,E,0.07,0.00,121016,,,A*79
        /// $GPPUL,1476339860,200,0,0,9797*HH
        /// </summary>
        /// <param name="gpsdata"></param>
        /// <returns></returns>
        internal static List<GPSPoint> Analysis(string gpsdata)
        {
            List<GPSPoint> gpss = new List<GPSPoint>();
            //字符串转变为数组存放（换行符来区分）

            string[] gpsdatas = gpsdata.Split(
                new string[] { "\r\n" }, StringSplitOptions.None);
            for (int i = 0; i < gpsdatas.Length; i++)
            {
                if (i > 100) break;
                GPSPoint pt = AnalysisGPSPoint(gpsdatas[i], gpss);
                if (pt != null) gpss.Add(pt);
            }

            return (gpss);
        }
        /// <summary>
        /// $GNRMC,222424.000,A,3246.6099,N,10337.1339,E,0.07,0.00,121016,,,A*79
        /// </summary>
        /// <param name="nmea"></param>
        /// <returns></returns>
        internal static GPSPoint AnalysisGPSPoint(string nmea, List<GPSPoint> gpss = null)
        {
            GPSPoint pt = new GPSPoint();
            string[] datas = nmea.Split(new string[] { "," }
                , StringSplitOptions.None);
            if (datas[0] == "$GNRMC" && datas[2] == "A")
            {
                pt.Lng = (Convert.ToInt32(datas[5].Substring(0, 3))
                            + Convert.ToSingle(datas[5].Substring(3)) / 60)
                            * (datas[6] == "E" ? 1 : -1);
                pt.Lat = (Convert.ToInt32(datas[3].Substring(0, 2))
                            + Convert.ToSingle(datas[3].Substring(2)) / 60)
                            * (datas[3] == "N" ? 1 : -1);
                pt.Speed = Convert.ToSingle(datas[7]) * 1.852F;
                pt.Date = DateTime.ParseExact(datas[9]
                            + datas[1].Substring(0, datas[1].IndexOf("."))
                            , "ddMMyyHHmmss", null);
                if (gpss == null || gpss.Count == 0) pt.Distance = 0;
                else pt.Distance = (float)GetDistance(pt.Lat, pt.Lng
                    , gpss[gpss.Count - 1].Lat, gpss[gpss.Count - 1].Lng);
            }
            else return (null);
            return (pt);
        }


        private const double EARTH_RADIUS = 6378.137;//地球半径
        private static double rad(double d)
        {
            return d * Math.PI / 180.0;
        }

        public static double GetDistance(double lat1, double lng1, double lat2, double lng2)
        {
            double radLat1 = rad(lat1);
            double radLat2 = rad(lat2);
            double a = radLat1 - radLat2;
            double b = rad(lng1) - rad(lng2);

            double s = 2 * Math.Asin(Math.Sqrt(Math.Pow(Math.Sin(a / 2), 2) +
             Math.Cos(radLat1) * Math.Cos(radLat2) * Math.Pow(Math.Sin(b / 2), 2)));
            s = s * EARTH_RADIUS;
            s = Math.Round(s * 10000) / 10000;
            return s;
        }
    }
}
