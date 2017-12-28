﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetic.DataModel.Entities
{
   public class ModulesOnRole: BaseEntities
    {       

        public string RoleID { get; set; }
        public string ModuleID { get; set; }
        public string ModuleParentID { get; set; }
        public bool IsView { get; set; }
        public bool IsAction { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Modules Module { get; set; }        
        public virtual Role Roles { get; set; }
    }
}
