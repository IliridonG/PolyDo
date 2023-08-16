namespace Domain.Entities.Tasks.ValueObjects
{
    public class TaskId
    {
        public int Value { get; private set; }
        private TaskId(int value)
        {
            Value = value;

        }
        public static TaskId Create(int value)
        {
            return new TaskId(value);
        }
        private TaskId()
        {

        }
    }
}
