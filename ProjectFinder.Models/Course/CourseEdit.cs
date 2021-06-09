﻿using ProjectFinder.Data;
using ProjectFinder.Models.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinder.Models.Course
{
    public class CourseEdit
    {
        public int CourseId { get; set; }
        public string Cohort { get; set; }
        public CourseType CourseType { get; set; }
        [Display(Name = "Students")] // redundant because same name
        public ICollection<StudentListItem> Students { get; set; } // many-to-one ref from Student Class - not implemented as of yet ~Jay
        [Display(Name = "Start Date [UTC]")]
        public DateTimeOffset StartDate { get; set; }
        [Display(Name = "End Date [UTC]")]
        public DateTimeOffset EndDate { get; set; }
    }
}
