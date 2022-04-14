using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.DTOs
{
    public class ModulePermissionDTO
    {
        public string UserName { get; set; }
        public string Module { get; set; }
        public string Action { get; set; }
        public bool IsDeleted { get; set; }
    }
}