﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

public static class ClientMessageBox
{

    public static void Show(string message, Control owner)
    {
        Page page = (owner as Page) ?? owner.Page;
        if (page == null) return;

        page.ClientScript.RegisterStartupScript(owner.GetType(),
            "ShowMessage", string.Format("<script type='text/javascript'>alert('{0}')</script>",
            message));

    }

}
