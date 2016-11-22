﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Errors_ErrorGenerals : Tools.LocalizedPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
		string strAspErrorPath =
		  Request.Params["aspxerrorpath"];

		lnkTryAgain.NavigateUrl = strAspErrorPath;
    }
}