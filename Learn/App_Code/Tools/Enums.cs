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
    /// <summary>
    /// سطوح دسترسی
    /// در کلاس آتنتیکیتد یوزر این اعداد به رول نیم تبدیل میشن
    /// </summary>
	public enum Roles
	{
		
		Programmer = 100,
		Administrator = 200,
		SuperUser = 300,
		Manager = 400,
		Supervisor = 500,
		Editor= 600,
		Writer= 700,
		Reporter = 800,
		User = 900,
		None = 0,
	}
}