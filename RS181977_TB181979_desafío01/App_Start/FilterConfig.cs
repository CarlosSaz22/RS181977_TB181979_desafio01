﻿using System.Web;
using System.Web.Mvc;

namespace RS181977_TB181979_desafío01
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
