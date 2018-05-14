using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StakeBot
{
    class RRequest:RestRequest
    {

        public RRequest(Method method)
        {
            this.Method = method;
            this.AddHeader("Cache-Control", "no-cache");
            this.AddHeader("authority", "api.stake.com");
            this.AddHeader("referer", "https://stake.com/");
            this.AddHeader("accept", "application/json");
            this.AddHeader("content-type", "application/json");
            this.AddHeader("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/66.0.3359.139 Safari/537.36");
            this.AddHeader("accept-language", "en-US,en;q=0.9");
            this.AddHeader("accept-encoding", "gzip, deflate, br");
            this.AddHeader("origin", "https://stake.com");

            if (Global.LoginToken != "" && Global.LoginToken != null)
            {
                this.AddHeader("x-access-token", Global.LoginToken);
                this.AddHeader("authorization", "Bearer " + Global.LoginToken);
            }
        }

    }
}
