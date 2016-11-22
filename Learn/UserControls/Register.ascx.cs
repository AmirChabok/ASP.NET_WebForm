using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_WebUserControl : System.Web.UI.UserControl
{
    //بدنه ایونت پیج لود
    #region Page_Load(object sender, System.EventArgs e)

    /// <summary>
    /// ایونت پیج لود
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, System.EventArgs e)
    {
        if (Session["UserID"] != null)
        {
            Response.Redirect("Logout.aspx", false);
        }
        //غیر فعال کردن قسمت بالای صفحه برای نمایش پیامها
        divPageMessage.Visible = false;

        if (Page.IsPostBack == false)
        {
            Initialize();
        }
    }

    #endregion Page_Load(object sender, System.EventArgs e)

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

        // تکميل فيلد {0} الزامی است
        rfvConfirmPassword.ErrorMessage =
            string.Format(Resources.Messages.ErrorMessage002, Resources.Captions.ConfirmPassword);

        // تکميل فيلد {0} الزامی است
        rfvEmail.ErrorMessage =
            string.Format(Resources.Messages.ErrorMessage002, Resources.Captions.Email);

        // تکميل فيلد {0} الزامی است
        rfvMobile.ErrorMessage =
            string.Format(Resources.Messages.ErrorMessage002, Resources.Captions.Mobile);

    }

    #endregion Initialize()

    //بدنه متد بررسی برای ثبت نام
    #region CehckForRegisterUser()

    /// <summary>
    /// متد بررسی نام کاربری و ایمیل کاربر هنگام ثبت نام
    /// این متد چهار ورودی دارد
    /// به ترتیب
    /// دیتا تیبل - تیبل آداپتر - نام کاربری و رایانامه
    /// این متد یک رشته استرینگ حاوی پیام خطا برمیگرداند
    /// در صورتی که مشکل هنگام ثبت نام وجود نداشته باشد مقدار رشته خالی است
    /// </summary>
    /// <param name="oUserDataTable"></param>
    /// <param name="oUserTableAdapter"></param>
    /// <param name="username"></param>
    /// <param name="email"></param>
    /// <returns></returns>
    private string CheckRegistration(DataAccessLayer.DataSet.UsersDataTable oUserDataTable,
        DataAccessLayer.DataSetTableAdapters.UsersTableAdapter oUserTableAdapter,
        string username, string email)
    {
        //ایجاد یک پیام خطا
        string strErrorMessage = string.Empty;

        //پر نمودن شی ورودی تیبل آدابتر با شی ورودی دیتا تیبل و نام کاربری توسط متد مربوطه
        oUserTableAdapter.FillByUsername(oUserDataTable, username);

        //بررسی اینکه آیا نام کاربری وارد شده در سیستم وجود دارد یا خیر
        if (oUserDataTable.Count != 0)
        {
            if (string.IsNullOrEmpty(strErrorMessage) == false)
            {
                strErrorMessage += "<br/>";
            }

            strErrorMessage += Resources.Messages.ErrorMessage015;

        }

        //پر نمودن شی ورودی تیبل آدابتر با شی ورودی دیتا تیبل و رایانامه توسط متد مربوطه
        oUserTableAdapter.FillByUserEmail(oUserDataTable, email);

        //بررسی اینکه آیا رایانامه وارد شده در سیستم وجود دارد یا خیر
        if (oUserDataTable.Count != 0)
        {
            if (string.IsNullOrEmpty(strErrorMessage) == false)
            {
                strErrorMessage += "<br/>";
            }

            strErrorMessage += Resources.Messages.ErrorMessage016;
        }

        //ارسال پیام خطا ایجاد شده به عنوان خروجی متد
        return strErrorMessage;
    }

    #endregion CehckForRegisterUser()

    //بدنه ایونت کلیک برای ثبت نام
    #region Register_btnSubmit_Click(object sender, EventArgs e)

    /// <summary>
    /// ایونت کلیک دکمه سابمیت
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        try
        {
            //ایجاد یک شی از دیتا تیبل
            DataAccessLayer.DataSet.UsersDataTable oUserDataTable = new DataAccessLayer.DataSet.UsersDataTable();

            //ایجاد یک شی از تیبل آداپتر
            DataAccessLayer.DataSetTableAdapters.UsersTableAdapter oUserTableAdapter =
                new DataAccessLayer.DataSetTableAdapters.UsersTableAdapter();

            //ایجاد یک پیام خطا از جنس استرینگ و مقدار دهی آن با متد بررسی نام کاربری و ایمیل
            string strErrorMessage =
            CheckRegistration(oUserDataTable, oUserTableAdapter, txtUsername.Text, txtEmail.Text);

            //بررسی مقدار خروجی متد 
            if (string.IsNullOrEmpty(strErrorMessage) == false)
            {
                DisplayErrorMessage(strErrorMessage);
                return;
            }

            //ایجاد یک شی از یوزر رو و مقدار دهی آن با یک خط جدید
            DataAccessLayer.DataSet.UsersRow oUserRow = oUserDataTable.NewUsersRow();

            //مقدار دهی بقیه فیلد های جدول یوزرز در دیتا بیس با استفاده از شی یوزر رو

            //برای ایجاد انگیزه در یوزر که بعدا مثلا کاربرایی که زیاد لاگین کرده در صدر کاربران نمایش دهیم
            oUserRow.LoginCount = 0;
            oUserRow.IsUserEmailVerified = true;
            oUserRow.UserName = txtUsername.Text.ToLower();
           
            oUserRow.UserEmail = txtEmail.Text.ToLower();
            oUserRow.Mobile = txtMobile.Text;
            //فعال یا غیر فعال نمودن کاربر در هنگام ثبت نام
            oUserRow.IsUserActive = true;
            //زمان ثبت نام را ذخیره میکنیم
            System.DateTime dtmNow =
                        Tools.Utility.GetNow();

            //زمان اینسرت کردن اطلاعات یوزر در سایت رو بدست میاریم
            oUserRow.InsertTime = dtmNow;
            //زمانی که مثلا یوزر پروفایل رو آپدیت میکنه
            oUserRow.UpdateTime = dtmNow;
            //زمان آخرین لاگین را ذخیره میکنیم
            oUserRow.LastLoginTime = Tools.Utility.GetMinDateTime();
            //نقش کاربر رو مشخص میکنیم
            oUserRow.RoleId = (int)Tools.Roles.User;
            oUserRow.UserDescription = string.Empty;
            oUserRow.FullName = string.Empty;
            //گذر واژه رو هش میکنیم
            //اس اچ ای وان هر چی بهش بدین کر 40 تایی بر میگردونه
            oUserRow.Password = Tools.Utility.GetSha1(txtPassword.Text);

            string strUserEmailVerificationKey = Tools.Utility.GetGuidWithoutDash();
            oUserRow.UserEmailVerificationKey = strUserEmailVerificationKey;

            //افزودن خط جدید ایجاد شده به شی دیتا تیبل
            oUserDataTable.AddUsersRow(oUserRow);

            //افزودن دیتا تیبل ایجاد شده به تیبل آداپتر
            oUserTableAdapter.Update(oUserDataTable);
            //ارسال کلید تائید ایمیل
            //Tools.Email.SendEmailAfterRegistration(txtUsername.Text, txtPassword.Text, txtEmail.Text,"", strUserEmailVerificationKey);



            string strPathName = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/LocalizedEmailTemplates/Register.htm");
            string strEmailBody = Tools.File.Read(strPathName);

            //جایگذاری اطلاعات کاربر با قالب
            strEmailBody = strEmailBody
                            .Replace("[FULL_NAME]", oUserRow.FullName)
                            .Replace("[USER_NAME]", txtUsername.Text)
                            .Replace("[PASSWORD]", txtPassword.Text);

            //ایجاد شی از میل آدرس
            System.Net.Mail.MailAddress oMailAddress =
                new System.Net.Mail.MailAddress(oUserRow.UserEmail, oUserRow.FullName, System.Text.Encoding.UTF8);

            //################################
            //کدهای مربوط به ارسال ایمیل
            //################################

            //نمایش پیام موفقیت در ثبت نام
            string strInformationMessage =
                Resources.Messages.InformationMessage004;
            DisplayInformationMessage(strInformationMessage);
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

    #endregion Register_btnSubmit_Click(object sender, EventArgs e)

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
            string.Format("<div class ='error'>{0}</div>", message);
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
            string.Format("<div class ='information'>{0}</div>", message);
    }

    #endregion Messages()

}