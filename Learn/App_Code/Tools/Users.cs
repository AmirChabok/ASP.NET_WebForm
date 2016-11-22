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
    public static class Users
    {
        /// <summary>
        /// متد ذیل یک گذرواژه جدید هش شده را از طریق شناسه کاربری  برای کاربر ایجاد و در دیتا بیس قرار میدهد و ایمیل ارسال میکند
        /// </summary>
        /// <param name="userName"></param>
        public static void GenerateNewPasswordAndSendToUserByUserName(string userName)
        {
            try
            {
                //ساخت یک شی از دیتا تیبل
                DataAccessLayer.DataSetTableAdapters.UsersTableAdapter oUsersTableAdapter =
                    new DataAccessLayer.DataSetTableAdapters.UsersTableAdapter();
                //ساخت یک شی از تیبل آدابتر
                DataAccessLayer.DataSet.UsersDataTable oUsersDataTable =
                    new DataAccessLayer.DataSet.UsersDataTable();
                //فیل کردن تیبل آدابتر با متد مربوطه و دیتا تیبل
                oUsersTableAdapter.FillByUsername(oUsersDataTable, userName);
                //اگر کاربری وجود داشت
                if (oUsersDataTable.Count == 1)
                {
                    //یک رو جدید ایجاد و برابر  با خونه صفر دیتا تیبل قرار میدهیم
                    DataAccessLayer.DataSet.UsersRow oUsersRow = oUsersDataTable[0];

                    //Get User's data from DataSet
                    string strFullName = oUsersRow.FullName;
                    string strUserEmail = oUsersRow.UserEmail;

                    //Generate random Password
                    string strNewPassword = Tools.Utility.GetGuidWithoutDash().Substring(0, 8);
                    string strHashOfNewPassword = Tools.Utility.GetSha1(strNewPassword);

                    //گذرواژه جدید را در دیتا بیس ثبت میکنیم
                    oUsersRow.Password = strHashOfNewPassword;
                    //بروز رسانی دیتا بیس
                    oUsersTableAdapter.Update(oUsersDataTable);

                    //Assign Email Template
                    string strPathName = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/LocalizedEmailTemplates/ForgotPasswordUserEmail.htm");
                    string strEmailBody = Tools.File.Read(strPathName);

                    //جایگذاری اطلاعات کاربر با قالب
                    strEmailBody = strEmailBody
                                    .Replace("[FULL_NAME]", userName)
                                    .Replace("[USER_NAME]", userName)
                                    .Replace("[PASSWORD]", strNewPassword);

                    //ایجاد شی از میل آدرس
                    System.Net.Mail.MailAddress oMailAddress =
                        new System.Net.Mail.MailAddress(strUserEmail, strFullName, System.Text.Encoding.UTF8);

                    //################################
                    //کدهای مربوط به ارسال ایمیل
                    //################################
                }
            }
           
                //در صورت بروز خطا
            catch (Exception ex)
            {
                //میتوان خطا را لاگ نمود
                throw (ex);
            }
        }


        /// <summary>
        /// متد ذیل یک گذرواژه جدید از طریق  رایانامه  برای کاربر ایجاد و ایمیل ارسال میکند
        /// </summary>
        /// <param name="userEmail"></param>
        public static void GenerateNewPasswordAndSendToUserByUserEmail(string userEmail)
        {
            try
            {
                DataAccessLayer.DataSetTableAdapters.UsersTableAdapter oUsersTableAdapter =
                    new DataAccessLayer.DataSetTableAdapters.UsersTableAdapter();

                DataAccessLayer.DataSet.UsersDataTable oUsersDataTable =
                    new DataAccessLayer.DataSet.UsersDataTable();

                oUsersTableAdapter.FillByUserEmail(oUsersDataTable, userEmail);

                if (oUsersDataTable.Count == 1)
                {
                    DataAccessLayer.DataSet.UsersRow oUsersRow = oUsersDataTable[0];

                    //Get User's data from DataSet
                    string strFullName = oUsersRow.FullName;
                    string strUserName = oUsersRow.UserName;

                    //Generate random Password
                    string strNewPassword = Tools.Utility.GetGuidWithoutDash().Substring(0, 8);
                    string strHashOfNewPassword = Tools.Utility.GetSha1(strNewPassword);

                    oUsersRow.Password = strHashOfNewPassword;

                    oUsersTableAdapter.Update(oUsersDataTable);

                    //Assign Email Template
                    string strPathName = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/LocalizedEmailTemplates/ForgotPasswordUserEmail.htm");
                    string strEmailBody = Tools.File.Read(strPathName);

                    //جایگذاری اطلاعات کاربر با قالب
                    strEmailBody = strEmailBody
                                    .Replace("[FULL_NAME]", strFullName)
                                    .Replace("[USER_NAME]", strUserName)
                                    .Replace("[PASSWORD]", strNewPassword);

                    ////ایجاد شی از میل آدرس
                    System.Net.Mail.MailAddress oMailAddress =
                        new System.Net.Mail.MailAddress(userEmail, strFullName, System.Text.Encoding.UTF8);

                    //################################
                    //کدهای مربوط به ارسال ایمیل
                    //################################
                }
            }
            catch (Exception ex)
            {
                //میتوان خطا را لاگ نمود
                throw (ex);
            }
           
        }
     
    }
}