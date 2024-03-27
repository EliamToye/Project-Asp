using Project.Models;

namespace Project.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ProjectContext context)
        {
            // Look for any students.
            if (context.userdata.Any())
            {
                return;   // DB has been seeded
            }

            var users = new userdata[]
            {
                new userdata{Name="Carson Alexander",Email="C.Alexander@example.com"},
                new userdata{Name="Denki Smith",Email="D.Smith@example.com"},
            };

            context.userdata.AddRange(users);
            context.SaveChanges();

            var Mentors = new mentor[]
            {
                new mentor{Name = "Jeff"},
                new mentor{Name = "Micheal"},
                new mentor{Name = "Flop"},
                new mentor{Name = "Nekel"},
            };

            context.Mentor.AddRange(Mentors);
            context.SaveChanges();

            var lessons = new lesson[]
            {
                new lesson{ID=1, Start_time = "18u",End_time = "20u",Description = "Legday", Mentor_name = "Jeff" },
                new lesson{ID=2,Start_time = "18u",End_time = "20u",Description = "Chestday", Mentor_name = "Micheal"},
                new lesson{ID=3,Start_time = "18u",End_time = "20u",Description = "Shoulderday", Mentor_name = "Flop"},
            };

            context.Lessons.AddRange(lessons);
            context.SaveChanges();
        }
    }
}