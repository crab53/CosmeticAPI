﻿using Cosmetic.Core.Request;
using Cosmetic.DataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetic.Bussiness.Requests
{
    public class RoleRequest: RequestModelBase
    {
        public Role Role { get; set; }
    }
}
