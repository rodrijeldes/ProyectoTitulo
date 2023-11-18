using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace MVC_HojaDeTareas.Helper
{
    public class CustomPrincipal : IPrincipal
    {
        public IIdentity Identity { get; private set; }
        string[] roles;

        public CustomPrincipal(string usuario)//, string[] roles)
        {
            this.Identity = new GenericIdentity(usuario);
            this.roles = null;
        }

        public bool IsInRole(string role) { return roles.Contains(role); }
        public int? IdUsuario { get; set; }
        public string FullName { get; set; }

    }
}