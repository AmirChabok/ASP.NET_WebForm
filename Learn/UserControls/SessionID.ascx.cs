using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_SessionID : System.Web.UI.UserControl
{

    //بدنه ایونت پیج لود
    #region Page_Load(object sender, System.EventArgs e)

    /// <summary>
    /// ایونت پیج لود
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        //تعداد کاربران آنلاین را نمایش میدهیم
        litOnLineUserCount.Text =
           string.Format("| " + Resources.Captions.OnlineUser +": {0:#,##0}", Application["OnLineUserCount"]);
        //شناسه نشست کاربر را نمایش میدهیم
        litSessionId.Text =
            string.Format("* " + Resources.Captions.SessionID + ": {0}", Session.SessionID);

    }

    #endregion Page_Load(object sender, System.EventArgs e)
}