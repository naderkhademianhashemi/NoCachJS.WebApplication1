using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NoCachJS.WebApplication1.NoCachJs
{
    public partial class NoCach_Js : System.Web.UI.Page
    {
        public int GetRandom()
        {
            return new Random().Next(0, 20);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}