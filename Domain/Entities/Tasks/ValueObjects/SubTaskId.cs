namespace Domain.Entities.Tasks.ValueObjects
{
    public class SubTaskId
    {
        public int Value { get; private set; }
        private SubTaskId(int value)
        {
            Value = value;

        }
        public static SubTaskId Create(int value)
        {
            return new SubTaskId(value);
        }
        private SubTaskId()
        {

        }
    }
}
