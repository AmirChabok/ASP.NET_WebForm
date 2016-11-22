using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections;
using System.Text;

namespace Tools
{
    public class LocalizedPage : BasePage
    {
        public LocalizedPage()
        {
        }

        //اول کار مشخص میکنیم صفحه به چه زبانی دیده بشه
        protected override void InitializeCulture()
        {
            base.InitializeCulture();

            if (Session["Culture"] == null)
            {
                //Session["Culture"] = "en-US";
                Session["Culture"] = "fa-IR";
            }
            //دو متغییر ذیل را فقط در ایونت جاری میتوانیم تغییر دهیم
            //این دو متغییر را برابر سشن کالچر قرار میدهیم
            Culture = Session["Culture"].ToString();
            UICulture = Session["Culture"].ToString();
        }

       
    }
}
