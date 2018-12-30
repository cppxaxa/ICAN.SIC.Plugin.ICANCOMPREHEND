using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ICAN.SIC.Plugin.ICANSEE.Client
{
    public class HttpClient
    {
        string host;
        int port;
        WebClient webClient = new WebClient();

        public HttpClient()
        {
            host = "";
            port = 0;

            configWebClient();
        }

        public HttpClient(string host, int port)
        {
            this.host = host;
            this.port = port;

            configWebClient();
        }

        private void configWebClient()
        {
            webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
        }

        public string MakeGetCall(string Url)
        {
            return webClient.DownloadString(Url);
        }

        public string MakePostCall(string body)
        {
            if (host == "")
                throw new NotImplementedException();

            configWebClient();
            return webClient.UploadString("http://" + host + ":" + port + "/task", "POST", body);
        }

        public string MakePostCall(string Url, string body)
        {
            configWebClient();
            return webClient.UploadString(Url, "POST", body);
        }
    }
}
