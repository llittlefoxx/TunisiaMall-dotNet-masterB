using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using TunisiaMall.Domain.Entities;
using TunisiaMall.Service.Services;

namespace TunisiaMallWeb.Logic
{
    public class CurrentUser
    {
        public static user get()
        {
            IUserService userService = new UserService();
            var identity = (ClaimsIdentity)HttpContext.Current.User.Identity;
            IEnumerable<Claim> claims = identity.Claims;
            string username = claims.Single(c => c.Type == ClaimTypes.Name).Value;
            try {
                user user = userService.GetMany(u => u.login == username).First();
                return user;
            }
            catch (Exception e)

            {
                return null;
            }
        }
    }
}