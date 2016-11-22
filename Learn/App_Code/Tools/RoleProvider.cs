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
    public class RoleProvider : System.Web.Security.RoleProvider
    {
        public RoleProvider()
        {
            ApplicationName = "Tools Application";
        }

        public override string Name
        {
            get
            {
                return ("Tools Role Provider");
            }
        }

        public override string Description
        {
            get
            {
                return ("Tools Role Provider");
            }
        }

        private string _applicationName;
        public override string ApplicationName
        {
            get
            {
                return (_applicationName);
            }
            set
            {
                _applicationName = value;
            }
        }
        //کلیه رول ها رو میخونه و بصورت آرایه برمیگرداند
        public override string[] GetAllRoles()
        {
            return (null);
        }
        public override bool RoleExists(string roleName)
        {
            return (false);
        }

        public override void CreateRole(string rolename)
        {
        }
        public override string[] GetUsersInRole(string roleName)
        {
            return (null);
        }
        public override string[] GetRolesForUser(string userName)
        {

            string[] strRoles = null;

            object objRoleId = null;

            try
            {
                DataAccessLayer.DataSetTableAdapters.UsersTableAdapter oUsersTableAdapter =
                    new DataAccessLayer.DataSetTableAdapters.UsersTableAdapter();
                //توسط این تابع از مدل ریترن اسکالر استفاده میکنیم که رول آی دی رو بگیریم
                objRoleId = oUsersTableAdapter.GetRoleIdByUsername(userName);

                if (objRoleId != null)
                {
                    //میریزه تو عدد و کست میکنه به رول 
                    int intRoleId = (int)objRoleId;

                    Tools.Roles enmRole =
                        (Tools.Roles)intRoleId;
                    //آرایه رو نیو میکنیم یک خونه
                    strRoles = new string[1];
                    // خونه صفر رو برابر رول قرار میدهیم
                    strRoles[0] = enmRole.ToString();
                    return (strRoles);
                }
                return (null);
            }
            catch (ApplicationException ex0)
            {
                //متغیر ای ایکس را لاگ کنید
                throw (new ApplicationException(ex0.Message));
            }

            catch (Exception ex1)
            {
                //متغیر ای ایکس را لاگ کنید
                throw (new ApplicationException(ex1.Message));
            }

        }

        //تو وب کانفیگ این صفحه رو معرفی میکنیم


        public override bool IsUserInRole(string userName, string roleName)
        {
            return (false);
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            return (false);
        }

        public override void AddUsersToRoles(string[] usernames, string[] rolenames)
        {
        }

        public override void RemoveUsersFromRoles(string[] userNames, string[] roleNames)
        {
        }

        public override string[] FindUsersInRole(string rolename, string userNameToMatch)
        {
            return (null);
        }
       
        }
    }

