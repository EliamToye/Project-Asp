namespace Project.Models
{

    public class userdata
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<lesson> lessons { get; set; }

    }
}