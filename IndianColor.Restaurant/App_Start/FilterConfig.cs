﻿using System.Web;
using System.Web.Mvc;

namespace IndianColor.Restaurant
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
