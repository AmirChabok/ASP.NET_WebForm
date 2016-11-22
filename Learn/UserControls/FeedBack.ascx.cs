using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_FeedBack : System.Web.UI.UserControl
{
    #region PageLoad()
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    #endregion PageLoad()

    //بدنه ایونت کلیک روی دکه 
    #region ClickforContact
    // ایونت کلیک دکمه 
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            try
            {

                //بادی را این کدینگ میکنیم
                //Assign Email Template
                string strPathName = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/LocalizedEmailTemplates/Contact.htm");
                string strBody = Tools.File.Read(strPathName);

                //Replace User's data in Email body
                strBody = strBody
                                .Replace("[NAME]", txtName.Text)
                                .Replace("[MAIL]", txtMail.Text)
                                .Replace("[COMMENT]", txtComment.Text);

                //ایجاد شی از میل آدرس
                System.Net.Mail.MailAddress oMailAddress =
                    new System.Net.Mail.MailAddress(txtMail.Text, txtName.Text, System.Text.Encoding.UTF8);

                //################################
                //کدهای مربوط به ارسال ایمیل
                //################################

                string strInformationMessage =
                    "پیام شما با موفقیت ارسال شد و در صورت نیاز به آن پاسخ خواهیم داد";
                divPageMessage.Visible = true;
                litPageMessage.Text = strInformationMessage;

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

    //متد نمایش خطا
    //میتوانیم به جای این متد از دیو پیج مسیج استفاده کنیم
    protected virtual void DisplayErrorMessage(string message)
    {
        divPageMessage.Visible = true;

        litPageMessage.Text =
            string.Format("<div class='panel panel-danger'>{0}</div>", message);
    }

    #endregion ClickforContact
}