using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Administrator_UserControls_MangeUsers02 : System.Web.UI.UserControl
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
		divPageMessage.Visible = false;
        if (Page.IsPostBack == false)
        {
            Initialize();
        }
    }

    #endregion Page_Load(object sender, System.EventArgs e)

    //بدنه مربوط به متد اینیشیالایز
    #region Initialize()
    /// <summary>
    /// متد ذیل در هنگام بارگزاری صفحه اتفاق میفتد
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
        rfvEmail.ErrorMessage =
            string.Format(Resources.Messages.ErrorMessage002, Resources.Captions.Email);

		// تکميل فيلد {0} الزامی است
		rfvEmail.ErrorMessage =
			string.Format(Resources.Messages.ErrorMessage002, Resources.Captions.Mobile);

        try
        {
            //غیر فعال کردن برخی از فیلدها
            txtUserID.Enabled = false;
            txtRoleID.Enabled = false;
            txtPassword.Enabled = false;
            txtEmail.Enabled = false;
            btnCreateUser.Visible = false;
            //تعریف یک رشته که حاوی یوزر آی دی از آدرس بار میباشد
            string strUserId = Request.Params["UserID"];

            //تعریف دیتا تیبل
            DataAccessLayer.DataSet.UsersDataTable oUserDataTable = new DataAccessLayer.DataSet.UsersDataTable();

            //تعریف تیبل آدابتر
            DataAccessLayer.DataSetTableAdapters.UsersTableAdapter oUserTableAdapters =
                new DataAccessLayer.DataSetTableAdapters.UsersTableAdapter();
            //فیل کردن تیبل آدابتر با دیتا تیبل و متد مربوطه
            oUserTableAdapters.FillByUserId(oUserDataTable, Convert.ToInt32(strUserId));

            //اگر کاربری وجود نداشت
            if (oUserDataTable.Count != 1)
            {
                string strErrorMessage = Resources.Messages.ErrorMessage013;
                DisplayErrorMessage(strErrorMessage);
                return;
            }

            //داشتن مشخصات کاربر در یک خط
            DataAccessLayer.DataSet.UsersRow oUserrow = oUserDataTable[0];

            //بایند کردن کنترل های صفحه از دیتا بیس
            txtEmail.Text = oUserrow.UserEmail;
            txtPassword.Text = oUserrow.Password;
            txtRoleID.Text = oUserrow.RoleId.ToString();
            txtUserID.Text = oUserrow.UserId.ToString();
            txtUsername.Text = oUserrow.UserName;
			txtMobile.Text = oUserrow.Mobile.ToString();

            //تطابق دراب دان لیست با نام رول که توسط رول آی دی گرفته شده است
            switch (txtRoleID.Text)
            {
                case "0":
                    {
                        ddlRoleId.SelectedValue = "0";
                        break;
                    }

                case "900":
                    {
                        ddlRoleId.SelectedValue = "900";
                        break;
                    }

                case "100":
                    {
                        ddlRoleId.SelectedValue = "100";
                        break;
                    }

                case "200":
                    {
                        ddlRoleId.SelectedValue = "200";
                        break;
                    }

                case "300":
                    {
                        ddlRoleId.SelectedValue = "300";
                        break;
                    }

                case "400":
                    {
                        ddlRoleId.SelectedValue = "400";
                        break;
                    }

                case "500":
                    {
                        ddlRoleId.SelectedValue = "500";
                        break;
                    }

                case "600":
                    {
                        ddlRoleId.SelectedValue = "600";
                        break;
                    }

                case "700":
                    {
                        ddlRoleId.SelectedValue = "700";
                        break;
                    }

                case "800":
                    {
                        ddlRoleId.SelectedValue = "800";
                        break;
                    }

                default:
                    {
                        ddlRoleId.SelectedValue = "0";
                        break;
                    }

            }

            //اگر کاربر فعال بود چک باکس مربوطه فعال شود
            if (oUserrow.IsUserActive == true)
            {
                chkUserActive.Checked = true;

            }
            //در غیر اینصورت غیر فعال شود
            else
            {
                chkUserActive.Checked = false;

            }

            //اگر ایمیل کاربر تائید شده بود چک باکس مربوطه فعال شود
            if (oUserrow.IsUserEmailVerified == true)
            {
                chkEmailVerified.Checked = true;

            }
            //در غیر اینصورت غیر فعال شود
            else
            {
                chkEmailVerified.Checked = false;

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

    #endregion Initialize()

    //بدنه مربوط به ویرایش اطلاعات کاربر
    #region EditUsers_btnEdit_Click(object sender, EventArgs e)
    /// <summary>
    /// ایونت کلیک دکمه ویرایش
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        try
        {
            //تعریف دیتا تیبل
            DataAccessLayer.DataSet.UsersDataTable oUserDataTable = new DataAccessLayer.DataSet.UsersDataTable();
            //تعریف تیبل آدابتر
            DataAccessLayer.DataSetTableAdapters.UsersTableAdapter oUserTableAdapter =
                new DataAccessLayer.DataSetTableAdapters.UsersTableAdapter();
            //فیل نمودن تیبل آدابتر با دیتا تیبل و متد مربوطه
            oUserTableAdapter.FillByUserId(oUserDataTable, Convert.ToInt32(txtUserID.Text));
            //داشتن مشخصات کاربر در یک خط
            DataAccessLayer.DataSet.UsersRow oUserRow = oUserDataTable[0];
            //اگر کاربری وجود نداشت
            if (oUserDataTable.Count != 1)
            {
                string strErrorMessage =
                Resources.Messages.ErrorMessage017;
                DisplayErrorMessage(strErrorMessage);
                return;
            }
            //در غیر اینصورت مقادیر کنترل ها در دیتا بیس مینشیند
            oUserRow.IsUserEmailVerified = chkEmailVerified.Checked;
            oUserRow.IsUserActive = chkUserActive.Checked;

            //نشاندن مقدار رشته ای رول در دیتابیس و تطابق آن با تکست باکس رول آی دی
            switch (ddlRoleId.SelectedItem.Text)
            {
                case "None":
                    {
                        //تطابق
                        txtRoleID.Text = ddlRoleId.SelectedValue.ToString();
                        //نشاندن در دیتابیس
                        oUserRow.RoleId = 0;
                        break;
                    }

                case "User":
                    {
                        txtRoleID.Text = ddlRoleId.SelectedValue.ToString();
                        oUserRow.RoleId = 900;
                        break;
                    }

                case "Programmer":
                    {
                        txtRoleID.Text = ddlRoleId.SelectedValue.ToString();
                        oUserRow.RoleId = 100;
                        break;
                    }

                case "Administrator":
                    {
                        txtRoleID.Text = ddlRoleId.SelectedValue.ToString();
                        oUserRow.RoleId = 200;
                        break;
                    }

                case "Editor":
                    {
                        txtRoleID.Text = ddlRoleId.SelectedValue.ToString();
                        oUserRow.RoleId = 300;
                        break;
                    }

                case "SuperUser":
                    {
                        txtRoleID.Text = ddlRoleId.SelectedValue.ToString();
                        oUserRow.RoleId = 400;
                        break;
                    }

                case "Manager":
                    {
                        txtRoleID.Text = ddlRoleId.SelectedValue.ToString();
                        oUserRow.RoleId = 500;
                        break;
                    }

                case "SuperVisor":
                    {
                        txtRoleID.Text = ddlRoleId.SelectedValue.ToString();
                        oUserRow.RoleId = 600;
                        break;
                    }

                case "Reporter":
                    {
                        txtRoleID.Text = ddlRoleId.SelectedValue.ToString();
                        oUserRow.RoleId = 700;
                        break;
                    }

                case "SpecialUser":
                    {
                        txtRoleID.Text = ddlRoleId.SelectedValue.ToString();
                        oUserRow.RoleId = 800;
                        break;
                    }

            }

            //بروز رسانی دیتا بیس
            oUserTableAdapter.Update(oUserDataTable);

            //نمایش پیام موفقیت در عملیات
			divPageMessage.Visible = true;
            string strInformationMessage =
                Resources.Messages.InformationMessage009;
            litPageMessage.Text = strInformationMessage;

            string strPathName = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/LocalizedEmailTemplates/UserEdit.htm");
            string strEmailBody = Tools.File.Read(strPathName);

            //جایگذاری اطلاعات کاربر با قالب
			strEmailBody = strEmailBody
							.Replace("[USER_NAME]", txtUsername.Text)
							.Replace("[ROLE ID]", ddlRoleId.SelectedItem.Text)
							.Replace("[ACTIVE]", chkUserActive.Checked.ToString())
							.Replace("[VERIFIED]", chkEmailVerified.Checked.ToString());
                            

            //ایجاد شی از میل آدرس
            System.Net.Mail.MailAddress oMailAddress =
                new System.Net.Mail.MailAddress(oUserRow.UserEmail, oUserRow.FullName, System.Text.Encoding.UTF8);

            //################################
            //کدهای مربوط به ارسال ایمیل
            //################################
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

    #endregion EditUsers_btnEdit_Click(object sender, EventArgs e)

    //بدنه مربوط به ایجاد کاربر
    #region CreateUsers_btnCreateUser_Click(object sender, EventArgs e)
    /// <summary>
    /// متد ایجاد یک کاربر جدید توسط ادمین
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnCreateUser_Click(object sender, EventArgs e)
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
            oUserRow.IsUserEmailVerified = chkEmailVerified.Checked;
            oUserRow.UserName = txtUsername.Text.ToLower();
            oUserRow.Password = txtPassword.Text;
            oUserRow.UserEmail = txtEmail.Text.ToLower();
			oUserRow.Mobile = txtMobile.Text;
            //فعال یا غیر فعال نمودن کاربر در هنگام ثبت نام
            oUserRow.IsUserActive = chkUserActive.Checked;
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
            oUserRow.RoleId = Convert.ToInt32(ddlRoleId.SelectedValue);
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

            //نمایش پیام موفقیت در ثبت نام
			divPageMessage.Visible = true;
            string strInformationMessage =
                Resources.Messages.InformationMessage010;
            litPageMessage.Text = strInformationMessage;

            string strPathName = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/LocalizedEmailTemplates/CreateUser.htm");
            string strEmailBody = Tools.File.Read(strPathName);

            //جایگذاری اطلاعات کاربر با قالب
            strEmailBody = strEmailBody
                            .Replace("[FULL_NAME]", oUserRow.FullName)
                            .Replace("[USER_NAME]", txtUsername.Text)
                            .Replace("[PASSWORD]", txtPassword.Text)
                            .Replace("[ACTIVE]", chkUserActive.Checked.ToString())
                            .Replace("[VERIFIED]", chkEmailVerified.Checked.ToString())
                            .Replace("[ROLE ID]", ddlRoleId.SelectedItem.Text);

            //ایجاد شی از میل آدرس
            System.Net.Mail.MailAddress oMailAddress =
                new System.Net.Mail.MailAddress(oUserRow.UserEmail, oUserRow.FullName, System.Text.Encoding.UTF8);

            //################################
            //کدهای مربوط به ارسال ایمیل
            //################################

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

    #endregion CreateUsers_btnCreateUser_Click(object sender, EventArgs e)

    //بدنه مربوط به پاک کردن فرم
    #region ClareForm_btnCancel_Click(object sender, EventArgs e)
    /// <summary>
    /// متد پاک نمودن فرم ویرایش کاربر
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //غیر فعال کردن تعدادی از کنترل ها و پاک نمودن تعدادی دیگر
        btnEdit.Visible = false;
        btnDeleteUser.Visible = false;
        btnCancel.Visible = false;
        btnCreateUser.Visible = true;
        txtEmail.Text = string.Empty;
        txtPassword.Text = string.Empty;
        txtRoleID.Visible = false;
        lblRoleID.Visible = false;
        txtUserID.Visible = false;
        lblUserID.Visible = false;
        txtUsername.Text = string.Empty;
		txtMobile.Text = string.Empty;
        txtEmail.Enabled = true;
        txtPassword.Enabled = true;
		txtMobile.Enabled = true;
        txtUsername.Enabled = true;
        chkUserActive.Checked = false;
        chkEmailVerified.Checked = false;
    }

    #endregion ClareForm_btnCancel_Click(object sender, EventArgs e)

    //بدنه مربوط به حذف کاربر
    #region DeleteUsers_btnDeleteUser_Click(object sender, EventArgs e)
    /// <summary>
    /// متد حذف کاربر توسط ادمین
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnDeleteUser_Click(object sender, EventArgs e)
    {

        try
        {
            //ایجاد یک شی از کلاس دیتا ست تیبل آدابتر دات یوزر تیبل  آداپتر
            DataAccessLayer.DataSetTableAdapters.UsersTableAdapter oUserTableAdapter =
                new DataAccessLayer.DataSetTableAdapters.UsersTableAdapter();

            //ایجاد یک اینتیجر که یا یک میشود یا صفر
            //یک شدن به این معنا است که کاربر با نام کاربر وارد شده حذف گردیده
            //صفر شدن به این معناست که کاربری یا نام کاربری وارد شده وجود ندارد
            int intAffectedRows =
                    oUserTableAdapter.DeleteByUsername(txtUsername.Text);

            //اگر صفر بود
            if (intAffectedRows == 0)
            {
                string strErrorMessage =
                    Resources.Messages.ErrorMessage017;
                //نمایش پیام کاربری با مشخصات وارد شده وجود ندارد
                DisplayErrorMessage(strErrorMessage);
                return;
            }


            //اگر یک بود
            string strInformationMessage =
                   string.Format(Resources.Messages.InformationMessage005,
                   txtUsername.Text);
            //نمایش پیام حذف کاربر با موفقیت انجام شد
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
    #endregion btnDeleteUser_Click(object sender, EventArgs e)

    //بدنه مربوط به بررسی و صحت نام کاربری و رایانامه در هنگام ایجاد کاربر
    #region CheckForRegisterUser

    /// <summary>
    /// متد بررسی نام کاربری و ایمیل هنگام ایجاد کاربر
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

    #endregion CheckForRegisterUser

    //بدنه ایونت کلیک لینک باتن
    #region lnbManageUsers_Click(object sender, EventArgs e)

    /// <summary>
    ///  ایونت کلیک لینک باتن
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnbManageUsers_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Administrator/UserControl.aspx");
        return;
    }

    #endregion lnbManageUsers_Click(object sender, EventArgs e)

    //بدنه مربوط به متد های نمایش پیام
    #region Messages()

    /// <summary>
    /// متد های نمایش پیام
    /// </summary>
    /// <param name="message"></param>
    protected virtual void DisplayErrorMessage(string message)
    {
        divPageMessage.Visible = true;
        litPageMessage.Text =
            string.Format("<div class ='Error'>{0}</div>", message);
    }

    protected virtual void DisplayWarningMessage(string message)
    {
        divPageMessage.Visible = true;
        litPageMessage.Text =
            string.Format("<div class ='Warning'>{0}</div>", message);
    }

    protected virtual void DisplayInformationMessage(string message)
    {
        divPageMessage.Visible = true;
        litPageMessage.Text =
            string.Format("<div class ='Information'>{0}</div>", message);
    }

    #endregion Messages()

}

