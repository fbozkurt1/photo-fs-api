using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace photo_fs_api.Models
{
    public class Schedule
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Description { get; set; }

    }

    public class ScheduleInput
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public string Description { get; set; }

    }
}
