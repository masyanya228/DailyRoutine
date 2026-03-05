namespace DailyRoutine.Models.Entities
{
    public class Routine : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<RoutineTag> Tags { get; set; }
    }
}
