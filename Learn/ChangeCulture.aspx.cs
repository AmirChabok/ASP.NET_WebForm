public partial class ChangeCulture : Tools.LocalizedPage
{
    //در این صفحه تغییرات کالچر رو با توجه به انتخاب زبان توسط کاربر انجام میدهیم
    protected void Page_Load(object sender, System.EventArgs e)
    {

        // با دستور رکواست دات پارام پارامتر پاس شده به صفحه رو بدست میاریم

        string strCulture = Request.Params["Culture"];
        // اگر پارامتری پاس نشده بود ریدایرکت میشه به صفحه دیفالت
        if (string.IsNullOrEmpty(strCulture))
        {
            Response.Redirect("~/Default.aspx", false);
            return;
        }
        //با دستور ذیل صفحه ارجاع داده شده به این صفحه رو مشخص میکنیم
        //اگر نال باشه یعنی در آدرس بار آدرس تایپ شده
        //که در این صورت دوباره ریدایرکت میکنیم به صفحه دیفالت
        string strReferer = Request.ServerVariables["HTTP_REFERER"];
        if (string.IsNullOrEmpty(strReferer))
        {
            //پارامتر دوم رو که فالس میگذاریم یعنی ریدایرکت کن و بعد خط بعد رو اجرا میکنیم
            //در حالت تورو ترد شما بطور کامل قطع میشه و ران تایم ارور اتفاق میافته 
            //ولی ریترن ترد رو قطع نمیکنه
            Response.Redirect("~/Default.aspx", false);
            return;
        }
        //پارامتر را بزرگ میکنیم اگر حالتهای موجود در سایت بود 
        //دوباره پارامتر رو دو حرف اول کوچیک و دو حرف آخر بزرگ و سشن را ست میکنیم
        //بعد یوزر رو به صفحه ای که از همان صفحه اومده ریدایرکت میکنیم
        switch (strCulture.ToUpper())
        {
            case "FA-IR":
           
                {
					strCulture =
						strCulture.Substring(0, 2).ToLower() +
						"-" +
						strCulture.Substring(3, 2).ToUpper();
					//سشن کالچر را با توجه به زبان انتخاب شده ست میکنیم
					Session["Culture"] = strCulture;
					//یوزر رو ریدایرکت میکنیم به صفحه ای که از اونجا آمده
					Response.Redirect(strReferer, false);
					return;
                }
			case "EN-US":
				{
					strCulture =
					   strCulture.Substring(0, 2).ToLower() +
					   "-" +
					   strCulture.Substring(3, 2).ToUpper();
					//سشن کالچر را با توجه به زبان انتخاب شده ست میکنیم
					Session["Culture"] = strCulture;
					//یوزر رو ریدایرکت میکنیم به صفحه ای که از اونجا آمده
					Response.Redirect(strReferer, false);
					return;
				}
                //در غیر اینصورت ریدایرکت میکنیم به صفحه دیفالت
            default:
                {
                    Response.Redirect("~/Default.aspx", false);
                    return;
                }
        }
    }
}
