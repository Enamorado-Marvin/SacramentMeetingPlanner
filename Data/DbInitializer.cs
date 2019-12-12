using SacramentMeetingPlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Data
{
    public class DbInitializer
    {
        public static void Initialize(AgendaContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Agendas.Any())
            {
                return;   // DB has been seeded
            }
            
            var agendas = new Agenda[]
            {
            
            new Agenda{MeetingDate=DateTime.Parse("2005-09-01"),PresidingLeader="Bishop Travis",ConductingLeader="Brother Marvin Enamorado",OpeningSong="19 - We thank Thee o God for a Prophet",OpeningPrayer="Sister Clayton", SacramentHymn="72 - The Sacrament", Speaker= "Brother Monson, Sister Nelson", SpeakerSubject="Faith, Tithings", IntermediateNumber="Love one another by the choir", ClosingSong = "124 - Be still my soul", ClosingPrayer = "Brother Layton"  }            
            };
            foreach (Agenda a in agendas)
            {
                context.Agendas.Add(a);
            }
            context.SaveChanges();
        }
    }
}
