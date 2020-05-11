using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Randy
{
    internal class APIHelper
    {
        public static string ExecuteRequest(string address, string Data="", string Method = "GET")
        {

            string ResponseFromServer = "";
            try
            {
                ServicePointManager.Expect100Continue = true;
                //ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)192 |
(SecurityProtocolType)768 | (SecurityProtocolType)3072;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(address);
                request.Method = Method;

                request.Timeout = 10 * 1000;
                request.ReadWriteTimeout = 10 * 1000;

                //request.Accept = "application/json";
                //request.ContentType = "application/json";
                request.ContentLength = Data.Length;

                if (Method != "GET")
                    using (System.IO.Stream s = request.GetRequestStream())
                    {
                        using (System.IO.StreamWriter sw = new System.IO.StreamWriter(s))
                        {
                            sw.Write(Data);
                            sw.Flush();
                        }
                    }

                using (System.IO.Stream s = request.GetResponse().GetResponseStream())
                {
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
                    {
                        ResponseFromServer = sr.ReadToEnd();
                    }
                }


                return ResponseFromServer;
            }
            catch (WebException wex)
            {
                if (wex.Response != null)
                {
                    using (var errorResponse = (HttpWebResponse)wex.Response)
                    {
                        using (var reader = new StreamReader(errorResponse.GetResponseStream()))
                        {
                            ResponseFromServer = reader.ReadToEnd();
                        }
                    }
                }
                else
                    ResponseFromServer = wex.Message;
                return ResponseFromServer;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
