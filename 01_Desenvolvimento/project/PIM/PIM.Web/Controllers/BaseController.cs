using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static PIM.Web.Controllers.Enum;

namespace PIM.Web.Controllers
{
    public class BaseController : Controller
    {
        public void Alert(string message, NotificationType notificationType)
        {
            var msg = "swal('" + notificationType.ToString().ToUpper() + "', '" + message + "','" + notificationType + "')" + "";
            TempData["notification"] = msg;
        }
    }

    public class Enum
    {
        public enum NotificationType
        {
            error,
            success,
            warning,
            info
        }

    }
}