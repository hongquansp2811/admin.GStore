using Admin.DTOs;
using Admin.DTOs.UserDTOs;
using Admin.Models;
using Admin.Repositories;
using Admin.Services;
using Admin.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Admin.Controllers
{
    public class UserController : Controller
    {
        private IUserService _userService;
        public UserController()
        {
            this._userService = new UserService();
        }

        [Login]
        public ActionResult Index()
        {
            return View();
        }

        [Login]
        public ActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateUser(UserDto userDto)
        {
            var result = _userService.CreateUser(userDto);
            if (result == true) return RedirectToAction("GetAllUser");
            return View();
        }

        [Login]
        public ActionResult List()
        {
            var result = _userService.GetAllUsers();
            return View(result);
        }

        [HttpGet]
        public ActionResult DeleteUser(int id)
        {
            var result = _userService.DeleteUserById(id);
            if (result == true)
                return RedirectToAction("List");
            else
                return View(result);
        }

        [Login]
        public ActionResult UserDetail(int id)
        {
            var result = _userService.GetUserDTOById(id);
            return View(result);
        }

        [HttpPost]
        public ActionResult UpdateUser(UserDto user)
        {
            var result = _userService.UpdateUser(user);
            if (result == true)
                return RedirectToAction("List");
            else
                return View(result);
        }

        public ActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult LogIn(LoginUserDTO userLogin)
        {
            if (ModelState.IsValid)
            {
                var result = _userService.GetAllUsers();
                var current = result.FirstOrDefault(x => x.UserName.Equals(userLogin.UserName) && x.Password.Equals(userLogin.Password));
                if (current != null)
                {
                    Session["UserName"] = current.UserName;
                    Session["UserId"] = current.Id;
                    return RedirectToAction("List");
                }else
                    ViewBag.Message = "User không tồn tại";
            }
            return View();
        }

        [Login]
        public PartialViewResult PermissionMenu()
        {
            var _dbContext = new ApplicationDbContext();
            var param = new SqlParameter
            {
                ParameterName = "p_id",
                Value = Session["UserId"]
            };
            List<ModulePermissionDTO> listModulePermission = _dbContext.Database.SqlQuery<ModulePermissionDTO>("exec Proc_Permission @p_id", param).ToList();
            var data = listModulePermission.Where(x => x.ParentId == null).ToList();
            return PartialView(data);
        }

        [Login]
        public PartialViewResult ChilPermissionMenu(int parentId)
        {
            var _dbContext = new ApplicationDbContext();
            var param = new SqlParameter
            {
                ParameterName = "p_id",
                Value = Session["UserId"]
            };
            List<ModulePermissionDTO> listModulePermission = _dbContext.Database.SqlQuery<ModulePermissionDTO>("exec Proc_Permission @p_id", param).ToList();
            var data = listModulePermission.Where(x=>x.ParentId == parentId).ToList();
            ViewBag.Count = data.Count;
            return PartialView(data);
        }
    }
}