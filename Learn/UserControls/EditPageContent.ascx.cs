using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_EditPageContent : System.Web.UI.UserControl
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

		if (Page.IsPostBack == false)
		{
			//لینک گذر از این مرحله را فالس نموده و متد اینیشیالایز را فراخوانی میکنیم
			lnbCancel.Visible = false;
			Initialize();
		}

	}

	#endregion Page_Load(object sender, System.EventArgs e)


	//بدنه مربوط به متد اینیشیالایز
	#region Initialize()

	private void Initialize()
	{
		//دکمه ذخیره را غیر فعال میکنیم
		btnSave.Visible = false;

		//نام صفحه را از صفحه مدیریت صفحات میگیریم
		string strPageName = Request.Params["PageName"];

		//اگر از صفحه مدیریت صفحات نام صفحه ای را داشتیم
		if (strPageName != null)
		{
			//دراب دان لیست نام فایل را غیر فعال میکنیم
			DropDownList1.Visible = false;
			//تکست باکس نام فایل را برابر با مقدار ارسالی از صفحه مدیریت صفحات قرار میدهیم
			txtFileName.Text = strPageName;
			//دکمه ایجاد صفحه را غیر فعال میکنیم

		}


	}

	#endregion Initialize()


	//بدنه مربوط به باز کردن فایل و یا صفحه
	#region OpenPages_btnOpen_Click(object sender, EventArgs e)

	/// <summary>
	/// متد بازکردن یک فایل مربوط به صفحه توسط ادمین
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	protected void btnOpen_Click(object sender, EventArgs e)
	{
		//غیر فعال نمودن قسمت نمایش پیام
		divPageMessages.Visible = false;
		//تریم نمودن تکست باکس فایل نیم
		txtFileName.Text =
			txtFileName.Text.Trim();

		//اگر فایل انتخاب نشده بود
		if (txtFileName.Text == string.Empty)
		{
			//نمایش پیغام خطا
			string strErrorMessage =
				 Resources.Messages.ErrorMessage003;
			DisplayErrorMessage(strErrorMessage);
			return;
		}

		//اگر فایل انتخاب شده بود مسیر نسبی پوشه ای که صفحات اچ تی ام ال در آن قرار دارد را میدهیم
		string strFileName = txtFileName.Text;
		string strRootRelativePath = "~/App_Data/PageContents";
		string strRootRelativePathName =
			string.Format("{0}/{1}", strRootRelativePath, strFileName);
		//تبدیل مسیر نسبی به مسیر فیزیکی
		string strPathName = Server.MapPath(strRootRelativePathName);

		//اگر فایل وجود نداشت
		if (System.IO.File.Exists(strPathName) == false)
		{
			//نمایش پیغام خطا
			string strErrorMessage =
			   string.Format(Resources.Messages.ErrorMessage004, txtFileName.Text);
			DisplayErrorMessage(strErrorMessage);
			return;
		}
		//اگر وجود داشت از استریم ریدر یک شی میسازیم تا محتویات فایل را بخوانیم
		System.IO.StreamReader oStreamReader = null;

		try
		{
			//نیو کردن استریم ریدر
			oStreamReader = new System.IO.StreamReader(strPathName, System.Text.Encoding.UTF8);
			//خواندن از فایل
			txtEditContent.Text = oStreamReader.ReadToEnd();

			//نمایش پیغام موفقیت
			string strInformationMessage =
				  string.Format(Resources.Messages.InformationMessage001, txtFileName.Text);
			DisplayInformationMessage(strInformationMessage);

			//دکمه ذخیره را فعال میکنیم
			btnSave.Visible = true;
			//دکمه بازنمودن فایل را غیر فعال میکنیم
			btnOpen.Visible = false;
			//از دسترس خارج کردن دراب دان لیست
			DropDownList1.Enabled = false;
			lnbCancel.Visible = true;


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
			//بستن شی استریم ریدر
			if (oStreamReader != null)
			{
				oStreamReader.Dispose();
				oStreamReader = null;
			}
		}
	}

	#endregion btnOpen_Click(object sender, EventArgs e)


	//بدنه مربوط به ذخیره فایل و یا صفحه
	#region SavePages_btnSave_Click(object sender, EventArgs e)

	/// <summary>
	/// متد ذخیره فایل صفحه توسط ادمین
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	protected void btnSave_Click(object sender, EventArgs e)
	{
		//تریم کردن تکست باکس
		txtFileName.Text =
			txtFileName.Text.Trim();

		//اگر تکست باکس خالی بود
		if (txtFileName.Text == string.Empty)
		{
			//نمایش پیغام خطا
			string strErrorMessage =
				string.Format(Resources.Messages.ErrorMessage003);
			DisplayErrorMessage(strErrorMessage);
			return;

		}
		//در غیر اینصورت مراحل مسیر نسبی و تبدیل به مسیر فیزیکی
		string strFileName = txtFileName.Text;
		string strRootRelativePath = "~/App_Data/PageContents";
		string strRootRelativePathName =
			string.Format("{0}/{1}", strRootRelativePath, strFileName);

		string strPathName = Server.MapPath(strRootRelativePathName);

		//ایجاد یک شی از کلاس استریم رایتر
		System.IO.StreamWriter oStreamWriter = null;

		try
		{
			//نیو کردن استریم رایتر 
			oStreamWriter = new System.IO.StreamWriter
				(strPathName, false, System.Text.Encoding.UTF8);
			oStreamWriter.Write(txtEditContent.Text);

			//اگر فایل وجود نداشت
			if (System.IO.File.Exists(strPathName) == false)
			{
				//نمایش پیغام خطا
				string strErrorMessage =
				   string.Format(Resources.Messages.ErrorMessage004, txtFileName.Text);
				DisplayErrorMessage(strErrorMessage);
				return;
			}

			//در غیر اینصورت نمایش پیغام موفقیت در عملیات
			string strInformationMessage =
				string.Format(Resources.Messages.InformationMessage002, txtFileName.Text);
			DisplayInformationMessage(strInformationMessage);


			//تکست باکس فایل نیم را نمایان میکنیم
			txtFileName.Visible = true;
			//لینک گذر از این مرحله را فعال میکنیم
			lnbCancel.Visible = true;
			//دراب دان لیست فایل نیم را غیر فعال میکنیم
			DropDownList1.Enabled = false;

		}

			//در صورتی که عملیات ترای با خطا مواجه گردد
		catch (Exception ex)
		{
			//نمایش خطای ایجاد شده
			string strErrorMessage =
			Resources.Messages.ErrorMessage006;
			DisplayErrorMessage(strErrorMessage);

			System.Collections.Hashtable oHashtable =
				   new System.Collections.Hashtable();

			//اگر در داخل یک تابع غیر استاتیک  این تابع رو صدا میزنیم از دیس تا گت تایپ استفاده میکنیم
			//در غیر اینصورت از این روش استفاده میکنیم یعنی تایپ اف نام کلاس
			//پارامتر دوم مجموعه ای از اطلاعاتی که میتونه کمک کنه رو هم لاگ میکنیم
			//پارامتر سوم هم که ای ایکس هست رو لاگ میکنیم
			
			return;
		}

		finally
		{
			//بستن استریم رایتر
			if (oStreamWriter != null)
			{
				oStreamWriter.Dispose();
				oStreamWriter = null;
			}
		}
	}

	#endregion btnSave_Click(object sender, EventArgs e)


	//بدنه مربوط به تطابق دراب دان لیست و تکست باکس
	#region DropDownList&txtFileName()

	/// <summary>
	/// تطابق دراب دان دان لیست با تکست باکس فایل نیم
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
	{
		txtFileName.Text = DropDownList1.SelectedItem.Text;
	}

	#endregion DropDownList&txtFileName()


	//بدنه ایونت کلیک روی لینک باتن
	#region protected void lnbManagePages_Click(object sender, EventArgs e)

	/// <summary>
	/// ایونت کلیک لینک باتن
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	protected void lnbManagePages_Click(object sender, EventArgs e)
	{
		Response.Redirect("~/Administrator/EditPageContent.aspx");
		return;
	}

	#endregion protected void lnbManagePages_Click(object sender, EventArgs e)


	//بدنه ایونت کلیک روی لینک باتن
	#region protected void lnbCancel_Click(object sender, EventArgs e)

	/// <summary>
	/// ایونت کلیک لینک باتن
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	protected void lnbCancel_Click(object sender, EventArgs e)
	{
		//دکمه بازکردن فایل را غیر فعال میکنیم
		btnOpen.Visible = true;
		//دراب دان لیست را فعال میکنیم
		DropDownList1.Visible = true;
		DropDownList1.Enabled = true;
		//تکست باکس نام فایل را غیر فعال میکنیم
		txtFileName.Visible = true;
		//لینک باتن گذر از این مرحله را غیر فعال میکنیم
		lnbCancel.Visible = false;

	}

	#endregion protected void lnbCancel_Click(object sender, EventArgs e)

	//بدنه مربوط به نمایش پیام ها
	#region Messages()

	/// <summary>
	/// نمایش پیام متدها
	/// </summary>
	/// <param name="message"></param>
	protected virtual void DisplayErrorMessage(string message)
	{
		divPageMessages.Visible = true;
		litPageMessages.Text =
			string.Format("<div class='error'>[{0}]</div>", message);
	}

	protected virtual void DisplayWarningMessage(string message)
	{
		divPageMessages.Visible = true;
		litPageMessages.Text =
			string.Format("<div class='warning'>[{0}]</div>", message);
	}

	protected virtual void DisplayInformationMessage(string message)
	{
		divPageMessages.Visible = true;
		litPageMessages.Text =
			string.Format("<div class='information'>[{0}]</div>", message);
	}

	#endregion Messages()

}