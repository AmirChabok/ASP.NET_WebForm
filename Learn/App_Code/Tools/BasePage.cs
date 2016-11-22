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
    //صفحات از این صفحه اینهریت میشن یا از ایکس بیس 
    //یا از لوکالایز یا ایکس لوکالایز 
    //در ایکس ها متدهائی نیز تعبیه شده که میتونید یه سری کارها رو 
    //قبل هنگام و بعد از لود شدن صفحه هم انجام بدیم
    //بهتره با ایکس ها کار کنیم
    public class BasePage : System.Web.UI.Page
    {
        public BasePage()
        {
        }

        /// <summary>
        /// تابع آن لود رو اور راید کردیم
        /// در اینجا توابعی رو که میخوایم در هنگام لود شدن اتفاق میفتد را مینویسیم
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);

            OnBeforeInitialize();

            if (Page.IsPostBack == false)
            {
                OnInitialize();
            }

            OnAfterInitialize();
        }




        /// <summary>
        /// پرو تکدت ها در کلاس های اینهریت شده بهشون دسترسی داریم
        /// و چون ویرچوال هستند قابل پیاده سازی هستند
        /// </summary>
        protected virtual void OnBeforeInitialize()
        {
        }

        protected virtual void OnInitialize()
        {
        }

        protected virtual void OnAfterInitialize()
        {
        }
    }
}
