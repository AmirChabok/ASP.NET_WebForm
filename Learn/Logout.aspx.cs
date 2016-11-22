using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Logout : System.Web.UI.Page
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
        //تنظیمات مربوط به از بین بردن سشن
        Session.Clear();
        Session.Abandon();
        //تنظیمات مربوط به ساین اوت کردن کاربر
        System.Web.Security.FormsAuthentication.SignOut();
        //هدایت کاربر به صفحه لاگین بعد از ساین اوت شدن
        Response.Redirect("~/Login.aspx");
    }

    #endregion Page_Load(object sender, System.EventArgs e)
}