﻿using System;
using System.Collections.Generic;

namespace _11_LINQ.Models
{
    public partial class Status
    {
        public Status()
        {
            Instructors = new HashSet<Instructor>();
        }

        public byte StatusId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Instructor> Instructors { get; set; }
    }
}
