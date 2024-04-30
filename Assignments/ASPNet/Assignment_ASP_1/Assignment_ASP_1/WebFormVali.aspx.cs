<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_ASP_1
{
    public partial class WebFormVali : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnregister_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Response.Redirect("Welcome.html");
            }
        }
    }
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_ASP_1
{
    public partial class WebFormVali : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnregister_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Response.Redirect("Welcome.html");
            }
        }
    }
>>>>>>> 83109c39747d55bd89b86b0e0b98dc18c66fed71
}