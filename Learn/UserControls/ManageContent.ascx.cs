using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_ManageContent : System.Web.UI.UserControl
{
    
	#region Page_Load(object sender, System.EventArgs e)

	/// <summary>
	/// ایونت پیج لود
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	protected void Page_Load(object sender, EventArgs e)
	{
		btnDeleteAllPosts.Visible = false;
        btnCreatePost.Visible = false;
		divShowAvatar.Visible = false;
		divPageMessage.Visible = false;
        txtInsertTime.Enabled = false;
        txtPublishTime.Enabled = false;
        txtPostID.Enabled = false;
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
		rfvPost.ErrorMessage =
			string.Format(Resources.Messages.ErrorMessage002, Resources.Captions.Post);

		// تکميل فيلد {0} الزامی است
		rfvPostTypeId.ErrorMessage =
			string.Format(Resources.Messages.ErrorMessage002, Resources.Captions.PostTypeId);

		// تکميل فيلد {0} الزامی است
		rfvPostCategoryId.ErrorMessage =
			string.Format(Resources.Messages.ErrorMessage002, Resources.Captions.PostCategoryId);

		// تکميل فيلد {0} الزامی است
		rfvTitle.ErrorMessage =
			string.Format(Resources.Messages.ErrorMessage002, Resources.Captions.Title);

		// تکميل فيلد {0} الزامی است
		rfvKeyword1.ErrorMessage =
			string.Format(Resources.Messages.ErrorMessage002, Resources.Captions.Keyword);


		try
		{
            //تعریف یک رشته که حاوی یوزر آی دی از آدرس بار میباشد
            string strPostId = Request.Params["PostId"];
            txtPostID.Text = strPostId;

            //با استفاده از دیتا تیبل و تیبل آدابتر مقادیر را  در صورت وجود از دیتا بیس خوانده و در یک خط قرار میدهیم
            DataAccessLayer.DataSet.PostsDataTable oPostDataTable = new DataAccessLayer.DataSet.PostsDataTable();

            DataAccessLayer.DataSetTableAdapters.PostsTableAdapter oPostTableAdapter =
                new DataAccessLayer.DataSetTableAdapters.PostsTableAdapter();

            oPostTableAdapter.FillByPostId(oPostDataTable, Convert.ToInt32(strPostId));

            if (oPostDataTable.Count == 0)
            {
                string strErrorMessage = string.Format(Resources.Messages.ErrorMessage020);
                DisplayErrorMessage(strErrorMessage);
                return;
            }

            DataAccessLayer.DataSet.PostsRow oPostRow = oPostDataTable[0];

            ////مقدار دهی کنترل های صفحه از دیتابیس توسط خط ایجاد شده
            txtPost.Text = oPostRow.Body;
            txtTitle.Text = oPostRow.Title;
            txtPostTypeId.Text = oPostRow.PostTypeId.ToString();
            txtPostCategoryId.Text = oPostRow.PostCategoryId.ToString();
            txtKeyword1.Text = oPostRow.Keywords;
            txtPublishTime.Text = oPostRow.PublishTime.ToString();
            txtUpdateTime.Text = oPostRow.UpdateTime.ToString();
            txtInsertTime.Text = oPostRow.InsertTime.ToString();
            chkIsCommentEnabled.Checked = oPostRow.IsCommentEnabled;
            chkIsHot.Checked = oPostRow.IsHot;
            chkIsPostActive.Checked = oPostRow.IsPostActive;
            ddlPostCategory.SelectedIndex = oPostRow.PostCategoryId;
            ddlPostType.SelectedIndex = oPostRow.PostTypeId;

            //بروز رسانی تیبل آدابتر و بانک اطلاعات
            oPostTableAdapter.Update(oPostDataTable);
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

	//بدنه متد اینیشیالایز
	#endregion Initialize()


	//بدنه ایونت ویرایش پست
	#region btnEdit_Click(object sender, EventArgs e)

	/// <summary>
	/// ایونت ویرایش پست
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        try
        {
            //با استفاده از دیتا تیبل و تیبل آدابتور یک خط جدید ایجاد میکنیم

            DataAccessLayer.DataSet.PostsDataTable oPostDataTable = new DataAccessLayer.DataSet.PostsDataTable();

            DataAccessLayer.DataSetTableAdapters.PostsTableAdapter oPostTableAdapter =
                new DataAccessLayer.DataSetTableAdapters.PostsTableAdapter();

            oPostTableAdapter.FillByPostId(oPostDataTable,Convert.ToInt32(txtPostID.Text));

            DataAccessLayer.DataSet.PostsRow oPostRow = oPostDataTable[0];

            if (oPostDataTable.Count != 1)
            {
                string strErrorMessage =
                Resources.Messages.ErrorMessage017;
                DisplayErrorMessage(strErrorMessage);
                return;
            }

            System.DateTime dtmNow =
                              Tools.Utility.GetNow();

            //مقدار دهی به خط ایجاد شده
            oPostRow.Body = txtPost.Text;
            oPostRow.ExtendedBody = string.Empty; ;
            oPostRow.InsertTime = dtmNow;
            oPostRow.UpdateTime = dtmNow;
            oPostRow.PostCategoryId = Convert.ToInt32(txtPostCategoryId.Text);
            oPostRow.PostTypeId = Convert.ToInt32(txtPostTypeId.Text);
            oPostRow.Title = txtTitle.Text;
            oPostRow.UserId = (int)Session["UserID"];
            oPostRow.PublishTime = dtmNow;
            oPostRow.PostVisitedCount += 1;
            oPostRow.Keywords = txtKeyword1.Text;


            if (chkIsHot.Checked == true)
            {
                oPostRow.IsHot = true;
            }
            else
                oPostRow.IsHot = false;

            if (chkIsPostActive.Checked == true)
            {
                oPostRow.IsPostActive = true;
            }
            else
                oPostRow.IsPostActive = false;

            if (chkIsCommentEnabled.Checked == true)
            {
                oPostRow.IsCommentEnabled = true;
            }
            else
                oPostRow.IsCommentEnabled = false;

           
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
    }


	#endregion btnEdit_Click(object sender, EventArgs e)


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

	//بدنه ایونت پاک کردن فرم پست
	#region protected void btnCancel_Click(object sender, EventArgs e)

	/// <summary>
	/// ایونت پاک کردن فرم
	/// تعدادی از کنترل ها رو فعال و غیر فعال میکنیم
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	protected void btnCancel_Click(object sender, EventArgs e)
	{
		System.DateTime dtmNow =
						  Tools.Utility.GetNow();
		btnEdit.Visible = false;
		btnDeletePost.Visible = false;
		btnCancel.Visible = false;
		btnCreatePost.Visible = true;
		txtInsertTime.Text = dtmNow.ToString();
		txtPublishTime.Text = dtmNow.ToString();
		txtUpdateTime.Text = dtmNow.ToString();
		txtKeyword1.Text = string.Empty;
		txtPost.Text = string.Empty;
		txtPostCategoryId.Text = string.Empty;
		txtPostTypeId.Text = string.Empty;
		txtTitle.Text = string.Empty;
		chkIsCommentEnabled.Checked = false;
		chkIsHot.Checked = false;
		chkIsPostActive.Checked = false;
		int VisitCount = 0;
		btnDeleteAllPosts.Visible = false;
	}

	#endregion protected void btnCancel_Click(object sender, EventArgs e)


	//بدنه ایونت ایجاد پست جدید
	#region btnCreatePost_Click(object sender, EventArgs e)

	/// <summary>
	/// ایونت ایجاد پست جدید
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	protected void btnCreatePost_Click(object sender, EventArgs e)
	{
		try
		{
			//با استفاده از دیتا تیبل و تیبل آدابتور یک خط جدید ایجاد میکنیم

			DataAccessLayer.DataSet.PostsDataTable oPostDataTable = new DataAccessLayer.DataSet.PostsDataTable();

			DataAccessLayer.DataSetTableAdapters.PostsTableAdapter oPostTableAdapter =
				new DataAccessLayer.DataSetTableAdapters.PostsTableAdapter();

			DataAccessLayer.DataSet.PostsRow oPostRow = oPostDataTable.NewPostsRow();

			System.DateTime dtmNow =
							  Tools.Utility.GetNow();

			//مقدار دهی به خط ایجاد شده
			oPostRow.Body = txtPost.Text;
			oPostRow.ExtendedBody = string.Empty; ;
			oPostRow.InsertTime = dtmNow;
			oPostRow.UpdateTime = dtmNow;
			oPostRow.PostCategoryId = Convert.ToInt32(txtPostCategoryId.Text);
			oPostRow.PostTypeId = Convert.ToInt32(txtPostTypeId.Text);
			oPostRow.Title = txtTitle.Text;
			oPostRow.UserId = (int)Session["UserID"];
			oPostRow.PublishTime = dtmNow;
			oPostRow.PostVisitedCount = 1;
			oPostRow.Keywords = txtKeyword1.Text;


			if (chkIsHot.Checked == true)
			{
				oPostRow.IsHot = true;
			}
			else
				oPostRow.IsHot = false;

			if (chkIsPostActive.Checked == true)
			{
				oPostRow.IsPostActive = true;
			}
			else
				oPostRow.IsPostActive = false;

			if (chkIsCommentEnabled.Checked == true)
			{
				oPostRow.IsCommentEnabled = true;
			}
			else
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

	}

	#endregion btnCreatePost_Click(object sender, EventArgs e)


	//بدنه حذف پست
	#region btnDeletePost_Click(object sender, EventArgs e)

	/// <summary>
	/// ایونت حذف پست
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	protected void btnDeletePost_Click(object sender, EventArgs e)
	{
		if (Page.IsValid)
		{
			try
			{
				//ایجاد یک شی از تیبل آدابتر
				DataAccessLayer.DataSetTableAdapters.PostsTableAdapter oPostTableAdapter =
					new DataAccessLayer.DataSetTableAdapters.PostsTableAdapter();

				//ایجاد یک اینت که یا صفر است یا یک
				//یک بودن یعنی پست وجود داشته و  پست حذف شده است
				int intAffectedRows = oPostTableAdapter.DeleteByUserAndPostID((int)Session["UserID"], Convert.ToInt32(txtPostID.Text));

				//اگر صفر بود
				if (intAffectedRows == 0)
				{
					string strErrorMessage =
						Resources.Messages.ErrorMessage017;
					//نمایش پیام پست با مشخصات وارد شده وجود ندارد
					DisplayErrorMessage(strErrorMessage);
					return;
				}


				//اگر یک بود
				string strInformationMessage =
					   string.Format(Resources.Messages.InformationMessage015,
					   txtTitle.Text);
				//نمایش پیام حذف پست با موفقیت انجام شد
				DisplayInformationMessage(strInformationMessage);




				System.DateTime dtmNow =
						  Tools.Utility.GetNow();
				btnEdit.Visible = false;
				btnDeletePost.Visible = false;
				btnDeleteAllPosts.Visible = false;
				btnCancel.Visible = false;
				btnCreatePost.Visible = true;
				txtInsertTime.Text = dtmNow.ToString();
				txtPublishTime.Text = dtmNow.ToString();
				txtUpdateTime.Text = dtmNow.ToString();
				txtKeyword1.Text = string.Empty;
				txtPost.Text = string.Empty;
				txtPostCategoryId.Text = string.Empty;
				txtPostTypeId.Text = string.Empty;
				txtTitle.Text = string.Empty;
				chkIsCommentEnabled.Checked = false;
				chkIsHot.Checked = false;
				chkIsPostActive.Checked = false;
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

	#endregion btnDeletePost_Click(object sender, EventArgs e)

	//بدنه ایونت حذف تمامی پست های یک کاربر
	#region btnDeleteAllPosts_Click(object sender, EventArgs e)

	/// <summary>
	/// ایونت حذف تمامی پست های کاربر
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	protected void btnDeleteAllPosts_Click(object sender, EventArgs e)
	{
		if (Page.IsValid)
		{
			try
			{
				//ایجاد یک شی از تیبل آدابتر
				DataAccessLayer.DataSetTableAdapters.PostsTableAdapter oPostTableAdapter =
					new DataAccessLayer.DataSetTableAdapters.PostsTableAdapter();

				//ایجاد یک اینت که یا صفر است یا یک
				//یک بودن یعنی پست وجود داشته و  تمامی پست های کاربر حذف شده است
				int intAffectedRows = oPostTableAdapter.DeleteByUserId((int)Session["UserID"]);

				//اگر صفر بود
				if (intAffectedRows == 0)
				{
					string strErrorMessage =
						Resources.Messages.ErrorMessage017;
					//نمایش پیام پست با مشخصات وارد شده وجود ندارد
					DisplayErrorMessage(strErrorMessage);
					return;
				}


				//اگر یک بود
				string strInformationMessage =
					   string.Format(Resources.Messages.InformationMessage015,
					   txtTitle.Text);
				//نمایش پیام حذف پست با موفقیت انجام شد
				DisplayInformationMessage(strInformationMessage);


				System.DateTime dtmNow =
						  Tools.Utility.GetNow();
				btnEdit.Visible = false;
				btnDeletePost.Visible = false;
				btnDeleteAllPosts.Visible = false;
				btnCancel.Visible = false;
				btnCreatePost.Visible = true;
				txtInsertTime.Text = dtmNow.ToString();
				txtPublishTime.Text = dtmNow.ToString();
				txtUpdateTime.Text = dtmNow.ToString();
				txtKeyword1.Text = string.Empty;
				txtPost.Text = string.Empty;
				txtPostCategoryId.Text = string.Empty;
				txtPostTypeId.Text = string.Empty;
				txtTitle.Text = string.Empty;
				chkIsCommentEnabled.Checked = false;
				chkIsHot.Checked = false;
				chkIsPostActive.Checked = false;
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

	#endregion btnDeleteAllPosts_Click(object sender, EventArgs e)


	//بدنه ایونت کلیک لینک باتن
	#region lnbManagePosts_Click(object sender, EventArgs e)

	/// <summary>
	/// ایونت کلیک لینک باتن
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	protected void lnbManagePosts_Click(object sender, EventArgs e)
	{
		Response.Redirect("~/Administrator/ManageContents.aspx");
		return;
	}

	#endregion lnbManagePosts_Click(object sender, EventArgs e)


	//بدنه مربوط به تطابق دراب دان لیست ها با تکست باکس ها
	#region ddl_SelectedIndexChanged(object sender, EventArgs e)

	/// <summary>
	/// ایونت تطابق دراب دان لیست گروه با تکست باکس گروه
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	protected void ddlPostCategory_SelectedIndexChanged(object sender, EventArgs e)
	{
		txtPostCategoryId.Text = ddlPostCategory.SelectedValue;
	}
	/// <summary>
	/// ایونت تطابق دراب دان لیست شاخه با تکست باکس شاخه
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	protected void ddlPostType_SelectedIndexChanged(object sender, EventArgs e)
	{
		txtPostTypeId.Text = ddlPostType.SelectedValue;
	}

	#endregion ddl_SelectedIndexChanged(object sender, EventArgs e)


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