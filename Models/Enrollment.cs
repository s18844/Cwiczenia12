﻿using System;
using System.Collections.Generic;

namespace Cwiczenia12.Models
{
    public partial class Enrollment
    {
        public int IdEnrollment { get; set; }
        public int Semester { get; set; }
        public int IdStudy { get; set; }
        public DateTime StartDate { get; set; }
    }
}
