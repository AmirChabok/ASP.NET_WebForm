using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_CreateNewsletter : System.Web.UI.UserControl
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

		System.DateTime dtmNow =
				 Tools.Utility.GetNow();


	}

	#endregion Initialize()

	//بدنه ایجاد خبرنامه
	#region btnSubmit_Click(object sender, EventArgs e)
		/// <summary>
	/// ایونت ایجاد پست
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	protected void btnCreateNewsletter_Click(object sender, EventArgs e)
	{
		//اگر وجود داشت از استریم ریدر یک شی میسازیم تا محتویات فایل را بخوانیم
		try
		{
			//با استفاده از دیتا تیبل و تیبل آدابتور یک خط جدید ایجاد میکنیم
			DataAccessLayer.DataSet.PostsDataTable oPostDataTable = new DataAccessLayer.DataSet.PostsDataTable();

			DataAccessLayer.DataSetTableAdapters.PostsTableAdapter oPostTableAdapter =
				new DataAccessLayer.DataSetTableAdapters.PostsTableAdapter();

			DataAccessLayer.DataSet.PostsRow oPostRow = oPostDataTable.NewPostsRow();


			DataAccessLayer.DataSet.UsersDataTable oUserDataTable = new DataAccessLayer.DataSet.UsersDataTable();

			DataAccessLayer.DataSetTableAdapters.UsersTableAdapter oUserTableAdapters =
				new DataAccessLayer.DataSetTableAdapters.UsersTableAdapter();

			oUserTableAdapters.Fill(oUserDataTable);


			//Sava To Database1
			//###########################################################################

			//مقدار دهی به خط ایجاد شده
			oPostRow.Body = txtPost.Text;
			oPostRow.ExtendedBody = "";
			System.DateTime dtmNow =
			Tools.Utility.GetNow();
			oPostRow.InsertTime = dtmNow;
			oPostRow.UpdateTime = dtmNow;
			oPostRow.PostCategoryId = 1;
			oPostRow.PostTypeId = 29;
			oPostRow.Title = txtSubject.Text;
			oPostRow.UserId = (int)Session["UserId"];
			oPostRow.PublishTime = dtmNow;
			oPostRow.PostVisitedCount = 0;
			oPostRow.Keywords = "خبرنامه ";
			oPostRow.Password = string.Empty;
			oPostRow.IsHot = false;
			oPostRow.IsPostActive = true;
			oPostRow.IsCommentEnabled = true;


			//خط جدید مقدار دهی شده را به دیتا تیبل اد میکنیم
			oPostDataTable.AddPostsRow(oPostRow);
			//تیبل آدابتر و بروز رسانی دیتا بیس
			oPostTableAdapter.Update(oPostDataTable);

			string strPathName = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/LocalizedEmailTemplates/News.htm");
			string strEmailBody = Tools.File.Read(strPathName);

			//جایگذاری اطلاعات کاربر با قالب
			strEmailBody = strEmailBody
							.Replace("[Subject]", oPostRow.Title)
							.Replace("[Body]", oPostRow.Body);


			if (oUserDataTable.Count != 0)
			{
				for (int i = 0; i < oUserDataTable.Count; i++)
				{
					//ایجاد شی از میل آدرس
					System.Net.Mail.MailAddress oMailAddress =
						new System.Net.Mail.MailAddress(oUserDataTable[i].UserEmail);
                    //################################
                    //کدهای مربوط به ارسال ایمیل
                    //################################

				}
			}

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
	#endregion btnSubmit_Click(object sender, EventArgs e)

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