using HospitalERPNew.Data;
using HospitalERPNew.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI.WebControls;

namespace HospitalERPNew.Filters
{

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class MyAuthorizationFilter : FilterAttribute, IAuthorizationFilter
    {
        private readonly string _url;
        public MyAuthorizationFilter(string url)
        {
            this._url = url;
        }
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Session["UserInfo"] == null)
                filterContext.HttpContext.Response.Redirect(this._url);
        }
    }
}