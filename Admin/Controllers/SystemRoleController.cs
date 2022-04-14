using Admin.DTOs;
using Admin.Services;
using Admin.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Admin.Controllers
{
    public class SystemRoleController : Controller
    {
        private ISystemRoleService _systemRoleService;
        public SystemRoleController()
        {
            this._systemRoleService = new SystemRoleService();
        }

        // GET: SystemAdministration
        public ActionResult Index()
        {
            return View();
        }

        [Login]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(RoleDTO Dto)
        {
            var result = _systemRoleService.Create(Dto);
            if (result == true) return RedirectToAction("GetAllUser");
            return View();
        }

        [Login]
        public ActionResult GetAll()
        {
            var result = _systemRoleService.GetAll();
            return View(result);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var result = _systemRoleService.DeleteById(id);
            if (result == true)
                return RedirectToAction("GetAllUser");
            else
                return View(result);
        }

        [Login]
        public ActionResult Detail(int id)
        {
            var result = _systemRoleService.GetDTOById(id);
            return View(result);
        }

        [HttpPost]
        public ActionResult Update(RoleDTO Dto)
        {
            var result = _systemRoleService.Update(Dto);
            if (result == true)
                return RedirectToAction("GetAllUser");
            else
                return View(result);
        }
    }
}