﻿using System.Web;
using System.Web.Mvc;

namespace CardFile
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());   // Глобальный системный фильтр для обработки исключений
        }
    }
}
