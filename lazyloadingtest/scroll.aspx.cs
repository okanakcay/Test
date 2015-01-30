using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lazyloadingtest
{
    public partial class scroll : System.Web.UI.Page
    {
        int ps { get { return Convert.ToInt32(Request.QueryString["ps"]); } }
        int pn { get { return Convert.ToInt32(Request.QueryString["pn"]); } }
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var context = new NorthwindEntities())
            {
                var start = ps * pn;
                var entity = context.Products.ToList();
                var list = entity.Skip(start).Take(ps);
                rptTest.DataSource = list;
                rptTest.DataBind();
            }
        }
        protected String NextPage()
        {
            var next = pn + 1;
            return ResolveUrl("~/scroll.aspx?ps=2&pn=" + next);
        }
    }
}