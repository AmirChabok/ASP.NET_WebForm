using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_DefaultMenu : System.Web.UI.UserControl
{
	//بدنه ایونت پیج لود
	#region Page_Load(object sender, System.EventArgs e)

	/// <summary>
	///  ایونت پیج لود
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	protected void Page_Load(object sender, EventArgs e)
	{
		//بررسی مجوز های دسترسی کاربر
		if ((Context != null) &&
			(Context.Trace != null) &&
			(Context.User.Identity != null) &&
			(Context.User.Identity.IsAuthenticated))
		{
			//بررسی موجود بودن یا نبودن سشن کاربر
			if (Session["UserID"] == null)
			{
				Response.Redirect("~/Logout.aspx", false);
				return;
			}

			int intRoleID = Convert.ToInt32(Session["RoleID"]);

			if ((intRoleID == 100) || (intRoleID == 200))
			{
				//در صورتی که هم سشن و هم آدنتیکیشن برقرار باشد
				liMember.Visible = false;
				liLogout.Visible = true;
				liAdmin.Visible = true;
				liProfile.Visible = false;
			}

			else
			{
				//در صورتی که هم سشن و هم آدنتیکیشن برقرار باشد
				liMember.Visible = false;
				liLogout.Visible = true;
				liProfile.Visible = true;
				liAdmin.Visible = false;

			}
		}
		//در صورتی که آدنتیکیشن فالس باشد
		else
		{
			liMember.Visible = true;
			liLogout.Visible = false;
			liProfile.Visible = false;
			liAdmin.Visible = false;

		}
	}

	#endregion Page_Load(object sender, System.EventArgs e)
}