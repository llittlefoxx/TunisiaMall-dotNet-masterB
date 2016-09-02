using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using TunisiaMall.Domain.Entities;
using TunisiaMall.Service.Services;
using TunisiaMallWeb.Logic;

namespace TunisiaMallWeb.Controllers
{
    public class UserController : Controller
    {
        IUserService u = new UserService();
        IFriendShipService fs = new FriendShipService();
         [Authorize]
        [Route("GetProfile")]
        public ActionResult GetProfile()
        {

            user us = CurrentUser.get();

            return View(us);
        }


        // GET: User/Create
        [HttpGet]
        [Route("UserCreate")]
        public ActionResult UserCreate()
        {
            user us = new user();

            // string userId = Membership.GetUser().ProviderUserKey.ToString();
            //gestbookE.user_idUser = 2;

            return View(us);
        }


        [HttpPost]
        [Route("UserCreate")]
        public ActionResult UserCreate(user us)
        {
            u.Create(us);
            u.Commit();
            return Redirect("Login");

        }




        // GET: User/Edit/5
        [Authorize]
        [HttpGet]
        [Route("EditUser")]
        public ActionResult EditUser()
        {
            user us = CurrentUser.get();

            if (us == null)
            {
                return HttpNotFound();
            }
            return View(us);
        }

        // POST: User/Edit/5
        [HttpPost]
        [Authorize]
        [Route("EditUser")]
        public ActionResult EditUser(user us)
        {
            
                var ur = u.FindById(us.idUser);
                ur.firstName = us.firstName;
                ur.birthdate = us.birthdate;
                ur.job = us.job;
                ur.mail = us.mail;
                ur.phone = us.phone;
                ur.login = us.login;
                ur.address = us.address;
                u.Update(ur);
                u.Commit();

                return Redirect("EditUser");

            
        }


        // GET: User/Delete/5
        [HttpGet]
        [Authorize]
        [Route("DeleteUser")]
        public ActionResult DeleteUser()
        {
            user e = CurrentUser.get();
            return View(e);
        }

        // POST: User/Delete/5
        [HttpPost]
        [Authorize]
        [Route("DeleteUser")]
        public ActionResult DeleteUser(user us)
        {
            
            u.Delete(CurrentUser.get());
            u.Commit();

            return RedirectToAction("Logout");
        }

        [Authorize]
        [HttpGet]
        [Route("FriendShip")]
        public ActionResult FriendShip()
        {

            IEnumerable<user> users = u.GetMany();
            List<user> listusers = users.ToList();
            IEnumerable<friendship> friends = fs.GetMany();
            List<friendship> listfriends = friends.ToList();
            ViewBag.lfriends = listfriends;
            ViewBag.cUser = CurrentUser.get();
            return View(listusers);

        }
        [Authorize]
        [HttpPost]
        [Route("addFriend")]
        public ActionResult addFriend( int idUser2)
        {
            
                friendship fr = new friendship();
            fr.idUser1 = CurrentUser.get().idUser;
            fr.idUser2 = idUser2;
                fr.accepted = true;
                fs.Create(fr);
                fs.Commit();

                return RedirectToAction("FriendShip");
            
        }
        
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if (new UserService().Athenticate(username, password))
            {
                var ident = new ClaimsIdentity(
                  new[] { 
              // adding following 2 claim just for supporting default antiforgery provider
              new Claim(ClaimTypes.NameIdentifier, username),
              new Claim("http://schemas.microsoft.com/accesscontrolservice/2010/07/claims/identityprovider", "ASP.NET Identity", "http://www.w3.org/2001/XMLSchema#string"),

              new Claim(ClaimTypes.Name,username),

              // optionally you could add roles if any
              new Claim(ClaimTypes.Role, "Customer"),

                  },
                  DefaultAuthenticationTypes.ApplicationCookie);
                HttpContext.GetOwinContext().Authentication.SignIn(
                   new AuthenticationProperties { IsPersistent = false }, ident);
                return RedirectToAction("Index", "Home"); // auth succeed 
            }
            // invalid username or password
            ModelState.AddModelError("", "invalid username or password");
            return RedirectToAction("Index", "Home");
        }
        
        public ActionResult Logout()
        {
            HttpContext.GetOwinContext().Authentication.SignOut();
            return RedirectToAction("Index", "Home");
        }


        public string MySecretAction()
        {
            user user = CurrentUser.get();
            return "";
        }
    }
}