<%@ Application Language="C#" %>

<script RunAt="server">

    void Application_Start(object sender, EventArgs e)
    {
        /////////////////////////////////////////////////
        Application.Lock();
        Application["OnLineUserCount"] = 0;
        Application.UnLock();
        /////////////////////////////////////////////////
        
        string strPathName = Server.MapPath("~/App_Data/Logs/TotalUserCount.log");

    }

    void Session_Start(object sender, EventArgs e)
    {
        /////////////////////////////////////////////////
        Application.Lock();
        Application["OnLineUserCount"] =
            Convert.ToInt64(Application["OnLineUserCount"]) + 1;
        Application.UnLock();
        /////////////////////////////////////////////////
    }

    void Session_End(object sender, EventArgs e)
    {
        /////////////////////////////////////////////////
        Application.Lock();
        Application["OnLineUserCount"] =
            Convert.ToInt64(Application["OnLineUserCount"]) - 1;
        Application.UnLock();
        /////////////////////////////////////////////////
        
    }

    void Application_Error(object sender, EventArgs e)
    {
        if ((Server != null) &&
        (Server.GetLastError() != null) &&
        (Server.GetLastError().GetBaseException() != null))
        {
            System.Exception ex =
                Server.GetLastError().GetBaseException();

            string strErrorMessage =
                string.Format("{0} Time:{1:yyyy/mm/dd - hh:mm:ss},Path:{2},User IP{3}",
                ex.Message,
                System.DateTime.Now,
                Request.PhysicalPath,
                Request.UserHostAddress);

            Application.Lock();

            System.IO.StreamWriter oStreamWriter = null;

            try
            {
                string strApplicationPath =
                    "~/App_Data/Log/Application.log";

                string strApplicationPathName =
                    Server.MapPath(strApplicationPath);

                oStreamWriter =
                    new System.IO.StreamWriter(strApplicationPathName, true, System.Text.Encoding.UTF8);

                oStreamWriter.WriteLine(strErrorMessage);

            }
            catch
            {

            }

            finally
            {
                if (oStreamWriter != null)
                {
                    oStreamWriter.Dispose();
                    oStreamWriter = null;
                }
            }

            Application.UnLock();
        }

    }

    void Application_End(object sender, EventArgs e)
    {
    }
        
   

   
       
</script>
