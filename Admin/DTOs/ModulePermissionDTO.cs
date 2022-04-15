using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.DTOs
{
    public class ModulePermissionDTO
    {
        public int Id { get; set; }    
        public string UserName { get; set; }
        public string ModuleName { get; set; }
        public string Tag { get; set; }
        public int? ParentId { get; set; }
    }
}