namespace Project.Models
{
    public class lesson
    {
        public int ID { get; set; }
        public string Start_time { get; set; }

        public string End_time { get; set; }

        public string Description { get; set; }

        public ICollection<userdata> users { get; set; }

        public string Mentor_name { get; set; }
    }
}
