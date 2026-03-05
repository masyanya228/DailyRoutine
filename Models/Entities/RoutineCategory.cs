namespace DailyRoutine.Models.Entities
{
    public class RoutineCategory : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public IList<Routine> Routines { get; set; }
    }
}
