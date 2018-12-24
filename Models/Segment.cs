using System;
using System.Collections.Generic;
namespace TripTracker.BackService.Models
{
    public class Segment
    {
        public Segment()
        {
        }

        public int ID { get; set; }
        public int TripID { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset EndTime { get; set; }
    }
}
