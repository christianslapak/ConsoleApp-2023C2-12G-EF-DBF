﻿using System;
using System.Collections.Generic;

namespace ConsoleApp_2023C2_12G_EF_DBF.Modelo
{
    public partial class Teacher
    {
        public Teacher()
        {
            Course = new HashSet<Course>();
        }

        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public int? StandardId { get; set; }

        public virtual Standard Standard { get; set; }
        public virtual ICollection<Course> Course { get; set; }
    }
}
