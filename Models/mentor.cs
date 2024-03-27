namespace Project.Models
{
    public class mentor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<lesson> lessons { get; set; }
    }
}
