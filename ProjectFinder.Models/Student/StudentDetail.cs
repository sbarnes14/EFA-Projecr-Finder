﻿using ProjectFinder.Models.Course;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinder.Models.Student
{
    public class StudentDetail
    {     
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string GithubProfile { get; set; }
        public DateTimeOffset EnrollDate { get; set; }
        public string Course { get; set; }
    }
}
