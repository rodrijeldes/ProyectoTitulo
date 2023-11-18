using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace MVC_HojaDeTareas.Helper
{
    public static class CurrentUser
    {
        // note: the first two properties are used on _Layout page

        //public static bool IsAdmin { get { return true;/*Thread.CurrentPrincipal.IsInRole("Admin");*/ } }
        public static bool IsAuthenticated { get { return Thread.CurrentPrincipal.Identity.IsAuthenticated; } }

        public static int? IdUsuario { get { return (Thread.CurrentPrincipal is CustomPrincipal ? (Thread.CurrentPrincipal as CustomPrincipal).IdUsuario : null); } }
        public static string FullName { get { return (Thread.CurrentPrincipal is CustomPrincipal ? (Thread.CurrentPrincipal as CustomPrincipal).FullName : ""); } }
    }
}