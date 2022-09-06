namespace GenericsTest
{
    public class Comparable<T> : IComparable<T>
        where T : IUnit
    {
        public T Unit { get; set; }
        public int ExisingUnit { get; set; }
    }

    public class NonComparable<T> : IComparable<T>
        where T : IUnit
    {
        public T Unit { get; set; }
        public bool IsDifferent(int id) => true;
        public void AddNewPrices(decimal prices) => throw new System.NotImplementedException();
    }
}
