﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentCompanyProject.com.app.dataobjects
{
    class LoginDataObjects 
    {
       
        public string username { get; set; }
        public string password { get; set; }

        public UserTableDataObjects getUserData { protected set; get; }
         
    }
}