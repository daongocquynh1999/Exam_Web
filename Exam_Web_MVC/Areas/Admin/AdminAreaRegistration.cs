﻿using System.Web.Mvc;

namespace Exam_Web_MVC.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new {action = "Index", id = UrlParameter.Optional },
                new[] { "Exam_Web_MVC.Areas.Admin.Controllers" }
            );
        }
    }
}