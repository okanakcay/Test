using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lazyloadingtest
{
    public partial class test : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var context = new NorthwindEntities())
            {
                //context.Configuration.LazyLoadingEnabled = false;
                //context.Customers.Load();
                //lblTitle.Text = context.Customers.SqlQuery("select * from Customers").Count().ToString();
                //var entity = context.Categories.Include("Products").ToList();

                //rptCustomer.DataSource = entity;
                //rptCustomer.DataBind();
            }
        }
    }
}