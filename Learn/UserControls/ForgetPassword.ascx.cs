using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_ForgetPassword : System.Web.UI.UserControl
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
    /// متد اینیشیالایز
    /// </summary>
    private void Initialize()
    {

        // تکميل فيلد {0} الزامی است
        rfvForgetPassword.ErrorMessage =
            string.Format(Resources.Messages.ErrorMessage002, Resources.Captions.Username);

        // تکميل فيلد {0} الزامی است
        rfvEmail.ErrorMessage =
            string.Format(Resources.Messages.ErrorMessage002, Resources.Captions.Email);

    }

    #endregion Initialize()

    //بدنه ایونت فراموشی گذرواژه با نام کاربری
    #region ForgetPassword_btnForgetPassword_Click(object sender, EventArgs e)

    /// <summary>
    ///  ایونت فراموشی گذرواژه با استفاده از نام کاربری
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnForgetPassword_Click(object sender, EventArgs e)
    {
        //بررسی ولید بودن صفحه
        if (Page.IsValid)
        {
            //بدنه ترای
            try
            {
                // با استفاده از متد جنریت پسورد که در  کلاس یوزرز موجود در فولدر مای وب اپلیکیشن هست اقدام به تغییر گذرواژه میکنیم
                Tools.Users.GenerateNewPasswordAndSendToUserByUserName(txtForgetPassword.Text);

                //نمایش پیام ارسال ایمیل
                divPageMessage.Visible = true;
                litPageMessage.Text = Resources.Messages.InformationMessage008;
            }

                //درصورت بروز خطا نمایش و لاگ کردن خطا در دو کچ به ترتیب

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

    #endregion ForgetPassword_btnForgetPassword_Click(object sender, EventArgs e)

    //بدنه متد فراموشی گذرواژه با ایمیل
    #region ForgetPassword_btnForgetPassword2_Click(object sender, EventArgs e)

    /// <summary>
    /// ایونت فراموشی گذرواژه با ایمیل
    /// کد ها مثل ایونت بالا میباشد
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnForgetPassword2_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            try
            {
                Tools.Users.GenerateNewPasswordAndSendToUserByUserEmail(txtEmail.Text);

                divPageMessage.Visible = true;
                litPageMessage.Text = Resources.Messages.InformationMessage008;
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

    #endregion btnForgetPassword2_Click(object sender, EventArgs e)

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
