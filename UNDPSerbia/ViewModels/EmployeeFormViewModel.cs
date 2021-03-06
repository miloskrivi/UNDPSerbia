﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UNDPSerbia.Models;

namespace UNDPSerbia.ViewModels
{
    public class EmployeeFormViewModel
    {
        public Employee Employee { get; set; }
        public string Title
         {
             get
             {
                if (Employee != null && Employee.Id != 0)
                     return "Edit Employee";
 
                return "New Employee";
             }
         }
    }
}