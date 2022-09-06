namespace GenericsTest
{
    public class Comparable<T>
        where T : IUnit
    {
        public T Unit { get; set; }
        public int ExisingUnit { get; set; }
    }

    public class NonComparable<T>
        where T : IUnit
    {
        public T Unit { get; set; }
        public bool IsDifferent(int id) => true;
        public void AddNewPrices(decimal prices) => throw new System.NotImplementedException();
    }
}
