namespace Domain.Entities.Tasks.ValueObjects
{
    public class ListId
    {
        public int Value { get; private set; }
        private ListId(int value)
        {
            Value = value;

        }
        public static ListId Create(int value)
        {
            return new ListId(value);
        }
        private ListId()
        {

        }
    }
}
