using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_ChangePassword : System.Web.UI.UserControl
{
    //ایونت پیج لود
    #region LoadPage_Page_Load(object sender, EventArgs e)

    protected void Page_Load(object sender, EventArgs e)
    {

        //divAvatarMessage.Visible = false;
        txtUsername.ReadOnly = true;
        txtUsername.Text = (string)Session["Username"];

        if (Page.IsPostBack == false)
        {
            Initialize();
        }
    }

    #endregion Page_Load(object sender, EventArgs e)

    //متد اینیشیالایز
    #region Initialize()

    /// <summary>
    /// متد اینیشیالایز
    /// </summary>
    private void Initialize()
    {
        // لطفا قبل از ادامه عمليات خطاهای ذيل را بررسی
        // و برطرف نموده و سپس ادامه دهيد


        // تکميل فيلد {0} الزامی است
        rfvNewPassword.ErrorMessage =
            string.Format(Resources.Messages.ErrorMessage002, Resources.Captions.Password);

    }

    #endregion Initialize()

    //ایونت تغییر گذرواژه
    #region ChangePassword_btnChangePassword_Click(object sender, EventArgs e)
    /// <summary>
    /// متد تغییر گذرواژه
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            try
            {
                //ایجاد یک شی از یوزرز دیتا تیبل
                DataAccessLayer.DataSet.UsersDataTable oUserDataTable = new DataAccessLayer.DataSet.UsersDataTable();
                //ایجاد یک شی از  یوزرز تیبل آدابتر
                DataAccessLayer.DataSetTableAdapters.UsersTableAdapter oUserTableAdapter =
                    new DataAccessLayer.DataSetTableAdapters.UsersTableAdapter();
                //فیل کردن تیبل آدابتر با دیتاتیبل و متد مربوطه
                oUserTableAdapter.FillByUsername(oUserDataTable, txtUsername.Text);

                //اگر مقداری وجود نداشت
                if (oUserDataTable.Count != 1)
                {
                    //نمایش پیغام خطا
                    litPageMessages.Text = string.Format
                          (Resources.Messages.ErrorMessage021);
                }

                //در غیر اینصورت یک خط از مشخصات همان کاربر در هوا میگیریم
                DataAccessLayer.DataSet.UsersRow oUserRow = oUserDataTable[0];

                //مقدار دهی خط در دیتا بیس توسط کنترل های تکست باکس موجود در صفحه
                string strFullName = oUserRow.FullName;
                string strUserEmail = oUserRow.UserEmail;
                string strNewPassword = txtNewPassword.Text;
                //هش کردن گذر واژه
                string strHashOfNewPassword = Tools.Utility.GetSha1(strNewPassword);
                oUserRow.Password = strHashOfNewPassword;
                oUserTableAdapter.Update(oUserDataTable);
                //مراحل خواندن قالب از آدرس ذیل
                string strPathName = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/LocalizedEmailTemplates/ForgotPasswordUserEmail.htm");
                string strEmailBody = Tools.File.Read(strPathName);
                //جایگزینی مقادیر قالب توسط مقادیر مرتبط
                strEmailBody = strEmailBody
                .Replace("[FULL_NAME]", strFullName)
                .Replace("[USER_NAME]", txtUsername.Text)
                .Replace("[PASSWORD]", strNewPassword);

                //ارسال رایانامه برای کاربر
                System.Net.Mail.MailAddress oMailAddress =
                    new System.Net.Mail.MailAddress(strUserEmail, strFullName, System.Text.Encoding.UTF8);

                //################################
                //کدهای مربوط به ارسال ایمیل
                //################################

                //نمایش پیغام موفقیت
                divPageMessages.Visible = true;
                litPageMessages.Text = string.Format(Resources.Messages.InformationMessage007);

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
    }
    #endregion btnChangePassword_Click(object sender, EventArgs e)


    //بدنه متد های نمایش پیام
    #region Messages()

    /// <summary>
    /// متد های نمایش پیام
    /// </summary>
    /// <param name="message"></param>
    protected virtual void DisplayErrorMessage(string message)
    {
        divPageMessages.Visible = true;
        litPageMessages.Text =
            string.Format("<div class ='error'>{0}</div>", message);
    }

    protected virtual void DisplayWarningMessage(string message)
    {
        divPageMessages.Visible = true;
        litPageMessages.Text =
            string.Format("<div class ='warning'>{0}</div>", message);
    }

    protected virtual void DisplayInformationMessage(string message)
    {
        divPageMessages.Visible = true;
        litPageMessages.Text =
            string.Format("<div class ='information'>{0}</div>", message);
    }

    #endregion Messages()
}