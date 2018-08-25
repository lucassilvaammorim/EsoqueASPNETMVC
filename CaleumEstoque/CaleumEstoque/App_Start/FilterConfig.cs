using CaleumEstoque.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaleumEstoque.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilter(GlobalFilterCollection filter)
        {
            filter.Add(new AutorizarFilterAttribute());
        }
    }
}