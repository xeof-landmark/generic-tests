namespace GenericsTest
{
    public interface IComparable<T>
        where T : IUnit
    {
        public T Unit { get; set; }
    }
}