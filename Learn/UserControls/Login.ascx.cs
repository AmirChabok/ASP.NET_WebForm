using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_Login : System.Web.UI.UserControl
{

    //بدنه ایونت پیج لود
    #region PageLoad()

    /// <summary>
    /// ایونت پیج لود
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, System.EventArgs e)
    {
        //غیر فعال کردن قسمت بالای صفحه برای نمایش پیامها
        divPageMessage.Visible = false;

        //آدرس مسیری که کاربر درخواست کرده بود را بدست میاوریم و در یک رشته قرار میدهیم
        string strReturnUrl = Request.Params["ReturnUrl"];

        //اگر مسیر وجود نداشت
        if (string.IsNullOrEmpty(strReturnUrl) == false)
        {
            //نام صفحه را بدست میاوریم
            string strfileName =
                System.IO.Path.GetFileName(strReturnUrl);
            //پیغام خطا به کاربر نمایش میدهیم
            string strErrorMessage =
                string.Format(Resources.Messages.ErrorMessage018, strfileName);
            divPageMessage.Visible = true;
            litPageMessage.Text = strErrorMessage;
        }

        //اگر صفحه پست بک نشده بود متد اینیشیالایز را فراخوانی میکنیم
        if (Page.IsPostBack == false)
        {
            Initialize();
        }
    }

    #endregion PageLoad()

    //بدنه متد اینیشیالایز
    #region Initialize()

    /// <summary>
    /// در این متد چک میکنیم آیا فیلد ها پر شده است یا خیر
    /// </summary>
    private void Initialize()
    {

        // تکميل فيلد {0} الزامی است
        rfvUsername.ErrorMessage =
            string.Format(Resources.Messages.ErrorMessage002, Resources.Captions.Username);

        // تکميل فيلد {0} الزامی است
        rfvPassword.ErrorMessage =
            string.Format(Resources.Messages.ErrorMessage002, Resources.Captions.Password);

    }

    #endregion Initialize()

    //بدنه ایونت کلیک برای لاگین
    #region Login_btnSubmit_Click(object sender, EventArgs e)

    /// <summary>
    /// ایونت کلیک روی دکمه سابمیت
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            //چک نمودن ولید بودن صفحه
            if (Page.IsValid)
            {
                //ایجاد یک شی از کلاس دیتا ست.یوزر تیبل آداپتر
                DataAccessLayer.DataSet.UsersDataTable oUserDataTable = new DataAccessLayer.DataSet.UsersDataTable();

                //ایجاد یک شی از کلاس دیتا ست تیبل آدابتر دات یوزر تیبل  آداپتر
                DataAccessLayer.DataSetTableAdapters.UsersTableAdapter oUserTableAdapter =
                    new DataAccessLayer.DataSetTableAdapters.UsersTableAdapter();

                //پر نمودن شی ساخته شده از تیبل آداپتر با شی ساخته شده از دیتا تیبل با متد مربوطه
                oUserTableAdapter.FillByUsername(oUserDataTable, txtUsername.Text);

                //بررسی اینکه آیا کاربری وجود داشته است یا خیر
                if (oUserDataTable.Count != 1)
                {
                    string strErrorMessage = Resources.Messages.ErrorMessage013;
                    DisplayErrorMessage(strErrorMessage);
                    return;
                }

                //ایجاد یک شی از کلاس دیتاست . یوزر رو و مقدار دهی آن توسط شی ساخته شده از دیتا تیبل
                DataAccessLayer.DataSet.UsersRow oUserRow = oUserDataTable[0];

                //هش کردن گذرواژه
                string strPassword = Tools.Utility.GetSha1(txtPassword.Text);

                //بررسی یکسان بودن گذرواژه
                if (string.Compare(oUserRow.Password, strPassword, true) != 0)
                {
                    string strErrorMessage = Resources.Messages.ErrorMessage013;
                    DisplayErrorMessage(strErrorMessage);
                    return;
                }

                //بررسی فعال بودن کاربر
                if (oUserRow.IsUserActive == false)
                {
                    string strErrorMessage = string.Format(Resources.Messages.ErrorMessage014, txtUsername.Text);
                    DisplayErrorMessage(strErrorMessage);
                    return;
                }

                if (oUserRow.IsUserEmailVerified == false)
                {
                    // Your E-Mail was not verified by site! Please check your E-MailBox...
                    string strErrorMessage = string.Format(Resources.Messages.ErrorMessage019);
                    DisplayErrorMessage(strErrorMessage);
                    return;
                }

                //به تعداد لاگین های کاربر یکمقدار اضافه میکنیم
                oUserRow.LoginCount++;
                //زمان لاگین نمودن کاربر را توسط متد گت نو که در کلاس یوتیلیتی در فولدر مای وب اپلیکیشن هست ثبت میکنیم
                oUserRow.LastLoginTime = Tools.Utility.GetNow();

                //بروز رسانی تیبل آدابتر یوزر و بانک اطلاعاتی
                oUserTableAdapter.Update(oUserDataTable);

                //دو سشن شماره و نام کاربری ایجاد میکنیم 
                //سشن ها متغیر های برای یک کاربر و برای تمام صفحات وب سایت هستند
                Session["UserID"] = oUserRow.UserId;
                Session["Username"] = oUserRow.UserName;
                Session["RoleID"] = oUserRow.RoleId;

                //کاربر را ساین این میکنیم
                System.Web.Security.FormsAuthentication.RedirectFromLoginPage(oUserRow.UserName, false);
            }
        }

        catch (ApplicationException ex0)
        {
            //متغیر ای ایکس را لاگ کنید
            throw (new ApplicationException(Resources.Messages.ErrorMessage020));
        }

        catch (Exception ex)
        {
            //متغیر ای ایکس را لاگ کنید
            string strErrorMessage = string.Format(Resources.Messages.ErrorMessage020);
            DisplayErrorMessage(strErrorMessage);
            return;
        }

    }

    #endregion Login_btnSubmit_Click(object sender, EventArgs e)

    //بدنه متد های نمایش پیام
    #region Messages()

    /// <summary>
    /// متد های نمایش پیام
    /// </summary>
    /// <param name="message"></param>
    protected virtual void DisplayErrorMessage(string message)
    {
        divPageMessage.Visible = true;
        litPageMessage.Text =
            string.Format("<div class ='danger'>{0}</div>", message);
    }

    protected virtual void DisplayWarningMessage(string message)
    {
        divPageMessage.Visible = true;
        litPageMessage.Text =
            string.Format("<div class ='warning'>{0}</div>", message);
    }

    protected virtual void DisplayInformationMessage(string message)
    {
        divPageMessage.Visible = true;
        litPageMessage.Text =
            string.Format("<div class ='info'>{0}</div>", message);
    }

    #endregion Messages()

}