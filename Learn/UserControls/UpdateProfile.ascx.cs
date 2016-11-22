using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_UpdateProfile : System.Web.UI.UserControl
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
        divAvatarMessage.Visible = false;
        divPageMessages.Visible = false;


        if (Page.IsPostBack == false)
        {
            Initialize();
        }
    }

    #endregion Page_Load(object sender, System.EventArgs e)

    //بدنه متد اینیشیالایز
    #region Initialize()

    /// <summary>
    /// در این متد مشخصات کاربر در فیلد های نام کامل و توضیحات قرار میگیرد
    /// </summary>
    private void Initialize()
    {
        divShowAvatar.Visible = false;
        //آواتار
        DataAccessLayer.DataSet.UploadsDataTable oUploadDataTable = new DataAccessLayer.DataSet.UploadsDataTable();

        DataAccessLayer.DataSetTableAdapters.UploadsTableAdapter oUploadTableAdaptor =
            new DataAccessLayer.DataSetTableAdapters.UploadsTableAdapter();

        oUploadTableAdaptor.FillByUploadId(oUploadDataTable, (int)Session["UserID"]);

        if (oUploadDataTable.Count == 1)
        {

            DataAccessLayer.DataSet.UploadsRow oUploadRow = oUploadDataTable[0];

            divImageOfAvatar.Visible = true;
            divShowAvatar.Visible = true;
            imgAvatar.ImageUrl = "~/Uploads/" + oUploadRow.UploadFileName;

            imgAvatar.ImageAlign = System.Web.UI.WebControls.ImageAlign.AbsMiddle;

        }

        //پروفایل
        //ایجاد یک شی از کلاس دیتا ست.یوزر تیبل آداپتر
        DataAccessLayer.DataSet.UsersDataTable oUserDataTable =
            new DataAccessLayer.DataSet.UsersDataTable();

        //ایجاد یک شی از کلاس دیتا ست تیبل آدابتر دات یوزر تیبل  آداپتر
        DataAccessLayer.DataSetTableAdapters.UsersTableAdapter oUserTableAdapter =
            new DataAccessLayer.DataSetTableAdapters.UsersTableAdapter();

        //پر نمودن شی ساخته شده از تیبل آداپتر با شی ساخته شده از دیتا تیبل با متد مربوطه
        oUserTableAdapter.FillByUserId(oUserDataTable, (int)Session["UserID"]);

        //بررسی اینکه آیا کاربری وجود داشته است یا خیر
        if (oUserDataTable.Count != 1)
        {
            string strErrorMessage =
              Resources.Messages.ErrorMessage017;
            DisplayErrorMessage(strErrorMessage);
            return;
        }

        //ایجاد یک شی از کلاس دیتاست . یوزر رو و مقدار دهی آن توسط شی ساخته شده از دیتا تیبل
        DataAccessLayer.DataSet.UsersRow oUserRow = oUserDataTable[0];

        txtFullName.Text = oUserRow.FullName;
        txtDescription.Text = oUserRow.UserDescription;

    }

    #endregion Initialize()

    //بدنه ایونت کلیک برای آپدیت نمودن پروفایل
    #region UpdateProfile_btnSubmit_Click(object sender, EventArgs e)

    /// <summary>
    /// بروز رسانی صفحه پروفایل کاربر
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            //ایجاد یک شی از کلاس دیتا ست.یوزر تیبل آداپتر
            DataAccessLayer.DataSet.UsersDataTable oUsersDataTable =
                new DataAccessLayer.DataSet.UsersDataTable();

            //ایجاد یک شی از کلاس دیتا ست تیبل آدابتر دات یوزر تیبل  آداپتر
            DataAccessLayer.DataSetTableAdapters.UsersTableAdapter oUsersTableAdapter =
                new DataAccessLayer.DataSetTableAdapters.UsersTableAdapter();

            //پر نمودن شی ساخته شده از تیبل آداپتر با شی ساخته شده از دیتا تیبل با متد مربوطه
            oUsersTableAdapter.FillByUserId(oUsersDataTable, (int)Session["UserID"]);

            //بررسی اینکه آیا کاربری وجود داشته است یا خیر
            if (oUsersDataTable.Count != 1)
            {
                string strErrorMessage =
                Resources.Messages.ErrorMessage017;
                DisplayErrorMessage(strErrorMessage);
                return;
            }

            //ایجاد یک شی از کلاس دیتاست . یوزر رو و مقدار دهی آن توسط شی ساخته شده از دیتا تیبل
            DataAccessLayer.DataSet.UsersRow oUsersRow = oUsersDataTable[0];

            txtFullName.Text =
                txtFullName.Text.Trim();

            oUsersRow.FullName = txtFullName.Text;

            txtDescription.Text =
                txtDescription.Text.Trim();

            oUsersRow.UserDescription = txtDescription.Text;

            //بروز رسانی تیبل آدابتر با دیتا تیبل
            oUsersTableAdapter.Update(oUsersDataTable);

            string strInformationMessage =
            string.Format(Resources.Messages.InformationMessage006);

            DisplayInformationMessage(strInformationMessage);
        }
    }

    #endregion UpdateProfile_btnSubmit_Click(object sender, EventArgs e)

    //کلیک برای آپلود آواتار
    #region btnUpload
    protected void btnSubmit2_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {

            //در یک متغیر کمکی فایل آپلود را قرار میدهیم
            //این کنترل به اچ تی ام الی به نام اینپوت تاپ فایل تبدیل میشود
            //در وب 2 متغیر هست که اگر فضا کافی باشه این متغیر ها بدون تغییر میمانند
            //در غیر اینصورت روی این 2 متغییر عمل اورراید صورت میگیرد
            //اول متغیرهای سشن و دوم متغیرهای آپلود
            //بهمین دلیل شروطی را که برای آپلود و سشن مینویسیم معمولا در شرایط غیر طبیعی 
            //و هنگامی که رم سیستم با کمبود مواجه میشود اتفاق میافتد

            //متغیر آپلود از جنس اچ تی تی پی پستد فایل میباشد
            //جهت سهولت کار این متغیر را در یک متغیر کمکی از جنس اچ تی تی پی پستد فایل قرار میدهیم
            System.Web.HttpPostedFile oHttpPostedFile = myFileUpload.PostedFile;

            //شرایط غیر طبیعی
            if (oHttpPostedFile == null)
            {
                string strErrorMessage =
                    Resources.Messages.ErrorMessage026;

                DisplayErrorMessage(strErrorMessage);
                return;
            }

            //اگر فایل رو انتخاب نکرده باشید
            if (oHttpPostedFile.FileName.Trim() == string.Empty)
            {
                string strErrorMessage =
                    Resources.Messages.ErrorMessage027;

                DisplayErrorMessage(strErrorMessage);
                return;
            }

            //یک نمونه از پسوند فایل ها رو مورد بررسی قرار میدهیم  
            //بقیه فایل ها به همین ترتیب هست

            //فایل نیم را در یک متغیر قرار میدهیم
            string strFileName =
                System.IO.Path.GetFileName(oHttpPostedFile.FileName);
            //پسوند را در یک متغیر قرار میدهیم 
            string strFileExtension =
                System.IO.Path.GetExtension(strFileName).ToUpper();

            //اگر پسوند مورد نظر وارد نشه
            if ((strFileExtension != ".JPG") &&
                (strFileExtension != ".JPEG") &&
                (strFileExtension != ".JPE"))
            {
                string strErrorMessage =
                    Resources.Messages.ErrorMessage028;

                DisplayErrorMessage(strErrorMessage);
                return;
            }

            //ماهیت فایل را مورد بررسی قرار میدهیم 
            //تا واقعا مشخص شده فایل با پسوند مورد نظر هست و یا عمدا رینیم شده است
            //جی پی جی کانتنت تایپ بیشتر از یکی است  ولی در بقیه موارد اکثر یکی است
            string strContentType =
                oHttpPostedFile.ContentType.ToUpper();

            if ((strContentType != "IMAGE/JPEG") && // Firefox!
                (strContentType != "IMAGE/PJPEG"))  // Internet Explorer!
            {
                string strErrorMessage =
                    Resources.Messages.ErrorMessage029;

                DisplayErrorMessage(strErrorMessage);
                return;
            }

            //مشکل ترافیک سایت رو چک میکنیم که حجم آپلود شده صفر نباشه
            if (oHttpPostedFile.ContentLength == 0)
            {
                string strErrorMessage =
                    Resources.Messages.ErrorMessage030;

                DisplayErrorMessage(strErrorMessage);
                return;
            }

            //حجم فایل رو مورد بررسی قرار  میدهیم 120 کیلو بایت
            if (oHttpPostedFile.ContentLength > 120 * 1024)
            {
                string strErrorMessage =
                    Resources.Messages.ErrorMessage031;

                DisplayErrorMessage(strErrorMessage);
                return;
            }

            //اگر فایل آپلود شده تصویری نباشد چک کردن فایل تا همین مرحله کفایت میکند
            //درصورتی که فایل تصویری باشد مراحل ذیل را ادامه میدهیم

            //برای طول و عرض محدودیت قائل میشیم
            //با توجه به فرام استریم
            //اگر با فرام فایل اقدام به اینکار کنیم نیازه که ابتدا در سایت ذخیره کنیم
            //وبعد طول و عرض رو چک کنیم که این کار علاوه بر اوورهد زیاد در صورتی که فایل دارای طول و عرض مورد نظر نباشد
            //پاک کردن فایل از سرور ممکن است با مشکلاتی همراه باشد
            System.Drawing.Image oImage =
                System.Drawing.Image.FromStream(oHttpPostedFile.InputStream);

            if ((oImage.Width > 121) || (oImage.Height > 121))
            {
                string strErrorMessage =
                    Resources.Messages.ErrorMessage032;

                DisplayErrorMessage(strErrorMessage);
                return;
            }

            //اگر این مشکل ها وجود نداشت فایل رو در مسیر فیزیکی ذخیره میکنیم
            string strRootRelativePath = "~/Uploads";

            //مراحل تبدیل فایل نسبی به فایل فیزیکی
            string strPath =
                Server.MapPath(strRootRelativePath);
            //اگر فولدر وجود نداشت ایجاد میکنیم
            if (System.IO.Directory.Exists(strPath) == false)
            {
                System.IO.Directory.CreateDirectory(strPath);
            }
            //مسیر کامل را درون متغیر قرار میدهیم          
            string strPathName =
                string.Format("{0}\\{1}", strPath, strFileName);

            //ذخیره کردن نهایی
            oHttpPostedFile.SaveAs(strPathName);

            DataAccessLayer.DataSet.UploadsDataTable oUploadDataTable = new DataAccessLayer.DataSet.UploadsDataTable();

            DataAccessLayer.DataSetTableAdapters.UploadsTableAdapter oUploadTableAdaptor =
                new DataAccessLayer.DataSetTableAdapters.UploadsTableAdapter();

            oUploadTableAdaptor.FillByUploadId(oUploadDataTable, (int)Session["UserID"]);

            if (oUploadDataTable.Count == 0)
            {
                DataAccessLayer.DataSet.UploadsRow oUploadRow = oUploadDataTable.NewUploadsRow();

                oUploadRow.UploadId = (int)Session["UserID"];

                if (strPathName == string.Empty)
                {
                    oUploadRow.UploadFileName = null;
                }
                else
                {
                    oUploadRow.UploadFileName = strFileName;
                }

                oUploadDataTable.AddUploadsRow(oUploadRow);
                oUploadTableAdaptor.Update(oUploadDataTable);


            }

            else
            {
                DataAccessLayer.DataSet.UploadsRow oUploadRow = oUploadDataTable[0];


                if (strPathName == string.Empty)
                {
                    oUploadRow.UploadFileName = null;
                }
                else
                {
                    oUploadRow.UploadFileName = strFileName;
                }

                oUploadTableAdaptor.Update(oUploadDataTable);

            }




            //دیو نمایش تصویر را فعال میکنیم          
            divImageOfAvatar.Visible = true;
            //الاین نمودن تصویر در صفحه
            imgAvatar.ImageUrl = "~/Uploads/" + strFileName;
            imgAvatar.ImageAlign = System.Web.UI.WebControls.ImageAlign.AbsMiddle;
            divShowAvatar.Visible = true;
            string strInformationMessage =
                Resources.Messages.InformationMessage017;

            DisplayInformationMessage(strInformationMessage);
            return;

        }
    }

    #endregion btnUpload


    //حذف آواتار
    #region Delete Avatar
    protected void btnDelete_Click(object sender, EventArgs e)
    {

        DataAccessLayer.DataSet.UploadsDataTable oUploadDataTable = new DataAccessLayer.DataSet.UploadsDataTable();

        DataAccessLayer.DataSetTableAdapters.UploadsTableAdapter oUploadTableAdaptor =
            new DataAccessLayer.DataSetTableAdapters.UploadsTableAdapter();

        oUploadTableAdaptor.FillByUploadId(oUploadDataTable, (int)Session["UserID"]);

        if (oUploadDataTable.Count != 0)
        {

            DataAccessLayer.DataSet.UploadsRow oUploadRow = oUploadDataTable[0];

            divImageOfAvatar.Visible = true;
            divShowAvatar.Visible = false;
            imgAvatar.ImageUrl = null;
            oUploadRow.UploadFileName = string.Empty;
            oUploadTableAdaptor.Update(oUploadDataTable);

            string strInformationMessage =
                Resources.Messages.InformationMessage018;

        }


    }
    #endregion Delete Avatar

    //بدنه متد های نمایش پیام
    #region Messages()

    //متد های نمایش پیام
    protected virtual void DisplayErrorMessage(string message)
    {
        divPageMessages.Visible = true;
        litPageMessages2.Text =
            string.Format("<div class ='Error'>{0}</div>", message);
    }

    protected virtual void DisplayWarningMessage(string message)
    {
        divPageMessages.Visible = true;
        litPageMessages2.Text =
            string.Format("<div class ='Warning'>{0}</div>", message);
    }

    protected virtual void DisplayInformationMessage(string message)
    {
        divPageMessages.Visible = true;
        litPageMessages2.Text =
            string.Format("<div class ='Information'>{0}</div>", message);
    }

    #endregion Messages()

}