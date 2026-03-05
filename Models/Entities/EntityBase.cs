namespace DailyRoutine.Models.Entities
{
    public class EntityBase
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Deleted { get; set; }
    }
}
