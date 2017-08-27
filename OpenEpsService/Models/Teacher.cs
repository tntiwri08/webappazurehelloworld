﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenEpsService.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

      
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string EnrollmentNo { get; set; }

       
    }



    
}