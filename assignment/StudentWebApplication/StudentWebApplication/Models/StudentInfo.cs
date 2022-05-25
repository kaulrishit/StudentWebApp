using System;
using System.Collections.Generic;

namespace StudentWebApplication.Models
{
    public partial class StudentInfo
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentGender { get; set; }
        public int? StudentAge { get; set; }
    }
}
