﻿using System;
using System.Collections.Generic;

namespace Zhfógyakorlasutolso.Models
{
    public partial class Room
    {
        public Room()
        {
            Lessons = new HashSet<Lesson>();
        }

        public int RoomSk { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
