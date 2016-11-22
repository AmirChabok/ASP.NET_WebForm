using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region توضیحات

/// <summary>
/// این کلاس در متد پیج لود خود بررسی میکند که آیا اولا کاربر مجوز های دسترسی برای لاگین نمودن را دارد
/// و در ثانی آیا سشن ایجاد شده در لاگین برقرار هست یا خیر
/// در صورتی که دو شرط بالا برقرار باشد کاربر لاگین شده و تعدادی از لینک ها فعال و غیر فعال میشوند
/// </summary>
/// 

#endregion توضیحات


public partial class UserControls_UserLoginStatus : System.Web.UI.UserControl
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
				liLogin.Visible = false;
				liLogout.Visible = true;
				lblWelcome.Visible = true;
				liRegister.Visible = false;
				liProfile.Visible = true;
				lnkculture.Visible = false;
				lnkAdmin.Visible = true;

				string strUsername =
					Session["Username"].ToString();
				//پیغام نمایش خوش آمد گویی به کاربر
				lblWelcome.Text = string.Format("خوش آمدید {0} ", strUsername);
			}

			else
			{
				//در صورتی که هم سشن و هم آدنتیکیشن برقرار باشد
				liLogin.Visible = false;
				liLogout.Visible = true;
				lblWelcome.Visible = true;
				liRegister.Visible = false;
				liProfile.Visible = true;
				lnkculture.Visible = true;
				lnkAdmin.Visible = false;

				string strUsername2 =
						Session["Username"].ToString();
				//پیغام نمایش خوش آمد گویی به کاربر
				lblWelcome.Text = string.Format("خوش آمدید {0} ", strUsername2);
			}
		}
		//در صورتی که آدنتیکیشن فالس باشد
		else
		{
			lnkculture.Visible = true;
			liLogin.Visible = true;
			liLogout.Visible = false;
			lblWelcome.Visible = true;
			liRegister.Visible = true;
			liProfile.Visible = false;
			lnkAdmin.Visible = false;

		}
	}

	#endregion Page_Load(object sender, System.EventArgs e)
}