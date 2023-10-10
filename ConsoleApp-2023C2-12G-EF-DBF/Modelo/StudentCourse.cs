using System;
using System.Collections.Generic;

namespace ConsoleApp_2023C2_12G_EF_DBF.Modelo
{
    public partial class StudentCourse
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
