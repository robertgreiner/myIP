using System;
using System.Net;
using System.Text;

namespace myIP {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            ClientIP.Text = GetExternalIp();
        }
        private string GetExternalIp() {
            string ip = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (String.IsNullOrEmpty(ip)) {
                ip = Request.ServerVariables["REMOTE_ADDR"];
            }
            return ip;
        }
    }
}