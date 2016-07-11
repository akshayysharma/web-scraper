using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace scrape
{
    class WorkerClass
    {
        public static string getSoursecode(string url)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            StreamReader sr = new StreamReader(resp.GetResponseStream());
            string soursecode = sr.ReadToEnd();
            sr.Close();
            resp.Close();
            return soursecode;
        }

    }
}
