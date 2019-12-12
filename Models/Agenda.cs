using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class Agenda
    {
        public int ID { get; set; }
        public DateTime MeetingDate { get; set; }
        public string PresidingLeader { get; set; }
        public string ConductingLeader { get; set; }
        public string OpeningSong { get; set; }
        public string OpeningPrayer { get; set; }
        public string SacramentHymn { get; set; }
        public string Speaker { get; set; }
        public string SpeakerSubject { get; set; }
        
        public string IntermediateNumber { get; set; }
        public string ClosingSong { get; set; }
        public string ClosingPrayer { get; set; }

    }
}
