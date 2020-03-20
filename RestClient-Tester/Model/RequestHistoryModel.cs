using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClient_Tester.Model
{
    public class RequestHistoryModel
    {
        public string Method { get; set; }
        public string Url { get; set; }
        public string Body { get; set; }
        public string Header { get; set; }
        public string ResponseBody { get; set; }
        public string ResponseHeader { get; set; }
        public DateTime CreateDate { get; set; }

        public RequestHistoryModel()
        {
            this.ResponseBody = "";
            this.ResponseHeader = "";
            this.CreateDate = DateTime.Now;
        }
    }
    public class RequestHeaderModel
    {
        public string HeaderKey { get; set; }
        public string HeaderValue { get; set; }
    }
}
