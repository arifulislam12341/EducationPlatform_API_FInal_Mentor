﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.BOs
{
    public class CounselingModel
    {
        public int Id { get; set; }
        public Nullable<int> MentorId { get; set; }
        public Nullable<int> CourseId { get; set; }
        public string MeetLink { get; set; }
        public string Details { get; set; }
        public string Date { get; set; }

    }
}
