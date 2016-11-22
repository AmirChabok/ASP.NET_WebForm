using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Administrators_EditPageContent : Tools.LocalizedPage
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
			Initialize();
		}

	}

	#endregion Page_Load(object sender, System.EventArgs e)


	//بدنه مربوط به متد اینیشیالایز
	#region Initialize()

	private void Initialize()
	{
		//نام صفحه را از صفحه مدیریت صفحات میگیریم
		string strPageName = Request.Params["PageName"];

	}

	#endregion Initialize()
}