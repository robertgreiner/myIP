myIP
==========

just goofing off with ASP .NET and HttpContext.Current.Request.ServerVariables

Note: If you run this on your local machine you will get 127.0.0.1 as a result.

Usage
-----

Navigate to the page and your IP address will be displayed.

Code
------

    private string GetExternalIp() {
        string ip = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
        if (String.IsNullOrEmpty(ip)) {
            ip = Request.ServerVariables["REMOTE_ADDR"];
        }
        return ip;
    }

Copyright
---------

Copyright (c) 2011 <a href="http://creatingcode.com">Robert Greiner</a>. See LICENSE for details.
