using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_CreateEvent : System.Web.UI.UserControl
{
    //بدنه ایونت پیج لود
    #region Page_Load(object sender, EventArgs e)

    /// <summary>
    /// ایونت پیج لود
    /// در این ایونت قسمتهایی از صفحه را پنهان میکنیم
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        divShowAvatar.Visible = false;
        divPageMessage.Visible = false;
        if (Page.IsPostBack == false)
        {
            Initialize();
        }
    }

    #endregion Page_Load(object sender, EventArgs e)

    //بدنه متد اینیشیالایز
    #region Initialize()
    /// <summary>
    /// متد اینیشیالایز
    /// در این متد برخی از کنترل ها را فعال و غیر فعال میکنیم
    /// همچنین زمان ایجاد و بروز رسانی پست را مشخص مینمائیم
    /// </summary>
    private void Initialize()
    {
        // تکميل فيلد {0} الزامی است
        rfvSubject.ErrorMessage =
            string.Format(Resources.Messages.ErrorMessage002, Resources.Captions.Subject);

        // تکميل فيلد {0} الزامی است
        rfvPost.ErrorMessage =
            string.Format(Resources.Messages.ErrorMessage002, Resources.Captions.Post);

        // تکميل فيلد {0} الزامی است
        rfvKeyword.ErrorMessage =
            string.Format(Resources.Messages.ErrorMessage002, Resources.Captions.Keyword);

        System.DateTime dtmNow =
                 Tools.Utility.GetNow();


    }

    #endregion Initialize()

    //بدنه ایجاد پست فارسی
    #region btnSubmit_Click(object sender, EventArgs e)

    /// <summary>
    /// ایونت ایجاد پست
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //ایجاد یک شی از کلاس استریم رایتر
        System.IO.StreamWriter oStreamWriter = null;
        //اگر وجود داشت از استریم ریدر یک شی میسازیم تا محتویات فایل را بخوانیم
        System.IO.StreamReader oStreamReader = null;
        try
        {
            //با استفاده از دیتا تیبل و تیبل آدابتور یک خط جدید ایجاد میکنیم
            DataAccessLayer.DataSet.PostsDataTable oPostDataTable = new DataAccessLayer.DataSet.PostsDataTable();

            DataAccessLayer.DataSetTableAdapters.PostsTableAdapter oPostTableAdapter =
                new DataAccessLayer.DataSetTableAdapters.PostsTableAdapter();

            DataAccessLayer.DataSet.PostsRow oPostRow = oPostDataTable.NewPostsRow();

            //Sava To Database1
            //###########################################################################

            //مقدار دهی به خط ایجاد شده
            oPostRow.Body = txtPost.Text;
            oPostRow.ExtendedBody = imgAvatar.ImageUrl;
            System.DateTime dtmNow =
            Tools.Utility.GetNow();
            oPostRow.InsertTime = dtmNow;
            oPostRow.UpdateTime = dtmNow;
            oPostRow.PostCategoryId = 1;//Farsi
            oPostRow.PostTypeId = 28;//Akhbar
            oPostRow.Title = txtSubject.Text;
            oPostRow.UserId = (int)Session["UserID"];
            oPostRow.PublishTime = dtmNow;
            oPostRow.PostVisitedCount = 0;
            oPostRow.Keywords = txtKeyword1.Text;
            oPostRow.Password = string.Empty;
            oPostRow.IsHot = false;
            oPostRow.IsPostActive = true;
            oPostRow.IsCommentEnabled = false;


            //خط جدید مقدار دهی شده را به دیتا تیبل اد میکنیم
            oPostDataTable.AddPostsRow(oPostRow);
            //تیبل آدابتر و بروز رسانی دیتا بیس
            oPostTableAdapter.Update(oPostDataTable);


            //نمایش پیام موفقیت 
            string strInformationMessage =
                Resources.Messages.InformationMessage012;
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

        finally
        {
            if (oStreamReader != null)
            {
                oStreamReader.Dispose();
                oStreamReader = null;
            }

            if (oStreamWriter != null)
            {
                oStreamWriter.Dispose();
                oStreamWriter = null;
            }

        }
    }

    #endregion btnSubmit_Click(object sender, EventArgs e)

    //بدنه آپلود تصویر 
    #region UploadImage
    protected void btnUpload_Click(object sender, EventArgs e)
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
                (strFileExtension != ".JPE") &&
                (strFileExtension != ".PNG"))
            {
                string strErrorMessage =
                    Resources.Messages.ErrorMessage035;

                DisplayErrorMessage(strErrorMessage);
                return;
            }

            //ماهیت فایل را مورد بررسی قرار میدهیم 
            //تا واقعا مشخص شده فایل با پسوند مورد نظر هست و یا عمدا رینیم شده است
            //جی پی جی کانتنت تایپ بیشتر از یکی است  ولی در بقیه موارد اکثر یکی است
            string strContentType =
                oHttpPostedFile.ContentType.ToUpper();

            if ((strContentType != "IMAGE/JPEG") && // Firefox!
                (strContentType != "IMAGE/PJPEG") &&// Internet Explorer!
                (strContentType != "IMAGE/PNG"))
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

            //حجم فایل رو مورد بررسی قرار  میدهیم 300 کیلو بایت
            if (oHttpPostedFile.ContentLength > 800 * 800)
            {
                string strErrorMessage =
                    Resources.Messages.ErrorMessage034;

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

            if ((oImage.Width > 800) || (oImage.Height > 800))
            {
                string strErrorMessage =
                    Resources.Messages.ErrorMessage033;

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

            //دیو نمایش تصویر را فعال میکنیم          
            divImageOfAvatar.Visible = true;
            //الاین نمودن تصویر در صفحه
            imgAvatar.ImageUrl = "../Uploads/" + strFileName;
            imgAvatar.ImageAlign = System.Web.UI.WebControls.ImageAlign.AbsMiddle;
            divShowAvatar.Visible = true;
            string strInformationMessage =
                Resources.Messages.InformationMessage017;

            DisplayInformationMessage(strInformationMessage);
            return;
        }
    }
    #endregion Upload Image

    //بدنه حذف تصویر
    #region Delete Avatar
    protected void btnDeleteAvatar_Click(object sender, EventArgs e)
    {
        divImageOfAvatar.Visible = true;
        divShowAvatar.Visible = false;
        imgAvatar.ImageUrl = null;

        string strInformationMessage =
            Resources.Messages.InformationMessage018;
    }

    #endregion Delete Avatar

    //بدنه متد های نمایش پیام
    #region Messages()

    /// <summary>
    /// متد های نمایش پیام
    /// </summary>
    /// <param name="message"></param>
    protected virtual void DisplayErrorMessage(string message)
    {
        divPageMessage.Visible = true;
        litPageMessages.Text =
            string.Format("<div class ='error'>{0}</div>", message);
    }

    protected virtual void DisplayWarningMessage(string message)
    {
        divPageMessage.Visible = true;
        litPageMessages.Text =
            string.Format("<div class ='warning'>{0}</div>", message);
    }

    protected virtual void DisplayInformationMessage(string message)
    {
        divPageMessage.Visible = true;
        litPageMessages.Text =
            string.Format("<div class ='information'>{0}</div>", message);
    }

    #endregion Messages()
}